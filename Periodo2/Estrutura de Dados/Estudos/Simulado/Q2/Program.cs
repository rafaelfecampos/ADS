internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = { 5, 6, 8, 69, -8, -9, -7, 54, 21 };
        Console.WriteLine(ConverterNegativo(vetor));
    }

    static int ConverterNegativo(int[] vetor)
    {
        return ConverterNegativo(vetor, 0, 0);
    }

    static int ConverterNegativo(int[] vetor, int i, int cont)
    {
        if (i < vetor.Length){
            vetor[i] *=-1;
            if(vetor[i] < 0)
                return ConverterNegativo(vetor, i+1, cont+1);
            return ConverterNegativo(vetor, i+1, cont);
        }
        else
            return cont;
        
    }
}