using System;
using System.Collections.Generic;

namespace TowersofHanoi
{
    public class Game
    {
        public List<Tuple<int, int>> moves;

        public Game() {
            moves = new List<Tuple<int, int>>();
            MoveDisk(3, 0, 1, 2);
        }

        private void MoveDisk(int disk_num, int src, int aux, int dest) {
            if(disk_num == 1) {
                moves.Add(new Tuple<int, int>(src,dest));
                return;
            }
            MoveDisk(disk_num - 1, src, dest, aux);
            moves.Add(new Tuple<int, int>(src,dest));
            MoveDisk(disk_num - 1, aux, src, dest);
        }
    }
}