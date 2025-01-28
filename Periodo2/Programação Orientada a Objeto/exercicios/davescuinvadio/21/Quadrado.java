public class Quadrado
{
    private Linha verticalUm;
    private Linha verticalDois;
    private Linha horizontalUm;
    private Linha horizontalDois;
    
    public Quadrado(Linha vUm, Linha vDois, Linha hUm, Linha hDois)
    {
        this.verticalUm = vUm;
        this.verticalDois = vDois;
        this.horizontalUm = hUm;
        this.horizontalDois = hDois;
    }
    
    public double calculaPerimetro()
    {
        double perimetro = verticalUm.calculaTamanhoLinha()+verticalDois.calculaTamanhoLinha()
        +horizontalUm.calculaTamanhoLinha()+horizontalDois.calculaTamanhoLinha();
        return perimetro;
    }
}
