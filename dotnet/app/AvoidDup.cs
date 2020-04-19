using System;
using System.Collections.Generic;
using System.Linq;

namespace app.avoid
{
	public class AvoidDup
	{
		void Foo()
		{
			int[] testSet = { 100271, 234335, 342439, 999683 };

			/* Fix Here */
			var primes = testSet.Where(n => Factor(n).ToList().Count == 2 && Factor(n).ToList().Contains(1));

		}

		static IEnumerable<int> Factor(int number)
		{
			int max = (int)Math.Sqrt(number);
			for (int i = 1; i <= max; i++)
			{
				if (number % i == 0)
				{
					yield return i;
					if (i != number / i)
					{
						yield return number / i;
					}
				}
			}
		}
	}
}