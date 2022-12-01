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

namespace zadanie1
{
    /// <summary>
    /// Logika interakcji dla klasy Window_Menu.xaml
    /// </summary>
    public partial class Window_Menu : Window
    {
        public Window_Menu()
        {
            InitializeComponent();
        }

        private void info_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("to jest program testujący menu w klasie 3");
        }
    }
}
