using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMovel3
{
    class Login
    {
        Administrator systemAdmin = new Administrator("imovel@admin.com", "123456");

        public bool PerformLogin(string userEmail, string userPassword)
        {
            if (IsValidEmail(userEmail))
            {
                if (userEmail == systemAdmin.getEmail())
                {
                    if (userPassword == systemAdmin.getPassword())
                        return true;
                    else
                    {
                        System.Windows.MessageBox.Show("Senha Incorreta!", "Erro de Login.", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                        return false;
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Email de Usuário Incorreto!", "Erro de Login.", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    return false;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Digite um email de usuário válido!", "Erro de Login.", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                return false;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
