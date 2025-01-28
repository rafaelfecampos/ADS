public class funcionario
{
    // variáveis de instância - substitua o exemplo abaixo pelo seu próprio
    String nome;
    double salarioBruto;
    boolean usaValeTransporte, ehGerente;
    int nFilhos;

    /**
     * Construtor para objetos da classe funcionario
     */
    funcionario(String vNome, double vSalBruto, boolean vVale, boolean vGerente, int vNumFilhos)
    {
        // inicializa variáveis de instância
        nome = vNome;
        salarioBruto = vSalBruto;
        usaValeTransporte = vVale;
        ehGerente = vGerente;
        nFilhos = vNumFilhos;
    }

    double salarioLiquido()
    {
        // escreva seu código aqui
        double salario = salarioBruto - inss()- descontoVale() + bonusFilhos() + bonusGerente();
        return salario;
    }
    double inss()
    {
        return 0.13*salarioBruto;
    }
    double descontoVale()
    {
        /*if(usaValeTransporte == true){
            return salarioBruto*0.03;
        }
        else{
            return 0;
        }*/
        return (usaValeTransporte)?(salarioBruto*0.03):0;
    }
    double bonusFilhos()
    {
        /*if(nFilhos>=0 && nFilhos <= 3){
            return 115.00*nFilhos;
        }
        else{
            return 115.00*3;
        }*/
        return (nFilhos >=0 && nFilhos <=3)?(nFilhos*115):3*115;
    }
    double bonusGerente()
    {
        /*if(ehGerente == true){
            return salarioBruto*0.1;
        }
        else{
            return 0;
        }*/
        return (ehGerente)?(salarioBruto*0.1):0;
    }
}
