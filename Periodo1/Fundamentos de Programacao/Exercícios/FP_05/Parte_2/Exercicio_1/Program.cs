internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um número N inteiro e positivo: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {
            double e;
            e = 0;
            for (int i = 1; i <= n; i++)
            {
                e = e + 1.0 / i;
            }
            Console.WriteLine("E=1+(1/2)+(1/3)+...+(1/{0}) = {1}", n, e);
        }
        else
        {
            Console.WriteLine("Número inválido!.");
        }

    }
}