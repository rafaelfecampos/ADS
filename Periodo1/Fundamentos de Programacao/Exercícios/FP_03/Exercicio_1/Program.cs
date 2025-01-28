internal class Program
{
    static void Main(string[] args)
    {
        double n1,n2,n3;
        Console.WriteLine("Digite 3 números:");
        n1=Convert.ToDouble(Console.ReadLine());
        n2=Convert.ToDouble(Console.ReadLine());
        n3=Convert.ToDouble(Console.ReadLine());
        MediaNumerica(n1,n2,n3);
    }
    static void MediaNumerica(double a, double b, double c)
    {
        double media = (a+b+c)/3;
        Console.WriteLine("A média aritimética dos números é: {0:N2}", media);

    }
}