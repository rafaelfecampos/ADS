/*Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um programa que calcule seu peso ideal,
utilizando as seguintes fórmulas:
para homens: (72.7*h)-58
para mulheres: (62.1*h)-44.7*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Sexo (M ou F):");
        string sexo = Console.ReadLine();
        
        if(sexo == "M"){
            double pesoideal= (72.7*altura)-58;
            Console.WriteLine("Peso ideal: {0}", pesoideal);
        }
        else{
            double pesoideal =(62.1*altura)-44.7;
            Console.WriteLine("Peso ideal: {0}", pesoideal);
        }
        Console.ReadKey();
        }
}