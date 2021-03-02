using System;
using System.Linq;

namespace ShakespeareAssignment.Sorters
{
    public interface ISort<T> where T : IComparable
    {
        static T[] sort(T[] arr) => throw new NotImplementedException();
        static void print(T[] arr, int max = -1) {
            Console.WriteLine($"Word Count: {arr.Length}");
            Console.WriteLine(String.Join(", ", arr.Take(max >= 0 ? max : arr.Length)) + "\n");
        }
    }
}