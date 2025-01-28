/*Crie uma classe chamada ponto contendo apenas as coordenadas x e y (inteiros) do ponto. Declare 2 pontos, leia
as coordenadas x e y de cada um e calcule a distância entre eles Apresente no final a distância entre os dois pontos*/
internal class Program
{
    private static void Main(string[] args)
    {
        Ponto[] pontos = new Ponto[2];
        for (int i = 0; i < pontos.Length; i++)
        {
            pontos[i] = new Ponto();
            Console.WriteLine("Escreva as coordenadas do ponto {0}", i + 1);
            Console.Write("X = ");
            pontos[i].X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            pontos[i].Y = Convert.ToInt32(Console.ReadLine());
        }
        double distancia;
        distancia = Math.Sqrt(Math.Pow(Convert.ToDouble((pontos[1].X - pontos[0].X)), 2) + Math.Pow(Convert.ToDouble(pontos[1].Y - pontos[0].Y), 2));
        Console.WriteLine("\nDistância entre os pontos: {0:N2}",distancia);
    }
}