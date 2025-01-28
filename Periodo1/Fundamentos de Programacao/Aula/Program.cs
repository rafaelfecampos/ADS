internal class Program
{
    private static void Main(string[] args)
    {
        /*programa de calculo de área de um circulo*/
        double raio;
        double area;

        Console.Write("Informe o raio do circulo:");
        raio = Convert.ToDouble(Console.ReadLine()); //raio do circulo
        area = 3.14159*raio*raio; //área do circulo

        Console.WriteLine("A área é {0}", area);
        }
}