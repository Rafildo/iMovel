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
    /// Lógica interna para Cadastrar_usuário.xaml
    /// </summary>
    public partial class Cadastrar_usuário : Window
    {
        public Cadastrar_usuário()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (email.Text.Length != 0 && login.Text.Length != 0 && password.Password.Length != 0 )
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos!");
            }
        }
    }
}
