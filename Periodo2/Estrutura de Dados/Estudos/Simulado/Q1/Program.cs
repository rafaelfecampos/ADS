internal class Program
{
    private static void Main(string[] args)
    {
        ImprimeIntervalo(60);
    }

    static void ImprimeIntervalo(int n)
    {
        ImprimeIntervalo(0, n);
 
        // if(n!=0){ //ordem decrescente 
        //     if(n%2==0 && n%3==0){
        //         Console.WriteLine($"{n}");
        //         ImprimeIntervalo(n-1);
        //     }
        //     else
        //         ImprimeIntervalo(n-1);
        // }else{
        //     Console.WriteLine(0);
        // }
    }

    static void ImprimeIntervalo(int current, int n){ //ordem crescente
        if(current <= n){
            if(current%2==0 && current%3==0){
                Console.WriteLine(current);
            }
            ImprimeIntervalo(current+1,n);
        }
        
    }
}