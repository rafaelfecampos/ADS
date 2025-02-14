package com.example.demo.model;

import com.example.demo.service.EmailService;
import com.example.demo.service.Mock.EmailServiceMock01;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.text.DecimalFormat;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class Financiamento {
    private double valorFinanciado, valorEntrada, taxaJuros;
    private int numeroParcelas;
    private EmailService emailService;
    public double valorParcela() throws Exception {
        if(valorFinanciado == 0){
            throw new Exception("Valor Financiado não pode ser Zero (0)!");
        }
        double montante = getValorFinanciado()*(1+(12*getTaxaJuros())/100);
        double parcela = montante/getNumeroParcelas();

//        gambiarra do Daves
//        String valor = new DecimalFormat("#0.00").format(parcela).replace(",",".");
//        System.out.println(valor);
//        double nParcela = Double.parseDouble(valor);
//        return (nParcela > parcela)? nParcela : nParcela + 0.01;

        return new BigDecimal(parcela).setScale(2, RoundingMode.UP).doubleValue();

    }

    public void fecharFinanciamento(String email, String nome) throws Exception {
        emailService.sendEmail(email,
                "Confirmação dos dados do financiamento",
                "Parabéns, Sr(a) " + nome + " o seu financiemento no valor de " +
                        "R$"+valorFinanciado+" foi aprovado." +
                        "Serão "+ numeroParcelas  + " parcelas de R$" +
                        valorParcela());
    }
}
