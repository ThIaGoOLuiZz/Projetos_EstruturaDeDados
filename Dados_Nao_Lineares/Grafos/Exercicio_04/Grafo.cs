using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
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

        public void DFS(int inicio)
        {
            HashSet<int> visitado = new HashSet<int>();
            DFSUtil(inicio, visitado);
            Console.WriteLine();
        }

        private void DFSUtil(int v, HashSet<int> visitado)
        {
            visitado.Add(v);
            Console.Write(v + " ");

            if (!adj.ContainsKey(v)) return;

            foreach (var vizinho in adj[v])
            {
                if (!visitado.Contains(vizinho.Item1))
                    DFSUtil(vizinho.Item1, visitado);
            }
        }

        public void BFS(int inicio)
        {
            HashSet<int> visitado = new HashSet<int>();
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(inicio);
            visitado.Add(inicio);

            while (fila.Count > 0)
            {
                int atual = fila.Dequeue();
                Console.Write(atual + " ");

                if (!adj.ContainsKey(atual)) continue;

                foreach (var vizinho in adj[atual])
                {
                    if (!visitado.Contains(vizinho.Item1))
                    {
                        fila.Enqueue(vizinho.Item1);
                        visitado.Add(vizinho.Item1);
                    }
                }
            }
            Console.WriteLine();
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
    }
}
