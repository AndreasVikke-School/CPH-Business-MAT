using System;

namespace InsertionSelectionExercise.Sorters
{
    public class InsertionSort<T> : ISort<T> where T : IComparable {
        public static T[] sort(T[] array) {
            for (int i = 1; i < array.Length; ++i) {
                T tempVal = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(tempVal) >= 1) {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = tempVal;
            }
            return array;
        }
    }
}