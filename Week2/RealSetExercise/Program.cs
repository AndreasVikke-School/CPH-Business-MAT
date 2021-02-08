using System;

namespace RealSetExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            RangedRealSet rs = new RangedRealSet(4, 1, true, false);
            
            Console.WriteLine("2: " + rs.contains(2));
            Console.WriteLine("0: " + rs.contains(0));
            Console.WriteLine("1: " + rs.contains(1));
            Console.WriteLine("4: " + rs.contains(4));
            Console.WriteLine("2.5: " + rs.contains(2.5));
            Console.WriteLine("1.5: " + rs.contains(1.5));
            Console.WriteLine("0.5: " + rs.contains(0.5));
        }
    }
}
