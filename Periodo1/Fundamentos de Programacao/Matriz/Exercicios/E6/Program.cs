internal class Program
{
    static int SomarElementos(int[,] mat)
    {
        int soma=0;
        for(int i=0;i<mat.GetLength(0);i++)
        {
            for(int j=0;j<mat.GetLength(1);j++)
            {
                soma+=mat[i,j];
            }
        }
        return soma;
    }
    const int N=3;
    private static void Main(string[] args)
    {
        int[,] matriz = new int[N,N];
        Console.WriteLine("Dê os elementos da matriz");
        int soma=0;
        for(int i=0;i<matriz.GetLength(0);i++)
        {
            for(int j=0;j<matriz.GetLength(1);j++)
            {
                matriz[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nResultado da soma dos elementos da matriz: {0}", SomarElementos(matriz));
    }
}