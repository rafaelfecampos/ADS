/*Faça um programa que leia um vetor de 15 posições
(reais) e depois um valor a ser procurado no vetor Imprima
se o valor foi ou não encontrado e a quantidade de vezes que
o valor está presente no vetor*/

internal class Program
{
    const int N = 15;
    private static void Main(string[] args)
    {
        double[] reais = new double[N];
        Console.WriteLine("Escreva uma sequência de números reais: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Número {0}/{1}: ", i + 1, N);
            reais[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.Write("\nEscreva um valor a ser procurado na sequência: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        int cont = 0;
        for (int i = 0; i < N; i++)
        {
            if (valor == reais[i])
            {
                cont++;
            }
        }
        if (cont != 0)
        {
            Console.WriteLine("\nO valor {0} foi encontrado {1} vez(es)", valor, cont);
        }
        else
        {
            Console.WriteLine("\nO valor {0} não foi encontrado!", valor);
        }
    }
}