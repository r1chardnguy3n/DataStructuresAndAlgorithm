using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithm
{
    public class BubbleSort
    {
          /*
         * Bubble Sort
         * In-place algorithm - uses a small amount of extra memory
         * Time Complexity - O(n^2)
         * Degrades quickly
         */

        public static void Main(string[] args)
        {

        }

        //Implementation
        public static void BubbleSortImplementation(int[] array)
        {
            for(int partIndex = array.Length-1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if(i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
