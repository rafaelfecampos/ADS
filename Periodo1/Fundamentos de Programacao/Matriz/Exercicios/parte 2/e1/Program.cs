/*Faça um procedimento para calcular a multiplicação de uma matriz 3 x 4 por um escalar. Faça também um
procedimento capaz de imprimir esta matriz. Ao final, desenvolva uma função principal onde será criada e lida uma
matriz 3 x 4. Faça nesta função a chamada dos dois procedimentos criados anteriormente.*/
internal class Program
{
    static void Multiplicacao(double[,] mat)
    {
        Console.Write("\nDigite um escalar: ");
        double n = Convert.ToDouble(Console.ReadLine());
        for(int i=0;i<mat.GetLength(0);i++)
        {
            for(int j=0;j<mat.GetLength(1);j++)
            {
                mat[i,j]=mat[i,j]*n;
            }
        }
    }
    static void ImprimirMatriz(double[,] mat)
    {
        Console.WriteLine("Matriz principal x escalar:");
        for(int i=0;i<mat.GetLength(0);i++)
        {
            for(int j=0;j<mat.GetLength(1);j++)
            {
                Console.Write("{0,8}", mat[i,j]);
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        double[,] matriz = new double[3,4];
        Console.WriteLine("Digite os elementos de uma matriz");
        for(int i=0;i<matriz.GetLength(0);i++)
        {
            for(int j=0;j<matriz.GetLength(1);j++)
            {
                matriz[i,j]=Convert.ToDouble(Console.ReadLine());
            }
        }
        Multiplicacao(matriz);
        ImprimirMatriz(matriz);
    }
}