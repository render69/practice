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

namespace BNDProd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double h = 0.5;
            double y = 999;
            double a = 2, x = a;
            listbox11.Items.Clear();
            listbox11.Items.Add("     x   " + "          y     ");
            int n = Convert.ToInt32(Math.Round((12 - 2) / h) + 1);
            double sum = 0.0;
            //int count = 0;
            for (int i = 1; i <= n; i++)
            {
                string formula = "";
                if (x > 6)
                {
                    y = Math.Pow(x, 1.0 / 3);//особенность деления с плав. точкой
                    formula = "y=x^1/3";
                }
                else if (x < 5)
                {
                    y = 2 * Math.Sin(x);
                    formula = "y=2sin*x";
                }
                else if (5 <= x && x <= 6)
                {
                    y = Math.Sqrt(x + 1);
                    formula = "y=x+1/x+1";
                }
                listbox11.Items.Add(String.Format("{0,2:d}",i) + ") x = " + 
                    String.Format("{0,5:f2}",x) + 
                    " y = " + String.Format("{0,5:f2} ", y) + formula);
                sum += y;
               // if (y < 0)
               //     count++;
                x = x + h;
            }
            listbox11.Items.Add("Сумма значений y = " + String.Format("{0,4:f2} ", sum));
            //listbox11.Items.Add("Сумма значений y = " + count);
        }
    }
}
