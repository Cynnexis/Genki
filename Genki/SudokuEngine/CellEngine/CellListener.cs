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
	public delegate void OnValueChange(byte value);
	public delegate void OnDraftChange(ObservableCollection<byte> draft);
	public delegate void OnReadOnlyChange(bool readOnly);
	
	public class CellListener
	{
		public OnValueChange onValueChange { get; set; }
		public OnDraftChange onDraftChange { get; set; }
		public OnReadOnlyChange onReadOnlyChange { get; set; }

		public CellListener(OnValueChange onValueChange = null, OnDraftChange onDraftChange = null, OnReadOnlyChange onReadOnlyChange = null)
		{
			this.onValueChange = onValueChange != null ? onValueChange : new OnValueChange((value) => { });
			this.onDraftChange = onDraftChange != null ? onDraftChange : new OnDraftChange((draft) => { });
			this.onReadOnlyChange = onReadOnlyChange != null ? onReadOnlyChange : new OnReadOnlyChange((readOnly) => { });
		}
	}
}
