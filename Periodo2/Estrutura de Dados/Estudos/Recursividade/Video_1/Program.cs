//multiplicação por recursividade
/*class Program
{
    public static int Multiplicar(int m, int n)
    {
        int a;
        if(n == 0) //condição de parada
            return 0;
        else
            a = m + Multiplicar(m, n-1);
            Console.WriteLine(a);
            return a;
            //return m + Multiplicar(m, n-1);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Multiplicar(3,100));
    }
}*/

//Fatorial por recursividade
class Program
{
    public static int Fatorar(int n)
    {
        if(n == 0) //condição de parada
            return 1;
        else
            return n*(Fatorar(n-1));
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Fatorar(4));
    }
}