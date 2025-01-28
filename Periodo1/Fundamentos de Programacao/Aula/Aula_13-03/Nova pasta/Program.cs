internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite os coeficientes a, b e c da função: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double delta = (b*b-4*a*c);
        if (delta>=0)
        {
            double x1 = (-b+Math.Sqrt(delta))/2*a;
            double x2 = (-b-Math.Sqrt(delta))/2*a;
            Console.WriteLine("Raízes: {0}, {1}", x1,x2);
        }
        else
        {
            Console.WriteLine("Não existem raízes reais na equação");
        }
    }
}