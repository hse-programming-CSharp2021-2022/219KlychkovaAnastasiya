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
using System.Windows.Threading;
namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Windo_tick;
            timer.Start();
        }

        private void Windo_tick(object sender,EventArgs e)
        {
            if (button.IsVisible)
            {
                button.Visibility = Visibility.Hidden;
            }
            else
            {
                button.Visibility = Visibility.Visible;
            }
        }
        int plus = 0;
        int minus = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            plus++;
            t1.Text = plus.ToString();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            minus++;
            t2.Text = minus.ToString();
        }
    }
}
