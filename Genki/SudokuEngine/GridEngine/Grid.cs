using Genki.SudokuEngine.CellEngine;
using Genki.SudokuEngine.Exceptions;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.GridEngine
{
	[Serializable, DataContract, XmlRoot("Grid")]
	public class Grid
	{
		public const uint NB_ROWS = 9;
		public const uint NB_COLUMNS = 9;
		
		[DataMember]
		private Cell[][] _cells = null;
		
		[NonSerialized]
		private GridListener actionOnGrid = null;

		public GridListener ActionOnGrid
		{
			get { return actionOnGrid; }
			set { actionOnGrid = value; }
		}
		
		/// <summary>
		/// Standard: Cell[column][row] from 0
		/// </summary>
		private Cell[][] Cells
		{
			get { return _cells; }
			set { _cells = value;}
		}

		// Indexer (see https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/index)
		public Cell this[int i, int j]
		{
			get
			{
				return Cells[i][j];
			}
			set
			{
				Cells[i][j] = value;
				ActionOnGrid.ActionOnGridChange(i, j, value.Value);
			}
		}
		public Cell[] this[int i]
		{
			set
			{
				if (value.Length != NB_ROWS)
					throw new IndexOutOfRangeException("Expected length : " + NB_ROWS + ", length found : " + value.Length);
				Cells[i] = value;
				for (int j = 0; j < NB_ROWS; j++)
					Cells[i][j] = value[j];
			}
			get
			{
				return Cells[i];
			}
		}


		public Grid(GridListener gridListener = null, Grid copy = null)
		{
			if (gridListener != null)
				this.ActionOnGrid = gridListener;
			else
				this.ActionOnGrid = new GridListener((x, y, value) => { });

			Cells = new Cell[NB_COLUMNS][];
			
			for (int i = 0; i < NB_COLUMNS; i++)
			{
				this.Cells[i] = new Cell[NB_ROWS];
				for (int j = 0; j < NB_ROWS; j++)
				{
					this.Cells[i][j] = new Cell(new System.Drawing.Point(i + 1, j + 1), (copy == null ? (byte) 0 : copy[i, j].Value), new CellListener(
						(value) => { ActionOnGrid.ActionOnGridChange(i, j, value); },
						(draft) => { })
					);
				}
			}
		}

		/// <summary>
		/// Put a 0 value for every cell in the grid.
		/// <param name="resetDraft">Empty the draft of every cell if true. Default value is false</param>
		/// </summary>
		public void reset(bool resetDraft = false)
		{
			for (int i = 0; i < NB_ROWS; i++)
			{
				for (int j = 0; j < NB_COLUMNS; j++)
				{
					// if the cell (i, j) is null, the program creates it (regardless of the value of `resetDraft`)
					if (this.Cells[i][j] == null)
					{
						this.Cells[i][j] = new Cell(new System.Drawing.Point(i + 1, j + 1), 0, new CellListener(
							(value) => { ActionOnGrid.ActionOnGridChange(i - 1, j - 1, value); },
							(draft) => { })
						);
					}
					// Otherwise, the programe change the value to 0 and reset the draft list if `resetDraft` is equal to 0
					else
					{
						this.Cells[i][j].Value = 0;
						if (resetDraft)
							this.Cells[i][j].Draft.Clear();
					}
				}
			}
		}

		public Grid Transpose(Grid g)
		{
			if (NB_COLUMNS != NB_ROWS)
				throw new DimensionsNotEqualException();

			Grid tmp = new Grid();

			for (int i = 0; i < NB_ROWS; i++)
				for (int j = 0; j < NB_COLUMNS; j++)
					tmp[i, j] = g[j, i];

			return g;
		}
		public Grid Transpose()
		{
			return Transpose(this);
		}

		public void SetValues(Grid newGrid)
		{
			if (newGrid != null)
			{
				for (int i = 0; i < NB_ROWS; i++)
					for (int j = 0; j < NB_COLUMNS; j++)
						if (newGrid[i, j] != null)
							this[i, j].Value = newGrid[i, j].Value;
			}
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			bool result = true;
			Grid g = (Grid) obj;
			for (int i = 0; i < g.Cells.Length && result; i++)
				for (int j = 0; j < g.Cells[i].Length && result; j++)
					if (!this[i, j].Equals(g[i, j]))
						result = false;

			return result;
		}
	}
}
