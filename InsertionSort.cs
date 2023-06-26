using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHM
{
    internal class InsertionSort
    {
        public static void InsertionSortAlgorithm(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1] that are greater than the key
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }

    }

}
