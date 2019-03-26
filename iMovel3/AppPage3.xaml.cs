
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

namespace iMovel3
{
    /// <summary>
    /// Interação lógica para AppPage3.xam
    /// </summary>
    public partial class AppPage3 : UserControl
    {
        Login loginControl = new Login();
        private ContentControl control;
        public AppPage3(ContentControl controle)
        {
            InitializeComponent();
            this.control = controle;
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginControl.PerformLogin(UsernameTextBox.Text, PasswordTextBox.Password.ToString()))
            {
                this.control.Content = new HomePage3(control);
            }
        }
    }
}
