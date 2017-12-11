using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.GridEngine
{
	public delegate void OnGridChanged(int x, int y, int value);
	
	public class GridListener
	{
		[NonSerialized]
		private OnGridChanged actionOnGridChange = null;
		public OnGridChanged ActionOnGridChange
		{
			get { return actionOnGridChange; }
			set { actionOnGridChange = value; }
		}
		
		public GridListener(OnGridChanged onGridChanged)
		{
			this.ActionOnGridChange = onGridChanged;
		}
	}
}
