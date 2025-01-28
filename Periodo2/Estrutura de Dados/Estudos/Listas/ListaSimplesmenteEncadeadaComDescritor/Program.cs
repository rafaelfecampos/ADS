using ListaSimplesmenteEncadeadaComDescritor;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaEncadeada lista = new ListaEncadeada();

        lista.AdicionarNoInicio(1);
        lista.AdicionarNoInicio(2);
        lista.AdicionarNoInicio(3);
        lista.AdicionarNoInicio(4);
        lista.AdicionarNoInicio(5);

        lista.AdicionarNoFinal(0);
        lista.AdicionarNoFinal(-1);

        Imprimir(lista);

        Console.WriteLine("Tamanho da lista: {0}", lista.Tamanho);
        Console.WriteLine("Primeiro elemento da lista: {0}", lista.Primeiro.Valor);
        Console.WriteLine("Ultimo elemento da lista: {0}", lista.Ultimo.Valor);

        lista.RemoverFinal();
        lista.RemoverFinal();
        lista.RemoverInicio();
        lista.RemoverInicio();

        Console.WriteLine();
        Imprimir(lista);

        Console.WriteLine("Tamanho da lista: {0}", lista.Tamanho);
        Console.WriteLine("Primeiro elemento da lista: {0}", lista.Primeiro.Valor);
        Console.WriteLine("Ultimo elemento da lista: {0}", lista.Ultimo.Valor);
    }

    private static void Imprimir(ListaEncadeada lista)
    {
        var atual = lista.Primeiro;
        Console.Write("Lista: ");
        while(atual != null){
            Console.Write("{0,3}", atual.Valor);
            atual = atual.Proximo;
        }
        Console.WriteLine();
    }
}