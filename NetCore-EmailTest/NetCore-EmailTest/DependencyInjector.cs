using NetCore_EmailTest_Domain;
using NetCore_EmailTest_Infrastructure;
using NetCore_EmailTest_Presenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace NetCore_EmailTest
{
    static internal class DependencyInjector
    {
        static internal Window CreateSendTestEmailWindow()
        {
            var emailWorker = new SendEmailWorker();
            var presenter = new SendTestMailPresenter();
            var interactor = new SendTestMailInteractor(emailWorker, presenter);
            var view = new SendTestMailWindow(interactor);
            presenter.SetView(view);
            return view;
        }
    }
}
