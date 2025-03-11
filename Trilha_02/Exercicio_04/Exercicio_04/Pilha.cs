using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    internal class Pilha
    {
        private int[] elementos;
        private int topo;
        private int tamanhoMaximo;

        public Pilha(int tamanho)
        {
            tamanhoMaximo = tamanho;
            elementos = new int[tamanhoMaximo];
            topo = -1;
        }

        public void Empilhar(int elemento)
        {
            if(topo == tamanhoMaximo - 1)
            {
                Console.WriteLine("Pilha cheia!");
                return;
            }
            topo++;
            elementos[topo] = elemento;
            Console.WriteLine("Empilhado: " + elemento);
        }

        public int Desempilhar()
        {
            if (topo == -1)
            {
                Console.WriteLine("Pilha vazia!");
                return -1;
            }

            int elementoRemovido = elementos[topo];
            elementos[topo] = 0;
            topo--;
            return elementoRemovido;
        }


    }
}
