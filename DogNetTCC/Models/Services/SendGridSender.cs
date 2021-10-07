using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace DogNet.Services
{
    public class SendGridSender : IEmailSender
    {        
        public async Task SendEmailAsync(string email, string assunto, string mensagemTexto, string mensagemHtml)
        {
            //var apiKey = "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";
            //var client = new SendGridClient(apiKey);

            //var from = new EmailAddress("emaildognet@gmail.com", "DogNet");
            //var subject = assunto;
            //var to = new EmailAddress(email);
            //var plainTextContent = mensagemTexto;
            //var htmlContent = mensagemHtml;
            //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            //var response = await client.SendEmailAsync(msg);

            var apiKey = "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";
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress("emaildognet@gmail.com");
            var subject = assunto;
            var to = new EmailAddress(email);
            var plainText = mensagemTexto;
            var htmlContent = mensagemHtml;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainText, htmlContent);
            var response = await client.SendEmailAsync(msg);
            

        }        
    }
}
