internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escreva os pontos dos vértices de um triângulo: ");
        Console.Write("xA: ");
        double xA = Convert.ToDouble(Console.ReadLine());
        Console.Write("yA: ");
        double yA = Convert.ToDouble(Console.ReadLine());
        Console.Write("xB: ");
        double xB = Convert.ToDouble(Console.ReadLine());
        Console.Write("yA: ");
        double yB = Convert.ToDouble(Console.ReadLine());
        Console.Write("xC: ");
        double xC = Convert.ToDouble(Console.ReadLine());
        Console.Write("yC: ");
        double yC = Convert.ToDouble(Console.ReadLine());
        double retaAB = distanciaPontos(xA, yA, xB, yB);
        double retaAC = distanciaPontos(xA, yA, xC, yC);
        double retaBC = distanciaPontos(xB, yB, xC, yC);
        double perimetro = retaAB + retaAC + retaBC;
        Console.WriteLine("Perímetro do triângulo: {0:N2}", perimetro);
        Console.ReadKey();
    }
    static double distanciaPontos( double x1, double y1, double x2, double y2)
    {
        double distancia;
        distancia = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        return distancia;
    }
}