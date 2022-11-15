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
using static System.Math;

namespace _15._11_1
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

        private void butt_Click(object sender, RoutedEventArgs e)
        {
            double a = 0;
            double b = 2 * PI;
            double h = PI / 8;
            double y = 1;
            double x = a;
            listbox1.Items.Clear();
            listbox1.Items.Add("     x   " + "          y     ");
            int n = Convert.ToInt32(Round((b - a) / h) + 1);
            double sum = 0.0;
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                y = 0.5 - 0.1 - Sin(x);
                listbox1.Items.Add($"{i,2:d}) x = {x,5:f2} y = {y,5:f2}");
                if (y < 0)
                    sum += x;
                    count++;
                x = x + h;
            }
            listbox1.Items.Add($"Сумма значений x = {sum,4:f2} ");
            listbox1.Items.Add("Меньше 0 : " + count);
        }
    }
}
