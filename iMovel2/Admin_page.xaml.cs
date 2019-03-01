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

namespace iMovel2
{
    /// <summary>
    /// Interação lógica para Admin_page.xam
    /// </summary>
    public partial class Admin_page : UserControl
    {
        private ContentControl control;
        public Admin_page(ContentControl controle)
        {
            this.control = controle;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.control.Content = new Tela_de_Login(control);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.control.Content = new Cadastrar_usuario(control);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.control.Content = new Remover_usuario(control);
        }
    }
}
