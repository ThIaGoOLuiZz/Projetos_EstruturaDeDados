using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("Informe o valor buscado: ");
        int valorBuscado = int.Parse(Console.ReadLine());
        int indiceRetornado = BuscaValor(valorBuscado, vetor);

        if (indiceRetornado == (vetor.Length + 1)) Console.WriteLine("Valor não encontrado!");

        else Console.WriteLine($"Valor: {valorBuscado} | Indice: {indiceRetornado}");

        Console.Write("Valor a ser removido do Array: ");
        int valorRemover = int.Parse(Console.ReadLine());

        int[] novoVetor = RemoverValor(valorRemover, vetor);

        vetor = new int[vetor.Length - 1];

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = novoVetor[i];
        }

        foreach (int valor in vetor)
        {
            Console.WriteLine(valor);
        }

    }

    public static int BuscaValor(int valor, int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                return vetor[i];
            }
        }
        return (vetor.Length + 1);
    }

    public static int[] RemoverValor(int valor, int[] vetor)
    {

        int[] novoArray = new int[vetor.Length - 1];
        int contadorArray = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != valor)
            {
                novoArray[contadorArray] = vetor[i];
                contadorArray++;
            }
        }
        return novoArray;
    }
}