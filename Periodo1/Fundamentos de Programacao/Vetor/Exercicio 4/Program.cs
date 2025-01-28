internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetorA = new int[10];
        int[] vetorB = new int[10];

        Console.WriteLine("Dê uma sequência de número:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número {0} de {1}: ", i + 1, 10);
            vetorA[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nDê uma outra sequência de número:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número {0} de {1}: ", i + 1, 10);
            vetorB[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] soma = new int[10];
        Console.WriteLine("\nSomatório da sequência: ");
        for (int i = 0; i < 10; i++)
        {
            soma[i] = vetorA[i] + vetorB[i];
            Console.WriteLine("{0} + {1} = {2}", vetorA[i], vetorB[i], soma[i]);
        }

    }
}