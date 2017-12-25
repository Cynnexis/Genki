using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.CellEngine
{
	[Serializable, DataContract, XmlRoot("Cell")]
	public class Cell
	{
		#region Variables & Properties
		/// <summary>
		/// The coordinates start from (1, 1)
		/// </summary>
		[DataMember]
		private Point _coordinates;
		[DataMember]
		private byte _value = 0;
		[DataMember]
		private ObservableCollection<byte> _draft = new ObservableCollection<byte>();
		[DataMember]
		private bool readOnly = false;
		[NonSerialized]
		private CellListener _cellListeners = new CellListener();

		/// <summary>
		/// The coordinates start from (1, 1)
		/// </summary>
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

		/// <summary>
		/// The value of the cell. It must be between 0 and 9. Once the value is changed, it calls the OnValueChanged Listener.
		/// </summary>
		public byte Value
		{
			get { return _value; }
			set
			{
				if (value >= 0 && value <= 9)
					_value = value;
				else
					_value = 0;
				CellListeners?.onValueChanged(Value);
			}
		}

		/// <summary>
		/// The draft list. Once it changed, a listener is called
		/// </summary>
		public ObservableCollection<byte> Draft
		{
			get { return _draft; }
			set
			{
				_draft = value;
				CellListeners?.onDraftChanged(Draft);
			}
		}

		/// <summary>
		/// ReadOnly. It has no influence over the Setters of the cell, this is only an information which must be
		/// saved during the serialization. Once it changed, a listener is called
		/// </summary>
		public bool ReadOnly
		{
			get { return readOnly; }
			set
			{
				readOnly = value;
				CellListeners?.onReadOnlyChanged(ReadOnly);
			}
		}

		/// <summary>
		/// The listeners
		/// </summary>
		public CellListener CellListeners
		{
			get { return _cellListeners; }
			set { _cellListeners = value; }
		}
		#endregion

		#region Constructor
		public Cell(Point coordinates, byte value = 0, CellListener cellListeners = null, bool readOnly = false, ObservableCollection<byte> draft = null)
		{
			this.Coordinates = coordinates;
			this.Value = value;
			if (draft != null)
			{
				this.Draft = draft;
				this.Draft.CollectionChanged += (sender, e) => { CellListeners?.onDraftChanged(Draft); };
			}
			this.ReadOnly = readOnly;
			if (cellListeners != null)
				this.CellListeners = cellListeners;
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			// Coordinates
			string sCoord = "";
			if (Coordinates != null)
				sCoord += "(" + Coordinates.X.ToString() + " ; " + Coordinates.Y.ToString() + ")";
			else
				sCoord = "(null)";

			// Draft
			string sDraft = "[";
			if (Draft != null)
			{
				if (Draft.Count > 0)
				{
					for (int i = 0; i < Draft.Count - 1; i++)
						sDraft += Draft[i].ToString() + ", ";
					sDraft += Draft[Draft.Count - 1] + "]";
				}
				else
					sDraft = "[]";
			}
			else
				sDraft = "(null)";

			return "Cell{" +
				"Coordinates=" + sCoord + ", " +
				"Value=" + Value.ToString() + ", " +
				"Draft=\"" + sDraft + "\"" +
				"ReadOnly=\"" + ReadOnly.ToString() + "\"" +
				"CellListeners=\"" + CellListeners?.ToString() + "\", " +
				"}";
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Cell c = (Cell) obj;
			return this.Value == c.Value;
		}
		#endregion
	}
}
