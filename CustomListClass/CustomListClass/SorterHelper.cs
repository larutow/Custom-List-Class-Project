using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class SorterHelper
    {


        public SorterHelper()
        {

        }

        public CustomList<T> MergeSort<T>(CustomList<T> sortList) where T : IComparable
        {
                // the following code block will run to split into left & right arrays (until empty single instance arrays remain)

                if (sortList.Count <= 1)
                {
                    return sortList;
                }
                CustomList<T> left = new CustomList<T>(); // left side list created
                CustomList<T> right = new CustomList<T>(); // right side list created
                int midpoint = sortList.Count / 2;

                //populate left list
                for (int i = 0; i < midpoint; i++)
                {
                left.Add(sortList[i]);
                }
                //populate right list
                //need to make right start at zero but reference correct elements in array
                for (int i = midpoint; i < sortList.Count; i++)
                {
                    right.Add(sortList[i]);
                    
                }
                //recurse to break down until in single chunks
                left = MergeSort(left);
                right = MergeSort(right);
                //merge chunks up recursion tree
                return Merge(left, right);
        }

        private CustomList<T> Merge<T>(CustomList<T> left, CustomList<T> right) where T : IComparable
        {
            //first build a new empty list (to be composed of combined left & right lists)
            CustomList<T> mergedList = new CustomList<T>();


            //simple merge logic, compare each lists first value, if first value of list 
            int leftindex = 0;
            int rightindex = 0;
            while (leftindex < left.Count && rightindex < right.Count)
            {
                if (left[leftindex].CompareTo(right[rightindex]) <= 0 )
                {
                    mergedList.Add(left[leftindex]);
                    leftindex++;

                }
                else
                {
                    mergedList.Add(right[rightindex]);
                    rightindex++;

                }
            }

            if (leftindex == left.Count)
            {
                do
                {
                    mergedList.Add(right[rightindex]);
                    rightindex++;

                } while (rightindex < right.Count);
                
            }
            else
            {
                do
                {
                    mergedList.Add(left[leftindex]);
                    leftindex++;

                } while (leftindex < left.Count);
                
            }
            return mergedList;
        }

    }
}
