internal class Program
{
    private static void Main(string[] args)
    {
        Cartao cartao1 = new Cartao();
        cartao1.numero="4523562413858461";
        cartao1.nome="Willian da Silva Júnior";
        cartao1.validade="03/25";
        cartao1.codigo_seguranca=123;

        Cartao cartao2 = new Cartao();
        cartao2.numero="1234567887654321";
        cartao2.nome="Carlos Cardoso Oliveira";
        cartao2.validade="12/24";
        cartao2.codigo_seguranca=321;

        Console.WriteLine("Dados cartão 2:");
        Console.WriteLine("   Número: {0}", cartao2.numero);
        Console.WriteLine("   Nome: {0}", cartao2.nome);       
        Console.WriteLine("   Validade: {0}", cartao2.validade);       
        Console.WriteLine("   Código de segurança: {0}", cartao2.codigo_seguranca);       
    }
}