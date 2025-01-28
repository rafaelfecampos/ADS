public class Main {
    public static void main(String[] args) {
        Universidade universidadeEinstein = new Universidade("Princeton");
        Universidade universidadeNewton = new Universidade("Cambridge");


        Pessoa albertEinstein = new Pessoa("Albert Einstein", universidadeEinstein);
        Pessoa isaacNewton = new Pessoa("Isaac Newton", universidadeNewton);


        System.out.println(albertEinstein.getInfoUniversidade());
        System.out.println(isaacNewton.getInfoUniversidade());
    }
}