namespace Floyd_Warshall_algorithm
{
    internal class Program
    {
        static void Main()
        {
            const double inf = double.PositiveInfinity;
            double[,] graph = {
                { 0, inf, inf, inf, inf, inf },
{ 3, 0, 5, inf, inf, inf },
{ inf, inf, 0, inf, inf, 4 },
{  -4, inf, inf, 0, inf, inf },
{ inf, inf, 1,  inf, 0, inf },
{ inf, inf, inf, 6, 3, 0} };

            bool[,] graph2 ={
                { true, false, false, false, false, false },
{ true, true, true, false, false, false },
{ false, false, true, false, false, true },
{  true, false, false, true, false, false },
{ false, false, true,  false, true, false },
{ false, false, false, true, true, true} };

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

