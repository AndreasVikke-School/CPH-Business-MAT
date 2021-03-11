using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowersofHanoi
{
    class Program
    {
        private static List<int[]> towers;
        private static Game game;
        private static int disks;
        private static int speed;

        static void Main(string[] args)
        {
            #region User Input
            Console.WriteLine("How Many Disks to Solve?");
            disks = Int16.Parse(Console.ReadLine());
            Console.WriteLine("How fast to Solve (Miliseconds)?");
            speed = Int32.Parse(Console.ReadLine());
            #endregion

            #region Game Setup
            game = new Game(disks);
            towers = new List<int[]>() {
                new int[disks],
                new int[disks],
                new int[disks]
            };

            for(int i = 1; i <= disks; i++)
                towers[0][i-1] = disks - (i-1);
            #endregion

            Print(new Tuple<int, int>(0,0));
            Run();
        }

        public static void Run() {
            foreach(Tuple<int, int> move in game.moves) {
                // Delay between each Movement
                var t = Task.Run(async delegate
                        {
                            await Task.Delay(speed);
                        });
                t.Wait();

                // Find indexes of top disk in towers
                int fromIndex = towers[move.Item1].TakeWhile(x => x != 0).Count() - 1;
                int toIndex = towers[move.Item2].TakeWhile(x => x != 0).Count();

                // Move top disk form tower source to tower destination
                towers[move.Item2][toIndex] = towers[move.Item1][fromIndex];
                towers[move.Item1][fromIndex] = 0;

                // Print the current setup
                Print(move);
            }
        }

        public static void Print(Tuple<int, int> currentMove) {
            int seconds = game.moves.Count * speed / 1000;
            Console.Clear();
            Console.WriteLine($"Current Move: {currentMove}");
            Console.WriteLine($"Total Move To make: {game.moves.Count}");
            Console.WriteLine($"Total Time: {(seconds >= 60 ? seconds / 60 : seconds)} {(seconds >= 60 ? "minutes" : "seconds")}");
            
            int spaces = (disks-1)*2+1;

            Console.WriteLine(new String('=', spaces*3+disks));

            for(int i = disks - 1; i >= 0; i--) { // Make A Line in the Console for each disk
                string line = "";
                for(int x = 0; x < 3; x++) { // Make a section for each tower (3)
                    int t = towers[x][i]; // Get Value of each tower
                    if(t == 0) {
                        line += new String(' ', spaces); // Just add spaces if no value
                    } else {
                        int d = t + 1*(t) - 1; // Calculate how many # to show
                        int s = (spaces - d) / 2; // Calculate how many spaces before and after #
                        line += new String(' ', s) + new String('#', d) + new String(' ', s); // Add Spaces and # to line
                    }
                    line += " "; // Add Space between towers
                }
                Console.WriteLine(line);
            }

            Console.WriteLine(new String('=', spaces*3+disks));
        }
    }
}