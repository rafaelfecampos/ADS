public class Main
{
    //Leitura e Escrita
    public static void main(String args[]){
        System.out.println("### NOTAS ######");
        
        Aluno a1, a2;
        
        a1 = new Aluno("Pedrin", 8.5);
        a2 = new Aluno("Zezin", 7.5);
        
        if (a1.isAprovado()){
            System.out.println(a1.nome+" esta aprovado");
        }else{
            System.out.println(a1.nome+" esta reprovado");
        }
        if (a2.isAprovado()){
            System.out.println(a2.nome+" esta aprovado");
        }else{
            System.out.println(a2.nome+" esta reprovado");
        }
    }
}