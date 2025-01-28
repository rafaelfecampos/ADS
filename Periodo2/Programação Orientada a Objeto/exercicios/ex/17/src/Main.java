import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Artigo> artigos = new ArrayList<>();


        artigos.add(new Artigo("Título 1", "Resumo 1", List.of("Autor1", "Autor2", "Autor3")));
        artigos.add(new Artigo("Título 2", "Resumo 2", List.of("Autor4", "Autor5", "Autor6")));
        artigos.add(new Artigo("Título 3", "Resumo 3", List.of("Autor7", "Autor8", "Autor9")));


        for (Artigo artigo : artigos) {
            double nota = Math.random() * 10;
            artigo.setNota(nota);
        }

        Collections.sort(artigos, new ArtigoComparador());

        // Exibir os 3 artigos mais bem avaliados
        System.out.println("Os 3 artigos mais bem avaliados:");
        for (int i = 0; i < Math.min(3, artigos.size()); i++) {
            Artigo artigo = artigos.get(i);
            System.out.println("Título: " + artigo.getTitulo());
            System.out.println("Autores: " + artigo.getAutores());
            System.out.println("Nota: " + artigo.getNota());
            System.out.println("--------------------");
        }
    }
}