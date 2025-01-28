/*Faça um procedimento que receba por parâmetro o tempo de duração de um experimento expresso
em segundos e imprima na tela esse mesmo tempo em horas, minutos e segundos. */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escreva o tempo de duração do experimento em segundos: ");
        int segundos = Convert.ToInt32(Console.ReadLine());
        Console.Write("{0} segundos equivalem a ", segundos);
        ConverterSeg(segundos);
        Console.ReadKey();

    }
    static void ConverterSeg(int seg)
    {
        int horas, minutos;
        minutos = seg/60;
        seg = seg%60;
        horas=minutos/60;
        minutos = minutos%60;
        Console.WriteLine("{0} hora(s), {1} minuto(s) e {2} segundo(s)", horas, minutos, seg);
    }
}