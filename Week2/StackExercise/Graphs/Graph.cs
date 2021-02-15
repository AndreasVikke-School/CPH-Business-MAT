using System.Collections;
using System.Collections.Generic;

namespace StackExercise.Graphs
{
    public class Graph : IGraph {
        public void addEdge(int v, int w) {
            throw new System.NotImplementedException();
        }

        public int getE() {
            throw new System.NotImplementedException();
        }

        public int getV() {
            throw new System.NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator() {
            throw new System.NotImplementedException();
        }
        
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}