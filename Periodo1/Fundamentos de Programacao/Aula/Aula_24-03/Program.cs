internal class Program
{
    private static void Main(string[] args)
    {
        string mensagem;
        int qtdeRepeticoes;
        
        Console.Write("Mensagem: ");
        mensagem = Console.ReadLine();

        Console.Write("Qtde de repetições: ");
        qtdeRepeticoes = Convert.ToInt32(Console.ReadLine());

        imprime(mensagem, qtdeRepeticoes);    
    }
    static void imprime(string texto, int qtdeRepeticoes)
    {
        if (qtdeRepeticoes >0)
        {
            Console.WriteLine(texto);
            qtdeRepeticoes=qtdeRepeticoes-1;
            imprime(texto,qtdeRepeticoes);
        }
    }
}