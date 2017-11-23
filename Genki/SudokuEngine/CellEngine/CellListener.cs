using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genki.SudokuEngine.CellEngine
{

	public class CellListener
	{
		public delegate void OnValueChanged(byte value);
		public delegate void OnDraftChanged(ObservableCollection<byte> draft);

		public OnValueChanged onValueChanged { get; set; }
		public OnDraftChanged onDraftChanged { get; set; }

		public CellListener()
		{
			this.onValueChanged = (value) => { };
			this.onDraftChanged = (draft) => { };
		}
		public CellListener(OnValueChanged onValueChanged, OnDraftChanged onDraftChanged)
		{
			this.onValueChanged = onValueChanged;
			this.onDraftChanged = onDraftChanged;
		}
	}
}
