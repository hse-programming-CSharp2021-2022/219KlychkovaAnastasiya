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
        }

        private void set_Click(object sender, RoutedEventArgs e)
        {
            nameBlock.Text = $"Your name: {box.Text}";
            greetingBlock.Text = $"Hello, {box.Text}!";
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            nameBlock.Text = $"Your name: username";
            greetingBlock.Text = $"Hello, username!";
        }
    }
}
