namespace Exercicios_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            arvore.Raiz = new No(1);
            arvore.Raiz.Esquerda = new No(2);
            arvore.Raiz.Direita = new No(3);
            arvore.Raiz.Esquerda.Esquerda = new No(4);
            arvore.Raiz.Esquerda.Direita = new No(5);
            arvore.Raiz.Direita.Esquerda = new No(6);
            arvore.Raiz.Direita.Direita = new No(7);

            Console.WriteLine("Percurso In-Order:");
            arvore.InOrder(arvore.Raiz);
            Console.WriteLine();

            Console.WriteLine("Percurso Pre-Order:");
            arvore.PreOrder(arvore.Raiz);
            Console.WriteLine();

            Console.WriteLine("Percurso Post-Order:");
            arvore.PostOrder(arvore.Raiz);
            Console.WriteLine();

            /*
             Exemplo da arvore criada:

                    1
                   / \
                  2   3
                 / \ / \
                4  5 6  7

            */
        }
    }
}
