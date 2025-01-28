internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa joao = new Pessoa();
        joao.Peso = 98;
        joao.Altura = 1.90;
        Pessoa maria = new Pessoa();
        maria.Peso = 55;
        maria.Altura = 1.50;

        Console.WriteLine("Altura inicializada de João: {0:N2}", joao.Altura);
        joao.Altura = 1.78;
        Console.WriteLine("Altura correta de João: {0:N2}", joao.Altura);

        Console.WriteLine("\nPeso inicializado de Maria: {0}", maria.Peso);
        maria.Peso = 75;
        Console.WriteLine("Peso correto de Maria: {0}", maria.Peso);

        double mediaPeso, mediaAltura;
        mediaPeso = (joao.Peso + maria.Peso) / 2.0;
        mediaAltura = (joao.Altura + maria.Altura) / 2.0;

        Console.WriteLine("\nMédia dos pesos de João e Maria: {0}", mediaPeso);
        Console.WriteLine("Média das alturas de João e Maria: {0:N2}", mediaAltura);
    }
}