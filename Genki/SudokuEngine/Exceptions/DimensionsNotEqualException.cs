using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genki.SudokuEngine.Exceptions
{
	/// <summary>
	/// Exception called when the dimension of the grid are not equal
	/// </summary>
	public class DimensionsNotEqualException : Exception
	{
		public DimensionsNotEqualException() : base() { }

		public DimensionsNotEqualException(string message) : base(message) { }

		public DimensionsNotEqualException(string message, Exception innerException) : base(message, innerException) { }
	}
}
