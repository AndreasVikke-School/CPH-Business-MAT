using System;

namespace ShakespeareAssignment.Sorters
{
    public class SelectionSort<T> : ISort<T> where T : IComparable {
        public static T[] sort(T[] arr) {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j].CompareTo(arr[minIndex]) < 1)
                        minIndex = j;
    
                T temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}