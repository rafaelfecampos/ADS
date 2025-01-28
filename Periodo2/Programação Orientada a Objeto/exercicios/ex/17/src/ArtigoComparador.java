import java.util.Comparator;

public class ArtigoComparador implements Comparator<Artigo> {
    @Override
    public int compare(Artigo artigo1, Artigo artigo2){
        return  Double.compare(artigo2.getNota(), artigo1.getNota());
    }

}
