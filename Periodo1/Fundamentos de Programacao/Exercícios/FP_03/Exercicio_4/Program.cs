internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe dois números inteiros");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        operacoes(n1, n2);
    }
    static void operacoes(int a, int b)
    {
        int soma, diferenca, produto, quociente, resto;
        soma = a + b;
        diferenca = a - b;
        produto = a * b;
        quociente = a / b;
        resto = a % b;
        Console.WriteLine("Soma: {0}", soma);
        Console.WriteLine("Diferença: {0}", diferenca);
        Console.WriteLine("Produto: {0}", produto);
        Console.WriteLine("Quociente: {0}", quociente);
        Console.WriteLine("Resto: {0}", resto);
        Console.ReadKey();
        
    }
}