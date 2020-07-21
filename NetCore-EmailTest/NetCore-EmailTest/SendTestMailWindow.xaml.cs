using NetCore_EmailTest_Domain;
using NetCore_EmailTest_Domain.Models;
using NetCore_EmailTest_Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NetCore_EmailTest
{
    /// <summary>
    /// Interaction logic for SendTestMailWindow.xaml
    /// </summary>
    public partial class SendTestMailWindow : Window
    {
        private readonly ISendTestMail interactor;

        public SendTestMailWindow()
        {
            var presenter = new SendTestMailPresenter();
            this.interactor = new SendTestMailInteractor(new EmailSender(), presenter);
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var request = new SendTestMailRequest() 
            {
                Server = txtSMTPServer.Text.Trim(),
                Port = txtSMTPPort.Text.Trim(),
                Username = txtSMTPEmail.Text.Trim(),
                Password = txtSMTPPassword.Text.Trim(),
                FromName = txtFromName.Text.Trim(),
                ToName = txtToName.Text.Trim(),
                ToAddress = txtToEmail.Text.Trim(),
                MailSubject = txtMailSubject.Text.Trim(),
                MailMessage = txtMailMessage.Text.Trim(),
                UseSSL = cbUseSSL.IsChecked ?? false
            };
            interactor.StartProcess(request);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            txtSMTPServer.Text = string.Empty;
            txtSMTPPort.Text = string.Empty;
            txtSMTPEmail.Text = string.Empty;
            txtSMTPPassword.Text = string.Empty;
            txtFromName.Text = string.Empty;
            
            txtToEmail.Text = string.Empty;
            txtToName.Text = string.Empty;
            
            txtMailSubject.Text = string.Empty;
            txtMailMessage.Text = string.Empty;

            cbUseSSL.IsChecked = false;
        }
    }
}
