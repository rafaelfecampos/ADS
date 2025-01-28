

public class Imovel
{
    private String endereco;
    private double preco;
    private double comissaoEmPorcentagem;
    
    public Imovel(String endereco, double preco, double comissao)
    {
        this.endereco = endereco;
        this.preco = preco;
        this.comissaoEmPorcentagem = comissao;
    }
    
    public Imovel()
    {
    }

    public String getEndereco()
    {
        return endereco;
    }
    
    public void setEndereco(String endereco){
        this.endereco=endereco;
    }
    
    public double getPreco()
    {
        return preco;
    }
    
    public void setPreco(double preco){
        this.preco=preco;
    }
    
    public double getComissaoEmPorcentagem()
    {
        return comissaoEmPorcentagem;
    }
    
    public void setComissaoEmPorcentagem(double comissaoEmPorcentagem){
        this.comissaoEmPorcentagem=comissaoEmPorcentagem;
    }
    
    public double getComissaoEmDinheiro(){
        double decimalDaComissao = comissaoEmPorcentagem/100;
        return preco*decimalDaComissao;
    }
}
