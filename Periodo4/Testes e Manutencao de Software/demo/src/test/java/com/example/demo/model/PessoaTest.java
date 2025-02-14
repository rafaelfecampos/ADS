//package com.example.demo.model;
//
//import org.junit.jupiter.api.Assertions;
//import org.junit.jupiter.api.DisplayName;
//import org.junit.jupiter.api.Test;
//import org.springframework.boot.test.context.SpringBootTest;
//
//@SpringBootTest
//public class PessoaTest {
//    @Test
//    @DisplayName("Teste valores ok")
//    public void teste_valores_OK() throws Exception {
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",80, 1.8);
//        double imcEsperado = 24.69;
//
//        //2º passo - execução
//        double imcObtido = p.imc();
//
//        //3º passo - validação
//        Assertions.assertEquals(imcEsperado, imcObtido,0.01);
//    }
//
//    @Test
//    @DisplayName("Teste valores magro")
//    public void teste_valores_magro() throws Exception {
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",41.6, 1.5);
//        double imcEsperado = 18.49;
//
//        //2º passo - execução
//        double imcObtido = p.imc();
//
//        //3º passo - validação
//        Assertions.assertEquals(imcEsperado, imcObtido,0.01);
//    }
//    @Test
//    @DisplayName("Teste peso 0")
//    public void teste_peso0(){
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",0, 1.8);
//
//        //2º passo - execução
//        try{
//            double imcObtido = p.imc();
//            Assertions.fail("###### método deveria dar erro: resultado = "  + imcObtido +" #######");
//        }catch (Exception e){
//            Assertions.assertTrue(e.getMessage().contains("Peso não pode ser menor ou igual a zero")); //ainda verifica se a mensagem de erro é igual
//        }
//
//    }
//
//    @Test
//    @DisplayName("Teste peso negativo")
//    public void teste_peso_negativo(){
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",-1, 1.8);
//
//        //2º passo - execução
//        try{
//            double imcObtido = p.imc();
//            Assertions.fail("###### método deveria dar erro: resultado = "  + imcObtido +" #######");
//        }catch (Exception e){
//            Assertions.assertTrue(e.getMessage().contains("Peso não pode ser menor ou igual a zero")); //ainda verifica se a mensagem de erro é igual
//        }
//
//    }
//
//    @Test
//    @DisplayName("Teste altura 0")
//    public void teste_altura0(){
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",80, 0);
//
//        //2º passo - execução
//        try{
//            double imcObtido = p.imc();
//            Assertions.fail("###### método deveria dar erro: resultado = "  + imcObtido +" #######");
//        }catch (Exception e){
//            Assertions.assertTrue(e.getMessage().contains("Altura não pode ser menor ou igual a zero")); //ainda verifica se a mensagem de erro é igual
//        }
//
//    }
//
//    @Test
//    @DisplayName("Teste altura negativo")
//    public void teste_altura_negativa(){
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",80, -1);
//
//        //2º passo - execução
//        try{
//            double imcObtido = p.imc();
//            Assertions.fail("###### método deveria dar erro: resultado = "  + imcObtido +" #######");
//        }catch (Exception e){
//            Assertions.assertTrue(e.getMessage().contains("Altura não pode ser menor ou igual a zero")); //ainda verifica se a mensagem de erro é igual
//        }
//
//    }
//
//    @Test
//    @DisplayName("Teste faixa magro")
//    public void teste_faixa_magro() throws Exception {
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",41.6, 1.5);
//        String faixaEsperada = "magrao";
//
//        //2º passo - execução
//        String faixaObtida = p.faixa();
//        //3º passo - validação
//        Assertions.assertEquals(faixaEsperada, faixaObtida);
//    }
//
//    @Test
//    @DisplayName("Teste faixa magro, limite")
//    public void teste_faixa_magroLimite() throws Exception {
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",41.62, 1.5);
//        String faixaEsperada = "magrao";
//
//        //2º passo - execução
//        String faixaObtida = p.faixa();
//        //3º passo - validação
//        Assertions.assertEquals(faixaEsperada, faixaObtida);
//    }
//
//    @Test
//    @DisplayName("Teste faixa normal, limite inferior")
//    public void teste_faixa_ok() throws Exception {
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",41.64, 1.5);
//        String faixaEsperada = "normal";
//
//        //2º passo - execução
//        String faixaObtida = p.faixa();
//        //3º passo - validação
//        Assertions.assertEquals(faixaEsperada, faixaObtida);
//    }
//    @Test
//    @DisplayName("Teste faixa pre-obesidade")
//    public void teste_faixa_preObesidade() throws Exception {
//        //1º passo - preparação
//        Pessoa p = new Pessoa("",81, 1.8);
//        String faixaEsperada = "Pré-obesidade";
//
//        //2º passo - execução
//        String faixaObtida = p.faixa();
//        //3º passo - validação
//        Assertions.assertEquals(faixaEsperada, faixaObtida);
//    }
//
//}
