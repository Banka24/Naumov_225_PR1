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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            int a, b; 
            double chast = 0, total, product, different;

            TextAnswer.Clear();

            if(!int.TryParse(NumberATextBox.Text, out a))
            {
                MessageBox.Show("Число А - только число");
            }

            if (!int.TryParse(NumberBTextBox.Text, out b))
            {
                MessageBox.Show("Число B - только число");
            }

            total = Pow(a, 2) + Pow(b, 2);
            product = Pow(a, 2) * Pow(b, 2);
            different = Pow(a, 2) - Pow(b, 2);

            if(b != 0)
            {
                chast = Pow(a, 2) / Pow(b, 2);
            }
            else
            {
                MessageBox.Show("На ноль делить");
            }
            TextAnswer.Text += $"Сложение: {total}\nПроизведение: {product}\nВычитание: {different}\nЧастное: {chast:f3}";
        }
    }
}
