package com.example.demo.service;

import org.springframework.stereotype.Service;

@Service
public class EmailService {
    public void sendEmail(String email, String titulo, String corpo) throws Exception {
        try{
            if (email.contains("@") && !titulo.isEmpty() && !corpo.isEmpty()) {
                System.out.println("An email was sent to " + email + " with the title of" + titulo +
                        "\n\n" + corpo);
            }
        }catch (Exception ex){
            throw new Exception("Error at sending the email: " + ex.getMessage());
        }
    }
}
