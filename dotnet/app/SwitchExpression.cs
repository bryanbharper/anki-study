using System;
using System.Collections.Generic;
using System.Linq;

namespace anki.switch_expression
{
	class SwitchExpression
	{

		// Utilize a switch expression
		public int OldSchool(Object oby)
		{
			if ((int?)oby == 12) return 0;
			if (oby is int) return 1;
			if ((oby as string).Contains("Hello")) return 2;
			if((oby as Cat).Age == 3) return 3;

			throw new Exception("Unsuported");
		}
	}

	class Cat
	{
		public int Age { get; set; }
	}
}