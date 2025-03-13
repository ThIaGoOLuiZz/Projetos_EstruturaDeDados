namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo g = new Grafo();

            g.AdicionarAresta(0, 1);
            g.AdicionarAresta(0, 2);
            g.AdicionarAresta(1, 3);
            g.AdicionarAresta(1, 4);
            g.AdicionarAresta(2, 5);
            g.AdicionarAresta(3, 6);
            g.AdicionarAresta(4, 6);
            g.AdicionarAresta(5, 6);

            Console.WriteLine("DFS a partir do nó 0:");
            g.DFS(0);

            Console.WriteLine("BFS a partir do nó 0:");
            g.BFS(0);

            Grafo gDir = new Grafo();
            gDir.AdicionarAresta(0, 1, 2, true);
            gDir.AdicionarAresta(0, 2, 4, true);
            gDir.AdicionarAresta(1, 3, 1, true);
            gDir.AdicionarAresta(2, 3, 2, true);
            gDir.AdicionarAresta(3, 4, 3, true);

            Console.WriteLine("Dijkstra a partir do nó 0:");
            gDir.Dijkstra(0);
        }
    }
}
