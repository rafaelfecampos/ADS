/*Faça uma função que receba dois números reais, a e b, e retorne o valor de ( A² + B² )^(1/2).
Observação: para calcular a raiz quadrada será preciso utilizar a função Math.Sqrt().*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("A = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        double b = Convert.ToDouble(Console.ReadLine());
        double raiz = raizquadrada(a, b);
        Console.Write("(A²+B²)^(1/2) = {0:N3}", raiz);
    }
    static double raizquadrada(double x, double y)
    {
        double rquadrada;
        rquadrada = Math.Sqrt((Math.Pow(x,2)+Math.Pow(y,2)));
        return rquadrada;
    }
}