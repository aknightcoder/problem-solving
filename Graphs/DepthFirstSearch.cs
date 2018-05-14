using System.Collections.Generic;

namespace problemsolving.Graphs
{
    public class DepthFirstSearch
    {
        private IGraph _graph;

        private bool[] _isVisited;

        public DepthFirstSearch(IGraph graph)
        {
            _graph = graph;

            _isVisited = new bool[graph.VertexCount];
        }

        public List<int> Search(){

            var stack = new Stack<int>();

            var resultList = new List<int>();

            stack.Push(0);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                _isVisited[current] = true;

                resultList.Add(current);

                foreach (var neighbour in _graph.GetNeighbours(current))
                    stack.Push(neighbour);
            }

            return resultList;
        }
    }
}
