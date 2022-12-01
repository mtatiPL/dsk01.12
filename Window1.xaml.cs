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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(liczba3.Text,out int n))
            {
                string informacja;
                if (czyPierwsza(n))
                {
                    informacja = n.ToString() + "jest liczbą pierwszą";

                }
                else
                {
                    informacja = n.ToString() + "jest liczbą złożnoną";

                }
                MessageBox.Show(informacja);


            }
            else
            {
                MessageBox.Show("Formularz musi zawierać liczbę dodatnią", "ostrzeżenie");

            }
        }
        private bool czyPierwsza(int n)
        {
            int i = 1;
            while (i * i <= n)
            {
                i++;
            }
            for(int k = 2; k < i; k++)
            {
                if (n % k == 0)
                    return false;
            }
            return true;
        }
    }
}
