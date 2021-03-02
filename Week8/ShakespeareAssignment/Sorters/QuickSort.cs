using System;
using ShakespeareAssignment.Utils;

namespace ShakespeareAssignment.Sorters
{
    public class QuickSort<T> : ISort<T> where T : IComparable
    {
        public static T[] sort(T[] arr) {
            sort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void sort(T[] arr, int low, int high) {
            if(low < high) {
                int part = partition(arr, low, high);

                sort(arr, low, part -1);
                sort(arr, part + 1, high);
            }
        }

        private static int partition(T[] arr, int low, int high) {
            T pivot = arr[high];
            int i = (low - 1);

            for(int j = low; j <= high - 1; j++)
                if(arr[j].CompareTo(pivot) < 1) {
                    i++;
                    SwapUtility.Swap<T>(arr, i, j);
                }

            SwapUtility.Swap<T>(arr, (i + 1), high);
            return (i + 1);
        }
    }
}