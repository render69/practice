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

namespace BNDReoject_2
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
            double b = Convert.ToDouble(number_b_2_1.Text);
            double x = Convert.ToDouble(number_x_2_1.Text);
            double y = -999, bx = b * x;
            if (bx < 1)
                y = bx - Math.Log(bx);
            else if (bx == 1)
                y = 1;
            else if (bx > 1)
                y = bx + Math.Log(bx);
            answer_1.Content = string.Format("{0:f4}", y);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(number_x_2_2.Text);
            double y = -999;
            if (x > 1)
                y = Math.Log(x + 1);
            else if (x == 1)
                y = Math.Sin(Math.Sqrt(Math.Abs(x)));
            else if (x < 1)
                y = Math.Cos(x * x + 2 * 10 * -5);
            answer_2.Content = string.Format("{0:f4}", y);
        }
    }
}
