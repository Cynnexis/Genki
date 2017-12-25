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
	/// Listeners for a counter
	/// </summary>
	/// <typeparam name="T">The type of data the counter has</typeparam>
	/// <seealso cref="AbstractCounter{T}"/>
	public class CounterListener<T>
	{
		#region Delegates Declaration
		public delegate void OnValueChanged(T value);
		public delegate void OnMinChanged(T min);
		public delegate void OnMaxChanged(T max);
		public delegate void OnStepChanged(T step);
		#endregion

		#region Variables & Properties
		[NonSerialized]
		public OnValueChanged actionOnValueChanged;
		[NonSerialized]
		public OnMinChanged actionOnMinChanged;
		[NonSerialized]
		public OnMaxChanged actionOnMaxChanged;
		[NonSerialized]
		public OnStepChanged actionOnStepChanged;

		public OnValueChanged ActionOnValueChanged
		{
			get { return actionOnValueChanged; }
			set { actionOnValueChanged = value; }
		}
		public OnMinChanged ActionOnMinChanged
		{
			get { return actionOnMinChanged; }
			set { actionOnMinChanged = value; }
		}
		public OnMaxChanged ActionOnMaxChanged
		{
			get { return actionOnMaxChanged; }
			set { actionOnMaxChanged = value; }
		}
		public OnStepChanged ActionOnStepChanged
		{
			get { return actionOnStepChanged; }
			set { actionOnStepChanged = value; }
		}
		#endregion

		#region Constructor
		public CounterListener(OnValueChanged onValueChanged = null, OnMinChanged onMinChanged = null, OnMaxChanged onMaxChanged = null, OnStepChanged onStepChanged = null)
		{
			this.ActionOnValueChanged = onValueChanged == null ? new OnValueChanged((value) => { }) : onValueChanged;
			this.ActionOnMinChanged = onMinChanged == null ? new OnMinChanged((min) => { }) : onMinChanged;
			this.ActionOnMaxChanged = onMaxChanged == null ? new OnMaxChanged((max) => { }) : onMaxChanged;
			this.ActionOnStepChanged = onStepChanged == null ? new OnStepChanged((step) => { }) : onStepChanged;
		}
		#endregion
	}
}
