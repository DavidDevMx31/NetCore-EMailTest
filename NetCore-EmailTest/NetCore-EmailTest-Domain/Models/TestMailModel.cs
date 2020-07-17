using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_EmailTest_Domain.Models
{
    public class TestMailModel
    {
        public EmailConfiguration SMTPConfiguration { get; set; }
        public EmailAccount From { get; set; }
        public EmailAccount To { get; set; }
        public EmailContent Content { get; set; }
    }

    public class EmailConfiguration
    {
        public string Server { get; private set; }
        public int Port { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public bool UseSSL { get; private set; }

        public EmailConfiguration(string server, int port, string username, string password, bool useSSL)
        {
            this.Server = server;
            this.Port = port;
            this.UserName = username;
            this.Password = password;
            this.UseSSL = UseSSL;
        }
    }

    public class EmailAccount
    {
        public string UserName { get; private set; }
        public string Address { get; private set; }

        public EmailAccount(string userName, string address)
        {
            this.Address = address;
            this.UserName = userName;
        }
    }

    public class EmailContent
    {
        public string Subject { get; private set; }
        public string Message { get; private set; }

        public EmailContent(string subject, string message)
        {
            this.Subject = string.IsNullOrWhiteSpace(subject) ? "This is a test email" : subject;
            this.Message = message;
        }
    }
}
