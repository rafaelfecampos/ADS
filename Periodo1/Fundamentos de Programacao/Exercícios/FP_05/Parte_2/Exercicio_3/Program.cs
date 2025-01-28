/*Chico tem 1,50 metros e cresce 2 centímetros por ano, enquanto Zé tem 1,40
metros e cresce 3 centímetros por ano. Construa um algoritmo que calcule e
imprima quantos anos serão necessários para que Zé seja maior que Chico*/
internal class Program
{
    private static void Main(string[] args)
    {
        double chico =1.50, ze=1.40;
        int ano=1;
        while(chico>=ze)
        {
            chico=chico+0.02;
            ze=ze+0.03;
            ano++;
            Console.WriteLine("Ano {0}: Chico={1:N2}/Zé={2:N2}",ano,chico,ze);
        }
        Console.WriteLine("Zé levará {0} anos para ser maior que Chico", ano);
    }
}