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
    /// Логика взаимодействия для Second.xaml
    /// </summary>
    public partial class Second : Window
    {
        public Second()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowsFrame.Employees employees = new WindowsFrame.Employees();
            employees.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowsFrame.Department department = new WindowsFrame.Department();
            department.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowsFrame.ConfirmContracts confirmContracts = new WindowsFrame.ConfirmContracts();
            confirmContracts.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
