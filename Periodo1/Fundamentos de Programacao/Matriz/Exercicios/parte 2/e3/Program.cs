/*Faça um programa que leia uma matriz quadrada de dimensão 10, uma função que encontre o maior valor desta
matriz e uma função que encontre o menor valor. Imprima os valores encontrados na função principal.*/
internal class Program
{
    static int EncontrarMaior(int[,] mat)
    {
        int maior=mat[0,0];
        for(int i=0; i<mat.GetLength(0);i++)
        {
            for(int j=0;j<mat.GetLength(1);j++)
            {
                if(maior<=mat[i,j])
                    maior=mat[i,j];
            }
        }
        return maior;
    }
    static int EncontrarMenor(int[,] mat)
    {
        int menor=mat[0,0];
        for(int i=0; i<mat.GetLength(0);i++)
        {
            for(int j=0;j<mat.GetLength(1);j++)
            {
                if(menor>=mat[i,j])
                    menor=mat[i,j];
            }
        }
        return menor;
    }
    const int N=10;
    private static void Main(string[] args)
    {
        int[,] matriz = new int[N,N];
        int aux=0;
        Console.WriteLine("Escreva os elementos de uma matriz: ");
        for(int i=0; i<matriz.GetLength(0);i++)
        {
            for(int j=0;j<matriz.GetLength(1);j++)
            {
                aux++;
                matriz[i,j]=aux;
            }
        }
        Console.WriteLine("\nMatriz principal:");
        for(int i=0; i<matriz.GetLength(0);i++)
        {
            for(int j=0;j<matriz.GetLength(1);j++)
            {
                Console.Write("{0,4}",matriz[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMaior elemento da matriz: {0}", EncontrarMaior(matriz));
        Console.WriteLine("\nMenor elemento da matriz: {0}", EncontrarMenor(matriz));
    }
}