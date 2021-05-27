using System;
using ImplemetationExercise.Queues;
using ImplemetationExercise.Test.Queues;
using ImplemetationExercise.Test.Stacks;

namespace ImplemetationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueueTest.RunTest();
            LinkedQueueTest.RunTest();
            ArrayQueueTest.RunTest();

            ArrayStackTest.RunTest();
            LinkedStackTest.RunTest();
        }
    }
}
