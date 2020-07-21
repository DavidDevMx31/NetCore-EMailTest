using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_EmailTest_Presenter
{
    public interface ISendTestMailView
    {
        void ShowValidationError(string title, string message);
        void ShowSendingMailError(string title, string message);
        void ShowSuccessResult(string title, string message);
    }
}
