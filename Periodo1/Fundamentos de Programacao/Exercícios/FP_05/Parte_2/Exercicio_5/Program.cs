internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um valor N inteiro positivo: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i,aux=1;
        double e=0;
        if(n>0)
        {
            for(i=0; i<=n; i++)
            {
                aux=aux*i;
                Console.WriteLine(aux);
                Console.WriteLine(i);

            }
        }
    }
}