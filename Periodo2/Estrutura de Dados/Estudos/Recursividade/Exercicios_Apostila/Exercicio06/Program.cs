internal class Program
{
    private static void Main(string[] args)
    {
        double[] vet = {-1,2,-3,-5};
        Console.WriteLine("Elementos vetor: ");
        for(int i=0; i<vet.Length;i++)
            Console.Write($" {vet[i]} ");
        Converte(vet);
        Console.WriteLine("\nElementos vetor convertido: ");
        for(int i=0; i<vet.Length;i++)
            Console.Write($" {vet[i]} ");
    }
    static void Converte(double[] vetor)
    {
        Converte(vetor, vetor.Length);
    }
    static void Converte(double[] vetor, int n)
    {
        if(n>0)
        {
            if(vetor[n-1]<0)
                vetor[n-1]=vetor[n-1]*-1;
            Converte(vetor, n-1);
        }
    }
}


/* //Resolução apostila
using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        double[] vet = {-1,2,-3,-5};
        Console.WriteLine("Elementos vetor: ");
        for(int i=0; i<vet.Length;i++)
            Console.Write($" {vet[i]} ");
        Converte(vet);
        Console.WriteLine("\nElementos vetor convertido: ");
        for(int i=0; i<vet.Length;i++)
            Console.Write($" {vet[i]} ");
    }
    static void Converte(double[] vetor, int n = 0)
    {
        if(n<vetor.Length)
        {
            if(vetor[n]<0)
                vetor[n]*=-1;
            Converte(vetor, n+1);
        }
    }
} */