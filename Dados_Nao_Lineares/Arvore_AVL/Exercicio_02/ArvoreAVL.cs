using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class ArvoreAVL
    {
        public No Raiz;

        private int Altura(No no)
        {
            return no == null ? 0 : no.Altura;
        }

        private int FatorBalanceamento(No no)
        {
            return no == null ? 0 : Altura(no.Esquerda) - Altura(no.Direita);
        }

        private void AtualizarAltura(No no)
        {
            no.Altura = Math.Max(Altura(no.Esquerda), Altura(no.Direita)) + 1;
        }

        private No RotacaoDireita(No y)
        {
            No x = y.Esquerda;
            No temp = x.Direita;

            x.Direita = y;
            y.Esquerda = temp;

            AtualizarAltura(y);
            AtualizarAltura(x);

            return x;
        }

        private No RotacaoEsquerda(No x)
        {
            No y = x.Direita;
            No temp = y.Esquerda;

            y.Esquerda = x;
            x.Direita = temp;

            AtualizarAltura(x);
            AtualizarAltura(y);

            return y;
        }

        public void Inserir(int valor)
        {
            Raiz = InserirRec(Raiz, valor);
        }

        private No InserirRec(No no, int valor)
        {
            if (no == null)
                return new No(valor);

            if (valor < no.Valor)
                no.Esquerda = InserirRec(no.Esquerda, valor);
            else if (valor > no.Valor)
                no.Direita = InserirRec(no.Direita, valor);
            else
                return no;

            AtualizarAltura(no);

            return Balancear(no);
        }

        private No Balancear(No no)
        {
            int balanceamento = FatorBalanceamento(no);

            if (balanceamento > 1)
            {
                if (FatorBalanceamento(no.Esquerda) < 0)
                    no.Esquerda = RotacaoEsquerda(no.Esquerda);
                return RotacaoDireita(no);
            }

            if (balanceamento < -1)
            {
                if (FatorBalanceamento(no.Direita) > 0)
                    no.Direita = RotacaoDireita(no.Direita);
                return RotacaoEsquerda(no);
            }

            return no;
        }

        public void PercursoInOrder()
        {
            InOrderRec(Raiz);
            Console.WriteLine();
        }

        private void InOrderRec(No no)
        {
            if (no != null)
            {
                InOrderRec(no.Esquerda);
                Console.Write(no.Valor + " ");
                InOrderRec(no.Direita);
            }
        }
    }
}
