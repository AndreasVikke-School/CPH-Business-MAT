using System;
using System.Diagnostics;
using System.Linq;
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

            // #region Selection Sort
            // Console.WriteLine("==== Selection Sort on Array ====");
            // string[] selectionOutput = StopWatchUtility.time(() => SelectionSort<string>.sort((string[])data.Clone()));
            // ISort<string>.print(selectionOutput, printLines);
            // #endregion

            // #region Insertion Sort
            // Console.WriteLine("==== Insertion Sort on Array ====");
            // string[] insertionOutput = StopWatchUtility.time(() => InsertionSort<string>.sort((string[])data.Clone()));
            // ISort<string>.print(insertionOutput, printLines);
            // #endregion

            // #region Merge Sort
            // Console.WriteLine("==== Merge Sort on Array ====");
            // string[] mergeOutput = StopWatchUtility.time(() => MergeSort<string>.sort((string[])data.Clone()));
            // ISort<string>.print(mergeOutput, printLines);
            // #endregion

            #region Heap Sort
            Console.WriteLine("==== Heap Sort on Array ====");
            string[] heapOutput = StopWatchUtility.time(() => HeapSort<string>.sort((string[])data.Clone()));
            Array.Reverse(heapOutput);
            ISort<string>.print(heapOutput, printLines);
            #endregion

            #region Trie Sort
            Console.WriteLine("==== Trie Sort on Array ====");
            string[] trieOutput = StopWatchUtility.time<string[]>(() => TrieSort.sort((string[])data.Clone()));
            ISort<string>.print(trieOutput, printLines);
            #endregion
        }
    }
}
