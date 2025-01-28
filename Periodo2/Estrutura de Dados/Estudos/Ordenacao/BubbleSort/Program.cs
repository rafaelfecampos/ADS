internal class Program
{
    //Bubblesort
    /*Ordenação por trocas é aplicados a todos os pares consecutivos de chaves nao ordenados
    
    1 - Em cada passo, o elemento é comparado com o elemento seguinte
    2 - Se o elemento estiver fora de ordem, a troca é realizada
    3 - Realizam-se a quantidade que for necessaria de passos até que não ocorram mais trocas

    O processo de comparação dos pares é chamado de varredura ou iteração
    *CADA VARREDURA IRÁ POSICIONAR A CHAVE DE *MAIOR VALOR* EM SUA POSIÇÃO CORRETA
    A cada nova varredura, podemos desconsiderar a ultima posição varrida
    */
    private static void Main(string[] args)
    {
        var vet = new double[] { 8.8, 9.65, 58.9, 0.11, 0.10 };
        Console.WriteLine("Vetor desordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
        BubbleSort(vet);
        Console.WriteLine("Vetor ordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
    }

    static void BubbleSort(double[] vetor)
    {
        int fim = vetor.Length - 1, pos;
        do
        {
            pos = -1;
            for (int i = 0; i < fim; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    Troca(vetor, i, i + 1);
                    pos = i;
                }
            }
            fim = pos;
        } while (fim > 0);
    }

    //Função BubbleSort com varável troca
    /*static void BubbleSort(double[] vetor) 
    {
        int fim = vetor.Length - 1, pos = 0;
        bool troca = true;
        while (troca)
        {
            troca = false;
            for (int i = 0; i < fim; i++) //varredura i
                if (vetor[i] > vetor[i + 1])
                {
                    Troca(vetor, i, i + 1);
                    pos = i;
                    troca = true;
                }
            fim = pos ;
        }
    }*/

    static void Troca(double[] vetor, int i, int j)//Troca os valores das posições i e j do vetor passado
    {
        double aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }
}