using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_03
{
    internal class ArvoreBinaria
    {
        public No Raiz;

        public ArvoreBinaria()
        {
            Raiz = null;
        }

        public void InOrder(No no)
        {
            if(no != null)
            {
                InOrder(no.Esquerda);
                Console.WriteLine(no.Valor + " ");
                InOrder(no.Direita);
            }
        }

        public void PreOrder(No no)
        {
            if(no != null)
            {
                Console.WriteLine(no.Valor);
                PreOrder(no.Esquerda);
                PreOrder(no.Direita);
            }
        }

        public void PostOrder(No no)
        {
            if(no != null)
            {
                PostOrder(no.Esquerda);
                PostOrder(no.Direita);
                Console.WriteLine(no.Valor + " ");
            }
        }
    }
}
