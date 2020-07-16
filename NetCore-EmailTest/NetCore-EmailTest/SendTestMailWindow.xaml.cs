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
        public SendTestMailWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
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
