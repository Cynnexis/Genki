using Genki.SudokuEngine.GridEngine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Genki.SudokuEngine
{
	public delegate void ActionOnGameState(GameState oldState, GameState newState);

	/// <summary>
	/// Manage a Sudoku game.
	/// <seealso cref="Genki.SudokuEngine.CellEngine.Cell"/>
	/// <seealso cref="Genki.SudokuEngine.GridEngine.Grid"/>
	/// </summary>
	[Serializable,DataContract, XmlRoot("Game")]
	public class Game
	{
		#region Declarations
		#region Variables
		[NonSerialized]
		private int ColumnProduct = 0;
		[NonSerialized]
		private int ColumnSum = 0;
		[NonSerialized]
		private int RowProduct = 0;
		[NonSerialized]
		private int RowSum = 0;
		[NonSerialized]
		private int MaxSeconds = 25;

		[DataMember]
		private GameState state;

		[DataMember]
		private Grid sudokuGrid;

		[DataMember]
		private Grid solution;

		[DataMember]
		private StopwatchEngine.Stopwatch stopwatch = null;

		[NonSerialized]
		private ActionOnGameState onGameStateChange = null;
		#endregion

		#region Properties
		public GameState State {
			get { return state; }
			set
			{
				GameState oldState = state;
				state = value;

				// If the game is getting out of the "PAUSE" state, resume the stopwatch
				if (oldState == GameState.PAUSE && state != GameState.PAUSE)
					SudokuStopwatch.Activated = true;

				// If the game enters the "PAUSE" state, pause the stopwatch
				if (state == GameState.PAUSE && SudokuStopwatch != null)
					SudokuStopwatch.Activated = false;

				OnGameStateChange?.Invoke(oldState, state);
			}
		}

		/// <summary>
		/// The virtual sudoku grid
		/// </summary>
		public Grid SudokuGrid
		{
			get { return sudokuGrid; }
			set { sudokuGrid = value; }
		}
		/// <summary>
		/// The solution of the grid <c>grid</c>
		/// </summary>
		public Grid Solution
		{
			get { return solution; }
			set { solution = value;}
		}

		public StopwatchEngine.Stopwatch SudokuStopwatch
		{
			get { return stopwatch; }
			set { stopwatch = value; }
		}
		
		public ActionOnGameState OnGameStateChange
		{
			get { return onGameStateChange; }
			set { onGameStateChange = value; }
		}
		#endregion
		#endregion

		#region Constructor & Initialization
		/// <summary>
		/// Construct a game instance by initilizing the grid (with <paramref name="gl"/>), the variables <c>ColumnProduct</c>,
		/// <c>ColumnSum</c>, <c>RowProduct</c> and <c>RowSum</c>. This constructor do not compute any grid (you must call <c>ComputeGrid</c> method).
		/// </summary>
		/// <param name="gl"></param>
		public Game(GridListener gl = null, Action OnSecondChange = null, ActionOnGameState OnGameStateChange = null)
		{
			this.OnGameStateChange = OnGameStateChange != null ? OnGameStateChange : new ActionOnGameState((oldState, newState) => { });
			State = GameState.PAUSE;
			SudokuGrid = new Grid(new GridListener(
				(x, y, value) =>
				{
					gl?.ActionOnGridChange?.Invoke(x, y, value);
					this.CheckWin();
				})); // The constructor init the grid
			Solution = new Grid();

			InitConst();

			if (OnSecondChange == null)
				SudokuStopwatch = new StopwatchEngine.Stopwatch(() => { }, () => { });
			else
				SudokuStopwatch = new StopwatchEngine.Stopwatch(() => { }, () => { OnSecondChange(); });
		}

		public void LoadGameInstance(Game g)
		{
			if (g != null)
			{
				State = GameState.PAUSE;

				// Saving all the listeners during the copy of the new instance
				GridListener gl = SudokuGrid.ActionOnGrid;
				SudokuGrid = g.SudokuGrid;
				Solution = g.Solution;

				if (g.SudokuStopwatch != null)
				{
					/*Action onStopwatchActiveStateChange = SudokuStopwatch.OnActiveStateChange;
					Action onStopwatchSecondChange = SudokuStopwatch.OnSecondChange;
					Action onStopwatchMinuteChange = SudokuStopwatch.OnMinuteChange;
					Action onStopwatchHourChange = SudokuStopwatch.OnHourChange;

					SudokuStopwatch = new StopwatchEngine.Stopwatch(onStopwatchActiveStateChange,
						onStopwatchSecondChange, onStopwatchMinuteChange, onStopwatchHourChange);*/

					SudokuStopwatch.Second = g.SudokuStopwatch.Second;
					SudokuStopwatch.Second = g.SudokuStopwatch.Minute;
					SudokuStopwatch.Second = g.SudokuStopwatch.Hour;
				}
				else
				{

					SudokuStopwatch.Second = 0;
					SudokuStopwatch.Second = 0;
					SudokuStopwatch.Second = 0;
				}

				// Applying again the listener on the new instance
				SudokuGrid.ActionOnGrid = gl;

				// Finally, changing the game state
				State = g.State;
			}
		}

		private void InitConst()
		{
			ColumnProduct = 1;
			ColumnSum = 0;
			for (int i = (int)Grid.NB_COLUMNS; i >= 1; i--)
			{
				ColumnProduct *= i;
				ColumnSum += i;
			}

			RowProduct = 1;
			RowSum = 0;
			for (int i = (int)Grid.NB_ROWS; i >= 1; i--)
			{
				RowProduct *= i;
				RowSum += i;
			}
		}
		#endregion

		#region Compute Grid
		public void ComputeGrid(Action OnGridFound = null, bool useThread = false)
		{
			State = GameState.COMPUTING;

			if (useThread)
			{
				try
				{
					Thread t_compute = new Thread(() => { ComputeGridContent(OnGridFound); });
					t_compute.Start();
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine(ex.StackTrace);
					ComputeGridContent(OnGridFound);
				}
			}
			else
				ComputeGridContent(OnGridFound);
		}
		private void ComputeGridContent(Action OnGridFound = null)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			do
			{
				InitGrid();
				Solution = new Grid(null, SudokuGrid);
				SolveGrid(ref solution);
			} while ((Solution == null || !IsFull(Solution)) && stopwatch.ElapsedMilliseconds <= 10000);

			// Check if the program found a grid, or timeout
			if (stopwatch.ElapsedMilliseconds > (MaxSeconds * 1000))
				SetDefaultGrid();

			// If OnGridFound is not null, then call it
			OnGridFound?.Invoke();
		}

		/// <summary>
		/// <para>
		/// Initialize a Sudoku grid with missing number. The provided grid might not contain a solution.
		/// </para>
		/// <para>
		/// The digits are placed with
		/// respect of the three main rules of the sudoku:
		/// </para>
		/// <para>
		/// <list type="bullet">
		///		<item>
		///			<description>A digit is unique in a column</description>
		///			<description>A digit is unique in a row</description>
		///			<description>A digit is unique in a 3-by-3 square</description>
		///		</item>
		/// </list>
		/// </para>
		/// </summary>
		/// <param name="nb_digit">Number of initial digit in the grid. This number must be greater or equal to 20, otherwise
		/// the program will choose a digit between 20 and 40 randomly</param>
		public void InitGrid(int nb_digit = -1)
		{
			byte column, row, value;
			Random rand = new Random((int)DateTime.Now.Ticks);

			if (nb_digit < 20)
				nb_digit = rand.Next(30, 40 + 1);

			SudokuGrid.reset();

			try
			{
				for (int i = 0; i < nb_digit; i++)
				{
					column = (byte)rand.Next(0, (int)Grid.NB_COLUMNS);
					row = (byte)rand.Next(0, (int)Grid.NB_ROWS);
					value = (byte)rand.Next(1, 9 + 1);

					bool? r = IsInTheSquare(value, column, row);
					if (SudokuGrid[column, row].Value == 0 && !(r == null ? true : (bool)r) && !IsInTheColumn(value, column) && !IsInTheRow(value, row))
						SudokuGrid[column, row].Value = value;
					else
						i--;
				}
			}
			catch (IndexOutOfRangeException ex)
			{
				System.Console.Error.WriteLine(ex.StackTrace);
#if DEBUG
				Debugger.Break();
#endif
			}
		}

		/// <summary>
		/// Set a default grid with a pre-computed solution
		/// </summary>
		public void SetDefaultGrid()
		{
			// Sudoku from https://www.websudoku.com/images/example-steps.html
			int[][] problem = new int[][]
			{
				new int[] { 0, 0, 0, 0, 0, 0, 6, 8, 0},
				new int[] { 0, 0, 0, 0, 7, 3, 0, 0, 9},
				new int[] { 3, 0, 9, 0, 0, 0, 0, 4, 5},
				new int[] { 4, 9, 0, 0, 0, 0, 0, 0, 0},
				new int[] { 8, 0, 3, 0, 5, 0, 9, 0, 2},
				new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 6},
				new int[] { 9, 6, 0, 0, 0, 0, 3, 0, 8},
				new int[] { 7, 0, 0, 6, 8, 0, 0, 0, 0},
				new int[] { 0, 2, 8, 0, 0, 0, 0, 0, 0}
			};

			int[][] solution = new int[][]
			{
				new int[] { 1, 7, 2, 5, 4, 9, 6, 8, 3},
				new int[] { 6, 4, 5, 8, 7, 3, 2, 1, 9},
				new int[] { 3, 8, 9, 2, 6, 1, 7, 4, 5},
				new int[] { 4, 9, 6, 3, 2, 7, 8, 5, 1},
				new int[] { 8, 1, 3, 4, 5, 6, 9, 7, 2},
				new int[] { 2, 5, 7, 1, 9, 8, 4, 3, 6},
				new int[] { 9, 6, 4, 7, 1, 5, 3, 2, 8},
				new int[] { 7, 3, 1, 6, 8, 2, 5, 9, 4},
				new int[] { 5, 2, 8, 9, 3, 4, 1, 6, 7}
			};

			for (int i = 0; i < Grid.NB_COLUMNS; i++)
				for (int j = 0; j < Grid.NB_ROWS; j++)
					SudokuGrid[i, j].Value = (byte)problem[j][i];

			for (int i = 0; i < Grid.NB_COLUMNS; i++)
				for (int j = 0; j < Grid.NB_ROWS; j++)
					Solution[i, j].Value = (byte)solution[j][i];
		}
		#endregion

		#region Solve Grid
		public Grid SolveGrid()
		{
			Grid g = new Grid(null, SudokuGrid);
			return SolveGrid(ref g);
		}
		public Grid SolveGrid(ref Grid g)
		{
			if (g == null)
				g = new Grid(null, this.SudokuGrid);

			bool isValid = SolveGridRec(ref g, 0);
			return isValid ? g : null;
		}
		private bool SolveGridRec(ref Grid g, int pos = 0)
		{
			if (pos == Grid.NB_COLUMNS * Grid.NB_ROWS)
				return true;

			int i = pos % (int) Grid.NB_COLUMNS; // i is the column
			int j = pos / (int) Grid.NB_ROWS; // j is the row

			if (g[i, j].Value != 0)
				return SolveGridRec(ref g, pos + 1);

			for (byte k = 1; k <= 9; k++)
			{
				bool? r = IsInTheSquare(g, k, i, j);
				if (!(r == null ? true : (bool)r) && !IsInTheColumn(g, k, (byte) i) && !IsInTheRow(g, k, (byte) j))
				{
					g[i, j].Value = k;
					if (SolveGridRec(ref g, pos + 1))
						return true;
				}
			}

			g[i, j].Value = 0;
			return false;
		}
		#endregion

		#region Check Move
		/// <summary>
		/// Check if putting the value <paramref name="value"/> in the column <paramref name="x"/> and row <paramref name="y"/> is a problem for the 3 rules of the Sudoku game:
		/// <para>
		/// <list type="bullet">
		///		<item>
		///			<description>A digit is unique in a column</description>
		///			<description>A digit is unique in a row</description>
		///			<description>A digit is unique in a 3-by-3 square</description>
		///		</item>
		/// </list>
		/// </para>
		/// The grid does not need to be entirely complete, and the value k must not be necessary put in the grid before calling this method.
		/// </summary>
		/// <param name="g">The grid to check</param>
		/// <param name="value">The input value. After checking, this method WON'T put the k value in the coordinates (<paramref name="x"/> ; <paramref name="y"/>)</param>
		/// <param name="x">The column, [0 ; Grid.NB_COLUMNS - 1]</param>
		/// <param name="y">The row, [0 ; Grid.NB_ROWS - 1]</param>
		/// <param name="wrongDigits">Reference to a list of point (which will be cleared at the beginning of the method) which will containing at the end
		/// the position in the grid <paramref name="g"/> of all conficted digits</param>
		/// <returns></returns>
		public bool CheckMove(Grid g, byte value, int x, int y, out List<Point> wrongDigits)
		{
			bool result, hasPutValueInGrid = false;
			wrongDigits = new List<Point>();

			bool bc;
			bool br;
			bool bs;
			bool? bt;
			List<Point> wdc;
			List<Point> wdr;
			List<Point> wds;

			if (g[x, y].Value == value)
			{
				g[x, y].Value = 0;
				hasPutValueInGrid = true;
			}

			bc = !IsInTheColumn(g, value, x, out wdc);
			br = !IsInTheRow(g, value, y, out wdr);
			bt = !IsInTheSquare(g, value, x, y, out wds);

			bs = (bt == null ? false : (bool) bt);

			result = bc && br && bs;

			wrongDigits.AddRange(wdc);
			wrongDigits.AddRange(wdr);
			wrongDigits.AddRange(wds);

			// Finally, the method adds the actual point if there is a problem:
			if (!result)
				wrongDigits.Add(new Point(x, y));

			if (hasPutValueInGrid)
				g[x, y].Value = value;

			return result;
		}
		public bool CheckMove(Grid g, byte value, int x, int y)
		{
			List<Point> l;
			return CheckMove(g, value, x, y, out l);
		}
		public bool CheckMove(byte value, int x, int y, out List<Point> wrongDigits)
		{
			return CheckMove(this.SudokuGrid, value, x, y, out wrongDigits);
		}
		public bool CheckMove(byte value, int x, int y)
		{
			return CheckMove(this.SudokuGrid, value, x, y);
		}
		
		/// <summary>
		/// Check if the grid respects the Sudoku rules:
		/// <para>
		/// <list type="bullet">
		///		<item>
		///			<description>A digit is unique in a column</description>
		///			<description>A digit is unique in a row</description>
		///			<description>A digit is unique in a 3-by-3 square</description>
		///		</item>
		/// </list>
		/// </para>
		/// The grid must be complete.
		/// </summary>
		/// <returns></returns>
		public bool CheckGrid()
		{
			int columnProduct = 1;
			int columnSum = 0;
			int rowProduct = 1;
			int rowSum = 0;
			int squareProduct = 1;
			int squareSum = 0;

			// Columns & Rows Test
			for (int i = 0; i < Grid.NB_COLUMNS; i++)
			{
				for (int j = 0; j < Grid.NB_ROWS; j++)
				{
					columnProduct *= SudokuGrid[i, j].Value;
					columnSum += SudokuGrid[i, j].Value;
					rowProduct *= SudokuGrid[j, i].Value;
					rowSum += SudokuGrid[j, i].Value;
				}

				if (columnProduct != ColumnProduct || columnSum != ColumnSum || rowProduct != RowProduct || rowSum != RowSum)
					return false;

				columnProduct = 1;
				columnSum = 0;
				rowProduct = 1;
				rowSum = 0;
				squareProduct = 1;
				squareSum = 0;
			}

			// Bloc test
			for (int imin = 0, jmin = 0; imin < Grid.NB_COLUMNS && jmin < Grid.NB_ROWS; imin += 3, jmin += 3)
			{
				for (int i = imin; i < imin + 3; i++)
				{
					for (int j = imin; j < jmin + 3; j++)
					{
						squareProduct *= SudokuGrid[i, j].Value;
						squareSum += SudokuGrid[i, j].Value;
					}
				}

				if (squareProduct != ColumnProduct || squareSum != ColumnSum)
					return false;

				squareProduct = 1;
				squareSum = 0;
			}

			return true;
		}
		#endregion

		#region Is In The Row
		/// <summary>
		/// Check if the value <paramref name="value"/> is is the grid <paramref name="g"/> in the row <paramref name="y"/>
		/// </summary>
		/// <param name="g">The grid to check</param>
		/// <param name="value">The value to check, [0 ; 9]</param>
		/// <param name="y">The row, [0 ; Grid.NB_ROWS-1]</param>
		/// <returns>Return <c>true</c> if value <paramref name="value"/> is in the row <paramref name="y"/>, otherwise <c>false</c></returns>
		public bool IsInTheRow(Grid g, byte value, int y, out List<Point> wrongDigits)
		{
			wrongDigits = new List<Point>();
			bool condition = false;
			for (int i = 0; i < Grid.NB_COLUMNS; i++)
			{
				if (g[i, y].Value == value)
				{
					condition = true;
					wrongDigits.Add(new Point(i, y));
				}
			}

			return condition;
		}
		public bool IsInTheRow(Grid g, byte value, int y)
		{
			List<Point> l;
			return IsInTheRow(g, value, y, out l);
		}
		public bool IsInTheRow(byte value, int y, out List<Point> wrongDigits)
		{
			return IsInTheRow(this.SudokuGrid, value, y, out wrongDigits);
		}
		public bool IsInTheRow(byte value, int y)
		{
			return IsInTheRow(this.SudokuGrid, value, y);
		}
		#endregion

		#region Is In The Column
		/// <summary>
		/// Check if the value <paramref name="value"/> is is the grid <paramref name="g"/> in the column <paramref name="x"/>
		/// </summary>
		/// <param name="g">The grid to check</param>
		/// <param name="value">The value to check, [0 ; 9]</param>
		/// <param name="x">The column, [0 ; Grid.NB_COLUMNS-1]</param>
		/// <returns>Return <c>true</c> if value <paramref name="value"/> is in the column <paramref name="x"/>, otherwise <c>false</c></returns>
		public bool IsInTheColumn(Grid g, byte value, int x, out List<Point> wrongDigits)
		{
			wrongDigits = new List<Point>();
			bool condition = false;
			for (int j = 0; j < Grid.NB_ROWS; j++)
			{
				if (g[x, j].Value == value)
				{
					condition = true;
					wrongDigits.Add(new Point(x, j));
				}
			}

			return condition;
		}
		public bool IsInTheColumn(Grid g, byte value, int x)
		{
			List<Point> l;
			return IsInTheColumn(g, value, x, out l);
		}
		public bool IsInTheColumn(byte value, int x, out List<Point> wrongDigits)
		{
			return IsInTheColumn(this.SudokuGrid, value, x, out wrongDigits);
		}
		public bool IsInTheColumn(byte value, int x)
		{
			return IsInTheColumn(this.SudokuGrid, value, x);
		}
		#endregion

		#region Is In The Square
		/// <summary>
		/// Check if the value <paramref name="value"/> is is the grid <paramref name="g"/> in the square (<paramref name="squarex"/> ; <paramref name="squarey"/>)
		/// </summary>
		/// <param name="g">The grid to check</param>
		/// <param name="value">The value to check, [0 ; 9]</param>
		/// <param name="x">[0 ; NB_COLUMNS - 1]</param>
		/// <param name="y">[0 ; NB_ROWS - 1]</param>
		/// <returns></returns>
		public bool? IsInTheSquare(Grid g, byte value, int x, int y, out List<Point> wrongDigits)
		{
			wrongDigits = new List<Point>();

			if ((x < 0 || x >= Grid.NB_COLUMNS) && (y < 0 || y >= Grid.NB_ROWS))
				return null;

			bool condition = false;

			try
			{
				int imin = 3 * (x / 3);
				int jmin = 3 * (y / 3);
				for (int i = imin; i < imin + 3; i++)
				{
					for (int j = jmin; j < jmin + 3; j++)
					{
						if (g[i, j].Value == value)
						{
							condition = true;
							wrongDigits.Add(new Point(i, j));
						}
					}
				}
			}
			catch (IndexOutOfRangeException ex)
			{
				System.Console.Error.WriteLine(ex.StackTrace);
#if DEBUG
				Debugger.Break();
#endif
			}

			return condition;
		}
		public bool? IsInTheSquare(Grid g, byte value, int x, int y)
		{
			List<Point> l;
			return IsInTheSquare(g, value, x, y, out l);
		}
		public bool? IsInTheSquare(byte value, int x, int y, out List<Point> wrongDigits)
		{
			return IsInTheSquare(this.SudokuGrid, value, x, y, out wrongDigits);
		}
		public bool? IsInTheSquare(byte value, int x, int y)
		{
			return IsInTheSquare(this.SudokuGrid, value, x, y);
		}
		#endregion

		#region Is Empty
		public bool IsEmpty(Grid g)
		{
			if (g != null)
			{
				bool notZeroDetected = false;

				for (int i = 0; i < Grid.NB_COLUMNS && !notZeroDetected; i++)
				{
					for (int j = 0; j < Grid.NB_ROWS && !notZeroDetected; j++)
					{
						if (g[i, j] != null)
						{
							if (g[i, j].Value != 0)
								notZeroDetected = true;
						}
						else
							notZeroDetected = true;
					}
				}

				return !notZeroDetected;
			}
			return false;
		}
		public bool IsEmpty()
		{
			return IsEmpty(this.SudokuGrid);
		}
		#endregion

		#region Is Full
		public bool IsFull(Grid g)
		{
			if (g == null)
				return false;

			bool zeroDetected = false;

			for (int i = 0; i < Grid.NB_COLUMNS && !zeroDetected; i++)
			{
				for (int j = 0; j < Grid.NB_ROWS && !zeroDetected; j++)
				{
					if (g[i, j] != null)
					{
						if (g[i, j].Value == 0)
							zeroDetected = true;
					}
					else
						zeroDetected = true;
				}
			}

			return !zeroDetected;
		}
		public bool IsFull()
		{
			return IsFull(this.SudokuGrid);
		}
		#endregion

		#region Check Win
		public bool CheckWin()
		{
			if (SudokuGrid != null && (State == GameState.PLAYING/* || State == GameState.WIN*/) && IsFull() && CheckGrid())
			{
				State = GameState.WIN;
				return true;
			}

			return false;
		}
		#endregion

		#region Format Grid
		public static string FormatGrid(Grid g)
		{
			string result = "";

			for (int j = 0; j < Grid.NB_ROWS; j++)
			{
				for (int i = 0; i < Grid.NB_COLUMNS; i++)
				{
					result += g[i, j].Value != 0 ? g[i, j].Value.ToString() : " ";
					if (i == 2 || i == 5)
						result += "|";
					else
						result += " ";
				}

				result += '\n';

				if (j == 2 || j == 5)
				{
					for (int i = 0; i < Grid.NB_COLUMNS * 2 + 2; i++)
						result += "-";

					result += '\n';
				}
			}
			return result;
		}
		#endregion
	}
}
