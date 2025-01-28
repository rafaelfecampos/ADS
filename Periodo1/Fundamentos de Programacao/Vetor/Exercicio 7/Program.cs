internal class Program
{
    const int N = 10;
    private static void Main(string[] args)
    {
        int[] inteiros = new int[N];
        int indice = 0;
        Console.WriteLine("Informe uma sequência de números inteiros: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Número {0}/{1}: ", i+1, N);
            inteiros[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            if (inteiros[indice] > inteiros[i])
            {
                indice = i;
            }
        }
        Console.Write("O menor númeor é {0} e está no indice {1}", inteiros[indice], indice);
    }
}