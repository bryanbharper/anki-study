using System;

namespace app.isop
{
		public class ConstantPattern
		{
				public void Foobar()
				{
					var blah = 2;

					if(blah == 2) Console.WriteLine("It's two.");
					if(blah == null) Console.WriteLine("It's null.");
				}
		}
}