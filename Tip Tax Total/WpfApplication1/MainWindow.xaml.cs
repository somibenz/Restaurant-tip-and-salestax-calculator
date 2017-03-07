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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int amount = int.Parse(textBox.Text);
                decimal tip = amount * 0.15m;
                label.Content = tip;
                decimal tax = amount * 0.07m;
                label1.Content = tax;
                decimal total = amount + tip + tax;
                label2.Content = total;
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a number");
            }
          
        }
    }
}
