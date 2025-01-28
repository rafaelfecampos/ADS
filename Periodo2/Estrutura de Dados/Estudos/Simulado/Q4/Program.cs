internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = { 5,3, 8 , 9, 10 , 1, 4};
        Console.WriteLine("Vetor desordenado:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write((i != vetor.Length - 1) ? $"{vetor[i]} | " : $"{vetor[i]}\n");
        }
        BubbleSort(vetor);
        Console.WriteLine("\n\nVetor ordenado:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write((i != vetor.Length - 1) ? $"{vetor[i]} | " : $"{vetor[i]}\n");
        }
    }

    static void BubbleSort(int[] vetor)
    {
        int end = vetor.Length - 1, pos = 0;
        bool troca = true;
        // do
        // {
        //     pos = -1;
        //     for (int i = 0; i < end; i++)
        //     {
        //         if (vetor[i] > vetor[i + 1])
        //         {
        //             Troca(vetor, i, i + 1);
        //             pos = i;
        //         }
        //     }
        //     end = pos;
        // } while (end>0);

        while (troca)
        {
            troca = false;
            for (int i = 0; i < end; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    Troca(vetor, i, i + 1);
                    pos = i;
                    troca = true;
                }
            }
            end = pos;
            
        }
    }
    static void Troca(int[] vetor, int i, int j)
    {
        int aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }
}