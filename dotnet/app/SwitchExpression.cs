using System;
using System.Collections.Generic;
using System.Linq;

namespace anki.switch_expression
{
	public class SwitchExpression
	{

		public T OldSchool<T>(IEnumerable<T> sequence)
		{
			if (sequence.GetType() == typeof(Array))
			{
				var array = sequence as Array;
				if (array.Length == 2) return (T)array.GetValue(1);     // An Array of two elements, second element
				return (T)array.GetValue(0);                            // Any Array, first element
			}

			if (sequence.GetType() == typeof(IEnumerable<T>))
			{
				var list = sequence as IEnumerable<T>;
				if (list.Count() < 3) return list.Last();   // An Enumerable of less than three elements, last element
			}

			throw new Exception(nameof(sequence));                    // None of the above
		}
	}
}