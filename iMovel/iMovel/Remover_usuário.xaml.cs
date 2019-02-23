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
    /// Lógica interna para Remover_usuário.xaml
    /// </summary>
    public partial class Remover_usuário : Window
    {
        public Remover_usuário()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Length != 0 && password.Password == "123")
            {
                MessageBox.Show("Removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos!");
            }
        }
    }
}
