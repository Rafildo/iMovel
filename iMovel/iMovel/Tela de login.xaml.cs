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
using System.Windows.Shapes;

namespace iMovel
{
    /// <summary>
    /// Lógica interna para Tela_de_login.xaml
    /// </summary>
    public partial class Tela_de_login : Window
    {
        public Tela_de_login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Text == "Admin" && password.Password == "123" )
            {
                MessageBox.Show("Logado com sucesso!");
                AdminPage adminPage = new AdminPage();
                this.Content = adminPage;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida");
            }
        }
    }
}
