public class ImovelAntigo extends Imovel
{
    private double descontoEmPorcentagem;
    public ImovelAntigo(String endereco, double preco, double comissaoEmPorcentagem, double desconto)
    {
        super(endereco, preco, comissaoEmPorcentagem);
        descontoEmPorcentagem = desconto;
    }

    public double getPrecoComDesconto(){
        double decimalDoPreco = (100 - descontoEmPorcentagem)/100;
        double precoComDesconto = getPreco()*decimalDoPreco;
        return precoComDesconto;
    }
    
    public double getDescontoEmPorcentagem()
    {
        return descontoEmPorcentagem;
    }
    
    public void setDescontoEmPorcentagem(double descontoEmPorcentagem){
        this.descontoEmPorcentagem=descontoEmPorcentagem;
    }
    
    @Override
    public double getComissaoEmDinheiro(){
        double decimalDaComissao = getComissaoEmPorcentagem()/100;
        return getPrecoComDesconto()*decimalDaComissao;
    }
    
}
