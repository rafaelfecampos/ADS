import java.time.LocalDate;
import java.time.LocalDateTime;

public class Data {
    private int dia;
    private int mes;
    private int ano;

    public Data(int dia, int mes, int ano) {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
    public Data(){
        this(LocalDateTime.now().getDayOfMonth(),
                LocalDateTime.now().getMonthValue(),
                LocalDate.now().getYear());
    }

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }

    public int getMes() {
        return mes;
    }

    public void setMes(int mes) {
        this.mes = mes;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    public String toString() {
        return String.format("%d/%d/%d",dia,mes,ano);
    }

    public void avancarDia(){
        if(dia > 31){
            dia = 1;
            mes++;
        }
        if(mes > 12){
            mes = 1;
            ano++;
        }
    }
}
