internal class Program
{
    static double CalcMedia(int n)
    {
        
        int cont, a, soma;
        double media;
        cont=0;
        soma=0;
        while (n > cont)
        {
            Console.Write("Informe um numero inteiro: ");
            a=Convert.ToInt32(Console.ReadLine());
            soma=soma+a;
            cont++;
        }
        Console.WriteLine(cont);
        media= Convert.ToDouble(soma)/cont;
        return media;
    }
    private static void Main(string[] args)
    {  
        Console.Write("Quantidade de numeros a serem informados: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Média aritimética: {0:N2}", CalcMedia(num));
    }
}

/*internal class Program
{
    private static void Main(string[] args)
    {
        int cont, num;
        double soma, media;
        Console.Write("Escreva um numero inteiro diferente de 0: ");
        num = Convert.ToInt32(Console.ReadLine());
        cont=0;
        soma=0;
        while(num!=0)
        {
            if(num % 2==0)
            {
                soma+=num;
                cont++;
            }
            Console.Write("Escreva um numero inteiro diferente de 0: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        media = soma/cont;
        Console.WriteLine("Média aritmética dos numeros inteiros pares informados: {0:N2}", media);
    }
}*/