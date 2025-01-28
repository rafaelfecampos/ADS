/*a)Escreva uma função que receba como parâmetros as coordenadas de dois pontos e retorne a distância entre eles.*/
/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escreva as coordenadas do ponto A");
        Console.Write("x1 = ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva as coordenadas do ponto B");
        Console.Write("x2 = ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        double distancia = DistanciaEntrePontos(x1,y1,x2,y2);
        Console.WriteLine("Distancia entre A e B: {0:N2}", distancia);
        Console.ReadKey();
    }
    static double DistanciaEntrePontos(double x1, double y1, double x2, double y2)
    {
        double dist;
        dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
        return dist;
    }
}*/

/*Escreva um programa C# (função principal) que capture do teclado as coordenadas dos 3
vértices de um triângulo, calcule e imprima o perímetro deste triângulo. Este programa deve 
utilizar a função do item anterior.*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dê as coordenadas dos vértices de um triângulo ABC");
        Console.Write("Ax = ");
        double xA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ay = ");
        double yA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Bx = ");
        double xB = Convert.ToDouble(Console.ReadLine());
        Console.Write("By = ");
        double yB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cx = ");
        double xC = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cy = ");
        double yC = Convert.ToDouble(Console.ReadLine());
        double distanciaAB = DistanciaEntrePontos(xA, yA, xB, yB);
        double distanciaBC = DistanciaEntrePontos(xB, yB, xC, yC);
        double distanciaAC = DistanciaEntrePontos(xA, yA, xC, yC);
        double perimetro = distanciaAB + distanciaAC + distanciaBC;
        Console.WriteLine("Perímetro do triângulo: {0:N3}", perimetro);
        Console.ReadKey();
    }
    static double DistanciaEntrePontos(double x1, double y1, double x2, double y2)
    {
        double dist;
        dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        return dist;
    }
}