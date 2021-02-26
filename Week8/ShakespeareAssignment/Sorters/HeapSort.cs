using System;

namespace ShakespeareAssignment.Sorters
{
    public class HeapSort<T> : ISort<T> where T : IComparable
    {
        public static T[] sort(T[] arr) {
            return arr;
        }

        private static void heapify(T[] arr, int n, int i) {
        }
    }
}