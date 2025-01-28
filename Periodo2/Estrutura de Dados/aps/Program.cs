internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = { 10, 20, 30, 40, 50, 60 };
        int aux;

        for (int i = 0; i < 3; i++)
        {
            aux = vetor[i];
            vetor[i] = vetor[6 - 1 - i];
            vetor[6 - 1 - i] = aux;
        }

        for(int j=0; j<vetor.Length;j++){
            Console.WriteLine(vetor[j]);
        }
    }
}