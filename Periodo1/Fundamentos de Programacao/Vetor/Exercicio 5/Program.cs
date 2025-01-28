internal class Program
{
    static void receberVetor(int[] vetor)
    {
        Console.WriteLine("Dê uma sequência de número:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número {0} de {1}: ", i + 1, 10);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void ImprimirSoma(int[] soma, int[] vetor1, int[] vetor2)
    {
        Console.WriteLine("Somatório das sequências:");
        for (int i = 0; i < 10; i++)
        {
            soma[i] = vetor1[i] + vetor2[i];
            Console.WriteLine("{0} + {1} = {2}", vetor1[i], vetor2[i], soma[i]);
        }
    }
    static void Main(string[] args)
    {
        int[] vetorA = new int[10];
        int[] vetorB = new int[10];
        int[] soma = new int[10];
        receberVetor(vetorA);
        receberVetor(vetorB);
        ImprimirSoma(soma, vetorA, vetorB);
    }
}