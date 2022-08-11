using Exercicio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.EnviaEmail
{
    public class EmailGato
    {
        public string  EnviaEmailGato(Gato gato)
        {
            // Envio de e-mail
            var mail = new MailMessage("comunicacao@petstore.com", gato.Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem vindo a Pet Store";
            mail.Body = $"Parabéns! Seu Pet {gato.Nome} foi cadastrado com sucesso!";
            client.Send(mail);

            return "Email dizendo que o gato foi cadastrado com sucesso!";
        }
    }
}
