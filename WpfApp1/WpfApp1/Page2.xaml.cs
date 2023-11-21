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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            
            TextAnswer.Clear();

            if (!int.TryParse(NumberATextBox.Text, out a))
            {
                MessageBox.Show("Число А - только число");
            }

            if (!int.TryParse(NumberBTextBox.Text, out b))
            {
                MessageBox.Show("Число B - только число");
            }

            c = a;
            a = b;
            b = c;

            TextAnswer.Text += $"A = {a}\nB = {b}";
        }
    }
}
