using NetCore_EmailTest_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_EmailTest_Domain
{
    public class SendTestMailInteractor : ISendTestMail
    {
        public void StartProcess(SendTestMailRequest request)
        {
            var validationResult = ValidateRequest(request);

            if (string.IsNullOrWhiteSpace(validationResult))
            {

            }
            // Show errors to the user
        }

        private string ValidateRequest(SendTestMailRequest request)
        {
            StringBuilder errorsFound = new StringBuilder();

            ValidateIssuerAccountRequiredFields(request, errorsFound);
            ValidateReceiverAccountRequiredFields(request, errorsFound);
            ValidateEmailContentRequiredFields(request, errorsFound);
            
            if (!int.TryParse(request.Port, out int port))
                errorsFound.AppendLine("The port contain an integer number.");

            return errorsFound.ToString();
        }

        private void ValidateIssuerAccountRequiredFields(SendTestMailRequest request, StringBuilder errorsFound)
        {
            if (CheckIfRequiredFieldIsEmpty(request.Server))
                errorsFound.AppendLine("The SMTP server data is required.");

            if (CheckIfRequiredFieldIsEmpty(request.Port))
                errorsFound.AppendLine("The SMTP port is required.");

            if (CheckIfRequiredFieldIsEmpty(request.Username))
                errorsFound.AppendLine("The issuer email address is required.");

            if (CheckIfRequiredFieldIsEmpty(request.Password))
                errorsFound.AppendLine("The email password is required.");
        }

        private void ValidateReceiverAccountRequiredFields(SendTestMailRequest request, StringBuilder errorsFound)
        {
            if (CheckIfRequiredFieldIsEmpty(request.ToAddress))
                errorsFound.AppendLine("The receiver email is required.");
        }

        private void ValidateEmailContentRequiredFields(SendTestMailRequest request, StringBuilder errorsFound)
        {
            if (CheckIfRequiredFieldIsEmpty(request.MailMessage))
                errorsFound.AppendLine("The email message is required.");
        }

        private bool CheckIfRequiredFieldIsEmpty(string fieldData)
        {
            if (string.IsNullOrWhiteSpace(fieldData))
                return true;

            return false;
        }

    }
}
