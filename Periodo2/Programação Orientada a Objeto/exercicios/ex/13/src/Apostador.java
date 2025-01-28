public class Apostador {
    private String nome;
    private int numeroCartao;
    private String respostas;

    public Apostador(String nome, int numeroCartao, String respostas) {
        this.nome = nome;
        this.numeroCartao = numeroCartao;
        this.respostas = respostas;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getNumeroCartao() {
        return numeroCartao;
    }

    public void setNumeroCartao(int numeroCartao) {
        this.numeroCartao = numeroCartao;
    }

    public String getRespostas() {
        return respostas;
    }

    public void setRespostas(String respostas) {
        this.respostas = respostas;
    }

    private boolean validarRespostas(String respostas){
        return respostas.matches("[1x2]+") && respostas.length() == 13;
    }

    public void mostrarResultados(String gabarito){
        System.out.println("Apostador: " + nome);
        System.out.println("Número de Cartão: " + numeroCartao);
        System.out.println("Número de Acertos: " + calcularAcertos(gabarito));
        if(calcularAcertos(gabarito) == 13){
            System.out.println("ganhador");
        }
    }
    public int calcularAcertos(String gabarito){
        int acertos = 0;
        for (int i = 0; i < gabarito.length(); i ++){
            if(gabarito.charAt(i) == respostas.charAt(i)){
                acertos++;
            }
        }
        return acertos;
    }
}
