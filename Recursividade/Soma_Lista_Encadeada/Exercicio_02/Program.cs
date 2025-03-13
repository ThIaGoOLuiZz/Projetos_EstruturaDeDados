namespace Exercicio_02
{
    internal class Program
    {
        public static int SomaLista(Node node)
        {
            if(node == null)
            {
                return 0;
            }

            return Convert.ToInt32(node.Data) + SomaLista(node.Next);
        }

        static void Main(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();

            lista.InsertAtBeginning(1);
            lista.InsertAtEnd(2);
            lista.InsertAtEnd(3);
            lista.InsertAtBeginning(4);

            Console.WriteLine("Valor total: " + SomaLista(lista.head));

        }
    }
}
