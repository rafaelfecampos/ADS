//Q1
//Faça uma função recursiva que receba um número inteiro por parâmetro e retorne true, se o número for um número perfeito, ou false caso contrário. Um número perfeito é um número natural para o qual a soma de todos os seus divisores naturais é igual ao prório número. Não pode utilizar comandos de repitição
//ex: 6, 28, 496

/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escreva um número inteiro: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((EhPerfeito(n)) ? $"O número {n} é perfeito!" : $"O número {n} não é perfeito!");
    }
    static bool EhPerfeito(int n, int i = 1, int soma = 0)
    {
        if (i <= n/2)
        {
            if (n % i == 0)
                soma += i;
            return (EhPerfeito(n, i + 1, soma));
        }
        else
        {
            if (soma == n)
                return true;
            else
                return false;
        }
    }
}*/

//Q2
//Faça três procedimentos. Cada procedimento deve receber um vetor de atletas e reoganizar o mesmo em ordem decrescente do peso do atleta. O primeiro procedimento deve utilizar o método bolha, o segundo método da inserção e o terceiro método da seleção.

internal class Program
{
    private static void Main(string[] args)
    {
        Atletas[] atleta = new Atletas[5];
        Console.WriteLine("Dê os dados dos atletas:");
        for (int i = 0; i < atleta.Length; i++)
        {
            atleta[i] = new Atletas();
            Console.Write("-Peso: ");
            atleta[i].Peso = Convert.ToDouble(Console.ReadLine());
        }
        SelectionSort(atleta);
        Console.WriteLine("\n\nAtletas ordenados do maior peso para o menos: ");
        for (int i = 0; i < atleta.Length; i++)
        {
            Console.WriteLine($"-Peso: {atleta[i].Peso}");
        }
    }
    static void BubbleSort(Atletas[] vetor)
    {
        bool troca = true;
        int pos = -1, fim = vetor.Length - 1;
        while (troca)
        {
            troca = false;
            for (int i = 0; i < fim; i++)
            {
                if (vetor[i].Peso < vetor[i + 1].Peso)
                {
                    Troca(vetor, i, i + 1);
                    pos = i;
                    troca = true;
                }
            }
            fim = pos;
        }
    }
    static void InsertSort(Atletas[] vetor){
        for (int i = 1; i < vetor.Length; i++)
        {
            double chave = vetor[i].Peso;
            int j = i-1;

            while(j>=0 && chave>vetor[j].Peso){
                vetor[j+1].Peso= vetor[j].Peso;
                j--;
            }
            vetor[j+1].Peso = chave;
        }
    }
    static void SelectionSort(Atletas[] vetor){
        for (int i = 0; i < vetor.Length; i++)
        {
            int indMenor = i;
            for (int j = i+1; j < vetor.Length; j++)
            {
                if(vetor[j].Peso > vetor[indMenor].Peso)
                    indMenor = j;
            }
            if(i!=indMenor){
                Troca(vetor, i, indMenor);
            }
        }
    }
    static void Troca(Atletas[] vetor, int i, int j)
    {
        double auxP = vetor[i].Peso;
        vetor[i].Peso = vetor[j].Peso;
        vetor[j].Peso = auxP;
    }
}