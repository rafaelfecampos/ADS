/*Altere o algoritmo anterior para que seja informado se o número é divisível por 2 e por 3, mas que não seja divisível por 5.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um número inteiro: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0 && n % 3 == 0 && n % 5 == 0)
        {
            Console.WriteLine("{0} é divisível por 2, 3 e 5 simultaneante", n);
        }
        else
        {
            Console.WriteLine("{0} não é divisil por 2, 3 e 5 simultaneamente", n);
        }
    }
}