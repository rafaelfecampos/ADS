
//Divida 10000 reais. Juros 2,5% ao mes. Aplicação de 1500 reais com rendemimento de 4% ao mes.
// Fazer um algoritmo que determina o numero de meses necessario para pagar a divida
internal class Program
{
    private static void Main(string[] args)
    {
        double divida, aplicacao;
        divida = 10000;
        aplicacao = 1500;
        int cont = 0;
        Console.Write("Mês {0}: ", cont);
        Console.WriteLine("Divida=R${0:N2}, Aplicação=R${1:N2}", divida, aplicacao);
        while (divida > aplicacao)
        {
            divida = divida + divida *0.025;
            aplicacao = aplicacao + aplicacao * 0.04;
            cont++;
            Console.Write("Mês {0}: ", cont);
            Console.WriteLine("Divida=R${0:N2}, Aplicação=R${1:N2}", divida, aplicacao);
        }
        Console.WriteLine("Será necessário {0} meses para pagar a dívida.", cont);
    }
}