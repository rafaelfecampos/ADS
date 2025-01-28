internal class Program
{
    static void Main(string[] args)
    {
        double cels;
        double fahr;

        Console.Write("Temperatura em Celsius:");
        cels = Convert.ToDouble(Console.ReadLine());

        fahr = CelsiusFahrenheit(cels);

        Console.Write("Temperatura em Fahrenheit:");
        Console.Write(fahr);
    }
    static double CelsiusFahrenheit(double tc)
    {
        double tf;
        tf = 1.8*tc+32;
        return tf;
    }
}