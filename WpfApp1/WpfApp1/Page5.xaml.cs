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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            int a1, b1, c1, a2, b2, c2;
            double d, x, y;

            TextAnswer.Clear();

            if(!int.TryParse(TbNumberA1.Text, out a1))
            {
                MessageBox.Show("Число А1 - только число");
            }
            if (!int.TryParse(TbNumberA2.Text, out a2))
            {
                MessageBox.Show("Число А2 - только число");
            }
            if (!int.TryParse(TbNumberB1.Text, out b1))
            {
                MessageBox.Show("Число B1 - только число");
            }
            if (!int.TryParse(TbNumberB2.Text, out b2))
            {
                MessageBox.Show("Число B2 - только число");
            }
            if (!int.TryParse(TbNumberC1.Text, out c1))
            {
                MessageBox.Show("Число C1 - только число");
            }
            if (!int.TryParse(TbNumberC2.Text, out c2))
            {
                MessageBox.Show("Число C2 - только число");
            }

            d = a1 * b2 - a2 * b1;
            x = (c1 * b2 - c2 * b1) / d;
            y = (a1 * c2 - a2 * c1) / d;
            TextAnswer.Text += $"X = {x:f3}\nY = {y:f3}";
        }
    }
}
