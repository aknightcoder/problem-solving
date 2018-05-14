namespace problemsolving.Graphs
{
    public static class Utils
    {
        public static IGraph GetDirectedGraph(){

            IGraph graph = new DirectedGraph(8);

            graph.AddEdge(1, 3);
            graph.AddEdge(3, 7);
            graph.AddEdge(7, 5);
            graph.AddEdge(5, 4);
            graph.AddEdge(2, 4);
            graph.AddEdge(6, 2);

            return graph;
        }
    }
}
