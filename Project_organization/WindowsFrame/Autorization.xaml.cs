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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Login = Tbx_Login.Text;
            string Password = Tbx_Password.Password.ToString();

            if (Login == "" && Password == "")
            {
                MessageBox.Show("Убедитесь, что все поля заполнены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
            else if (Login == "2" && Password == "2")
            {
                WindowsFrame.Second second = new Second();
                second.Show();
                this.Close();
            }
            else
            {
                WindowsFrame.First first = new First();
                first.Show();
                this.Close();
            }
        }
    }
}
