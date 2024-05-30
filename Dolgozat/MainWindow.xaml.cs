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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dolgozat.Menu;

namespace Dolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void WindowClose(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void radiobtn1_Checked(object sender, RoutedEventArgs e)
        {
            Control.Content = new Task1();
        }

        private void radiobtn2_Checked(object sender, RoutedEventArgs e)
        {
            Control.Content = new Task2();
        }

        private void radiobtn3_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
