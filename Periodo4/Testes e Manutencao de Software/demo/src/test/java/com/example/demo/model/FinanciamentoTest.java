package com.example.demo.model;

import com.example.demo.service.EmailService;
import com.example.demo.service.Mock.EmailServiceMock01;
import com.example.demo.service.Mock.EmailServiceMock02;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import org.mockito.Mock;
import org.springframework.boot.test.context.SpringBootTest;

import static org.mockito.Mockito.mock;
import static org.mockito.Mockito.when;

@SpringBootTest
public class FinanciamentoTest {
    @Test
    @DisplayName("Testar financiamento de Zero reais")
    public void teste001(){
        //Montar Cenário
        Financiamento f = new Financiamento();
        f.setValorFinanciado(0);
        f.setTaxaJuros(5);
        f.setNumeroParcelas(12);
        f.setValorEntrada(1000);
//        double valorEsperado =

        //exercutar
        try{
            double valorCalculado = f.valorParcela();
            Assertions.fail("Não retornou um erro !!! Resultado: "+valorCalculado);
        }catch (Exception e){
            Assertions.assertTrue(e.getMessage()
                    .contains("Valor Financiado não pode ser Zero (0)!"));
        }

    }

    @Test
    @DisplayName("financiamento de 1000 a 1.0% ao mes em 12 parcelas, sem entrada")
    public void teste002() throws Exception {
        //Montar Cenário
        Financiamento f = new Financiamento();
        f.setValorFinanciado(1000);
        f.setTaxaJuros(1);
        f.setNumeroParcelas(12);
        f.setValorEntrada(0);
        double valorEsperado = 93.34;

        //exercutar
        double valorCalculado = f.valorParcela();
        Assertions.assertEquals(valorEsperado, valorCalculado);
    }

    @Test
    @DisplayName("Teste de integração com o Gmail, impedir que o email seja enviado")
    public void testeIntegracao() throws Exception {
        Financiamento f = new Financiamento();
        f.setValorFinanciado(1000);
        f.setTaxaJuros(1);
        f.setNumeroParcelas(12);
        f.setValorEntrada(0);
        f.setEmailService(new EmailServiceMock01());//mock simula a funcionalidade de um método para evitar que o método seja executado realmente
        //a classe mock precisa herdar da classe que possui o método a ser mockado
        f.fecharFinanciamento("rafael@rafael","Rafael");
        Assertions.assertTrue(true);
    }
    @Test
    @DisplayName("Teste de integração com o Gmail, verificar se o email nao é enviado")
    public void testeIntegracao2() throws Exception {
        Financiamento f = new Financiamento();
        f.setValorFinanciado(1000);
        f.setTaxaJuros(1);
        f.setNumeroParcelas(12);
        f.setValorEntrada(0);
        f.setEmailService(new EmailServiceMock02());//mock simula a funcionalidade de um método para evitar que o método seja executado realmente
        //a classe mock precisa herdar da classe que possui o método a ser mockado
        try{
            f.fecharFinanciamento("ze@ze", "ze das cove");
            Assertions.fail("falhou!!");
        }catch (Exception e){
            Assertions.assertEquals("538 - Destinário invalido!!!", e.getMessage());
        }
    }
//    @Test
//    @DisplayName("Teste de integração com o Gmail, impedir que o email seja enviado")
//    public void testeIntegracao3() throws Exception {
//        Financiamento f = new Financiamento();
//        f.setValorFinanciado(1000);
//        f.setTaxaJuros(1);
//        f.setNumeroParcelas(12);
//        f.setValorEntrada(0);
////        EmailService emailService = mock(EmailService.class);
////        when(emailService.sendEmail("ze@ze", "Confirmação dos dados do financiamento", "Parabéns, Sr(a) " + "Zezin da cove" + " o seu financiemento no valor de " +
////                "R$1000,00 foi aprovado." +
////                "Serão 12 parcelas de R$93,34")).thenThrow(
////                        throw new Exception("538 - Destinário invalido!!!");
////        );
//
////        f.setEmailService(emailService);
//        try{
//            f.fecharFinanciamento("ze@ze", "ze das cove");
//            Assertions.fail("falhou!!");
//        }catch (Exception e){
//            Assertions.assertEquals("538 - Destinário invalido!!!", e.getMessage());
//        }
//    }
}
