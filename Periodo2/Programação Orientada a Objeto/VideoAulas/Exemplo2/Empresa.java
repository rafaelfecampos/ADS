import java.util.ArrayList;
public class Empresa
{
    private String nome;
    private ArrayList<Funcionario> funcionario;
    //construtor
    public Empresa(String nome){
        this.nome = nome;
        funcionario = new ArrayList<>();
    }
    
    //set nome empresa
    public void setNome(String nome){
        this.nome = nome;
    }
    public String getNome(){
        return nome;
    }
    
    public double folhaPagamento(){
        double salTotal = 0;
        for(int i = 0; i<funcionario.size(); i++){
            Funcionario f = funcionario.get(i);//simplifcação
            
            salTotal+=f.salarioLiquido();
        }
        return salTotal;
    }
    
    //get funcionarios
    public ArrayList<Funcionario> getFuncionarios(){
        return funcionario;
    }
    
    //"set" funcionarios (add e remove)
    public void addFuncionario(Funcionario func){
        this.funcionario.add(func);
    }
    public void removeFuncionario(Funcionario func){
        this.funcionario.remove(func);
    }
    public void removeFuncionario(int idx){
        if(idx >= 0 && idx < funcionario.size())
            this.funcionario.remove(idx);
    }
}
