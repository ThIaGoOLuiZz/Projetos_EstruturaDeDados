namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha(5);

            pilha.Empilhar(10);
            pilha.Empilhar(20);
            pilha.Empilhar(30);

            Console.WriteLine("Desempilhado: " + pilha.Desempilhar());
        }
    }
}
