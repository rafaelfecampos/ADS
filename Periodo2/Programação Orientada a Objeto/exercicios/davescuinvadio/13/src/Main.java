import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

            Scanner scanner = new Scanner(System.in);

            // Leitura do gabarito
            System.out.println("Informe o gabarito (ex: 112X212X11221):");
            String gabarito = scanner.next();

            if (!gabarito.matches("[1X2]+") || gabarito.length() != 13) {
                System.out.println("Gabarito inválido. Use apenas '1', '2' ou 'X'.");
                return;
            }

            // Leitura das apostas dos apostadores
            System.out.println("Informe o número de apostadores:");
            int numApostadores = scanner.nextInt();

            for (int i = 1; i <= numApostadores; i++) {
                System.out.println("\nApostador " + i);
                System.out.println("Informe o nome do apostador:");
                String nomeApostador = scanner.next();
                System.out.println("Informe o número do cartão:");
                int numeroCartao = scanner.nextInt();
                System.out.println("Informe as respostas do cartão (ex: 112X212X11221):");
                String respostas = scanner.next();

                try {
                    Apostador apostador = new Apostador(nomeApostador, numeroCartao, respostas);
                    apostador.mostrarResultados(gabarito);
                } catch (IllegalArgumentException e) {
                    System.out.println(e.getMessage());
                }
            }

    }
}