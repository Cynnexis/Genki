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
	/// Counter of element <paramref name="T"/>
	/// </summary>
	/// <typeparam name="T">The type of variable to count</typeparam>
	[Serializable, DataContract, XmlRoot("AbstractCounter")]
	public abstract class AbstractCounter<T> : CounterInterface<T>
	{
		#region Variables & Properties
		[DataMember]
		private T _value;
		[DataMember]
		private T _min;
		[DataMember]
		private T _max;
		[DataMember]
		private T _step;
		[NonSerialized]
		private CounterListener<T> actionOnCounter = null;

		public T Value
		{
			get { return _value; }
			set
			{
				_value = value;
				if (ActionOnCounter != null)
					ActionOnCounter.ActionOnValueChanged(_value);
			}
		}

		public T Min
		{
			get { return _min; }
			set
			{
				_min = value;
				if (ActionOnCounter != null)
					ActionOnCounter.ActionOnMinChanged(_min);
			}
		}

		public T Max
		{
			get { return _max; }
			set
			{
				_max = value;
				if (ActionOnCounter != null)
					ActionOnCounter.ActionOnMaxChanged(_max);
			}
		}

		public T Step
		{
			get { return _step; }
			set
			{
				_step = value;
				if (ActionOnCounter != null)
					ActionOnCounter.ActionOnStepChanged(_step);
			}
		}

		public CounterListener<T> ActionOnCounter
		{
			get { return actionOnCounter; }
			set { actionOnCounter = value; }
		}
		#endregion

		#region Constructor
		public AbstractCounter(T defaultValue, T min, T max, T step, CounterListener<T> cl = null)
		{
			this.Value = defaultValue;
			this.Min = min;
			this.Max = max;
			this.Step = step;
			if (cl != null)
				this.ActionOnCounter = cl;
			else
				this.ActionOnCounter = new CounterListener<T>();
		}
		#endregion

		#region Counter Operations
		public bool increment()
		{
			bool overflow = false;

			Value = plus(this.Value, this.Step);

			while (compare(Value, Max) > 0)
			{
				Value = plus(Min, minus(Max, Value));
				overflow = true;
			}

			return overflow;
		}

		public bool decrease()
		{
			bool overflow = false;

			Value = minus(this.Value, this.Step);

			while (compare(Value, Min) < 0)
			{
				Value = plus(Max, minus(Value, Min));
				overflow = true;
			}

			return overflow;
		}

		public void reset()
		{
			Value = Min;
		}
		#endregion

		#region Operations over T
		public abstract T plus(T t1, T t2);
		public abstract T minus(T t1, T t2);
		public abstract int compare(T t1, T t2);
		#endregion

		#region Override
		public override string ToString()
		{
			return Value.ToString();
		}
		#endregion
	}
}
