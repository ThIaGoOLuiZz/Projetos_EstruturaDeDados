namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();

            lista.InsertAtEnd(10);
            lista.InsertAtEnd(20);
            lista.InsertAtEnd(30);


            Console.WriteLine("Número de nós na lista: " + lista.ContaNodes(lista.head));
        }
    }
}
