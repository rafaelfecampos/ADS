internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe dois números inteiros: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine("{0}>{1}", n1, n2);
        }
        else if (n1 ==n2)
        {
            Console.WriteLine("{0}={1}", n1, n2);
        }
        else
        {
            Console.WriteLine("{0}<{1}", n1, n2);
        }
    }
}