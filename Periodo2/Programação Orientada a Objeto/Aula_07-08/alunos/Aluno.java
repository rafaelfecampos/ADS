public class Aluno
{
    //Atributos
    String nome;
    double nota;
    
    //Metodo Construtor
    //mesmo nome da classe
    //nao tem retorno
    Aluno(String vNome, double vNota){
        nome = vNome;
        nota = vNota;
    }
    //metodos
    boolean isAprovado(){
        return (nota >= 7); //retorna true ou false de acordo com a condiçao (nota >= 7)
    }
}