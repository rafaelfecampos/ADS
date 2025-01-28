/*Faça uma função que receba por parâmetro um número inteiro e retorne “par” se o número recebido por parâmetro for par. Caso contrário, a função deve retornar “ímpar”. No método principal (Main), leia um número inteiro e passeo por  arâmetro para a função criada, imprimindo em seguida o seu retorno.*/

internal class Program
{
    static string ParOuImpar(int n)
    {
        if (n % 2 == 0)
        {
            return "Par";
        }
        else
        {
            return "Ímpar";
        }
    }
    private static void Main(string[] args)
    {
        int num;
        string a;
        Console.Write("Escreva um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());
        a = ParOuImpar(num);
        Console.WriteLine(a);
        Console.ReadKey();
    }
}