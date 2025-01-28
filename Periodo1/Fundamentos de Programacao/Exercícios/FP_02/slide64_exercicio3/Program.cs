/*Programa que recebe segundos e converte em horas, minutos e segundos.*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor do produto: R$");
        double valorProduto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do desconto: R$ ");
        double valorDesconto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor final do produto: R${0:N2}", valorProduto = valorProduto - valorDesconto);
        Console.ReadKey();
    }
}