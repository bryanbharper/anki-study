using System;

namespace app
{
	public class InlineTuple
	{
		public void Foobar()
		{
			var namedLetters = ("a", "b");
			Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");
		}
	}
}