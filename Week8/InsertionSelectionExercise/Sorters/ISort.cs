using System;
using System.Linq;

namespace InsertionSelectionExercise.Sorters
{
    public interface ISort<T>
    {
        static T[] sort(T[] array) => throw new NotImplementedException();
        static void print(T[] array, int max = -1) {
            Console.WriteLine(String.Join(", ", array.Take(max >= 0 ? max : array.Length)));
        }
    }
}