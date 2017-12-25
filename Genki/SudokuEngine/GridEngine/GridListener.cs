using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.GridEngine
{
	#region Delegate Declaration
	public delegate void OnGridChanged(int x, int y, int value);
	#endregion

	public class GridListener
	{
		#region Variable & Property
		[NonSerialized]
		private OnGridChanged actionOnGridChange = null;
		public OnGridChanged ActionOnGridChange
		{
			get { return actionOnGridChange; }
			set { actionOnGridChange = value; }
		}
		#endregion

		#region Constructor
		public GridListener(OnGridChanged onGridChanged)
		{
			this.ActionOnGridChange = onGridChanged;
		}
		#endregion
	}
}
