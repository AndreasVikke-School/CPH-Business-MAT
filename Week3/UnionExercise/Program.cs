using System;
using UnionExercise.Unions;

namespace UnionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Quick Union ====");
            IUnionFind qf = new QuickUnion(10);

            qf.union(9,8);
            qf.union(4,3);
            qf.union(3,8);

            qf.union(7,1);
            qf.union(2,1);
            qf.union(6,5);
            qf.union(5,0);
            qf.union(0,1);

            qf.union(5,9);
            qf.print();

            Console.WriteLine("Is 7 and 5 connected: " + qf.connected(7, 5));
            Console.WriteLine("Is 9 and 3 connected: " + qf.connected(7, 5));
            Console.WriteLine("Is 9 and 3 connected: " + qf.connected(1, 1));

            Console.WriteLine("==== Weighted Union ====");
            IUnionFind wf = new WeightedUnion(10);
            wf.union(1,2);
            wf.union(4,3);
            wf.union(2,5);
            wf.union(5,4);

            wf.union(9,7);
            wf.union(6,8);
            wf.union(0,6);
            wf.union(0,7);

            wf.union(5,8);
            wf.print();

            Console.WriteLine("Is 7 and 5 connected: " + wf.connected(7, 5));
            Console.WriteLine("Is 9 and 3 connected: " + wf.connected(7, 5));
            Console.WriteLine("Is 9 and 3 connected: " + wf.connected(1, 1));
        }
    }
}
