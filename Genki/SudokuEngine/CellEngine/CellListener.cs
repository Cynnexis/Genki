using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.CellEngine
{
	#region Delegates Declaration
	public delegate void OnValueChanged(byte value);
	public delegate void OnDraftChanged(ObservableCollection<byte> draft);
	public delegate void OnReadOnlyChanged(bool readOnly);
	#endregion

	public class CellListener
	{
		#region Properties
		public OnValueChanged onValueChanged { get; set; }
		public OnDraftChanged onDraftChanged { get; set; }
		public OnReadOnlyChanged onReadOnlyChanged { get; set; }
		#endregion

		#region Constructor
		public CellListener(OnValueChanged onValueChanged = null, OnDraftChanged onDraftChanged = null, OnReadOnlyChanged onReadOnlyChanged = null)
		{
			this.onValueChanged = onValueChanged != null ? onValueChanged : new OnValueChanged((value) => { });
			this.onDraftChanged = onDraftChanged != null ? onDraftChanged : new OnDraftChanged((draft) => { });
			this.onReadOnlyChanged = onReadOnlyChanged != null ? onReadOnlyChanged : new OnReadOnlyChanged((readOnly) => { });
		}
		#endregion
	}
}
