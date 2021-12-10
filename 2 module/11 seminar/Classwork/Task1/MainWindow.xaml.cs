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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button button = new Button();
            button.Content = "Hello";
            button.Width = 100;
            button.Height = 100;
            layout.Children.Add(button);
            button.Click += Button1_Click;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi, "+textbox1.Text);
        }
            private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("!!!");
        }
    }
}
