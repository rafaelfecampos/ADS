internal class Program
{
    const int N = 5;
    private static void Main(string[] args)
    {
        int[] inteiros = new int[N];
        Console.WriteLine("Informe uma sequência de números inteiros: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Número {0}/{1}: ", i+1, N);
            inteiros[i] = Convert.ToInt32(Console.ReadLine());
        }
        ImprimirMenor(inteiros);
    }
    static void ImprimirMenor(int[] vetor)
    {
        int indice=0;
        for (int i = 0; i < N; i++)
        {
            if (vetor[indice] > vetor[i])
            {
                indice = i;
            }
        }
        Console.Write("O menor númeor é {0} e está no indice {1}", vetor[indice], indice);
    }
}