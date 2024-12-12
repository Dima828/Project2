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
    /// Логика взаимодействия для ConfirmContracts.xaml
    /// </summary>
    public partial class ConfirmContracts : Window
    {
        public ConfirmContracts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowsFrame.Second second = new WindowsFrame.Second();
            second.Show();
            this.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Договор оформлен!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
