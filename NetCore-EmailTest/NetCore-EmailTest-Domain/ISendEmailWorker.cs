using NetCore_EmailTest_Domain.Models;

namespace NetCore_EmailTest_Domain
{
    public interface ISendEmailWorker
    {
        void SendEmail(TestMailModel testMail);
    }
}
