using ListaCircular;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaCircu lista = new ListaCircu();
        lista.AdicionarNoInicio(1);
        lista.AdicionarNoInicio(2);
        lista.AdicionarNoInicio(3);
        lista.AdicionarNoInicio(4);
        lista.AdicionarNoInicio(5);

        lista.AdicionarNoFinal(0);
        lista.AdicionarNoFinal(-1);

        Console.Write("Lista: ");
        Imprimir(lista);

        Console.WriteLine("Tamanho da lista: {0}", lista.Tamanho);
        Console.WriteLine("Primeiro elemento da lista: {0}", lista.Primeiro.Valor);
        Console.WriteLine("Ultimo elemento da lista: {0}", lista.Ultimo.Valor);
        Console.Write("Valor do elemento anterior ao elemento de valor 3: ");
        Console.WriteLine((lista.Localizar(3).Anterior != null) ? lista.Localizar(3).Anterior.Valor : "###Erro: Elemento nulo!!!###");
        lista.RemoverFinal();
        lista.RemoverFinal();
        lista.RemoverInicio();
        lista.RemoverInicio();

        Console.WriteLine();
        
        Console.Write("Lista: ");
        Imprimir(lista);

        Console.WriteLine("Tamanho da lista: {0}", lista.Tamanho);
        Console.WriteLine("Primeiro elemento da lista: {0}", lista.Primeiro.Valor);
        Console.WriteLine("Ultimo elemento da lista: {0}", lista.Ultimo.Valor);
        Console.Write("Valor do elemento anterior ao elemento de valor 3: ");
        Console.WriteLine((lista.Localizar(3).Anterior != null) ? lista.Localizar(3).Anterior.Valor : "###Erro: Elemento nulo!!!###");

        Console.WriteLine();

        lista.Primeiro = lista.Localizar(1);
        lista.Ultimo = lista.Localizar(1).Anterior;
        Console.Write("Lista: ");
        Imprimir(lista);

        Console.WriteLine("Tamanho da lista: {0}", lista.Tamanho);
        Console.WriteLine("Primeiro elemento da lista: {0}", lista.Primeiro.Valor);
        Console.WriteLine("Ultimo elemento da lista: {0}", lista.Ultimo.Valor);
        Console.Write("Valor do elemento anterior ao elemento de valor 3: ");
        Console.WriteLine((lista.Localizar(3).Anterior != null) ? lista.Localizar(3).Anterior.Valor : "###Erro: Elemento nulo!!!###");
    }

    private static void Imprimir(ListaCircu lista)
    {
        var atual = lista.Primeiro;
        
        do
        {
            Console.Write("{0,3}", atual.Valor);
            atual = atual.Proximo;
        }while (atual!= lista.Primeiro);
        Console.WriteLine();
    }
}