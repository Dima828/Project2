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
    /// Логика взаимодействия для Department.xaml
    /// </summary>
    public partial class Department : Window
    {
        public Department()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowsFrame.First first = new WindowsFrame.First();
            first.Show();
            this.Close();
        }
    }
}
