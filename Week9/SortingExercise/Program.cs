using System;

namespace SortingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {10, 23, 8, 9, 1, 35, 5};
            int[] sorted = QuickSort.sort(arr);
            Console.WriteLine(String.Join(", ", sorted));
        }
    }
}
