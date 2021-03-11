using System;
using System.Collections.Generic;

namespace TowersofHanoi
{
    public class Game
    {
        private List<List<int>> towers;
        public List<Tuple<int, int>> moves;

        public Game() {
            towers = new List<List<int>>();
            moves = new List<Tuple<int, int>>();
            towers.Add(new List<int> {3,2,1});
            towers.Add(new List<int>());
            towers.Add(new List<int>());

            MoveDisk(3, 0, 1, 2);
        }

        private void MoveDisk(int disk_num, int src, int aux, int dest) {
            if(disk_num == 1) {
                Move(src, dest);
                return;
            }
            
            MoveDisk(disk_num - 1, src, dest, aux);

            Move(src, dest);

            MoveDisk(disk_num - 1, aux, src, dest);
        }

        private void Move(int src, int dest) {
            int last = towers[src][towers[src].Count - 1];
            towers[dest].Add(last);
            towers[src].Remove(last);
            moves.Add(new Tuple<int, int> (src, dest));
        }
    }
}