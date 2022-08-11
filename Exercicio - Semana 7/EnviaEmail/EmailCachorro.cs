using Exercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.EnviaEmail
{
    public class EmailCachorro
    {
        //POR QUE TEM QUE SER STATIC????????????????????????????????????????????????????????????????????????????????????
        public static string EnviaEmailCachorro(Cachorro cachorro)
        {
            // Envio do e-mail
            var mail = new MailMessage("comunicacao@petstore.com", cachorro.Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem vindo a Pet Store";
            mail.Body = $"Parabéns! Seu Pet {cachorro.Nome} foi cadastrado com sucesso!";
            client.Send(mail);

            return "Email dizendo que o cachorro foi cadastrado com sucesso!";
        }
    }
}
