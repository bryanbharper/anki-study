using System.Collections.Generic;

namespace anki.nullable
{
		class NullCoalescing
		{
				public void Foobar()
				{
					List<int> numbers = null;

					// Fix Here
					numbers = numbers ?? new List<int>();
				}
		}
}