using NetCore_EmailTest_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_EmailTest_Domain
{
    public interface ISendTestMailPresenter
    {
        void PresentResult(SendTestMailResult testMailResult);
    }
}
