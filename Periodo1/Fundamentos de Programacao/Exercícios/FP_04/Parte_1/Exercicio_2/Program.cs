/*Ler um número inteiro e informar se ele é divisível por 2.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um número inteiro: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if ((n % 2) == 1)
        {
            Console.WriteLine("{0} é divisível por 2", n);
        }
        else
        {
            Console.WriteLine("{0} não é divisível por 2", n);
        }
    }
}