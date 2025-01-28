public class Pessoa {
    private String nome;
    private Universidade universidade;

    public Pessoa(String nome, Universidade universidade) {
        this.nome = nome;
        this.universidade = universidade;
    }

    public String getNome() {
        return nome;
    }

    public String getInfoUniversidade(){
        return nome + "trabalha na Universidade de " + universidade.getNome();
    }
}
