using NetCore_EmailTest_Domain.Models;

namespace NetCore_EmailTest_Domain
{
    public interface IEmailSender
    {
        void SendEmail(TestMailModel testMail);
    }
}
