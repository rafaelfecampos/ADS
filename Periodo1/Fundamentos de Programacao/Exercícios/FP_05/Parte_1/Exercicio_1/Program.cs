//imrpimir todos os numeros pares de 1 a 100
internal class Program
{
    private static void Main(string[] args)
    {
        int cont = 100;
        while (cont > 0)
        {
            if (cont % 2 ==0)
            {
                Console.Write("{0}  ",cont);
            }
            cont--;
        }
    }
}