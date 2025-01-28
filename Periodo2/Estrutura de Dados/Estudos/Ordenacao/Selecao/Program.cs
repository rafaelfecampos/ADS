internal class Program
{
    //Seleção
    /*
    Consiste na seleção do menor ou do maior valor contido no vetor, variando se a ordenação será feita de modo crescente ou descescente

    O elemento de menor(ou maior) valor é selecionado e colocado em sua posição correta dentro do vetor
    Este processo é repetido para o segmento do vetor que possui os elementos ainda nao selecionados

    O vetor é dividido em dois segmentos: com valores ja selecionados e com valores ainda nao selecionados

    1 - É feita uma verredura no segmento com os elementos nao selecionados, identificando o menor ou maior valor;
    2 - O elemento identificado é inserido no segmento classificado na ultima posição
    3 - O tamanho do segmento que contém os elementos ainda não slelcionados é atualizado, diminuindo 1;
    4 - O processp é repetido até que o segmento com valores nao selecionados fique com apenas um elemento;
    */
    private static void Main(string[] args)
    {
        var vet = new double[] { 40, 30, 15, 25 };
        Console.WriteLine("Vetor desordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
        Selecao(vet);
        Console.WriteLine("Vetor ordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write((i != vet.Length - 1) ? $"{vet[i]} - " : $"{vet[i]}\n");
        }
    }

    static void Selecao(double[] vetor){ //ordem crescente
        //a aprte ordenada está entre 0 e i
        for(int i = 0; i<vetor.Length; i++){
            int indMenor = i;
            //localiza o índice indMenor do menor elemento na parte não ordenada do vetor
            for(int j = i+1; j<vetor.Length; j++){
                if(vetor[j] < vetor[indMenor])
                    indMenor = j;
            }
            if (i != indMenor)//troca o item i pelo item indMenor
                Troca(vetor, i, indMenor);
        }
    }
    /*static void Selecao(double[] vetor){ //ordem descrescente
        //a aprte ordenada está entre 0 e i
        for(int i = vetor.Length-1; i>=0; i--){
            int indMaior = i;
            //localiza o índice indMaior do menor elemento na parte não ordenada do vetor
            for(int j = i-1; j>=0; j--){
                if(vetor[j] > vetor[indMaior])
                    indMaior = j;
            }
            if (i != indMaior)//troca o item i pelo item indMaior
                Troca(vetor, i, indMaior);
        }
    }*/
    static void Troca(double[] vetor, int i, int j)//Troca os valores das posições i e j do vetor passado
    {
        double aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }
}