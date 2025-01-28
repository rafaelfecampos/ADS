/*Faça uma função que receba a idade de uma pessoa em anos, meses e dias e retorne essa idade
expressa em dias.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a sua idade em");
        Console.Write("Anos: ");
        int anos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Meses: ");
        int meses = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dias: ");
        int dias = Convert.ToInt32(Console.ReadLine());
        int diasTotal = converterEmDias(anos, meses, dias);
        Console.WriteLine();
        Console.Write("{0} ano(s), {1} mes(es) e {2} dia(s) equivale(m) a {3} dia(s) vividos", anos, meses, dias, diasTotal);
    }
    static int converterEmDias(int x, int y, int z)
    {
        int diasT;
        diasT = x * 365 + y * 365 + z;
        return diasT;
    }
}