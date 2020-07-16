using System;
using System.Collections.Generic;
using System.Text;
using NetCore_EmailTest_Domain.Models;

namespace NetCore_EmailTest_Domain
{
    public interface ISendTestMail
    {
        void StartProcess(SendTestMailRequest request);
    }
}
