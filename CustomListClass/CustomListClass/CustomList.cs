﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _array[i];
            }
        }


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
        
        //public CustomList(IEnumerable<T> collection)
        //{
        //    //initializes list w/ default capacity (0)
        //    _count = 0;
        //    _capacity = 0;
        //    foreach (T item in collection)
        //    {
        //        Add(item);
        //    }

        //}

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

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();
            for(int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1[i]);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                list3.Add(list2[i]);
            }
            return list3;
        }

        //private helper method to mirror lists
   

       //removes list2 elements from list1
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> subtractedList = new CustomList<T>();
            subtractedList = list1;

            for(int i = 0; i < list2.Count; i++)
            {
                for(int j = 0; j < list1.Count; j++)
                {
                    if (list1[j].Equals(list2[i]))
                    {
                        subtractedList.Remove(subtractedList[j]);
                        break;
                    }
                }
            }

            return subtractedList;
        }

        private int CompareCounts(CustomList<T> listToCompareCountTo)
        {
            if(_count >= listToCompareCountTo.Count)
            {
                return Count;
            }
            else
            {
                return listToCompareCountTo.Count;
            }
        }
        public CustomList<T> Zip(CustomList<T> listToBeZipped)
        {
            /* 1. take in a list to be zipped (arg)
             * 2. create a new list (the list to be returned) 
             * 2.5 note the following steps will take place for as long as longest count (need to compare counts)
             * 3. take the i element of this list and add it to new list (if i < this list.count)
             * 4. take the i element of the list to be zipped (arg) and add it to the list (if i < this list.count)
             * 5. repeat 3 & 4 for as long as there are elements in one of the lists
             */
            CustomList<T> zippedList = new CustomList<T>();
            int longestCount = CompareCounts(listToBeZipped);

            for (int i = 0; i < longestCount; i++)
            {
                if(i < Count)
                {
                    zippedList.Add(_array[i]);
                }
                if (i < listToBeZipped.Count)
                {
                    zippedList.Add(listToBeZipped[i]);
                }
            }

            return zippedList;
        }

    }
}
