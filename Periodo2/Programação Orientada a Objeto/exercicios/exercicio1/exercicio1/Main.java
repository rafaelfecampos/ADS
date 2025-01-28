public class Main
{
    public static void main(String args[])
    {
        Ponto ponto = new Ponto();
        double x1 = 5, x2 = 5;
        System.out.println("# Ponto X: "+x1+", "+x2);
        double y1 = 8, y2 = 8;
        System.out.println("# Ponto Y: "+y1+", "+y2);
        
        System.out.println("# Distancia pontos: "+ponto.distanciaPontos(x1,x2,y1,y2));
        
    }   
}
