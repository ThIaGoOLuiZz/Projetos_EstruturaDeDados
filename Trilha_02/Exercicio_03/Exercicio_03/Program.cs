namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();

            lista.Insertfirst("Primeiro valor adicionado");
            lista.Insertfirst("Segundo valor adicionado");
            lista.Insertfirst("Terceiro valor adicionado");
            
            lista.PrintNextOrder();
            Console.WriteLine();
            lista.PrintPrevOrder();
            Console.WriteLine();

            Console.WriteLine();
            lista.RemoveLast();

            lista.PrintNextOrder();
            Console.WriteLine();
            lista.PrintPrevOrder();
            Console.WriteLine();
        }
    }
}
