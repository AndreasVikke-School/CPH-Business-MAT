using System;

namespace UnionExercise.Unions
{
    public class QuickUnion : IUnionFind
    {
        private int[] id;
        private int idCount;

        public QuickUnion(int size) {
            id = new int[size];
            idCount = size;
            for (int i = 0; i < size; i++) {
                id[i] = i;
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
            if (rootP == rootQ) 
                return;
            id[rootP] = rootQ; 
            idCount--;
        }

        public void print() {
            Console.WriteLine("Id: " + string.Join(", ", id));
        }
    }
}