namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxHeap fila = new MaxHeap();

            fila.Inserir(10);
            fila.Inserir(20);
            fila.Inserir(15);
            fila.Inserir(30);
            fila.Inserir(25);

            Console.WriteLine("Fila de prioridade:");
            fila.Mostrar();

            Console.WriteLine("\nRemovendo maior: " + fila.RemoverMaior());
            fila.Mostrar();

            Console.WriteLine("\nMaior agora: " + fila.VerMaior());
        }
    }
}
