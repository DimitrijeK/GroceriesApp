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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            AfterLogIn window = new AfterLogIn();
            window.Show();
            
        }

        private void englishBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void spanishBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
