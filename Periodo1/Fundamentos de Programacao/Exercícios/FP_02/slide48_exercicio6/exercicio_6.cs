/*Construa um programa para ler um intervalo de tempo em segundos, converter para horas, minutos e segundos e imprimir o resultado.*/
internal class Program
{
    private static void Main(string[] args)
    {
        int segundos, segundosTotal, minutos, horas;
        Console.Write("Insira o tempo em segundos:");

        segundos = Convert.ToInt32(Console.ReadLine());
        segundosTotal = segundos;
        minutos = segundos / 60;
        segundos = segundos % 60;
        horas = minutos / 60;
        minutos = minutos % 60;

        Console.WriteLine("{0} segundos equivale a {1} hora(s), {2} minuto(s) e {3} segundo(s)", segundosTotal, horas, minutos, segundos);
        Console.ReadKey();
    }
}