import java.util.Scanner;
import java.util.ArrayList;

public class Main
{
    
    static Scanner le = new Scanner(System.in);
    public static void main(String args[]) {
        Corretor c = cadastrarCorretor();
        while(true){
            String op = menu();
            if(op.equals("S"))
            {
                Imovel i = cadastrarImovel(c);
                c.addImovel(i);
            } 
            else
            {
                break;
            } 
        }
    }

    public static Corretor cadastrarCorretor()
    {
        Corretor c = new Corretor();
        System.out.println("## Nome do Corretor: ");
        c.setNome(le.nextLine());
        System.out.println("## Idade do Corretor: ");
        c.setIdade(le.nextInt());
        return c;
    }
    
     public static Imovel cadastrarImovel(Corretor c)
    {
        Imovel i;
        System.out.println("Qual o endereço do imóvel?");
        String endereco = le.nextLine();
        le.nextLine();
        System.out.println("Qual o preço do imóvel?");
        double preco = le.nextDouble();
        System.out.println("Qual a comissão em porcentagem?");
        double comissaoEmPorcentagem = le.nextDouble();
        System.out.println("Qual o tipo de imóvel? (A)ntigo ou (N)ovo ");
        String tipo = le.next().toUpperCase();
        le.nextLine();
        if(tipo.equals("A"))
        {
            System.out.println("Qual o desconto do imóvel em porcentagem?");
            i = new ImovelAntigo(endereco, preco, comissaoEmPorcentagem, le.nextDouble());
            System.out.println("Sua comissão pela venda deste imóvel é R$ "+i.getComissaoEmDinheiro());
        }
        else
        {
            i = new Imovel(endereco, preco, comissaoEmPorcentagem);
            System.out.println("Sua comissão pela venda deste imóvel é R$ "+i.getComissaoEmDinheiro());
        }
        return i;
    }
    
     public static String menu()
    {
        System.out.println("############# MENU ##############");
        System.out.println("## 1 - Deseja cadastrar um imóvel? (s)im ou (n)ão");
        return le.next().toUpperCase();
    }
}
