import java.util.Scanner;
public class Principal
{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        Empresa emp = new Empresa("");
        Funcionario func = new Funcionario();
        emp.addFuncionario(func);
        
        emp.getFuncionarios().get(0);
        
        System.out.println("Informe seu nome: ");
        func.setNome(ler.next());
    }
}
