using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05_pt02
{
    internal class FilaCircular
    {
        int[] Fila;
        int Frente, Tras, Tamanho, Capacidade;

        public FilaCircular(int capacidade)
        {
            Capacidade = capacidade;
            Fila = new int[Capacidade];
            Frente = 0;
            Tras = -1;
            Tamanho = 0;
        }

        public void Enqueue(int value)
        {
            if(Tamanho == Capacidade)
            {
                Console.WriteLine("Fila cheia!");
                return;
            }

            Tras = (Tras + 1) % Capacidade;
            Fila[Tras] = value;
            Tamanho++;
        }

        public int? Dequeue()
        {
            if(Tamanho == 0)
            {
                Console.WriteLine("Fila vazia!");
                return null;
            }

            int value = Fila[Frente];
            Frente = (Frente + 1) % Capacidade;
            Tamanho--;
            return value;
        }

        public void Mostrar()
        {
            int count = Tamanho;
            int i = Frente;

            Console.Write("Fila Circular: ");
            while (count > 0)
            {
                Console.Write(Fila[i] + " ");
                i = (i + 1) % Capacidade; // Move circularmente
                count--;
            }
            Console.WriteLine();
        }
    }
}
