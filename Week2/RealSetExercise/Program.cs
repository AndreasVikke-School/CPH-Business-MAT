using System;
using RealSetExercise.RealSets;

namespace RealSetExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // min, max, mininclude, maxinclude
            IRealSet rs1 = new RangedRealSet(1, 4, true, false);
            IRealSet rs2 = new RangedRealSet(1, 8, true, false);
            IRealSet rs3 = new RangedRealSet(8, 12, true, false);
            
            
            Console.WriteLine("===== Ranged Test =====");
            Console.WriteLine("Ranged (1-4) contains 2: " + rs1.contains(2)); // True
            Console.WriteLine("Ranged (1-4) contains 5: " + rs1.contains(5)); // False
            Console.WriteLine("Ranged (1-4) contains 9: " + rs1.contains(9)); // False
            Console.WriteLine("Ranged (1-8) contains 2: " + rs2.contains(2)); // True
            Console.WriteLine("Ranged (1-8) contains 5: " + rs2.contains(5)); // True
            Console.WriteLine("Ranged (1-8) contains 9: " + rs2.contains(9)); // False

            Console.WriteLine("===== Union Test =====");
            Console.WriteLine("Union (1-4 + 1-8) contains 2: " + rs1.union(rs2).contains(2)); // True
            Console.WriteLine("Union (1-4 + 1-8) contains 5: " + rs1.union(rs2).contains(5)); // True
            Console.WriteLine("Union (1-4 + 1-8) contains 9: " + rs1.union(rs2).contains(9)); // False
            Console.WriteLine("Union (1-4 + 8-12) contains 2: " + rs1.union(rs3).contains(2)); // True
            Console.WriteLine("Union (1-4 + 8-12) contains 5: " + rs1.union(rs3).contains(5)); // False
            Console.WriteLine("Union (1-4 + 8-12) contains 9: " + rs1.union(rs3).contains(9)); // True

            Console.WriteLine("===== Intersection Test =====");
            Console.WriteLine("Intersection (1-4 + 1-8) contains 2: " + rs1.intersection(rs2).contains(2));// True
            Console.WriteLine("Intersection (1-4 + 1-8) contains 5: " + rs1.intersection(rs2).contains(5));// False
            Console.WriteLine("Intersection (1-4 + 1-8) contains 9: " + rs1.intersection(rs2).contains(9));// False
            Console.WriteLine("Intersection (1-4 + 8-12) contains 2: " + rs1.intersection(rs3).contains(2)); // False
            Console.WriteLine("Intersection (1-4 + 8-12) contains 5: " + rs1.intersection(rs3).contains(5)); // False
            Console.WriteLine("Intersection (1-4 + 8-12) contains 9: " + rs1.intersection(rs3).contains(9)); // False

            Console.WriteLine("===== Complement Test =====");
            Console.WriteLine("Complement (1-4) contains 2: " + rs1.complement().contains(2)); // False
            Console.WriteLine("Complement (1-4) contains 5: " + rs1.complement().contains(5)); // True
            Console.WriteLine("Complement (1-4) contains 9: " + rs1.complement().contains(9)); // True
            Console.WriteLine("Complement (1-8) contains 2: " + rs2.complement().contains(2)); // False
            Console.WriteLine("Complement (1-8) contains 5: " + rs2.complement().contains(5)); // False
            Console.WriteLine("Complement (1-8) contains 9: " + rs2.complement().contains(9)); // True

            Console.WriteLine("===== Anders Test =====");
            IRealSet rsa = new RangedRealSet(1, 10, true, true);
            IRealSet rsb = new RangedRealSet(20, 30, true, true);
            IRealSet rsc = new RangedRealSet(15, 25, true, true);
            IRealSet rsu = new UnionRealSet(rsa, rsb);
            IRealSet rsi = new IntersectionRealSet(rsu, rsb);

            Console.WriteLine("Intersection (Union(1-10 + 20-30) + 15-25) contains 0: " + rsi.contains(0));
            Console.WriteLine("Intersection (Union(1-10 + 20-30) + 15-25) contains 3: " + rsi.contains(3));
            Console.WriteLine("Intersection (Union(1-10 + 20-30) + 15-25) contains 7: " + rsi.contains(7));
            Console.WriteLine("Intersection (Union(1-10 + 20-30) + 15-25) contains 13: " + rsi.contains(13));
            Console.WriteLine("Intersection (Union(1-10 + 20-30) + 15-25) contains 24: " + rsi.contains(24));
            Console.WriteLine("Intersection (Union(1-10 + 20-30) + 15-25) contains 100: " + rsi.contains(100));
        }
    }
}
