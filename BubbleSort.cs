using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHM
{
    internal class BubbleSort
    {
        public static void BubbleSortArr()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array:");
            PrintArray(arr);

            BubbleSort(arr);
            Console.WriteLine("Sorted array:");
            PrintArray(arr);

            static void PrintArray(int[] arr)
            {
                foreach (int element in arr)
                    Console.Write(element + " ");
                Console.WriteLine();
            }

            static void BubbleSort(int[] arr)
            {
                int n = arr.Length;
                bool swapped;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;

                            swapped = true;
                        }
                    }

                    // If no two elements were swapped in the inner loop, the array is already sorted
                    if (!swapped)
                        break;
                }

            }
        }
    }
}
