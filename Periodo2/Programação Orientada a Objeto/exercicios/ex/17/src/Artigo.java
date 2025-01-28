import java.util.List;
public class Artigo {
    private String titulo;
    private String resumo;
    private List<String> autores;
    private double nota;

    public Artigo(String titulo, String resumo, List<String> autores, double nota) {
        this.titulo = titulo;
        this.resumo = resumo;
        this.autores = autores;
        this.nota = nota;
    }

    public Artigo(String titulo, String resumo, List<String> autor1) {
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getResumo() {
        return resumo;
    }

    public void setResumo(String resumo) {
        this.resumo = resumo;
    }

    public List<String> getAutores() {
        return autores;
    }

    public void setAutores(List<String> autores) {
        this.autores = autores;
    }

    public double getNota() {
        return nota;
    }

    public void setNota(double nota) {
        this.nota = nota;
    }
}
