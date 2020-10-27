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

        private void ExpandArray()
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
                ExpandArray();
            }
        }

        private void ArrayItemRemoveOp(int indexItemToRemove)
        {
            for (int i = indexItemToRemove; i < (_count - 1); i++)
            { 
                _array[i] = _array[i + 1];
            }
        }

        public bool Remove(T item)
        {
            bool removeSuccess = false;
            for (int i = 0; i < _count; i++)
            {
                if(item.Equals(_array[i]))
                {
                    ArrayItemRemoveOp(i);
                    _count--;
                    removeSuccess = true;
                    break;
                }
            }

            return removeSuccess;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < _count; i++)
            {
                sb.Append(_array[i]);
                if(i < _count - 1)
                {
                    sb.Append(", ");
                }
                
            }
            return sb.ToString();
        }

    }
}
