﻿using System;
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

namespace iMovel
{
    /// <summary>
    /// Interação lógica para AdminPage.xam
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_usuário cadastrar_Usuário = new Cadastrar_usuário();
            cadastrar_Usuário.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Remover_usuário remover_Usuário = new Remover_usuário();
            remover_Usuário.Show();
        }
    }
}
