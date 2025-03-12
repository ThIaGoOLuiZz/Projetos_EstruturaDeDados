namespace Exercicio_06
{
    internal class Program
    {
        static int contadorMovimentos = 0;

        static void MoverDiscos(int n, char origem, char destino, char auxiliar)
        {
            if (n == 1)
            {
                Console.WriteLine($"Mover disco 1 de {origem} para {destino}");
                contadorMovimentos++;
                return;
            }

            MoverDiscos(n - 1, origem, auxiliar, destino);
            Console.WriteLine($"Mover disco {n} de {origem} para {destino}");
            contadorMovimentos++;
            MoverDiscos(n - 1, auxiliar, destino, origem);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o número de discos: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSolução da Torre de Hanói:");
            MoverDiscos(n, 'A', 'C', 'B');

            Console.WriteLine($"\nNúmero total de movimentos: {contadorMovimentos}");
        }
    }
}
