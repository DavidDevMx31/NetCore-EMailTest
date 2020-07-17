using MailKit.Net.Smtp;
using MimeKit;
using NetCore_EmailTest_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_EmailTest_Domain
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(TestMailModel testMail)
        {
            var email = CreateMail(testMail);
            Send(email, testMail.SMTPConfiguration);
        }

        private MimeMessage CreateMail(TestMailModel model)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(model.From.UserName, model.From.Address));
            email.To.Add(new MailboxAddress(model.To.UserName, model.To.Address));
            email.Subject = model.Content.Subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = model.Content.Message };

            return email;
        }

        private void Send(MimeMessage email, EmailConfiguration configuration)
        {
            using var client = new SmtpClient();

            try
            {
                client.Connect(configuration.Server, configuration.Port, configuration.UseSSL);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(configuration.UserName, configuration.Password);

                client.Send(email);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.InnerException);
                throw;
            }
            //finally
            //{
            //    client.Disconnect(true);
            //    client.Dispose();
            //}
        }
    }
}
