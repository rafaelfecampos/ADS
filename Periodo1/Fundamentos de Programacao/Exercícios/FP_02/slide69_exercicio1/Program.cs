internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, soma, sub, div, mult;

        Console.Write("Insira um número: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira outro número: ");
        b = Convert.ToDouble(Console.ReadLine());

        soma = a + b;
        sub = a - b;
        div = a / b;
        mult = a * b;

        Console.WriteLine("Adição: {0} + {1} = {2}", a, b, soma);
        Console.ReadKey();
        Console.WriteLine("Subtração: {0} - {1} = {2}", a, b, sub);
        Console.ReadKey();
        Console.WriteLine("Divisão: {0}/{1} = {2:N3}", a, b, div);
        Console.ReadKey();
        Console.WriteLine("Multiplicação: {0} x {1} = {2}", a, b, mult);
        Console.ReadKey();
    }
}