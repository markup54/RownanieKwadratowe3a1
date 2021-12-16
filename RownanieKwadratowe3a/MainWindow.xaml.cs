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

namespace RownanieKwadratowe3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double a, b, c, d;
        private string atxt, btxt, ctxt;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            atxt = txta.Text;
            btxt = txtb.Text;
            ctxt = txtc.Text;
            a = double.Parse(atxt);
            b = double.Parse(btxt);
            c = double.Parse(ctxt);
            if (a == 0)
            {
                blad.Content = "By równanie było kwadratowe a musi\nbyć różne od 0";
            }
            else
            {
                string str_a;
                string str_b;
                string str_c;
                switch (a)
                {
                    case 1:
                        str_a = "x²";
                        break;
                    default:
                        str_a = atxt + "x²";
                        break;
                }
                switch (b)
                {
                    case 0:
                        str_b = "";
                        break;
                    case 1:
                        str_b = "x";
                        break;
                    default:
                        str_b = btxt + "x";
                        break;
                }
                switch (c)
                {
                    case 0:
                        str_c = "";
                        break;
                    default:
                        str_c = ctxt;
                        break;
                }
                rownanie.Content = str_a + ((str_b == "") ? "" : " + " + str_b) + ((str_c == "") ? "" : " + " + str_c);
                delta.Content = obliczanieDelty();
                d = obliczanieDelty();
            }
        }
        private double obliczanieDelty()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
