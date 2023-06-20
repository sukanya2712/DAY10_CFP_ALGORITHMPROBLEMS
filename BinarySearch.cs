using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ALGORITHM
{
     class BinarySearch
    {
        public static void BinaryArr()
        {
            int[] arr = { 2, 5, 7, 10, 15, 20, 25, 30 };
            int target = 15;

            int result = BinarySearchArr(arr, target);

            if (result == -1)
                Console.WriteLine("Element not present in the array");
            else
                Console.WriteLine("Element found at index " + result);

            static int BinarySearchArr(int[] arr, int target)
            {
                int left = 0;
                int right = arr.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    
                    if (arr[mid] == target)
                        return mid;

                   
                    if (arr[mid] < target)
                        left = mid + 1;

                    
                    else
                        right = mid - 1;
                }

                
                return -1;
            }
        }
     }
}
