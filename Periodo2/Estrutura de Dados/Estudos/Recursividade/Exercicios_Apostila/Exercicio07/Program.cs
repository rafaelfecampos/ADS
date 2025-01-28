internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Dê um número inteiro: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A soma do intervalo desse numero até zero é {Soma(n)}");
    }
    private static int Soma(int n)
    {
        if (n != 0)
        {
            if (n > 0)
                return n + Soma(n - 1);
            else
                return n + Soma(n + 1);
        }
        else
            return 0;
    }
    //Resolução Apostila
    /* private static int Soma(int n)
    {
        if (n > 0)
            return n + Soma(n - 1);
        else if (n < 0)
            return n + Soma(n + 1);
        else
            return 0;
    } */
}