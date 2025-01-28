/*Faça uma função que receba um vetor de números inteiros por
parâmetro e multiplique por -1 todos os elementos negativos desse vetor. A função
deve retornar o número de elementos negativos encontrados. Restrição: não utilize
comandos de repetição.*/
internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] { -2, 3, -5, -6, -1 };
        Console.WriteLine(CountAndConvertNegatives(vetor));
    }
    static int CountAndConvertNegatives(int[] vetor, int i = 0, int cont = 0)
    {
        if (i < vetor.Length)
        {
            if (vetor[i] < 0)
            {
                vetor[i] *= -1;
                return CountAndConvertNegatives(vetor, i + 1, cont + 1);
            }
            return CountAndConvertNegatives(vetor, i + 1, cont);
        }
        return cont;
    }
}
