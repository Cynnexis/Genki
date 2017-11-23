using Genki.SudokuEngine.CellEngine;

namespace Genki.SudokuEngine.GridEngine
{
	public class Grid
	{
		public const uint NB_ROWS = 9;
		public const uint NB_COLUMNS = 9;

		private Cell[][] _cells = null;
		private Cell[][] Cells
		{
			get { return _cells; }
			set { _cells = value; }
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
				gl.onGridChanged(i + 1, j + 1, value.Value);
			}
		}

		public GridListener gl { get; set; }

		public Grid(GridListener gridListener = null)
		{
			if (gridListener != null)
				this.gl = gridListener;
			else
				this.gl = new GridListener((x, y, value) => { });

			Cells = new Cell[NB_ROWS][];

			// TODO: Optimiser les boucles 'for{for}; for' en un 'for {for; for}' (plus rapide)
			for (int i = 0; i < Cells.Length; i++)
				this.Cells[i] = new Cell[NB_COLUMNS];

			for (int i = 0; i < NB_ROWS; i++)
			{
				for (int j = 0; j < NB_COLUMNS; j++)
				{
					this.Cells[i][j] = new Cell(new System.Drawing.Point(i + 1, j + 1), 0, new CellListener(
						(value) => { gl.onGridChanged(i + 1, j + 1, value); },
						(draft) => { })
					);
				}
			}
		}
	}
}
