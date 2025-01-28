/*Faça um programa que leia 3 comprimentos (x, y e z) e responda se eles formam um triângulo, ou seja,
se x < y + z e y < x + z e z < x + y.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe os três comrpimentos de um triângulo: ");
        double x = ladotriangulo("Lado X");
        double y = ladotriangulo("Lado Y");
        double z = ladotriangulo("Lado Z");
        
        if(x<y+z && y<x+z && z<x+y){
            Console.WriteLine("Triângulo existente");
        }
        else{
            Console.WriteLine("Triângulo inexistente");
        }
    }
    static double ladotriangulo(string lado)
    {
        Console.Write("{0}: ", lado);
        double comprimento = Convert.ToDouble(Console.ReadLine());
        return comprimento;
    }
}