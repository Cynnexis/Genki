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
	/// <summary>
	/// List of counter
	/// </summary>
	/// <typeparam name="C">A counter inherted from AbstractCounter</typeparam>
	/// <typeparam name="T">The type of data the counters have</typeparam>
	/// <seealso cref="AbstractCounter{T}"/>
	[Serializable, DataContract, XmlRoot("CounterList")]
	public class CounterList<C, T> where C : AbstractCounter<T>
	{
		#region Variables, Properties & Indexer
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
		#endregion

		#region Constructor
		public CounterList(int capacity = 0)
		{
			Counters = new List<C>(capacity);
		}
		#endregion

		#region Counter List Operations
		/// <summary>
		/// Increment the last counter. If the last counter overflow, increment the second counter, and so on.
		/// </summary>
		/// <returns>Return true if more than 1 counter have been incremented</returns>
		public bool increment()
		{
			bool keepGoing = true;
			int i;
			for (i = 0; i < this.Counters.Count && keepGoing; i++)
				keepGoing = this[i].increment();

			return i > 0;
		}

		/// <summary>
		/// Decrease the last counter. If the last counter overflow, decrease the second counter, and so on.
		/// </summary>
		/// <returns>Return true if more than 1 counter have been decreased</returns>
		public bool decrease()
		{
			bool keepGoing = true;
			int i;
			for (i = 0; i < this.Counters.Count && keepGoing; i++)
				keepGoing = this[i].decrease();

			return i > 0;
		}

		/// <summary>
		/// Reset all counters
		/// </summary>
		public void reset()
		{
			for (int i = 0; i < this.Counters.Count; i++)
				this[i].reset();
		}
		#endregion

		#region Override
		public override string ToString()
		{
			string result = "";
			for (int i = 0; i < this.Counters.Count; i++)
				result = this[i].Value.ToString() + (i == 0 ? "" : ",") + result;
			return result;
		}
		#endregion
	}
}
