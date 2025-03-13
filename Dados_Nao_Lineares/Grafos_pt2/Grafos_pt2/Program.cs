namespace Grafos_pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo g = new Grafo();
            g.AdicionarAresta(0, 1, 4);
            g.AdicionarAresta(0, 2, 1);
            g.AdicionarAresta(2, 1, 2);
            g.AdicionarAresta(1, 3, 1);
            g.AdicionarAresta(2, 3, 5);

            Console.WriteLine("Dijkstra a partir do nó 0:");
            g.Dijkstra(0);

            Console.WriteLine("\nFloyd-Warshall:");
            g.FloydWarshall();
        }
    }
}
