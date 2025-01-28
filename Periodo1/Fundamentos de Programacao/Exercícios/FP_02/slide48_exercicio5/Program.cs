//Construa um programa que aplique um desconto de 25% sobre o preço de um produto recebido como entrada e imprima o valor resultante.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor do produto: R$");
        double preco = Convert.ToDouble(Console.ReadLine());
        preco=preco-(0.25*preco);

        Console.WriteLine("O preço final do produto é: R${0:N2}", preco);
    }
}