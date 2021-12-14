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

namespace Task1._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid grid;
        Canvas canvas;
        Slider horisontalSlider;
        Slider verticalSlider;
        Button button;
        Polyline line;
        public MainWindow()
        {
            InitializeComponent();

            grid = new Grid();
            canvas = new Canvas();
            horisontalSlider = new Slider();
            verticalSlider = new Slider();
            button = new Button();
            line = new Polyline();

            grid.ShowGridLines = true;
            var c1 = new ColumnDefinition();
            c1.Width = GridLength.Auto;
            var r2 = new RowDefinition();
            r2.Height = GridLength.Auto;
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(r2);
            grid.ColumnDefinitions.Add(c1);
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            this.Content = grid;

            grid.Children.Add(canvas);
            Grid.SetColumn(canvas, 1);
            Grid.SetRow(canvas, 0);
            canvas.Background = Brushes.LemonChiffon;

            grid.Children.Add(horisontalSlider);
            Grid.SetColumn(horisontalSlider, 1);
            Grid.SetRow(horisontalSlider, 1);
            horisontalSlider.Orientation = Orientation.Horizontal;
            horisontalSlider.Minimum = 0;
            horisontalSlider.Maximum = 400;
            horisontalSlider.ValueChanged += AddPoint;

            grid.Children.Add(verticalSlider);
            Grid.SetColumn(verticalSlider, 0);
            Grid.SetRow(verticalSlider, 0);
            verticalSlider.Orientation = Orientation.Vertical;
            verticalSlider.Minimum = 0;
            verticalSlider.Maximum = 400;
            verticalSlider.ValueChanged += AddPoint;

            canvas.Children.Add(line);
            line.Stroke = Brushes.Black;
            line.StrokeThickness = 3;
            line.Points.Add(new Point(0,0));

            grid.Children.Add(button);
            Grid.SetColumn(button, 0);
            Grid.SetRow(button, 1);
            button.Content = "Clear";
            button.Click += Clear;
        }
        private void AddPoint(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            line.Points.Add(new Point(horisontalSlider.Value, verticalSlider.Value));
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            line.Points.Clear();
        }
    }
}
