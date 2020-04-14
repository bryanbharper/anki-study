
using System;

namespace app
{
		class DeconstructTuple
		{
				(string, string) GetName()
				{
					return ("Bryan", "Harper");
				}

				void PrintName()
				{
					var fixMe = GetName();
					Console.WriteLine($"{first} {last}");
				}
		}
}