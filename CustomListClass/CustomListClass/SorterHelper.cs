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
                CustomList<T> left = new CustomList<T>(); // left side array created
                CustomList<T> right = new CustomList<T>(); // right side array created
                int midpoint = sortList.Count / 2;

                //populate left array
                for (int i = 0; i < midpoint; i++)
                {
                left.Add(sortList[i]);
                }
                //populate right array
                //need to make right start at zero but reference correct elements in array
                for (int i = midpoint; i < sortList.Count; i++)
                {
                    right.Add(sortList[i]);
                    
                }

                left = MergeSort(left);
                right = MergeSort(right);
                return Merge(left, right);
        }

        private CustomList<T> Merge<T>(CustomList<T> left, CustomList<T> right) where T : IComparable
        {
            //first build a new empty array based upon length of two arrays
            CustomList<T> mergedList = new CustomList<T>();

            int leftindex = 0;
            int rightindex = 0;
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[leftindex].CompareTo(right[rightindex]) <= 0 )
                {
                    mergedList.Add(left[0]);
                    left.Remove(left[0]);
                }
                else
                {
                    mergedList.Add(right[rightindex]);
                    right.Remove(right[rightindex]);
                }
            }

            if (leftindex == left.Count)
            {
                do
                {
                    mergedList.Add(right[rightindex]);
                    right.Remove(right[rightindex]);
                } while (rightindex < right.Count);
                
            }
            else
            {
                do
                {
                    mergedList.Add(left[leftindex]);
                    left.Remove(left[leftindex]);
                } while (leftindex < left.Count);
                
            }
            return mergedList;
        }

    }
}
