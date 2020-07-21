using NetCore_EmailTest_Domain;
using NetCore_EmailTest_Domain.Models;
using System;

namespace NetCore_EmailTest_Presenter
{
    public class SendTestMailPresenter : ISendTestMailPresenter
    {
        public void PresentResult(SendTestMailResult testMailResult)
        {
            string title = string.Empty;
            string message = string.Empty;

            switch (testMailResult.Status)
            {
                case ResultStatus.ValidationError:
                    System.Diagnostics.Debug.WriteLine($"Validation error: The following errors were found:/n{testMailResult.Message}");
                    break;
                case ResultStatus.ErrorSendingMail:
                    System.Diagnostics.Debug.WriteLine($"There was an error :/n{testMailResult.Message}");
                    break;
                case ResultStatus.Success:
                    System.Diagnostics.Debug.WriteLine($"The email was sent successfully!");
                    break;
            }
        }
    }
}
