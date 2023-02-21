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
using System.Windows.Shapes;

namespace EAST_COAST_RAIL
{
    /// <summary>
    /// Interaction logic for ManifestWindow.xaml
    /// </summary>
    public partial class ManifestWindow : Window
    {
        public ManifestWindow()
        {
            InitializeComponent();
        }

        private void home2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void trainIdSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
