import java.util.ArrayList;

public class Corretor
{
    private String nome;
    private int idade;
    private ArrayList<Imovel> imoveis;
    public Corretor()
    {
        imoveis = new ArrayList<>();
    }
    
    public Corretor(String nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
        imoveis = new ArrayList<>();
    }

    public String getNome()
    {
        return nome;
    }
    
    public void setNome(String nome){
        this.nome=nome;
    }
    
    public int getIdade()
    {
        return idade;
    }
    
    public void setIdade(int idade){
        this.idade=idade;
    }
    
    public ArrayList<Imovel> getImoveis()
    {
        return imoveis;
    }
    
    public void addImovel(Imovel i){
        imoveis.add(i);
    }
}
