namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            arvore.Raiz = new No(50);
            arvore.Raiz.Esquerda = new No(30);
            arvore.Raiz.Direita = new No(70);
            arvore.Raiz.Esquerda.Esquerda = new No(20);
            arvore.Raiz.Esquerda.Direita = new No(40);
            arvore.Raiz.Direita.Esquerda = new No(60);
            arvore.Raiz.Direita.Direita = new No(80);

            int valorBusca = 40;
            No resultado = arvore.Buscar(arvore.Raiz, valorBusca);

            if (resultado != null)
            {
                Console.WriteLine($"Valor {valorBusca} encontrado na árvore.");
            }
            else
            {
                Console.WriteLine($"Valor {valorBusca} não encontrado na árvore.");
            }
        }
    }
}
