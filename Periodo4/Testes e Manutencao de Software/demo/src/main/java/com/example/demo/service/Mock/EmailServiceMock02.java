package com.example.demo.service.Mock;

import com.example.demo.service.EmailService;

public class EmailServiceMock02 extends EmailService {
    public void sendEmail(String email, String titulo, String corpo) throws Exception{
        throw new Exception("538 - Destinário invalido!!!");
    }
}
