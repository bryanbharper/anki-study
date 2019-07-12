using System;
using app.contracts;

namespace app.models
{
    public class Itty<T> : IIterator<T>
    {
        private int _index;
        private T[] _aggregate;
        public Itty(T[] aggregate)
        {
            _index = 0;
            _aggregate = aggregate;
        }
        public bool HasNext()
        {
            try
            {
                var x = _aggregate[_index];
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public T Next()
        {
            return _aggregate[_index++];
        }
    }
}