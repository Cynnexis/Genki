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

		public byte Value
		{
			get { return _value; }
			set
			{
				if (value >= 0 && value <= 9)
					_value = value;
				else
					_value = 0;
				CellListeners?.onValueChange(Value);
			}
		}

		public ObservableCollection<byte> Draft
		{
			get { return _draft; }
			set
			{
				_draft = value;
				CellListeners?.onDraftChange(Draft);
			}
		}

		public bool ReadOnly
		{
			get { return readOnly; }
			set
			{
				readOnly = value;
				CellListeners?.onReadOnlyChange(ReadOnly);
			}
		}

		public CellListener CellListeners
		{
			get { return _cellListeners; }
			set { _cellListeners = value; }
		}
		


		public Cell(Point coordinates, byte value = 0, CellListener cellListeners = null, bool readOnly = false, ObservableCollection<byte> draft = null)
		{
			this.Coordinates = coordinates;
			this.Value = value;
			if (draft != null)
			{
				this.Draft = draft;
				this.Draft.CollectionChanged += (sender, e) => { CellListeners?.onDraftChange(Draft); };
			}
			this.ReadOnly = readOnly;
			if (cellListeners != null)
				this.CellListeners = cellListeners;
		}

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
	}
}
