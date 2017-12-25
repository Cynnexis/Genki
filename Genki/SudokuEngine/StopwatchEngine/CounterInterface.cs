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
	/// Interface to implement the basic operations for <paramref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The element</typeparam>
	public interface CounterInterface<T>
	{
		/// <summary>
		/// Sum <paramref name="t1"/> and <paramref name="t2"/>
		/// </summary>
		/// <param name="t1"></param>
		/// <param name="t2"></param>
		/// <returns><paramref name="t1"/> + <paramref name="t2"/></returns>
		T plus(T t1, T t2);

		/// <summary>
		/// Sum <paramref name="t1"/> and -<paramref name="t2"/>
		/// </summary>
		/// <param name="t1"></param>
		/// <param name="t2"></param>
		/// <returns><paramref name="t1"/> - <paramref name="t2"/></returns>
		T minus(T t1, T t2);

		/// <summary>
		/// Compare <paramref name="t1"/> and <paramref name="t2"/> in the T vector-space.
		/// </summary>
		/// <param name="t1">First object to compare</param>
		/// <param name="t2">Second object to compare</param>
		/// <returns>Return an integer lesser than 0 if <paramref name="t1"/> is lesser than <paramref name="t2"/>, greather than 0 if <paramref name="t1"/> is greater than <paramref name="t2"/>, and equals to 0 if <paramref name="t1"/> = <paramref name="t2"/></returns>
		int compare(T t1, T t2);
	}
}
