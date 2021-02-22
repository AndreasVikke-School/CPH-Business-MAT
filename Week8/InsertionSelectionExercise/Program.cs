using System;
using System.Diagnostics;
using System.Threading;
using InsertionSelectionExercise.Sorters;
using InsertionSelectionExercise.Utils;

namespace InsertionSelectionExercise
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
            #endregion

            #region Insertion Sort
            Console.WriteLine("==== Insertion Sort on Array ====");
            string[] insertionOutput = StopWatchUtility.time(() => InsertionSort<string>.sort((string[])data.Clone()));
            ISort<string>.print(insertionOutput, printLines);
            #endregion

            #region Selection Sort
            Console.WriteLine("==== Selection Sort on Array ====");
            string[] selectionOutput = StopWatchUtility.time(() => SelectionSort<string>.sort((string[])data.Clone()));
            ISort<string>.print(selectionOutput, printLines);
            #endregion
        }
    }
}
