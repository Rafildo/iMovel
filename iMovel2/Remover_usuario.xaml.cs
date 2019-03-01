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
    /// Interação lógica para Remover_usuario.xam
    /// </summary>
    public partial class Remover_usuario : UserControl
    {
        private ContentControl control;
        public Remover_usuario(ContentControl controle)
        {
            this.control = controle;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text!= null && password.Password!= null)
            {
                MessageBox.Show("Usuário removido com sucesso!");
                this.control.Content = new Admin_page(control);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.control.Content = new Admin_page(control);
        }
    }
}
