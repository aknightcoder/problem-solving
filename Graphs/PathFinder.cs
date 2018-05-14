using System.Collections.Generic;

namespace problemsolving.Graphs
{
    public class PathFinder
    {
        private IGraph _graph;

        private bool[] _isVisited;

        public PathFinder(IGraph graph)
        {
            _graph = graph;

            _isVisited = new bool[graph.VertexCount];
        }

        public bool FindPath(int startVertex, int endVertex){

            if (startVertex == endVertex)
                throw new System.ArgumentException("Start and End vertex can not be the same.");
            
            bool foundPath = false;

            var stack = new Stack<int>();

            stack.Push(startVertex);

            _isVisited[startVertex] = true;

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                _isVisited[current] = true;

                if (current == endVertex)
                {
                    foundPath = true;
                    break;
                }

                foreach(var neighbour in _graph.GetNeighbours(current))
                {
                    stack.Push(neighbour);
                }
            }

            return foundPath;
        }
    }
}
