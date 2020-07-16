using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_EmailTest_Domain.Models
{
    public class SendTestMailRequest
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UseSSL { get; set; }
        public string FromName { get; set; }
        public string ToAddress { get; set; }
        public string ToName { get; set; }
        public string MailSubject { get; set; }
        public string MailMessage { get; set; }
    }
}
