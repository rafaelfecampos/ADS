internal class Program
{
    static void Main(string[] args)
    {
        int minutos;
        Console.Write("Minutos totais: ");
        minutos=Convert.ToInt32(Console.ReadLine());
        Console.Write("{0} minutos equivale a ", minutos);
        ConversaoEmHoras(minutos);
    }
    static void ConversaoEmHoras(int min)
    {
        int horas;
        horas=min/60;
        min=min%60;
        Console.Write("{0}:{1}", horas, min);
    }
}