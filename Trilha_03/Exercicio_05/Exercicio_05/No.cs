﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class No
    {
        public int Valor;
        public No Esquerda;
        public No Direita;

        public No(int valor)
        {
            Valor = valor;
            Esquerda = null;
            Direita = null;
        }
    }
}
