using NetCore_EmailTest_Domain;
using NetCore_EmailTest_Domain.Models;
using System;

namespace NetCore_EmailTest_Presenter
{
    public class SendTestMailPresenter : ISendTestMailPresenter
    {
        private ISendTestMailView view;

        public void SetView(ISendTestMailView view)
        {
            this.view = view ?? throw new ArgumentNullException("view");
        }

        public void PresentResult(SendTestMailResult testMailResult)
        {
            switch (testMailResult.Status)
            {
                case ResultStatus.ValidationError:
                    view.ShowValidationError("Validation error", $"The following errors were found:{Environment.NewLine}{testMailResult.Message}");
                    break;
                case ResultStatus.ErrorSendingMail:
                    view.ShowSendingMailError("Error", $"The email could not be sent due to the next error:{Environment.NewLine}{testMailResult.Message}");
                    break;
                case ResultStatus.Success:
                    view.ShowSuccessResult("Email sent", "The email was sent successfully!");
                    break;
            }
        }
    }
}
