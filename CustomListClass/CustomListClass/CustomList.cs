using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] _array;
        private int _count;
        private int _capacity;
        public int Count{
            get
            {
                return _count;
            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public T this[int index]
        {
            get
            {
                if(index >= Count || index < 0)
                {
                    throw new System.ArgumentOutOfRangeException("index", "index is out of the range (valid range: between 0 & Count)");
                }
                return _array[index];    
                //TODO: Add exception if index >= count
            }
        }
        public CustomList()
        {
            //initializes list w/ default capacity (0)
            _count = 0;
            _capacity = 0;
        }

        private void TransferArrayLarger()
        {
            T[] largerArray = new T[_capacity];
            for(int i = 0; i < _count; i++)
            {
                largerArray[i] = _array[i];
            }
            _array = largerArray;
        }

        //create initial array
        private void ListInitialize()
        {
            _array = new T[4];
            _capacity = 4;
        }

        public void Add(T item)
        {
            //If array is currently empty
            if(_count == 0)
            {
                ListInitialize();
            }
            _array[_count] = item;
            _count++;
            if(_count == _capacity)
            {
                _capacity *= 2;
                TransferArrayLarger();
            }
        }

    }
}
