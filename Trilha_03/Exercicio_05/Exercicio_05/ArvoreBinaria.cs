using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class ArvoreBinaria
    {
        public No Raiz;

        public ArvoreBinaria()
        {
            Raiz = null;
        }

        public No Buscar(No no, int valor)
        {
            if (no == null || no.Valor == valor)
                return no;

            if (valor < no.Valor)
                return Buscar(no.Esquerda, valor);

            return Buscar(no.Direita, valor);
        }
    }
}
