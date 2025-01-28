internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("{0} > 0", num);
        }
        else if (num < 0)
        {
            Console.WriteLine("{0}<0", num);
        }
        else
        {
            Console.WriteLine("{0}=0", num);
        }

    }
}