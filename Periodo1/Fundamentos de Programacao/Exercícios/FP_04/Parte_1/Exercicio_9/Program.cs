/*Para auxiliar os vendedores de uma loja na orientação aos clientes sobre as diversasformas de pagamento, desenvolver um
algoritmo para:
a) Imprimir o seguinte menu:
b) Ler o código da opção de pagamento.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Forma de pagamento:");
        Console.WriteLine(" - À vista.");
        Console.WriteLine(" - Cheque para trinta dias.");
        Console.WriteLine(" - Em duas vezes.");
        Console.WriteLine(" - Em três vezes.");
        Console.WriteLine(" - Em quatro vezes.");
        Console.WriteLine(" - A partir de cinco vezes.");
        Console.Write("Entre com sua opção: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo==1){
            Console.WriteLine("Desconto de 20%");
        }
        else if (codigo == 2 || codigo == 3 || codigo == 4){
            Console.WriteLine("Mesmo preço a vista");
        }
        else if (codigo == 5){
            Console.WriteLine("Juros de 3% ao mês"); 
        }
        else if (codigo == 6){
            Console.WriteLine("Juros de 5% ao mês");
        }
        else{
            Console.WriteLine("Opção inválida");
        }
        }
}