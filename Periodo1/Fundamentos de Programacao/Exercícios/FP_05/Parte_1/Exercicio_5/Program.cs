internal class Program
{
    private static void Main(string[] args)
    {
        double s=0;
        double div =50;
        int i;
        for(i=1;i<=25;i++)
        {
            s=s+(Math.Pow(2,i))/div;
            div-=2;
        }
            Console.Write("S = 2/50+(2^2)/48+(2^3)/46+...+(2^25)/2={0}",s);
    }
}