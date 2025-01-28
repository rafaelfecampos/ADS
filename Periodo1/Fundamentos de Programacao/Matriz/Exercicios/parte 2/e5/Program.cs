/*Faça um programa que leia uma matriz de caracteres 5 x 10 e uma função que conte quantas letras 'a' aparecem na
matriz. Você poderá fazer a leitura letra a letra ou considerar que cada linha da matriz é uma string*/
internal class Program
{
    const int x = 3, y = 5;
    static void ImprimirMatriz(char[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,-4}",mat[i,j]);
            }
            Console.WriteLine();
        }
    }
    static int ContarLetra(char[,] mat)
    {
        int cont=0;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if(mat[i,j]=='a')
                    cont++;
            }
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        char[,] matriz = new char[x, y];
        Console.WriteLine("Escreva os elementos de uma matriz de caracteres:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i,j]=Convert.ToChar(Console.ReadLine());
            }
        }
        Console.WriteLine("\nMatriz principal:");
        ImprimirMatriz(matriz);
        Console.WriteLine("\nNúmero de letra 'a' na matriz: {0}", ContarLetra(matriz));
    }
}