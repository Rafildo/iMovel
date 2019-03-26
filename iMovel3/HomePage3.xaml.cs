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
    /// Interação lógica para HomePage3.xam
    /// </summary>
    public partial class HomePage3 : UserControl
    {
        private ContentControl control;
        public HomePage3(ContentControl controle)
        {
            this.control = controle;
            InitializeComponent();
        }
        private void AddRenterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddRealtyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BindContractButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.control.Content = new AppPage3(control);
        }
    }
}
