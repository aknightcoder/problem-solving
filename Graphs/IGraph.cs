using System.Collections.Generic;

namespace problemsolving.Graphs
{
    public interface IGraph
    {
        int VertexCount { get; }

        void AddEdge(int vertex, int edge);

        LinkedList<int> GetNeighbours(int vertext);
    }
}
