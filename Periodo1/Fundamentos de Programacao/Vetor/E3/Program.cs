/*Faça um programa que leia um vetor com 15 valores reais
A seguir, encontre o menor elemento do vetor e a sua
posição dentro do vetor, mostrando O menor elemento do
vetor está na posição XXXX e tem o valor YYYYY*/

internal class Program
{
    const int N = 15;
    private static void Main(string[] args)
    {
        double[] reais = new double[N];
        int indice = 0;
        Console.WriteLine("Escreva uma sequência de números: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Número {0}/{1}: ", i + 1, N);
            reais[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            if (reais[indice] > reais[i])
            {
                indice = i;
            }
        }
        Console.WriteLine("\nO menor elemento do vetor está na posição {0} e tem o valor {1}", indice+1, reais[indice]);
    }
}