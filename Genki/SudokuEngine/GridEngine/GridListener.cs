using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genki.SudokuEngine.GridEngine
{
	public class GridListener
	{
		public delegate void OnGridChanged(int x, int y, int value);

		public OnGridChanged onGridChanged { get; set; }
		
		public GridListener(OnGridChanged onGridChanged)
		{
			this.onGridChanged = onGridChanged;
		}
	}
}
