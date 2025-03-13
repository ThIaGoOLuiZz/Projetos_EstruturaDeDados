namespace Exercicio_05_pt02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaCircular fila = new FilaCircular(5);

            fila.Enqueue(10);
            fila.Enqueue(20);
            fila.Enqueue(30);
            fila.Mostrar();

            Console.WriteLine("Removido: " + fila.Dequeue());
            fila.Mostrar();

            fila.Enqueue(40);
            fila.Enqueue(50);
            fila.Enqueue(60);
            fila.Mostrar();
        }
    }
}
