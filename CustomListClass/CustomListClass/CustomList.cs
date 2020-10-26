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
        public CustomList()
        {
            //initializes list w/ default capacity (4)
            _array = new T[4];
        }
    }
}
