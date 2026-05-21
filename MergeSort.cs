using System;
using System.Collections.Generic;
using System.Text;


namespace Rovy_Assignement_7._2
{
    internal class MergeSort
    {
        // Public method called from Program.cs
        public static void Sort(int[] arr)
        {
            // Call the recursive MergeSort method
            MergeSortRecursive(arr, 0, arr.Length - 1);
        }

        //MergeSort is Divide and Conquer Algo. 
        //1. Sort the left half
        //2. Sort the right half
        //3. Then merge them
        static void MergeSortRecursive(int[] arr, int left, int right)
        {
            if (left >= right)
                return; // Base case: one element → already sorted

            var mid = (left + right) / 2; //finds the middle index 

            MergeSortRecursive(arr, left, mid);     //Sort the left half of the array
            MergeSortRecursive(arr, mid + 1, right); //sort the right half of the array

            // Recursion results:
            // Left half sorted: [3, 8]
            // Right half sorted: [2, 5]

            Merge(arr, left, mid, right);

            //Merge Call Combines then [3,8] [2,5] to [2,3,5,8]
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            var i = left;      // Pointer for left half
            var j = mid + 1;   // Pointer for right half; starts at mid + 1
            var k = 0;         // Pointer for temp array

            var temp = new int[right - left + 1]; // Temp array to store merged values

            // Compare while both halves have elements left 
            while (i <= mid && j <= right)
            {
                // Compare current element in left 1/2 w current element in right 1/2
                if (arr[i] <= arr[j])
                {
                    // Take the smaller one
                    temp[k] = arr[i]; // If left is smaller copy into the temp array
                    i++;              // move left pointer forward 
                }
                else
                {
                    temp[k] = arr[j]; // if the right element is smaller copy into temp
                    j++;              // move the right pointer forward
                }
                k++; // move the temp pointer forward 
            }

            // Loop runs as long as there are elements left in left side
            while (i <= mid)
            {
                temp[k] = arr[i]; //Copy current element from left half into the temp array
                i++;              // move left pointer 
                k++;              // move temp pointer
            }

            // Loop runs as long as there are elements left in right side
            while (j <= right)
            {
                temp[k] = arr[j]; //Copy current element from right half into the temp array
                j++;              // move right pointer 
                k++;              // move temp pointer
            }

            // Copy merged temp array back into original array
            for (int x = 0; x < temp.Length; x++)
            {
                arr[left + x] = temp[x];
            }
        }
    }
}

