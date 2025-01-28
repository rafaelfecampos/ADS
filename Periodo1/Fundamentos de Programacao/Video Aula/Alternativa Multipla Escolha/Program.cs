/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Trimestre: ");
        int trimestre = Convert.ToInt32(Console.ReadLine());
        switch (trimestre)
        {
            case 1: Console.WriteLine("Verão"); break;
            case 2: Console.WriteLine("Outono"); break;
            case 3: Console.WriteLine("Inverno"); break;
            case 4: Console.WriteLine("Primavera"); break;
            default: Console.WriteLine("Inválido"); break;
        }
    }
}*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Mês: ");
        string mes= Console.ReadLine();
        switch(mes)
        {
            case "janeiro":case "fevereiro": case "março":
                Console.WriteLine("Primeiro trimestre");
                break;
            case "abril": case "maio": case "junho":
                Console.WriteLine("Segundo trimestre");
                break;
            case "julho": case "agosto": case "setembro":
                Console.WriteLine("Terceiro trimestre");
                break;
            case "outubro": case "novembro": case "dezembro":
                Console.WriteLine("Quarto trimestre");
                break;
            default:
                Console.WriteLine("Inválido");
                break;
        }
    }
}