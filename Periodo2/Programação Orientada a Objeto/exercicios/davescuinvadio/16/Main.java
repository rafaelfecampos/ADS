import java.util.Scanner;

public class Main
{
    static Scanner le;
    public static void main(String args[])
    {
        le = new Scanner(System.in);
        Professor prof = constroiProfessor();
        imprimiResultado(prof);
    }

    public static Professor constroiProfessor()
    {
        Professor p = new Professor();
        System.out.println("Qual sua formacao? (g/e/m/d)");
        p.setFormacao(le.next());
        System.out.println("Quantas horas de aulas presenciais você ministra por semana?");
        p.setAulasPresenciais(le.nextInt());
        System.out.println("Quantas horas de aulas EAD você ministra por semana?");
        p.setAulasEad(le.nextInt());
        return p;
    }
    
    public static void imprimiResultado(Professor prof){
        System.out.println("Seu salário mensal será de R$ " + prof.calculaSalario());
    }
}
