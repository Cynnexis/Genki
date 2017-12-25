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
		#region Variables
		private int[][] problem = null;
		private Grid gproblem = null;
		private int[][] solution = null;
		private Grid gsolution = null;
		private Game game = null;
		#endregion

		#region Setup Method
		[TestInitialize]
		public void setUp()
		{
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
		#endregion

		#region Test Value In Column, Row & Square
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
		#endregion

		#region Test Emptyness of the Grid 
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
		#endregion

		#region Computing Methods
		[TestMethod]
		public void Test_CheckWin_Method()
		{
			game.SudokuGrid.SetValues(game.Solution);
			game.State = GameState.PLAYING;

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
		#endregion
	}
}
