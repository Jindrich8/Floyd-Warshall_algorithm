namespace Floyd_Warshall_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] graph =
            { {0,   5,  double.PositiveInfinity, 10},
                               {double.PositiveInfinity,  0,  3,  double.PositiveInfinity},
                               {double.PositiveInfinity, double.PositiveInfinity, 0,   1},
                               {double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, 0} };

            bool[,] graph2 =
           { {true,   true,  false, true},
                               {false,  true,  true,  false},
                               {false, false, true,   true},
                               {false, false, false, true} };

           var floyd = new GraphFloyd(graph);
            floyd.Floyd();
            floyd.Print(Console.Out);
            Console.WriteLine();
            var roy = new GraphRoy(graph2);
            roy.Roy();
            roy.Print(Console.Out);
        }
    }
}

