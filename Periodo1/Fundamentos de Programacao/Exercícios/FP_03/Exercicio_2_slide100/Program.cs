/*Faça uma função que receba por parâmetro o raio de uma esfera e calcule o seu volume:
v = (4 * PI * R3) /3.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Raio da esfera em metros:");
        double raio = Convert.ToDouble(Console.ReadLine());
        double volume = CalculoVol(raio);
        Console.WriteLine("Volume: {0:N2}m³", volume);
        Console.ReadKey();
    }
    static double CalculoVol(double r)
    {
        double v=(4*Math.PI*(Math.Pow(r,3)))/3;
        return v;
    }
}