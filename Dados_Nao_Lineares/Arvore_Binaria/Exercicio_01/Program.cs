namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            int[] valores = { 50, 30, 70, 20, 40, 60, 80 };
            foreach (int valor in valores)
            {
                arvore.Inserir(valor);
            }

            arvore.Inserir(50);
            arvore.Inserir(30);
            arvore.Inserir(70);
            arvore.Inserir(20);
            arvore.Inserir(40);
            arvore.Inserir(60);
            arvore.Inserir(80);


            Console.WriteLine("Percurso In-Order:");
            arvore.PercursoInOrder();

            Console.WriteLine("Buscar 40: " + (arvore.Buscar(40) ? "Encontrado" : "Não encontrado"));
            Console.WriteLine("Buscar 100: " + (arvore.Buscar(100) ? "Encontrado" : "Não encontrado"));
        }
    }
}
