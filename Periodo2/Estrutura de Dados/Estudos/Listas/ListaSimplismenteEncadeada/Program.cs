using ListaSimplismenteEncadeada;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaEncadeada lista = new ListaEncadeada();

        

        lista.AdicionarNoInicio(1);
        Console.WriteLine(lista.Primeiro.Valor);

        lista.AdicionarNoInicio(2);
        Console.WriteLine(lista.Primeiro.Valor);

        lista.AdicionarNoFinal(3);

        Imprimir(lista);
        
        lista.RemoverInicio();
        Imprimir(lista);

        lista.RemoverFinal();
        Imprimir(lista);
    }

    private static void Imprimir(ListaEncadeada lista)
    {
        No aux = lista.Primeiro;

        Console.Write("Lista: ");

        while(aux!= null){
            Console.Write("{0,3}", aux.Valor);
            aux = aux.Proximo;
        }

        Console.WriteLine();
    }
}