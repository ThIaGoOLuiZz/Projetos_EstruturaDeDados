using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class No
    {
        public int Valor;
        public No Esquerda, Direita;
        public int Altura;

        public No(int valor)
        {
            Valor = valor;
            Esquerda = null;
            Direita = null;
            Altura = 1;
        }
    }
}
