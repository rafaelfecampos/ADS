internal class Program
{
    //QuickSort
    /*
    Se o vetor contem mais de um elemento:
    -Escolha um elemento como pivô
    -Divida os elementos em dois sub-vetores: menores ou iguais ao pivô e maior que o pivô
    -Chame novamente a função QuickSort para cada um dos dois sub-vetores

    Posicione os elementos do vetor de modo que o vetor resultante tenha:
    -Elementos menores ou iguais que o pivô à esqueda
    -Elementos maires que o pivô à direita

    Chame o QuickSort para o sub-vetor da esquerda informando o indice inicial como 0 e o final sendo uma unidade menor que a do pivô;
    Chame o QuickSort para o sub-vetor da direira informando o indice inicial como sendo uma unidade maior que a do pivô e o final sendo uma unidade menor que o tamanho do vetor;
    */
    private static void Main(string[] args)
    {
        double[] vet = new double[20];
        Random random = new Random();
        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = random.Next(1, 101); // Gere números aleatórios entre 1 e 100
        }
        Console.WriteLine("Vetor desordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
        QuickSort(vet);
        Console.WriteLine("Vetor ordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
    }

    static void QuickSort(double[] vetor)
    {
        QuickSort(vetor, 0, vetor.Length - 1);
    }

    static void QuickSort(double[] vetor, int inicio, int fim)
    {
        if (inicio >= fim)
            return;
        int indMenor = fim, indMaior = inicio;
        int pivo = indMenor;

        do
        {
            while (indMaior < fim && vetor[indMaior] <= vetor[pivo])
                indMaior++;
            while (indMenor > inicio && vetor[indMenor] > vetor[pivo])
                indMenor--;
            if (indMaior < indMenor)
                Troca(vetor, indMaior, indMenor);
        } while (indMenor > indMaior);
        Troca(vetor, indMenor, pivo);
        QuickSort(vetor, inicio, pivo - 1);
        QuickSort(vetor, pivo + 1, fim);
    }
    static void Troca(double[] vetor, int i, int j)//Troca os valores das posições i e j do vetor passado
    {
        double aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }
}