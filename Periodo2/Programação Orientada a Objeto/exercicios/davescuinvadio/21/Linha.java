
public class Linha
{
    private Ponto inicial;
    private Ponto pFinal;
    public Linha(Ponto i, Ponto f)
    {
        this.inicial = i;
        this.pFinal = f;
    }
    
    public double calculaTamanhoLinha()
    {
        double x = pFinal.getX() - inicial.getX();
        double y = pFinal.getY() - inicial.getY();
        double distancia = Math.sqrt((Math.pow(x, 2)) + Math.pow(y, 2));
        return distancia;
    }
    
    public boolean  ehVertical()
    {
        if(pFinal.getX()==inicial.getX())
        {
            return true;
        }else{
            return false;
        }
    }
    
    public boolean  ehHorizontal()
    {
        if(pFinal.getY()==inicial.getY())
        {
            return true;
        }else{
            return false;
        }
    }
}
