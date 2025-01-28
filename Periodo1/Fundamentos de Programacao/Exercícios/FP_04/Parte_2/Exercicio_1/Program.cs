/*Faça um programa que leia dois números inteiros e faça a divisão do primeiro pelo segundo (se o segundo for diferente de zero).*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escreva dois números: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        double n2 = Convert.ToDouble(Console.ReadLine());
        if (n2 != 0)
        {
            double div = n1/n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, div);
        }
        else{
            Console.WriteLine("Não é possivel realizar a divisão.");
        }
        Console.ReadKey();
    }
}