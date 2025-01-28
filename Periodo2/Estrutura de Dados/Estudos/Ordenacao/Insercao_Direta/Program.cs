internal class Program
{
    //Inserção
    /*
    O vetor é dividido em dois segmentos: um onde serão armezenados os valores ordenados, e outro onde estão os valores nao ordenados.

    1 - Retira-se o primeiro elemento do vetor nao ordenado (menor) e coloca-o no vetor ordenado na posição correta
    2 - Repete este processo até que todos os elementos estejam na posição correta
    */
    private static void Main(string[] args)
    {
        var vet = new double[] { 40, 30, 15, 25 };
        Console.WriteLine("Vetor desordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
        Insercao(vet);
        Console.WriteLine("Vetor ordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
    }

    static void Insercao(double[] vetor)
    {
        //a parte ordenada está entre 0 e i
        for (int i = 1; i < vetor.Length; i++)
        {
            //valor a ser inserido na parte ordenada
            double chave = vetor[i];
            int j = i - 1;
            //localiza a posição j de chave na parte ordenada
            while (j >= 0 && chave < vetor[j])
            {
                vetor[j + 1] = vetor[j];
                j--;
            }
            vetor[j + 1] = chave;
        }

    }
}