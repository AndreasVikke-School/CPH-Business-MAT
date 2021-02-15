using System.Collections.Generic;

namespace StackExercise.Graphs
{
    public interface IGraph : IEnumerable<int>
    {
        int getV(); // number of vertices
        int getE(); // number of edges
        void addEdge(int v, int w);
    }
}