using Genki.SudokuEngine.StopwatchEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.StopwatchEngine
{
	[Serializable, DataContract, XmlRoot("CounterList")]
	public class CounterList<C, T> where C : AbstractCounter<T>
	{
		[DataMember]
		private List<C> counters;
		public List<C> Counters
		{
			get { return counters; }
			set { counters = value; }
		}

		// Indexer
		public C this[int i]
		{
			get { return Counters[i]; }
			set { Counters[i] = value; }
		}

		public CounterList(int capacity = 0)
		{
			Counters = new List<C>(capacity);
		}

		public bool increment()
		{
			bool keepGoing = true;
			int i;
			for (i = 0; i < this.Counters.Count && keepGoing; i++)
				keepGoing = this[i].increment();

			return i > 0;
		}

		public bool decrease()
		{
			bool keepGoing = true;
			int i;
			for (i = 0; i < this.Counters.Count && keepGoing; i++)
				keepGoing = this[i].decrease();

			return i > 0;
		}

		public void reset()
		{
			for (int i = 0; i < this.Counters.Count; i++)
				this[i].reset();
		}

		public override string ToString()
		{
			string result = "";
			for (int i = 0; i < this.Counters.Count; i++)
				result = this[i].Value.ToString() + (i == 0 ? "" : ",") + result;
			return result;
		}
	}
}
