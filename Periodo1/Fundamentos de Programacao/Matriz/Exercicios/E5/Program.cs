internal class Program
{
    static void TranformarIdentidade(int[,] matriz, int[,] identidade)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (j == i)
                {
                    identidade[i, j] = matriz[i, j];
                    identidade[N-1-i,j]= matriz [N-1-i,j];
                    identidade[i,N-1-j]=matriz[i,N-1-j];
                }
                else
                {
                    identidade[i, j] = 0;
                }
            }
        }
    }
    static void ImprimirMatriz(int[,] imprimir)
    {
        for (int i = 0; i < imprimir.GetLength(0); i++)
        {
            for (int j = 0; j < imprimir.GetLength(1); j++)
            {
                Console.Write("{0,4}", imprimir[i,j]);
            }
            Console.WriteLine();
        }
    }
    const int N = 5;
    private static void Main(string[] args)
    {
        int[,] mat = new int[N, N];
        int[,] identidade = new int[N, N];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Matriz 1: ");
        ImprimirMatriz(mat);
        TranformarIdentidade(mat,identidade);
        Console.WriteLine("Matriz identidade: ");
        ImprimirMatriz(identidade);

    }
}


