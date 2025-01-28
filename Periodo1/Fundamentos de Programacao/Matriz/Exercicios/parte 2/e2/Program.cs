/*Faça um programa que leia uma matriz 7 x 5 e imprima a terceira coluna.*/
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[7, 5];
        Console.WriteLine("Escreva os elementos da matriz: ");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nTerceira coluna da matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if(j==2)
                    Console.Write(matriz[i,j]);
            }
            Console.WriteLine();
        }
    }
}