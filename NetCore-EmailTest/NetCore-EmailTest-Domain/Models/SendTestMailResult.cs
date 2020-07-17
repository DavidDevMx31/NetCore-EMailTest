using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_EmailTest_Domain.Models
{
    public class SendTestMailResult
    {
        public ResultStatus Status { get; private set; }
        public string Message { get; private set; }

        public SendTestMailResult(ResultStatus status, string message)
        {
            this.Status = status;
            this.Message = message;
        }
    }

    public enum ResultStatus
    {
        ValidationError,
        ErrorSendingMail,
        Success
    }
}
