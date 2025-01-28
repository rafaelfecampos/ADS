//Fazer um algoritmo que imprima todos os numeros de 100 ate 1

internal class Program
{
    private static void Main(string[] args)
    {
        int cont = 100;
        while(cont>0)
        {
            Console.Write("{0} ",cont);
            cont--;
        }
    }
}