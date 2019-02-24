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
    /// Interação lógica para Tela_de_Login.xam
    /// </summary>
    public partial class Tela_de_Login : UserControl
    {
        private ContentControl control;
        public Tela_de_Login(ContentControl controle)
        {
            this.control = controle;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "Rafildo" && password.Password == "123")
            {
                MessageBox.Show("Logado com sucesso");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.control.Content = new Tela_inicial(control);
        }
    }
}
