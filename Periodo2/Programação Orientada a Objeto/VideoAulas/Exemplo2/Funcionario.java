
public class Funcionario
{
    private String nome;
    private double salarioBase, totalVendas;
    private int numeroFilhos;
    private boolean usaVale, trabalhaNoite, ehVendedor;
    private Empresa empresa;
    
    //construtor
    public Funcionario(){   
    }
    public Funcionario(String nome){
        this.nome = nome;
    }
    
    //métodos
    public double salarioLiquido(){
        return salarioBase - inss() + bonusFilhos() - vale()
        + bonusNoite() + bonusVendedor();
    }
    
    public double inss(){
        return salarioBase*0.13;
    }
    
    public double bonusFilhos(){
        return (numeroFilhos <=3)? 50.0*numeroFilhos: 150.00;
    }
    
    public double vale(){
        return (usaVale)? salarioBase*0.03: 0;
    }
    
    public double bonusNoite(){
        return (trabalhaNoite)? salarioBase*0.05: 0;
    }
    
    public double bonusVendedor(){
        return (ehVendedor)? totalVendas*0.02:0;
    }
    
    //set e get
    public void setEmpresa(Empresa empresa){
        this.empresa = empresa;
    }
    public Empresa getEmpresa(){
        return empresa;
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    public String getNome(){
        return nome;
    }
    
    public void setSalarioBase(double salarioBase){
        this.salarioBase = salarioBase;
    }
    public double getSalarioBase(){
        return salarioBase;
    }
    
    public void setTotalVendas(double totalVendas){
        this.totalVendas = totalVendas;
    }
    public double getTotalVendas(){
        return totalVendas;
    }
    
    public void setNumeroFilhos(int numeroFilhos){
        this.numeroFilhos = numeroFilhos;
    }
    public int getNumeroFilhos(){
        return numeroFilhos;
    }
    
    public void setUsaVale(boolean usaVale){
        this.usaVale = usaVale;
    }
    public boolean getUsaVale(){
        return usaVale;
    }
    
    public void setTrabalhaNoite(boolean trabalhaNoite){
        this.trabalhaNoite = trabalhaNoite;
    }
    public boolean getTrabalhaNoite(){
        return trabalhaNoite;
    }
    
    public void setEhVendedor(boolean ehVendedor){
        this.ehVendedor = ehVendedor;
    }
    public boolean getEhVendedor(){
        return ehVendedor;
    }
    
}
