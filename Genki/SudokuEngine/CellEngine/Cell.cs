using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genki.SudokuEngine.CellEngine
{
	public class Cell
	{
		/// <summary>
		/// The coordinates start from (1, 1)
		/// </summary>
		private Point _coordinates;
		public Point Coordinates
		{
			get { return _coordinates; }
			private set
			{
				if (value.X >= 0 && value.Y <= 0)
					_coordinates = value;
				else
					_coordinates = new Point(0, 0);
			}
		}


		private byte _value = 0;
		public byte Value
		{
			get { return _value; }
			set
			{
				if (value >= 0 && value <= 9)
					_value = value;
				else
					_value = 0;
			}
		}

		private CellListener _cellListeners = new CellListener();
		public CellListener CellListeners
		{
			get { return _cellListeners; }
			set { _cellListeners = value; }
		}

		private ObservableCollection<byte> _draft = new ObservableCollection<byte>();
		public ObservableCollection<byte> Draft
		{
			get { return _draft; }
			set { _draft = value; }
		}
		


		public Cell(Point coordinates, byte value = 0, CellListener cellListeners = null, ObservableCollection<byte> draft = null)
		{
			this.Coordinates = coordinates;
			this.Value = value;
			if (cellListeners != null)
				this.CellListeners = cellListeners;
			if (draft != null)
				this.Draft = draft;
		}
	}
}
