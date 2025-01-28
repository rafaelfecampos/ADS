/*Faça um procedimento que faça a leitura um vetor de 10
elementos inteiros e imprima somente os valores
armazenados nos índices pares*/
internal class Program
{
    const int N = 10;
    private static void Main(string[] args)
    {
        int[] inteiros = new int[N];
        Console.WriteLine("Escreva uma sequência de inteiros: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Número {0}/{1}: ",i+1,N);
            inteiros[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nImpressão dos números pares da sequência: ");
        for(int i=0;i<N;i++)
        {
            if(i%2==0)
            {
                Console.WriteLine("Vetor no índice {0}: {1}",i,inteiros[i]);
            }
        }
    }
}