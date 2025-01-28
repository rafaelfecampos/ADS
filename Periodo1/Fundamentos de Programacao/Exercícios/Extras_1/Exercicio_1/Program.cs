//Faça um procedimento que receba por parâmetro um número inteiro e escreva “par” se o número recebido por parâmetro for par. Caso contrário, o procedimento deve escrever “ímpar”. No método principal (Main), leia um número inteiro e passe-o por parâmetro para o procedimento criado.

internal class Program
{
    static void ParOuImpar (int n)
    {
        if (n%2==0)
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Ímpar");
        }
    }
    
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());
        ParOuImpar(num);
    }
}