/*Desenvolva um programa que leia um vetor de números
reais, um escalar e imprima o resultado da multiplicação do
vetor pelo escalar*/

internal class Program
{
    const int N=5;
    private static void Main(string[] args)
    {
        int[] inteiros = new int[N];
        int escalar;
        Console.WriteLine("Digite uma sequência de números: ");
        for(int i=0;i<N;i++)
        {
            Console.Write("Número {0}/{1}: ",i+1,N);
            inteiros[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("\nDigite o escalar: ");
        escalar=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nResultado vetor*escalar:");
        for(int i=0;i<N;i++)
        {
            Console.WriteLine("Multiplicação {0}/{1}: {2}*{3}={4}",i+1,N,inteiros[i],escalar,inteiros[i]*escalar);
        }
    }
}