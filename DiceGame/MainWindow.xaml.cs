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

namespace DiceGame
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
            
            Random rd = new Random();
            int num1 = rd.Next(1, 7);
            textblock.Text = Convert.ToString(num1);

            string route = Convert.ToString(AppDomain.CurrentDomain.BaseDirectory) + "/images/" + Convert.ToString(num1) + ".png";

            Uri imguri = new Uri(route);
            BitmapImage img = new BitmapImage(imguri);

            popo.Source = img;
            
        }
    }
}
