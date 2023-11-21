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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            double n, c, z;
            TextAnswer.Clear();

            if (!double.TryParse(NumberNTextBox.Text, out n))
            {
                MessageBox.Show("Число F - только число");
            }

            z = (n + Cos(n + 1) / Sin(n + 1)) / Sin(n + 1);
            c = Abs((n + Pow(z, 5)) / (3 + z));

            TextAnswer.Text += $"C = {c:f3}";
        }
    }
}
