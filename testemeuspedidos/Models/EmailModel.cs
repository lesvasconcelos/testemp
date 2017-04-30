using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace testemeuspedidos.Models
{
    public enum EmailPerfil
    {
        FrontEnd,
        BackEnd,
        Mobile,
        Generico
    }

    public class EmailModel
    {
        public const string EMAIL_REMETENTE = "testedevmp@gmail.com";
        public static void Enviar(EmailPerfil emailPerfil, string destinatario)
        {
            var mail = MailMessageFromEmailPerfil(emailPerfil);
            mail.To.Add(new MailAddress(destinatario));

            var smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(EMAIL_REMETENTE, "testeDevMP123");
            smtp.Send(mail);
        }

        public static MailMessage MailMessageFromEmailPerfil(EmailPerfil emailPerfil)
        {
            var mail = new MailMessage();
            var corpoGenerico = "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador {0}entraremos em contato.";
            mail.From = new MailAddress(EMAIL_REMETENTE, "Teste MP");
            mail.Subject = "Obrigado por se candidatar";

            switch (emailPerfil)
            {
                case EmailPerfil.BackEnd:
                    mail.Body = string.Format(corpoGenerico, "Back-End ");
                    break;
                case EmailPerfil.FrontEnd:
                    mail.Body = string.Format(corpoGenerico, "Front-End ");
                    break;
                case EmailPerfil.Generico:
                    mail.Body = string.Format(corpoGenerico, string.Empty);
                    break;
                case EmailPerfil.Mobile:
                    mail.Body = string.Format(corpoGenerico, "Mobile ");
                    break;
            }

            return mail;
        }
        
    }
}
