/*Utilizando a classe ponto definida no exercício anterior, faça um programa que leia 4 pontos.
Em seguida imprima qual o ponto mais próximo do primeiro ponto lido*/
internal class Program
{
    const int N = 4;
    static void DistanciaPontos(double[] dist, Ponto[] p)
    {
        Console.WriteLine("\nDistância entre os pontos até o ponto 1: ");
        for (int i = 0; i < dist.Length; i++)
        {
            dist[i] = Math.Sqrt(Math.Pow(Convert.ToDouble((p[i+1].X - p[0].X)), 2) + Math.Pow(Convert.ToDouble(p[i+1].Y - p[0].Y), 2));
            Console.WriteLine("-Ponto {0}: {1:N2}", i + 2, dist[i]);
        }
    }
    static void MenorDistancia(double[] dist)
    {
        int menor = 0;
        for (int i = 0; i < dist.Length; i++)
        {
            if(dist[menor]>=dist[i])
            {
                menor=i;
            }
        }
        Console.WriteLine("Ponto que tem a menor distância em relação ao ponto 1: Ponto {0}", menor+2);
    }
    private static void Main(string[] args)
    {
        Ponto[] pontos = new Ponto[N];
        for (int i = 0; i < pontos.Length; i++)
        {
            pontos[i] = new Ponto();
            Console.WriteLine("Escreva as coordenadas do ponto {0}", i + 1);
            Console.Write("X = ");
            pontos[i].X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            pontos[i].Y = Convert.ToInt32(Console.ReadLine());
        }
        double[] distancia = new double[pontos.Length-1];
        DistanciaPontos(distancia, pontos);
       MenorDistancia(distancia);
    }
}