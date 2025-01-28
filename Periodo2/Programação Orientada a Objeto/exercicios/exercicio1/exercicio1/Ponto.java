
/**
 * Escreva uma descrição da classe ponto aqui.
 * 
 * @author (seu nome) 
 * @version (um número da versão ou uma data)
 */
public class Ponto
{
    // variáveis de instância - substitua o exemplo abaixo pelo seu próprio
    private double x1, x2;
    private double y1, y2;

    /**
     * Construtor para objetos da classe ponto
     */
    public Ponto()
    {
        // inicializa variáveis de instância
        double a1 = x1;
        double a2 = x2;
        double b1 = y1;
        double b2 = y2;
    }

    /**
     * Um exemplo de um método - substitua este comentário pelo seu próprio
     * 
     * @param  y   um exemplo de um parâmetro de método
     * @return     a soma de x e y 
     */
    public double distanciaPontos(double xA, double xB, double yA, double yB)
    {
        // escreva seu código aqui
        double distancia;
        distancia = java.lang.Math.sqrt(((xB-xA)*(xB-xA))+((yB-yA)*(yB*yA)));
        return distancia;
    }
}
