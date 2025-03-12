using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class ArvoreBinaria
    {
        public No Raiz;
        public void Inserir(int valor)
        {
            if (Raiz == null)
                Raiz = new No(valor);
            else
                InserirRec(Raiz, valor);
        }

        private void InserirRec(No atual, int valor)
        {
            if (valor < atual.Valor)
            {
                if (atual.Esquerda == null)
                    atual.Esquerda = new No(valor);
                else
                    InserirRec(atual.Esquerda, valor);
            }
            else if (valor > atual.Valor)
            {
                if (atual.Direita == null)
                    atual.Direita = new No(valor);
                else
                    InserirRec(atual.Direita, valor);
            }
        }
        public bool Buscar(int valor)
        {
            return BuscarRec(Raiz, valor);
        }

        private bool BuscarRec(No atual, int valor)
        {
            if (atual == null)
                return false;
            if (atual.Valor == valor)
                return true;
            return valor < atual.Valor ? BuscarRec(atual.Esquerda, valor) : BuscarRec(atual.Direita, valor);
        }

        public void PercursoInOrder()
        {
            InOrderRec(Raiz);
            Console.WriteLine();
        }

        private void InOrderRec(No atual)
        {
            if (atual != null)
            {
                InOrderRec(atual.Esquerda);
                Console.Write(atual.Valor + " ");
                InOrderRec(atual.Direita);
            }
        }
    }
}
