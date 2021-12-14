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
            grid.Background = Brushes.LightCyan;
            canvasRectangle.Fill = Brushes.PeachPuff;
            canvas.Background = Brushes.White;
            gridRectangle.Fill = Brushes.White;
        }

        bool isGrid = true;
        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            if (isGrid)
            {
                canvas.Background = Brushes.PeachPuff;
                canvasRectangle.Fill = Brushes.White;
                grid.Background = Brushes.White;
                gridRectangle.Fill = Brushes.LightCyan;
                isGrid = false;
            }
            else
            {
                grid.Background = Brushes.LightCyan;
                canvasRectangle.Fill = Brushes.PeachPuff;
                canvas.Background = Brushes.White;
                gridRectangle.Fill = Brushes.White;
                isGrid = true;
            }
        }
    }
}
