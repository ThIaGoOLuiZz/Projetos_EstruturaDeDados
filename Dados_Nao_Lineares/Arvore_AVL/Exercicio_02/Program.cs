using System.Drawing;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArvoreAVL arvore = new ArvoreAVL();

            arvore.Inserir(10);
            arvore.Inserir(20);
            arvore.Inserir(30);
            arvore.Inserir(40);
            arvore.Inserir(50);
            arvore.Inserir(25);

            Console.WriteLine("Percurso In-Order:");
            arvore.PercursoInOrder();
        }
    }
}
