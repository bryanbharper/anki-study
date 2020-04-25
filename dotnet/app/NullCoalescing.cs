using System.Collections.Generic;

namespace anki.nullable
{
		class NullCoalescing
		{
				public void Foobar()
				{
					List<int> numbers = null;
					int? i = null;


					// Fix Here
					numbers = numbers ?? new List<int>();
					numbers.Add(i is null ? 17 : (int)i);
				}
		}
}