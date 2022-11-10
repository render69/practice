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
using static System.Math; // что бу не писать Meth. и тд

namespace BNDProject
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
            butt.Content = "уравнение 1 готово";
            double a = 0.7, b = 0.05, x = 0.5;
            double r = Pow(x, 2) + (x + 1) / b - Pow(Sin(x + a), 2);


            yraw.Content = String.Format("r = {0:f4}", r);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cnop.Content = "уравнение 2 готово";
            double a = 0.7, b = 0.05, x = 0.5;
            double s = Sqrt(x * b / a) + Pow(Cos(Pow((x + b), 3)), 2);
            yraww.Content = String.Format("s = {0:f4}", s);
        }

        private void buttt_Click(object sender, RoutedEventArgs e)
        {
            buttt.Content = "уравнение 3 готово";
            double m = 2, b = 0.7, g = 2, c = -1, t = 1.2;
            double f = Pow((m * t * g * t) - Abs(c * Sin(t)) , 1.0 / 3);
            yrawww.Content = String.Format("f = {0:f4}", f);
        }

        private void butttt_Click(object sender, RoutedEventArgs e)
        {
            butttt.Content = "уравнение 4 готово";
            double m = 2, b = 0.7, g = 2, c = -1, t = 1.2;
            double z = m * Cos(b * t * Sin(t) + c);
            yrawwww.Content = String.Format("z = {0:f4}", z);
        }
    }
}
