using Genki.SudokuEngine.GridEngine;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace Genki
{
	public partial class Frame : Form
	{
		public Grid grid { get; set; }

		private Point activeCell = new Point(-1, -1);

		public Frame()
		{
			InitializeComponent();

			grid = new Grid(new GridListener(
				(x, y, value) =>
				{
					try
					{
						if (value != 0)
							dvg_grid[x - 1, y - 1].Value = value;
						else
							dvg_grid[x - 1, y - 1].Value = "";
					} catch (Exception e)
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
			dvg_grid.Columns[2].DividerWidth = 2;
			dvg_grid.Columns[5].DividerWidth = 2;
			dvg_grid.Rows[2].DividerHeight = 2;
			dvg_grid.Rows[5].DividerHeight = 2;

			for (int i = 0; i < dvg_grid.RowCount; i++)
				for (int j = 0; j < dvg_grid.Rows[i].Cells.Count; j++)
					dvg_grid.Rows[i].Cells[j].Value = "";
		}

		private void frame_Resize(object sender, EventArgs e)
		{
			this.dvg_grid.RowTemplate.Height = this.dvg_grid.Size.Height / (int)Grid.NB_ROWS;
			this.dvg_grid.Refresh();
		}

		private void dvg_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				object o = dvg_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
				byte value = 0;
				if (o is string)
				{
					string s = (string) o;
					if (s.Equals(""))
					{
						grid[e.ColumnIndex, e.RowIndex].Value = value;
						return;
					}

					try
					{
						value = byte.Parse((string)o);
					} catch (Exception ex) {
						System.Console.Error.WriteLine("Handled Exception:");
						System.Console.Error.WriteLine(ex.StackTrace);
						// DVG value <- Grid value
						dvg_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grid[e.ColumnIndex, e.RowIndex].Value;
						return;
					}
				}
				else if (o is byte || o is sbyte || o is short || o is ushort || o is int || o is uint || o is long || o is ulong || o is float || o is double || o is decimal)
					value = (byte)o;
				else
					value = 0;

				if (!(value >= 0 && value <= 9))
					value = 0;

				grid[e.ColumnIndex, e.RowIndex].Value = value;

				// If the value is 0, don't display it in the cell
				if (value == 0)
					dvg_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
			}
			catch (IndexOutOfRangeException ex)
			{
				System.Console.Error.WriteLine(ex.StackTrace);
			}
		}

		private void dvg_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			activeCell = new Point(e.ColumnIndex, e.RowIndex);
#if DEBUG
			System.Console.WriteLine("Active Cell[" + activeCell.X + ", " + activeCell.Y + "]");
#endif
			gb_cellOption.Visible = true;

			if (activeCell.X != -1 && activeCell.Y != -1)
			{
				n_cellValue.Value = grid[activeCell.X, activeCell.Y].Value;

				ObservableCollection<byte> list = grid[activeCell.X, activeCell.Y].Draft;
				lb_draft.Items.Clear();
				foreach (byte d in list)
					lb_draft.Items.Add(d);
			}
		}

		private void dvg_grid_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			activeCell = new Point(-1, -1);
			gb_cellOption.Visible = true;
		}

		private void n_cellValue_ValueChanged(object sender, EventArgs e)
		{
			// If X or Y is -1, then activeCell is not usable, and the program assumes there is no active cell in the DVG.
			if (activeCell.X == -1 || activeCell.Y == -1)
			{
				try
				{
					byte value = Convert.ToByte(n_cellValue.Value);
					if (value < 0 || value > 9)
					{
						n_cellValue.Value = 0;
						return;
					}

					grid[activeCell.X, activeCell.Y].Value = value;
				}
				catch (OverflowException ex)
				{
					System.Console.Error.WriteLine("Handled Error:");
					System.Console.Error.WriteLine(ex.StackTrace);
					n_cellValue.Value = grid[activeCell.X, activeCell.Y].Value;
				}
			}
		}

		private void b_editDraft_Click(object sender, EventArgs e)
		{

		}

		private void b_addDraft_Click(object sender, EventArgs e)
		{

		}

		private void b_removeDraft_Click(object sender, EventArgs e)
		{

		}

		private void mi_about_Click(object sender, EventArgs e)
		{
			AboutDialogBox about = new AboutDialogBox();
			about.ShowDialog(this);
		}
	}
}
