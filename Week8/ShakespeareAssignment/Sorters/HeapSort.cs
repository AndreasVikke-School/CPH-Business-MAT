using System;
using ShakespeareAssignment.Utils;

namespace ShakespeareAssignment.Sorters
{
    public class HeapSort<T> : ISort<T> where T : IComparable
    {
        public static T[] sort(T[] arr) {
            int size = arr.Length;

            // Build Min Heap
            for(int i = size / 2 - 1; i >= 0; i--)
                heapify(arr, size, i);

            for (int i = size - 1; i >= 1; i--) {
                SwapUtility.Swap<T>(arr, 0, i);

                heapify(arr, i, 0);
            }

            return arr;
        }

        private static void heapify(T[] arr, int n, int i) {
            int lowest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if(left < n && arr[left].CompareTo(arr[lowest]) < 1)
                lowest = left;

            if(right < n && arr[right].CompareTo(arr[lowest]) < 1)
                lowest = right;

            if(lowest != i) {
                SwapUtility.Swap<T>(arr, i, lowest);
                heapify(arr, n, lowest);
            }
        }
    }
}