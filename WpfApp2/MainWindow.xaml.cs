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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            var sender2 = sender as TextBox;
            sender2.Text = "";
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            var sender2 = sender as TextBox;
            if(sender2.Text.Length<1)
            {
                sender2.Text = "Search";
            }
        }
    }
}
