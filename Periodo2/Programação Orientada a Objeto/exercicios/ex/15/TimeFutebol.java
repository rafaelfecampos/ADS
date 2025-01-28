import java.util.ArrayList;

public class TimeFutebol
{   
    private String nome; 
    private String cidade; 
    private String estado;
    private ArrayList<Jogador> jogadores;
    
    public TimeFutebol()
    {
        this.jogadores = new ArrayList<>();
    }

    public TimeFutebol(String nome, String cidade, String estado)
    {
        this.nome = nome;
        this.cidade = cidade;
        this.estado = estado;
        this.jogadores = new ArrayList<>();
    }
    
    public ArrayList<Jogador> getJogadores(){
        return jogadores;
    }
    
    public void addJogador(Jogador j){
        if(jogadores.size()<11)
        {
            jogadores.add(j);        
        }
    }
    
    public String getNome()
    {
       return nome; 
    }
    
    public void setNome(String nome)
    {
        this.nome = nome;
    }
    
    public String getCidade()
    {
       return cidade; 
    }
    
    public void setCidade(String cidade)
    {
        this.cidade = cidade;
    }
    
    public String getEstado()
    {
       return estado; 
    }
    
    public void setEstado(String estado)
    {
        this.estado = estado;
    }
}
