using System;

namespace ShakespeareAssignment.Sorters
{
    public class MergeSort<T> : ISort<T> where T : IComparable
    {
        public static T[] sort(T[] arr) {
            sort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void sort(T[] arr, int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                sort(arr, left, middle);
                sort(arr, middle + 1, right);

                merge(arr, left, middle, right);
            }
        }

        private static void merge(T[] arr, int left, int middle, int right) {
            int n1 = middle - left + 1, 
                n2 = right - middle;

            T[] temp = (T[])arr.Clone();
            int i = 0, 
                j = 0, 
                k = left;

            while(i < n1 && j < n2)
                if(temp[left + i].CompareTo(temp[middle + 1 + j]) < 1)
                    arr[k++] = temp[left + i++];
                else 
                    arr[k++] = temp[middle + 1 + j++];

            while(i < n1)
                arr[k++] = temp[left + i++];

            while(j < n2)
                arr[k++] = temp[middle + 1 + j++];
        }
    }
}