using System;

namespace InsertionSelectionExercise.Sorters
{
    public class SelectionSort<T> : ISort<T> where T : IComparable {
        public static T[] sort(T[] array) {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j].CompareTo(array[minIndex]) < 1)
                        minIndex = j;
    
                T temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}