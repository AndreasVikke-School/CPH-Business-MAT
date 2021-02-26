using System;

namespace ShakespeareAssignment.Sorters
{
    public class InsertionSort<T> : ISort<T> where T : IComparable {
        public static T[] sort(T[] arr) {
            for (int i = 1; i < arr.Length; ++i) {
                T tempVal = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(tempVal) >= 1) {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = tempVal;
            }
            return arr;
        }
    }
}