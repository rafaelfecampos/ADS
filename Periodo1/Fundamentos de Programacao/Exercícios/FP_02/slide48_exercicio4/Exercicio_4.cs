/*Faça um programa que leia um número inteiro e imprima o seu antecessor e sucessor.*/
internal class Program
{
    private static void Main(string[] args)
    {
        int n;

        Console.Write("Insira um número inteiro: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O número que antecede {0} é: {1}", n, n - 1);
        Console.WriteLine("O número que sucede {0} é {1}", n, n + 1);
        ;
    }
}