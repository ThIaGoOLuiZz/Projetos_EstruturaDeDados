namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila<string> fila = new Fila<string>();

            while (true)
            {
                Console.WriteLine("\n1. Adicionar Cliente");
                Console.WriteLine("2. Atender Cliente");
                Console.WriteLine("3. Mostrar Fila");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Nome: ");
                        fila.Enqueue(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine(fila.Count > 0 ? $"Atendido: {fila.Dequeue()}" : "Fila vazia!");
                        break;
                    case "3":
                        Console.WriteLine("Fila: " + fila.ToString());
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
