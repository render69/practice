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
namespace BNDProd_list
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
            double a = Convert.ToDouble(box1.Text);
            double b = Convert.ToDouble(box2.Text);
            double h = Convert.ToDouble(box3.Text);
            double x = a;
            int n = Convert.ToInt32(Round((b - a) / h) + 1);
            listbox11.Items.Clear();
            listbox11.Items.Add("     x   " + "          y     ");
            for (int i = 1; i <= n; i++)
            {
                double y = Cos(x) + Atan(x);
                listbox11.Items.Add("     ");
                listbox11.Items.Add("    " + x.ToString() + "          " + y.ToString());
                x = x + h;
            }



        }
    }
}
