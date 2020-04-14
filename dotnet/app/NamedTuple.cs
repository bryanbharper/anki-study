
using System;

namespace app
{
		class NamedTuple
		{
				(string, string) GetName()
				{
					return ("Bryan", "Harper");
				}

				void PrintName()
				{
					var fullName = GetName();
					Console.WriteLine($"{fullName.First} {fullName.Last}");
				}
		}
}