using Genki.SudokuEngine.GridEngine;
using System;

namespace Genki.SudokuEngine
{
	public class Game
	{
		private int ColumnProduct = 0;
		private int ColumnSum = 0;
		private int RowProduct = 0;
		private int RowSum = 0;

		public Grid grid { get; set; }


		public Game(GridListener gl = null)
		{
			grid = new Grid(gl); // The constructor init the grid

			ColumnProduct = 1;
			ColumnSum = 0;
			for (int i = (int) Grid.NB_COLUMNS; i >= 1; i--)
			{
				ColumnProduct *= i;
				ColumnSum += i;
			}

			RowProduct = 1;
			RowSum = 0;
			for (int i = (int) Grid.NB_ROWS; i >= 1; i--)
			{
				RowProduct *= i;
				RowSum += i;
			}
		}

		public void IsValid()
		{
			IsValidRec(0);
		}
		private bool IsValidRec(int pos)
		{
			if (pos == Grid.NB_COLUMNS * Grid.NB_ROWS)
				return true;

			int i = pos % (int) Grid.NB_COLUMNS; // i is the column
			int j = pos / (int) Grid.NB_ROWS; // i is the row

			if (grid[i, j].Value != 0)
				return IsValidRec(pos + 1);

			for (byte k = 1; k <= 9; k++)
			{
				bool? r = IsInTheSquare(k, i, j);
				if (!(r == null ? true : false) && !IsInTheColumn(k, (byte) i) && !IsInTheRow(k, (byte) j))
				{
					grid[i, j].Value = k;
					if (IsValidRec(pos + 1))
						return true;
				}
			}

			grid[i, j].Value = 0;
			return false;
		}

		public void InitGrid()
		{
			Random rand = new Random((int) DateTime.Now.Ticks);
			byte column, row, value;

			grid.reset();

			for (int i = 0; i < Grid.NB_COLUMNS; i++)
			{
				column = (byte) rand.Next(0, (int)Grid.NB_COLUMNS + 1);
				row    = (byte)rand.Next(0, (int)Grid.NB_ROWS    + 1);
				value  = (byte)rand.Next(1, 9                    + 1);

				bool? r = IsInTheSquare(value, column, row);
				if (grid[column, row].Value == 0 && !(r == null ? true : false) && !IsInTheColumn(value, column) && !IsInTheRow(value, row))
					grid[column, row].Value = value;
				else
					i--;
			}
		}
		
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
					columnProduct *= grid[i, j].Value;
					columnSum += grid[i, j].Value;
					rowProduct *= grid[j, i].Value;
					rowSum += grid[j, i].Value;
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
						squareProduct *= grid[i, j].Value;
						squareSum += grid[i, j].Value;
					}
				}

				if (squareProduct != ColumnProduct || squareSum != ColumnSum)
					return false;
			}

			return true;
		}

		public bool IsInTheRow(byte value, byte x)
		{
			bool condition = false;
			for (int j = 0; j < Grid.NB_COLUMNS && !condition; j++)
				if (grid[x, j].Value == value)
					condition = true;

			return condition;
		}

		public bool IsInTheColumn(byte value, byte y)
		{
			bool condition = false;
			for (int i = 0; i < Grid.NB_ROWS && !condition; i++)
				if (grid[i, y].Value == value)
					condition = true;

			return condition;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="squarex">[1 ; NB_COLUMNS/3]</param>
		/// <param name="squarey">[1 ; NB_ROWS/3]</param>
		/// <returns></returns>
		public bool? IsInTheSquare(byte value, byte squarex, byte squarey)
		{
			if ((squarex <= 0 || squarex > Grid.NB_COLUMNS / 3) && (squarey <= 0 || squarey > Grid.NB_ROWS / 3))
				return null;

			bool condition = false;
			for (int i = 3 * squarex - 2; i <= 3 * squarex && !condition; i++)
				for (int j = 3 * squarey - 2; j <= 3 * squarex && !condition; j++)
					if (grid[i, j].Value == value)
						condition = true;

			return condition;
		}
		public bool? IsInTheSquare(byte value, int x, int y)
		{
			if ((x <= 0 || x > Grid.NB_COLUMNS) && (y <= 0 || y > Grid.NB_ROWS))
				return null;

			byte squarex = 0, squarey = 0;

			if (x >= 1 && x <= Grid.NB_COLUMNS / 3)
				squarex = 1;
			else if (x >= (Grid.NB_COLUMNS / 3) + 1 && x <= (6 * Grid.NB_COLUMNS) / 3)
				squarex = 2;
			else if (x >= ((6 * Grid.NB_COLUMNS) / 3) + 1 && x <= Grid.NB_COLUMNS)
				squarex = 3;

			if (y >= 1 && y <= Grid.NB_ROWS / 3)
				squarey = 1;
			else if (y >= (Grid.NB_ROWS / 3) + 1 && y <= (6 * Grid.NB_ROWS) / 3)
				squarey = 2;
			else if (y >= ((6 * Grid.NB_ROWS) / 3) + 1 && y <= Grid.NB_ROWS)
				squarey = 3;

			return IsInTheSquare(value, squarex, squarey);
		}
	}
}
