public class Jogador extends Atleta
{
    private int numero; 
    private int posicao;

    public Jogador(String nome, double peso)
    {
        super(nome, peso);
    }
    
    public Jogador(String nome, double peso, int numero, int posicao)
    {
        super(nome, peso);
        this.numero = numero;
        this.posicao = posicao;
    }
    
    public int getNumero()
    {
       return numero; 
    }
    
    public void setNumero(int numero)
    {
        this.numero = numero;
    }
    
    public int getPosicao()
    {
       return posicao; 
    }
    
    public void setPosicao(int posicao)
    {
        this.posicao = posicao;
    }
    
    public String getNomePosicao()
    {
        if(posicao==0)
        {
            return "goleiro";
        } else if(posicao==1)
        {
            return "zaga";
        } else if(posicao==2)
        {
            return "meio-campo";
        } else {
            return "ataque";
        }
    }
}
