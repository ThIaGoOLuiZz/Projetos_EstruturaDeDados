namespace Exercicio_01
{
    internal class Program
    {
        public static int Fatorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            return n * Fatorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Número para o calculo Fatorial: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fatorial: {Fatorial(valor)}");
        }
    }
}
