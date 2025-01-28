internal class Program
{
    const int N = 3;
    static void LeIngressos(Ingresso[] ingresso)
    {
        for (int i =0; i<ingresso.Length;i++)
        {
            Console.WriteLine("Ingresso {0}: ", i+1);
            ingresso[i]=new Ingresso();
            Console.Write("   Preço: R$");
            ingresso[i].Preco=Convert.ToDouble(Console.ReadLine());
            Console.Write("   Local: ");
            ingresso[i].Local=Console.ReadLine();
            Console.Write("   Atração: ");
            ingresso[i].Atracao=Console.ReadLine();
        }
    }
    static void VerificaMaisCaro(Ingresso[] ingresso)
    {
        int maior=0;
        for(int i=0; i<ingresso.Length;i++)
        {
            if(ingresso[maior].Preco<=ingresso[i].Preco)
            {
                maior=i;
            }
        }
        Console.WriteLine("\nEvento do ingresso mais caro: {0}", maior+1);
        Console.WriteLine("Atracao do ingresso mais caro: {0}", ingresso[maior].Atracao);
        Console.WriteLine("Local do ingresso mais caro: {0}", ingresso[maior].Local);
    }
    static void VerificaMaisBarato(Ingresso[] ingresso)
    {
        int menor=0;
        for(int i=0; i<ingresso.Length;i++)
        {
            if(ingresso[menor].Preco>=ingresso[i].Preco)
            {
                menor=i;
            }
        }
        Console.WriteLine("\nEvento do ingresso mais barato: {0}", menor+1);
        Console.WriteLine("Atracao do ingresso mais caro: {0}", ingresso[menor].Atracao);
        Console.WriteLine("Local do ingresso mais barato: {0}", ingresso[menor].Local);
    }
    private static void Main(string[] args)
    {
        Ingresso[] ingressos = new Ingresso[N];
        LeIngressos(ingressos);
        VerificaMaisCaro(ingressos);
        VerificaMaisBarato(ingressos);
    }
}