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
    /// Interação lógica para Cadastrar_usuario.xam
    /// </summary>
    public partial class Cadastrar_usuario : UserControl
    {
        private ContentControl control;
        public Cadastrar_usuario(ContentControl controle)
        {
            this.control = controle;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.control.Content = new Admin_page(control);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (email.Text != null && login.Text != null && password.Password!= null)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
