using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        // first create an array of Icomparable
        private static IComparable[] temp;

        // now we create 2 methods
        // this one accepts an array
        public MergeSort(IComparable[] sendIn)
        {
            temp = new IComparable[sendIn.Length];

            // and send in to the method that will handle the full array
            Sort(sendIn, 0, sendIn.Length - 1);
        }

        
        // and this one has the MEAT!
        public static void Sort(IComparable[] array, int low, int high)
        {
            if (high <= low)
            {
                return;
            }

            int mid = low + (high - low) / 2;

            Sort(array, low, mid);

            Sort(array, mid + 1, high);

            Merge(array, low, mid, high);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(((IDroid)array[i]).TotalCost);
            }
            
        }

        private static void Merge(IComparable[] array, int low, int mid, int high)
        {
            int leftPointer = low;
            int rightPointer = mid + 1;

            for (int k = low; k <= high; k++)
            {
                temp[k] = array[k];
            }

            for (int k = low; k <= high; k++)
            {
                if ( leftPointer > mid)
                {
                    array[k] = temp[rightPointer++];
                }

                else if ( rightPointer > high)
                {
                    array[k] = temp[leftPointer++];
                }

                else if (temp[rightPointer].CompareTo(temp[leftPointer]) < 0)
                {
                    array[k] = temp[rightPointer++];
                }

                else
                {
                    array[k] = temp[leftPointer++];
                }
            }
        }


    }
}
