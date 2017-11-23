using Genki.SudokuEngine.GridEngine;
using System.Windows.Forms;

namespace Genki
{
	public partial class Frame : Form
	{
		public Grid grid { get; set; }

		public Frame()
		{
			InitializeComponent();

			grid = new Grid(new GridListener(
				(x, y, value) =>
				{
					try
					{
						dvg_grid[x - 1, y - 1].Value = value;
					} catch (System.IndexOutOfRangeException e)
					{
						System.Console.Error.WriteLine(e.StackTrace);
#if DEBUG
						MessageBox.Show("An error occured during the update of " +
							"dvg_grid[" + (x - 1) + ", " + (y - 1) + "] in a delegate method.",
							"Error: DEBUG", MessageBoxButtons.OK);
#endif
					}
				}
				));

			dvg_grid.RowCount = (int)Grid.NB_ROWS;
			dvg_grid.ColumnCount = (int)Grid.NB_COLUMNS;

			for (int i = 0; i < Grid.NB_ROWS; i++)
			{
				for (int j = 0; j < Grid.NB_COLUMNS; j++)
				{
					dvg_grid.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				}
			}
		}

		private void dvg_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
