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

namespace Nabavka
{
    /// <summary>
    /// Interaction logic for AfterLogIn.xaml
    /// </summary>
    public partial class AfterLogIn : Window
    {
        public AfterLogIn()
        {
            InitializeComponent();
            MainFrame.Content = new MakeAListPage();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            string message = "Hello, MessageBox!";
            // Show message box
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void MakeAListBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MakeAListPage();
        }

        private void MyListBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MyListsPage();
        }
    }
}
