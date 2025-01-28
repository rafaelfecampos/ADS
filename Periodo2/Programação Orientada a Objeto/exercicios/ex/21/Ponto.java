
public class Ponto
{
    private double x;
    private double y;

    public Ponto()
    {
    }
    
    public Ponto(double px, double py)
    {
        this.x=px;
        this.y=py;
    }
    
    public void setX(double px){
        this.x = px;
    }
    
    public double getX(){
         return this.x;   
    }
    
    public void setY(double py){
        this.y = py;
    }
    
    public double getY(){
         return this.y;   
    }
}
