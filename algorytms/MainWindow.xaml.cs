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

namespace algorytms
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

        private void silnia(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(pier.Text, out int liczba1)&& int.TryParse(drug.Text, out int liczba2))
            {
                long value = liczba1;
                if (liczba2>17)
                {
                    for (int i = liczba1+1; i <= liczba2; i++)
                    {
                    value *= i;
                    }
                    MessageBox.Show(value.ToString(), "wynik",MessageBoxButton.OK,  MessageBoxImage.Warning);

                }
                
            }
        }

        private void nwd(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(pier.Text, out int liczba1) && int.TryParse(drug.Text, out int liczba2))
            {
                int value;
                while (liczba1 != liczba2)
                {
                    if (liczba1>liczba2)
                    {
                        liczba1 -= liczba2;
                    }
                    else
                    {
                        liczba2 -= liczba1;
                    }
                }
                value = liczba1;
                MessageBox.Show(value.ToString(), "wynik");
            }
        }

        private void potega(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(pier.Text, out int liczba1) && int.TryParse(drug.Text, out int liczba2))
            {
                float value = MathF.Pow(liczba1, liczba2);
                MessageBox.Show(value.ToString(), "wynik");
            }
        }

        private void pierwsze(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(pier.Text, out int liczba1) && int.TryParse(drug.Text, out int liczba2))
            {
                if (liczba1<2)
                {
                    liczba1 = 2;
                }
                if (liczba1>liczba2)
                {
                    int temp = liczba1;
                    liczba1 = liczba2;
                    liczba2 = temp;
                }
                for(int i = liczba1; i <= liczba2; i++)
                {
                    bool pierwsza = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            pierwsza=false;
                            break;
                        }
                    }
                    if (pierwsza)
                    {
                        MessageBox.Show(i.ToString(), "liczba pierwsza", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
