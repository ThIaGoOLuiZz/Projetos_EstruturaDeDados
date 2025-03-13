using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_pt2
{
    internal class Grafo
    {
        private Dictionary<int, List<Tuple<int, int>>> adj;

        public Grafo()
        {
            adj = new Dictionary<int, List<Tuple<int, int>>>();
        }

        public void AdicionarAresta(int u, int v, int peso = 1, bool direcionado = false)
        {
            if (!adj.ContainsKey(u)) adj[u] = new List<Tuple<int, int>>();
            if (!adj.ContainsKey(v)) adj[v] = new List<Tuple<int, int>>();

            adj[u].Add(new Tuple<int, int>(v, peso));
            if (!direcionado)
                adj[v].Add(new Tuple<int, int>(u, peso));
        }

        public void Dijkstra(int inicio)
        {
            Dictionary<int, int> dist = new Dictionary<int, int>();
            foreach (var no in adj.Keys) dist[no] = int.MaxValue;
            dist[inicio] = 0;

            PriorityQueue<int, int> fila = new PriorityQueue<int, int>();
            fila.Enqueue(inicio, 0);

            while (fila.Count > 0)
            {
                int atual = fila.Dequeue();

                if (!adj.ContainsKey(atual)) continue;

                foreach (var vizinho in adj[atual])
                {
                    int v = vizinho.Item1, peso = vizinho.Item2;
                    int novaDist = dist[atual] + peso;

                    if (novaDist < dist[v])
                    {
                        dist[v] = novaDist;
                        fila.Enqueue(v, novaDist);
                    }
                }
            }

            Console.WriteLine("Distâncias a partir do nó " + inicio + ":");
            foreach (var kvp in dist)
                Console.WriteLine($"Nó {kvp.Key}: {kvp.Value}");
        }

        public void FloydWarshall()
        {
            int INF = int.MaxValue;
            List<int> vertices = new List<int>(adj.Keys);
            int n = vertices.Count;
            Dictionary<int, Dictionary<int, int>> dist = new Dictionary<int, Dictionary<int, int>>();

            foreach (int u in vertices)
            {
                dist[u] = new Dictionary<int, int>();
                foreach (int v in vertices)
                    dist[u][v] = (u == v) ? 0 : INF;
            }

            foreach (int u in adj.Keys)
                foreach (var vizinho in adj[u])
                    dist[u][vizinho.Item1] = vizinho.Item2;

            foreach (int k in vertices)
                foreach (int i in vertices)
                    foreach (int j in vertices)
                        if (dist[i][k] != INF && dist[k][j] != INF)
                            dist[i][j] = Math.Min(dist[i][j], dist[i][k] + dist[k][j]);

            Console.WriteLine("Matriz de distâncias mínimas:");
            foreach (int i in vertices)
            {
                foreach (int j in vertices)
                {
                    if (dist[i][j] == INF)
                        Console.Write("INF".PadLeft(5));
                    else
                        Console.Write(dist[i][j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }
    }
}
