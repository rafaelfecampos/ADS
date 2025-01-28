import java.util.Scanner;

public class JogoDaVelha {
    enum Casa {VAZIA, JOGADOR1,JOGADOR2};
    private Casa[][] grade = new Casa[3][3];
    private int jogadas = 0;
    private int jogadorAtual = 1;

    public JogoDaVelha(){
        for(Casa[] linha : grade){
            for(int j = 0; j < grade[0].length;j++){
                linha[j] = Casa.VAZIA;
            }
        }
    }
    public void exibirGrade(){
        for(Casa[] linha : grade){
            for(Casa casa: linha){
                System.out.println(casa == Casa.VAZIA ? "- " : casa == Casa.JOGADOR1 ? "X " : "O ");
            }
            System.out.println();
        }
    }

    public void realizarJogada() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("jogador" + jogadorAtual + ", é a sua vez.");
        System.out.println("Informe a linha (0-2)");
        int linha = scanner.nextInt();
        System.out.println("Informe a coluna (0-2)");
        int coluna = scanner.nextInt();

        if (grade[linha][coluna] == Casa.VAZIA) {
            grade[linha][coluna] = (jogadorAtual == 1) ? Casa.JOGADOR1 : Casa.JOGADOR2;
            jogadas++;
            if (verificarVitoria()) {
                exibirGrade();
                System.out.println("Jogador " + jogadorAtual + " venceu!");
                reiniciarJogo();
            }
         else if (jogadas == 9) {
            exibirGrade();
            System.out.println("O jogo terminou em empate!");
            reiniciarJogo();
        }else{
            jogadorAtual = (jogadorAtual == 1) ? 2 : 1;
        }
    }else{
            System.out.println("Casa ocupada. Tente novamente");
        }
    }

    private boolean verificarVitoria(){
        for (int i = 0; i < 3; i++) {
            if (grade[i][0] != Casa.VAZIA && grade[i][0] == grade[i][1] && grade[i][1] == grade[i][2]) {
                return true; // Linha
            }
            if (grade[0][i] != Casa.VAZIA && grade[0][i] == grade[1][i] && grade[1][i] == grade[2][i]) {
                return true; // Coluna
            }
        }

        // Verificar diagonais
        if (grade[0][0] != Casa.VAZIA && grade[0][0] == grade[1][1] && grade[1][1] == grade[2][2]) {
            return true; // Diagonal principal
        }
        if (grade[0][2] != Casa.VAZIA && grade[0][2] == grade[1][1] && grade[1][1] == grade[2][0]) {
            return true; // Diagonal secundária
        }

        return false;
    }

    private void reiniciarJogo(){
        System.out.println("Deseja jogar novamente?(S/N)");
        Scanner scanner = new Scanner(System.in);
        if(scanner.next().toUpperCase().equals("S")){
            grade = new Casa[3][3];
            jogadas = 0;
            jogadorAtual = 0;
            jogar();
        }else{
            System.out.println("Obrigado por jogar!");
            System.exit(0);
        }
    }

    public void jogar(){
        while(true){
            exibirGrade();
            realizarJogada();
        }
    }
}
