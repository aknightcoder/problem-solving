using System.Collections.Generic;

namespace problemsolving.Graphs
{
    public class DirectedGraph : IGraph
    {
        private LinkedList<int>[] _adjacenyList;

        public int VertexCount { get; }

        public DirectedGraph(int vertexCount)
        {
            _adjacenyList = new LinkedList<int>[vertexCount];

            VertexCount = vertexCount;

            Initialize();
        }

        public void AddEdge(int vertex, int edge)
        {
            if (!IsValidVertex(vertex) || !IsValidVertex(edge))
                return;

            _adjacenyList[vertex].AddLast(edge);
        }

        public LinkedList<int> GetNeighbours(int vertex){
            if (!IsValidVertex(vertex))
                return new LinkedList<int>();

            return _adjacenyList[vertex];
        }

        private void Initialize()
        {
            for (var i = 0; i < VertexCount; i++){
                
                _adjacenyList[i] = new LinkedList<int>();
            }
        }

        private bool IsValidVertex(int vertex){
            
            return vertex >= 0 && vertex < VertexCount;
        }
    }
}
