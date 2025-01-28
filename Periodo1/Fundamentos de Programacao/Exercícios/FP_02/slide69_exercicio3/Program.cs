internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Altura em metros:");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Comprimento em metros:");
        double comprimento = Convert.ToDouble(Console.ReadLine());
        Console.Write("Largura em metros:");
        double largura = Convert.ToDouble(Console.ReadLine());

        double volume = altura*comprimento*largura;

        Console.Write("O volume do paralelepípedo é {0:N5}m³",volume);
}
}