namespace UnionExercise.Unions
{
    public interface IUnionFind
    {
         void union(int p, int q);          // Unite points p and q
         int find(int p);                   // Given point p, return set of p
         bool connected(int p, int q) {     // Is point p and q in the same set
            return find(p) == find(q);
         }
         int count();                       // How many sets are there
         void print();                      // Prints the list
    }
}