using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using ShakespeareAssignment.Sorters;
using ShakespeareAssignment.Utils;

namespace ShakespeareAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Get Data from user
            Console.WriteLine("How many lines should be read? ");
            int numbLines = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many words should be printed? ");
            int printLines = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Array Creation
            Console.WriteLine($"==== Reading {numbLines} from file ====");
            string[] data = StopWatchUtility.time(() => FileUtility.toStringArray("./data/shakespeare-complete-works.txt", numbLines));
            Console.WriteLine("");
            #endregion

            #region Selection Sort
            Console.WriteLine("==== Selection Sort on Array ====");
            string[] selectionOutput = StopWatchUtility.time(() => SelectionSort<string>.sort((string[])data.Clone()));
            ISort<string>.print(selectionOutput, printLines);
            #endregion

            #region Insertion Sort
            Console.WriteLine("==== Insertion Sort on Array ====");
            string[] insertionOutput = StopWatchUtility.time(() => InsertionSort<string>.sort((string[])data.Clone()));
            ISort<string>.print(insertionOutput, printLines);
            #endregion

            #region Merge Sort
            Console.WriteLine("==== Merge Sort on Array ====");
            string[] mergeOutput = StopWatchUtility.time(() => MergeSort<string>.sort((string[])data.Clone()));
            ISort<string>.print(mergeOutput, printLines);
            #endregion

            // #region Heap Sort
            // Console.WriteLine("==== Heap Sort on Array ====");
            // // string[] heapOutput = StopWatchUtility.time(() => HeapSort<string>.sort((string[])data.Clone()));
            // // ISort<string>.print(heapOutput, printLines);
            // int[] arr = { 12, 11, 13, 5, 6, 7 };
            // int[] oo = HeapSort<int>.sort(arr);
            // ISort<int>.print(oo, printLines);

            // #endregion
        }
    }
}
