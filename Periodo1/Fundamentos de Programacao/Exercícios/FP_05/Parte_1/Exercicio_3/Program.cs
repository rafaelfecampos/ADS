internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Informe um numero inteiro positivo: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num >0)
        {
            if(EhPrimo(num))
            {
                Console.WriteLine("{0} é primo.", num);
            }
            else
            {
                Console.WriteLine("{0} não é primo.", num);
            }
        }
        else{
            Console.WriteLine("Número inválido!");
        }
        
    }

    static bool EhPrimo (int n)
    {
        int i, cont;
        cont=0;
        for( i=1 ; i<=n/2;i++)
        {
            if(n%i==0)
            {
                cont++;
            }
        }
        return (cont==1);//retorna uma condição de verdade
    }
}