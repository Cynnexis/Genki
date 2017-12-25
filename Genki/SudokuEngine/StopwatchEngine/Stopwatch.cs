using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine.StopwatchEngine
{
	/// <summary>
	/// List of integer counters
	/// </summary>
	/// <seealso cref="IntegerCounter"/>
	[Serializable, DataContract, XmlRoot("Stopwatch")]
	public class Stopwatch : CounterList<IntegerCounter, int>
	{
		#region Variables & Properties
		[DataMember]
		private bool activated;
		[NonSerialized]
		private Thread watch;
		[DataMember]
		private bool continueThread;

		[NonSerialized]
		private Action onActiveStateChange;
		[NonSerialized]
		private Action onSecondChange;
		[NonSerialized]
		private Action onMinuteChange;
		[NonSerialized]
		private Action onHourChange;

		/// <summary>
		/// The "second" timer
		/// </summary>
		public int Second
		{
			get { return this[0].Value; }
			set { this[0].Value = value; }
		}

		/// <summary>
		/// The "minute" timer
		/// </summary>
		public int Minute
		{
			get { return this[1].Value; }
			set { this[1].Value = value; }
		}

		/// <summary>
		/// The "hour" timer
		/// </summary>
		public int Hour
		{
			get { return this[2].Value; }
			set { this[2].Value = value; }
		}

		/// <summary>
		/// Listener which is called when the state of the stopwatch is changed
		/// </summary>
		public Action OnActiveStateChange
		{
			get { return onActiveStateChange; }
			set { onActiveStateChange = value; }
		}

		/// <summary>
		/// Listener which is called when the state of the second timer is changed
		/// </summary>
		public Action OnSecondChange
		{
			get { return onSecondChange; }
			set { onSecondChange = value; }
		}

		/// <summary>
		/// Listener which is called when the state of the minute timer is changed
		/// </summary>
		public Action OnMinuteChange
		{
			get { return onMinuteChange; }
			set { onMinuteChange = value; }
		}

		/// <summary>
		/// Listener which is called when the state of the hour timer is changed
		/// </summary>
		public Action OnHourChange
		{
			get { return onHourChange; }
			set { onHourChange = value; }
		}

		/// <summary>
		/// The state of the stopwatch
		/// </summary>
		public bool Activated
		{
			get { return activated; }
			set
			{
				activated = value;
				OnActiveStateChange?.Invoke();
			}
		}
		#endregion

		#region Constructor and Destructor
		public Stopwatch(Action OnActiveStateChange = null, Action OnSecondChange = null, Action OnMinuteChange = null, Action OnHourChange = null)
		{
			this.OnActiveStateChange = (OnActiveStateChange == null ? () => { } : OnActiveStateChange);
			this.OnSecondChange = (OnSecondChange == null ? () => { } : OnSecondChange);
			this.OnMinuteChange = (OnMinuteChange == null ? () => { } : OnMinuteChange);
			this.OnHourChange = (OnHourChange == null ? () => { } : OnHourChange);

			this.Counters.Add(new IntegerCounter(0, 0, 59, 1, this.OnSecondChange)); // second
			this.Counters.Add(new IntegerCounter(0, 0, 59, 1, this.OnMinuteChange)); // minute
			this.Counters.Add(new IntegerCounter(0, 0, 23, 1, this.OnHourChange)); // heure

			Activated = false;
			RestartThread();
		}

		// Destructor
		~Stopwatch()
		{
			StopThread();
		}
		#endregion

		#region Thread Operations
		private void Watcher()
		{
			while (continueThread)
			{
				Thread.Sleep(1000);
				//waitHandler.WaitOne();
				if (activated)
					this.increment();
			}
		}

		public void StopThread()
		{
			activated = true;
			continueThread = false;
			try
			{
				Thread.Sleep(1000);
				watch.Abort();
			}
			catch (Exception ex) { }
		}

		public void RestartThread()
		{
			continueThread = true;
			watch = new Thread(Watcher);
			watch.Start();
		}
		#endregion

		#region ToString Override
		/// <summary>
		/// Compute a string to return the stopwatch in format "hh:mm:ss"
		/// </summary>
		/// <returns>Return the string representation of this instance of Stopwatch</returns>
		public override string ToString()
		{
			string result = "";

			try
			{
				result = convertNumberTo2Char(this.Hour) + ':' + convertNumberTo2Char(this.Minute) + ':' + convertNumberTo2Char(this.Second);
			} catch (IndexOutOfRangeException ex)
			{
				Console.Error.WriteLine(ex.StackTrace);
				return "";
			}

			return result;
		}

		/// <summary>
		/// Convert a 1 or 2-digits number to a 2-characters string. For example,
		/// convertNumberTo2Char(1) = "01", 
		/// convertNumberTo2Char(25) = "25" and
		/// convertNumberTo2Char(999) = "00"
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		private string convertNumberTo2Char(int number)
		{
			if (number < 0 || number > 99)
				return "00";

			string result = "";

			if (number >= 0 && number <= 9)
				result = "0";

			result += Convert.ToString(number);
			return result;
		}
		#endregion
	}
}
