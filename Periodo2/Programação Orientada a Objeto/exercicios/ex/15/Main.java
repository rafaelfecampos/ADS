import java.util.Scanner;

public class Main
{
    static Scanner le = new Scanner(System.in);
    
    public static void main(String[] args)
    {
        TimeFutebol saoPaulo = new TimeFutebol("São Paulo", "São Paulo", "SP");
        Jogador dani = new Jogador("Daniel Alves", 71, 10, 2);
        Jogador thiao = new Jogador("Thiao Volpi", 78, 1, 0);
        saoPaulo.addJogador(dani);  
        saoPaulo.addJogador(thiao);  
        imprimirTime(saoPaulo);
    }
    
    public static void imprimirTime(TimeFutebol t)
    {
        System.out.println("O time " + t.getNome() + " da cidade de "+t.getCidade() + "-"+t.getEstado()+".");
        System.out.println("Tem os seguintes jogadores: ");
        for(Jogador j: t.getJogadores())
        {
            System.out.println("Nome: "+j.getNome()+", massa: "+j.getPeso()+" kg, número: "+j.getNumero()+", posição: "+j.getNomePosicao()+".");
        }
    }
   
}
