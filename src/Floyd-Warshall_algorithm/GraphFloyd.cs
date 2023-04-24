namespace Floyd_Warshall_algorithm
{
    internal class GraphFloyd
    {
        private double[,] _graph;

        public GraphFloyd(double[,] graph)
        {
            _graph = graph ?? throw new ArgumentNullException(nameof(graph));
            if (graph.GetLength(0) != graph.GetLength(1))
                throw new ArgumentException("array must be square", nameof(graph));
        }

        public void Floyd()
        {
            int size = _graph.GetLength(0);
            /*
            * k - intermediary node
            * i - start node
            * j - target node
            */
            for (int k = 0; k < size; k++)
            {
                for(int i = 0; i < size; i++)
                {
                    for(int  j = 0; j < size; j++)
                    {
                        double ikj = _graph[i,k] + _graph[k,j];
                        if (ikj < _graph[i, j])
                        {
                            _graph[i, j] = ikj;
                        }
                    }
                }
            }
        }

        public void Print(TextWriter writer)
        {
            int size = _graph.GetLength(0);
            for (var i = 0; i < size; ++i)
            {
                writer.Write(_graph[i, 0]);
                for (var j = 1; j < size; ++j)
                {
                    writer.Write(", " + _graph[i, j]);
                }
                writer.WriteLine();
            }
        }

        
    }
}
