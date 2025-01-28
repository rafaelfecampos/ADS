internal class Program
{
    static void LerMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine("Linha {0}", i + 1);
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void SomarMatriz(int[,] matA, int[,] matB)
    {
        Console.WriteLine("\nSomatório das matrizes");
        for (int i = 0; i < matA.GetLength(0); i++)
        {
            for (int j = 0; j < matA.GetLength(1); j++)
                Console.Write("{0} ", matA[i, j] + matB[i, j]);
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        int[,] a = new int[3, 3];
        int[,] b = new int[3, 3];
        Console.WriteLine("Escreva os valores da primeira matriz:");
        LerMatriz(a);
        Console.WriteLine("\nEscreva os valores da segunda matriz:");
        LerMatriz(b);
        SomarMatriz(a, b);
    }
}