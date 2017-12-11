using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.StopwatchEngine
{
	[Serializable, DataContract, XmlRoot("IntegerCounter")]
	public class IntegerCounter : AbstractCounter<int>
	{
		public IntegerCounter(int defaultValue, int min, int max, int step, CounterListener<int> cl = null) : base(defaultValue, min, max, step, cl)
		{ }
		public IntegerCounter(int defaultValue, int min, int max, int step, Action action = null) : base(defaultValue, min, max, step)
		{
			if (action != null)
			{
				CounterListener<int> cl = new CounterListener<int>((value) => { action(); });
				this.ActionOnCounter = cl;
			}
		}

		public override int compare(int t1, int t2)
		{
			if (t1 < t2)
				return -1;
			else if (t1 > t2)
				return 1;
			else
				return 0;
		}

		public override int minus(int t1, int t2)
		{
			return t1 - t2;
		}

		public override int plus(int t1, int t2)
		{
			return t1 + t2;
		}
	}
}
