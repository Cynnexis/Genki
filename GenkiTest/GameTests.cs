using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Genki.SudokuEngine;
using Genki.SudokuEngine.CellEngine;
using Genki.SudokuEngine.GridEngine;
using System.Drawing;
using System.Diagnostics;
using System.IO;

namespace GenkiTest
{
	[TestClass]
	public class GameTests
	{
		private int[][] problem = null;
		private Grid gproblem = null;
		private int[][] solution = null;
		private Grid gsolution = null;
		private Game game = null;

		[TestInitialize]
		public void setUp()
		{
			/*
			// Sudoku from https://www.websudoku.com/images/example-steps.html
			problem = new int[][]
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
			problem = Transpose(problem);

			solution = new int[][]
			{
				new int[] { 1, 7, 2, 5, 4, 9, 6, 8, 3},
				new int[] { 6, 4, 5, 8, 7, 3, 2, 1, 9},
				new int[] { 3, 8, 9, 2, 6, 1, 7, 4, 5},
				new int[] { 4, 9, 6, 3, 2, 1, 8, 5, 1},
				new int[] { 8, 1, 3, 4, 5, 6, 9, 7, 2},
				new int[] { 2, 5, 7, 1, 9, 8, 4, 3, 6},
				new int[] { 9, 6, 4, 7, 1, 5, 3, 2, 8},
				new int[] { 7, 3, 1, 6, 8, 2, 5, 9, 4},
				new int[] { 5, 2, 8, 9, 3, 4, 1, 6, 7}
			};
			solution = Transpose(solution);

			gproblem = new Grid();
			game = new Game();
			for (int i = 0; i < Grid.NB_COLUMNS; i++)
				for (int j = 0; j < Grid.NB_ROWS; j++)
					game.SudokuGrid[i, j] = gproblem[i, j] = new Cell(new Point(i + 1, j + 1), (byte)problem[i][j]);

			gsolution = new Grid();
			game.Solution = new Grid();
			for (int i = 0; i < Grid.NB_COLUMNS; i++)
				for (int j = 0; j < Grid.NB_ROWS; j++)
					game.Solution[i, j] = gsolution[i, j] = new Cell(new Point(i + 1, j + 1), (byte)solution[i][j]);
			*/

			game = new Game();
			game.SetDefaultGrid();
			game.State = GameState.PLAYING;

			gproblem = new Grid();
			gsolution = new Grid();

			for (int i = 0; i < Grid.NB_COLUMNS; i++)
			{
				for (int j = 0; j < Grid.NB_ROWS; j++)
				{
					gproblem[i, j] = game.SudokuGrid[i, j];
					gsolution[i, j] = game.Solution[i, j];
				}
			}
		}

		[TestMethod]
		public void Test_IsInTheColumn_Method()
		{
			Assert.IsTrue(game.IsInTheColumn(6, 3));
			Assert.IsTrue(game.IsInTheColumn(5, 8));
		}

		[TestMethod]
		public void Test_IsInTheRow_Method()
		{
			Assert.IsTrue(game.IsInTheRow(5, 4));
			Assert.IsTrue(game.IsInTheRow(6, 7));
		}

		[TestMethod]
		public void Test_IsInTheSquare_Method()
		{
			bool? r = null;

			r = game.IsInTheSquare(5, 3, 3);
			Assert.IsTrue(r != null ? (bool)r : false);
			r = game.IsInTheSquare(5, 4, 4);
			Assert.IsTrue(r != null ? (bool)r : false);
			r = game.IsInTheSquare(5, 5, 5);
			Assert.IsTrue(r != null ? (bool)r : false);

			r = game.IsInTheSquare(3, 2, 1);
			Assert.IsTrue(r != null ? (bool)r : false);
			r = game.IsInTheSquare(3, 1, 2);
			Assert.IsTrue(r != null ? (bool)r : false);
			r = game.IsInTheSquare(7, 2, 7);
			Assert.IsTrue(r != null ? (bool)r : false);
		}

		[TestMethod]
		public void Test_IsFull_Method()
		{
			Assert.IsTrue(game.IsFull(game.Solution));
			Assert.IsFalse(game.IsFull(game.SudokuGrid));
		}

		[TestMethod]
		public void Test_IsEmpty_Method()
		{
			Assert.IsFalse(game.IsEmpty(game.Solution));
			Assert.IsFalse(game.IsEmpty(game.SudokuGrid));
		}

		[TestMethod]
		public void Test_CheckWin_Method()
		{
			game.SudokuGrid.SetValues(game.Solution);

			using (StreamWriter file = new StreamWriter("Test_CheckWin.output.txt"))
			{
				file.WriteLine("Problem (= Solution):");
				file.WriteLine(Game.FormatGrid(game.SudokuGrid));
				file.WriteLine();
				file.WriteLine("Solution:");
				file.WriteLine(Game.FormatGrid(game.Solution));
			}

			Assert.IsTrue(game.CheckWin());
		}

		[TestMethod]
		public void Test_SolveGrid()
		{
			game.SolveGrid();

			if (!game.Solution.Equals(gsolution))
			{
				throw new AssertFailedException("The solution found by Game is different from the correction");
			}
			else
			{
				using (StreamWriter file = new StreamWriter("Test_SolveGrid.output.txt"))
				{
					file.WriteLine("Problem:");
					file.WriteLine(Game.FormatGrid(gproblem));
					file.WriteLine();
					file.WriteLine("Solution:");
					file.WriteLine(Game.FormatGrid(gsolution));
					file.WriteLine();
					file.WriteLine("Computed Solution:");
					file.WriteLine(Game.FormatGrid(game.Solution));
				}
			}
		}

		[TestMethod]
		public void TestGenerationOfGrid()
		{
			game.ComputeGrid();
			using (StreamWriter file = new StreamWriter("TestGenerationOfGrid.output.txt"))
			{
				file.WriteLine("Computed Problem:");
				file.WriteLine(Game.FormatGrid(game.SudokuGrid));
				file.WriteLine();
				file.WriteLine("Computed Solution:");
				file.WriteLine(Game.FormatGrid(game.Solution));
			}
		}


		#region Utilities
		private static int[][] Transpose(int[][] matrix)
		{
			int w = matrix.Length;
			int h = matrix[0].Length;

			int[][] result = new int[h][];
			for (int i = 0; i < h; i++)
				result[i] = new int[w];

			for (int i = 0; i < w; i++)
				for (int j = 0; j < h; j++)
					result[j][i] = matrix[i][j];

			return result;
		}
		#endregion
	}
}
