public class Principal
{
    public static void main(String args[])
    {
        for(int i = 0; i<=2; i++){
            Aluno alu;
            alu = new Aluno("Zezin");
            
            System.out.println("Nome: " + alu.getNome());
            
            alu.setNota(5);
            
            if(alu.estaAprovado()){
                System.out.println(alu.getNome() + " aprovado!");
            }else{
                System.out.println(alu.getNome() + " reprovado!");
            }
        }
    }
}