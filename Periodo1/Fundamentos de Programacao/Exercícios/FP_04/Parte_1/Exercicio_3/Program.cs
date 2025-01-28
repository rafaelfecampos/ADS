/*Altere o algoritmo anterior para que seja informado se o número é divisível por 2 e por 3 simultaneamente.*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um número inteiro: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0 && n % 3 == 0)
        {
            Console.WriteLine("{0} é divisível por 2 e 3", n);
        }
        else
        {
            Console.WriteLine("{0} não é divisível por 2 e 3", n);
        }
    }
}