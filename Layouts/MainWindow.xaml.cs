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

namespace Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnDock.Click += Btn_Click;
            btnGrid.Click += Btn_Click;
            btnGridSplitter.Click += Btn_Click;
            btnStackPanel.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Content.ToString())
            {
                case "Dock":
                    {
                        Dock dock = new Dock();
                        dock.Show();
                        break;
                    }
                case "Grid":
                    {
                        Grid grid = new Grid();
                        grid.Show();
                        break;
                    }
                case "GridSplitter":
                    {
                        GridSplitter gridSplitter = new GridSplitter();
                        gridSplitter.Show();
                        break;
                    }
                case "StackPanel":
                    {
                        StackPanel stackPanel = new StackPanel();
                        stackPanel.Show();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
