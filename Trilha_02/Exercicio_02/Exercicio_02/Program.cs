namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();

            lista.InsertAtBeginning("valor1");
            lista.InsertAtEnd("valor2");
            lista.InsertAtEnd("valor3");
            lista.InsertAtBeginning("valorInseridoNoFinal");


            Console.Write("Valor inicial: {");
            foreach (var item in lista)
            {
                Console.Write(item + ",");
            }
            Console.Write("}");

            lista.Remove("valor2");

            Console.WriteLine();
            Console.Write("Valor final: {");
            foreach (var item in lista)
            {
                Console.Write(item + ",");
            }
            Console.Write("}");

        }
    }
}
