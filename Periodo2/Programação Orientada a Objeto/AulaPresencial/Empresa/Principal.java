public class Principal
{
    public static void main(String args[])
    {
        System.out.println("### EMPRESA XPTO ###");
        
        Funcionario f = new Funcionario ("Zezin", 800, true, false, 8);
        
        f.setNome("Pedrin");
        
        System.out.println("# Funcionario: "+f.getNome() + "\nSalario: R$" + f.salarioLiquido());        
    }
}