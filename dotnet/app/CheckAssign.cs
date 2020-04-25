using System;

namespace anki.check.assign
{
	class CheckAssign
	{
		public void FooBar()
		{
			int? sum = GetOne() + GetTwo();
			if (sum is int) Console.WriteLine(sum);
		}

		int? GetOne()
		{
			return 1;
		}

		int? GetTwo()
		{
			return 2;
		}
	}
}