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
    /// Логика взаимодействия для Contracts.xaml
    /// </summary>
    public partial class Contracts : Window
    {
        public Contracts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Name = Tbx_Name.Text;
            var Type = Cbx_type.Text;
            var Address = Tbx_Adress.Text;

            if(Name != "" &&  Type != "" &&  Address != "")
            {
                WindowsFrame.First first = new First();
                first.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Убедитесь, что все поля заполнены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
