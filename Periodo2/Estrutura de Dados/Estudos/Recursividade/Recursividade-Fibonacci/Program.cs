internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Fib(30));
    }
    static int Fib(int n)
    {
        if (n <= 2)
            return 1;
        else
            return Fib(n - 1) + Fib(n - 2);
    }
}