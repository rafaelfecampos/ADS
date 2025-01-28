/*Faça um programa que leia os valores dos lados e altura de um triângulo, calcule e imprima seu perímetro e área.*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe os dados de um triângulo isóceles");

        Console.Write("Base: ");
        double baseT = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lados: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        double altura = Math.Sqrt((lado * lado) - ((baseT / 2) * (baseT / 2)));
        Console.WriteLine("Altura:{0}", altura);

        Console.WriteLine();

        double perimetro = lado + lado + baseT;
        double area = (baseT * altura) / 2;

        Console.WriteLine("Perímetro: {0}", perimetro);
        Console.WriteLine("Área: {0}", area);
    }
}