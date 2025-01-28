/*Faça um programa que leia uma matriz 6 x 3 e um procedimento que gere duas matrizes 3 x 3, a primeira com
as 3 primeiras linhas e a outra com as restantes.*/
internal class Program
{
    static void ImprimirMatriz(double[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,4}", mat[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void SepararMatriz(double[,] mat)
    {
        double[,] mat1 = new double[3, 3];
        double[,] mat2 = new double[3, 3];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if(i<3)
                    mat1[i,j]=mat[i,j];
                else
                    mat2[i-3,j]=mat[i,j];
            }
        }
        Console.WriteLine("Matriz dividida 1: ");
        ImprimirMatriz(mat1);
        Console.WriteLine("Matriz dividida 2: ");
        ImprimirMatriz(mat2);
    }
    private static void Main(string[] args)
    {
        double[,] matriz = new double[6, 3];
        Console.WriteLine("Escreva os elementos de uma matriz 6x3:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        Console.WriteLine("Matriz principal: ");
        ImprimirMatriz(matriz);
        SepararMatriz(matriz);
    }
}