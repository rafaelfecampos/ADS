/*Considere as equações de movimento para calcular a posição (s) e velocidade (v) de uma partícula em um
determinado instante t, dado sua aceleração a, posição inicial s0 e velocidade inicial v0, de acordo com as fórmulas:
s = s0 + v0*t + (a * t * t)/2
v = v0 + a*t
Escreva um programa C# completo que capture os valores de s0, v0, a e t, fornecidos pelo usuário via teclado, e calcule
e imprima os valores de s e v.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Forneça os dados pedidos");
        Console.Write("s0 = ");
        double s0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("v0 = ");
        double v0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("t = ");
        double t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        double s = funcaoHoraria(s0, v0, a, t);
        double v = funcaoVelocidade(v0, a, t);

        Console.WriteLine("Resultados");
        Console.WriteLine("s = {0:N2}m", s);
        Console.WriteLine("v = {0:N2}m/s", v);
        Console.ReadKey();
    }
    static double funcaoHoraria(double s0, double v0, double a, double t)
    {
        double distancia;
        distancia = s0 + v0 * t + (a * t * t) / 2;
        return distancia;
    }
    static double funcaoVelocidade(double v0, double a, double t)
    {
        double velocidade;
        velocidade = v0 + a * t;
        return velocidade;
    }
}