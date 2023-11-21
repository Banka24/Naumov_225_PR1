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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            TextAnswer.Clear();

            if (!double.TryParse(NumberFTextBox.Text, out double f))
            {
                MessageBox.Show("Число F - только число");
            }

            double c = (f - 32) * 5 / 9;

            TextAnswer.Text += $"Температура в С: {c:f3}";
        }
    }
}
