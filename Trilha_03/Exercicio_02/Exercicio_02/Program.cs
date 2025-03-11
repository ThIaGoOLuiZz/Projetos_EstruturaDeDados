namespace Exercicio_02
{
    internal class Program
    {
        public static int CalculoFibonacci(int n)
        {
            if(n < 2)
            {
                return n;
            }
            else
            {
                return CalculoFibonacci(n - 1) + CalculoFibonacci(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Informe o valor: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Retorno: " + CalculoFibonacci(valor));
        }
    }
}
