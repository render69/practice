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

namespace BNDProd2d
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

        private void but_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Txt_x_1.Text);
            double a = Convert.ToDouble(Txt_a_1.Text);
            double y = Convert.ToDouble(Txt_y_1.Text);
            double b = Convert.ToDouble(Txt_b_1.Text);
            double z = -999;
            if (3 <= x && x <= 4)
                z = Min(a, Max(x, Max(y, b)));
            else
                z = Pow(x, 3) - y * Sqrt(b) * Pow(Log(Abs(x)), 2);   
            outin.Content = String.Format("{0:f4}", z);
        }

        private void but_Click_2(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Txt_x_1_Copy1.Text);
            double c = Convert.ToDouble(Txt_c_1_Copy1.Text);
            double b = Convert.ToDouble(Txt_b_1_Copy1.Text);
            double z = -999, cx = c*x;
            if (0 <= x && x <= 1)
                z = Cos(1 - (Pow (cx, 2) / b));
            else if (x > 1)
                z = Max(c, Max(x, Min(Sqrt(x), Min(Sqrt(b), c))));
            else if (x < 0)
                z = Exp(b * x + c);
            outin1.Content = String.Format("{0:f4}", z);
        }
    }
}
