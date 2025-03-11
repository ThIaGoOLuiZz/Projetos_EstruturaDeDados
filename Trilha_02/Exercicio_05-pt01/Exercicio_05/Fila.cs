using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Fila<T>
    {
        List<T> fila = new List<T>();
        public int Count => fila.Count;

        public void Enqueue(T value)
        {
            fila.Add(value);
        }

        public T Dequeue()
        {
            if(fila.Count > 0)
            {
                T value = fila[0];
                fila.RemoveAt(0);
                return value;
            }
            throw new InvalidOperationException("Fila vazia!");
        }

        public void Mostrar()
        {
            Console.WriteLine("Fila: " + this);
        }

        public override string ToString()
        {
            return fila.Count > 0 ? string.Join(", ", fila) : "Fila vazia!";
        }
    }
}
