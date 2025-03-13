using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class MaxHeap
    {
        private List<int> heap = new List<int>();

        public void Inserir(int valor)
        {
            heap.Add(valor);
            heap.Sort((a, b) => b.CompareTo(a));
        }

        public int RemoverMaior()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap vazio.");
            int maior = heap[0];
            heap.RemoveAt(0);
            return maior;
        }

        public int VerMaior()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap vazio.");
            return heap[0];
        }

        public void Mostrar()
        {
            Console.WriteLine(string.Join(", ", heap));
        }
    }
}
