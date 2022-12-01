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

namespace zadanie1
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
        private void oblicz(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(liczba1.Text, out int a) && int.TryParse(liczba2.Text, out int b) &&a>=0 && b>=0)
            {
                int wynik = nwdz(a, b);
                string wypis;
                if (wynik == 0)
                {
                    wypis = "Nieskończoność";
                }
                else
                {
                    wypis = wynik.ToString();
                }
                MessageBox.Show(wypis, "NWD", MessageBoxButton.OK,MessageBoxImage.Hand);
                /*
                int nwd=0;
                int mniejsza;
                if (a < b)
                    mniejsza = a;
                else
                    mniejsza = b;
                for(int i = 1; i <= mniejsza; i++)
                {
                    if(b%i==0 && a % i == 0)
                    {
                        nwd = i;
                        
                    }
                }
                MessageBox.Show(nwd.ToString(), "Wynik",
                   MessageBoxButton.OK,
                   MessageBoxImage.Information);
                */
            }
            else
            {
                MessageBox.Show("zle");
            }
            

        }
        private int nwdz(int x,int y)
        {
            while (y != 0)
            {
                int reszta = x % y;
                x = y;
                y = reszta;
            }

            return x;
        }
    }
}
