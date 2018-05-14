using System.Collections.Generic;

namespace problemsolving.Graphs
{
    public class BreadthFirstSearch
    {
        private readonly IGraph _graph;

        private readonly bool[] _isVisited;

        public BreadthFirstSearch(IGraph graph)
        {
            _graph = graph;

            _isVisited = new bool[graph.VertexCount];
        }

        public List<int> Search()
        {
            var queue = new Queue<int>();

            var resultList = new List<int>();

            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                _isVisited[current] = true;

                resultList.Add(current);

                foreach (var neighbour in _graph.GetNeighbours(current))
                    queue.Enqueue(neighbour);
            }

            return resultList;
        }
    }
}
