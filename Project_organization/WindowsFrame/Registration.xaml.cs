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

namespace Project_organization.WindowsFrame
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Login = Tbx_Login.Text;
            var Password = Tbx_Password.Password.ToString();
            var SecondPassword = Tbx_PasswordRemember.Password.ToString();

            if (Login == "" && Password == "" && SecondPassword == "")
            {
                MessageBox.Show("Убедитесь, что все поля заполнены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("Убедитесь, что все поля заполнены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Password != SecondPassword)
            {
                MessageBox.Show("Пароль не совпадает!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                WindowsFrame.Autorization autorization = new WindowsFrame.Autorization();
                autorization.Show();
                this.Close();
            }
        }
    }
}
