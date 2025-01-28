/*Faça uma função que ordene um vetor de inteiros passado por
parâmetro utilizando o método bolha e retorne o número de trocas realizadas*/
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] { 3, 5, -1, 0, 4 };
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{vetor[i]} ");
        }
        Console.WriteLine($"\n\nNúmero de trocas: {SelectSort(vetor)}");
        Console.WriteLine("Vetor ordenado: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{vetor[i]} ");
        }
    }
    static int BubbleSort(int[] vetor)
    {
        bool troca = true;
        int cont = 0, pos = -1, fim = vetor.Length - 1;
        while (troca)
        {
            troca = false;
            for (int i = 0; i < fim; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    Troca(vetor, i, i + 1);
                    troca = true;
                    pos = i;
                    cont++;
                }
            }
            fim = pos;
        }
        return cont;
    }
    static int InsertSort(int[] vetor)
    {
        int chave = 0, cont = 0;
        for (int i = 1; i < vetor.Length; i++)
        {
            chave = vetor[i];
            int j = i - 1;
            while (j >= 0 && vetor[j] > chave)
            {
                vetor[j + 1] = vetor[j];
                cont++;
                j--;
            }
            vetor[j + 1] = chave;
        }
        return cont;
    }
    static int SelectSort(int[] vetor)
    {
        int cont = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            int indMenor = i;
            for (int j = i + 1; j < vetor.Length; j++)
            {
                if (vetor[indMenor] > vetor[j])
                {
                    indMenor = j;
                }
            }
            if (indMenor != i)
            {
                Troca(vetor, i, indMenor);
                cont++;
            }
        }
        return cont;
    }
    static void Troca(int[] vetor, int i, int j)
    {
        int aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }
}