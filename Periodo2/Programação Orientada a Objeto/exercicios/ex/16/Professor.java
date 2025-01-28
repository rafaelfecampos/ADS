public class Professor
{
    // atributos
    private String formacao;
    private int aulasPresenciais;
    private int aulasEad;
    
    //construtor
    public Professor(String f, int ap, int ae)
    {
        formacao = f;
        aulasPresenciais = ap;
        aulasEad = ae;
    }
    
    public Professor()
    {}
    
    public void setFormacao(String f){
        if(f=="g" || f=="e"||f=="m"|| f=="d"){
            formacao = f;
        }
    }
    
    public String getFormacao(){
        return formacao;
    }
    
    public void setAulasPresenciais(int ap){
        if(ap>0){
            aulasPresenciais = ap;
        }
    }
    
    public int getAulasPresenciais(){
        return aulasPresenciais;
    }

    public void setAulasEad(int ae){
        if(ae>0){
            aulasEad = ae;
        }
    }
    
    public int getAulasEad(){
        return aulasEad;
    }
    
    public double valorAulasEad(){
        Double ae = (Double.valueOf(4*aulasEad))*0.75;
        if(formacao == "e"){
            return ae*25*1.15;
        } else if(formacao == "m") 
        {
            return ae*25*1.45;
        } else if(formacao == "d") 
        {
            return ae*25*1.75;
        } else {
            return ae*25;
        }
    }
    
    public double valorAulasPresenciais(){
        Double ap = Double.valueOf(4*aulasPresenciais);
        if(formacao == "e"){
            return ap*25*1.15;
        } else if(formacao == "m") 
        {
            return ap*25*1.45;
        } else if(formacao == "d") 
        {
            return ap*25*1.75;
        } else {
            return ap*25;
        }
    }
    
    public double calculaSalario(){
        return valorAulasEad() + valorAulasPresenciais();
    }
}
