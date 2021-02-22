using System;

namespace UnionExercise.Unions
{
    public class WeightedUnion : IUnionFind {
        private int[] id;
        private int[] size;
        private int idCount;

        public WeightedUnion(int size) {
            id = new int[size];
            this.size = new int[size];
            idCount = size;
            for (int i = 0; i < size; i++) {
                id[i] = i;
                this.size[i] = 1;
            }
        }
        public int count() {
            return idCount;
        }

        public int find(int p) {
            while(p != id[p])
                p = id[p];
            return p;
        }

        public void union(int p, int q) {
            int rootP = find(p);
            int rootQ = find(q);
            if (rootP == rootQ) return;

            // make smaller root point to larger one
            if (size[rootP] < size[rootQ]) {
                id[rootP] = rootQ;
                size[rootQ] += size[rootP];
            }
            else {
                id[rootQ] = rootP;
                size[rootP] += size[rootQ];
            }
            idCount--;
        }

        public void print() {
            Console.WriteLine("Id: " + string.Join(", ", id));
            Console.WriteLine("Size: " + string.Join(", ", size));
        }
    }
}