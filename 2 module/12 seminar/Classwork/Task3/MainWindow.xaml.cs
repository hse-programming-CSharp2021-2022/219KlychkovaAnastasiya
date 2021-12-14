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

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock block = new TextBlock();
            StackPanel panel = new StackPanel();
            Slider slider = new Slider();

            slider.Minimum = -10;
            slider.Maximum = 10;
            slider.Orientation = Orientation.Horizontal;
            slider.Margin = new Thickness(10);
            slider.ValueChanged += (s, e) =>
            {
                block.Text = slider.Value.ToString("F2");
            };

            block.HorizontalAlignment = HorizontalAlignment.Center;
            block.FontSize = 40;
            block.Text = "0";

            panel.Children.Add(slider);
            panel.Children.Add(block);
            this.Content = panel;
        }
    }
}
