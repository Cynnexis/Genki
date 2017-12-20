using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genki.SudokuEngine.Exceptions
{
	public class DimensionsNotEqualException : Exception
	{
		public DimensionsNotEqualException() : base() { }

		public DimensionsNotEqualException(string message) : base(message) { }

		public DimensionsNotEqualException(string message, Exception innerException) : base(message, innerException) { }
	}
}
