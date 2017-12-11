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
	[Serializable, DataContract, XmlRoot("Stopwatch")]
	public class Stopwatch : CounterList<IntegerCounter, int>
	{
		[DataMember]
		private bool activated;
		[NonSerialized]
		private Thread watch;
		[NonSerialized]
		private ManualResetEvent waitHandler = new ManualResetEvent(true);
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

		public int Second
		{
			get { return this[0].Value; }
			set { this[0].Value = value; }
		}

		public int Minute
		{
			get { return this[1].Value; }
			set { this[1].Value = value; }
		}

		public int Hour
		{
			get { return this[2].Value; }
			set { this[2].Value = value; }
		}

		public Action OnActiveStateChange
		{
			get { return onActiveStateChange; }
			set { onActiveStateChange = value; }
		}
		public Action OnSecondChange
		{
			get { return onSecondChange; }
			set { onSecondChange = value; }
		}
		public Action OnMinuteChange
		{
			get { return onMinuteChange; }
			set { onMinuteChange = value; }
		}
		public Action OnHourChange
		{
			get { return onHourChange; }
			set { onHourChange = value; }
		}

		public bool Activated
		{
			get { return activated; }
			set
			{
				activated = value;
				if (activated)
					waitHandler?.Set();
				else
					waitHandler?.Reset();
				OnActiveStateChange?.Invoke();
			}
		}

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

		private void Watcher()
		{
			while (continueThread)
			{
				Thread.Sleep(1000);
				waitHandler.WaitOne();
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
	}
}
