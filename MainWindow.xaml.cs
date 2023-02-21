using System;
using System.Collections.Generic;
using System.IO;
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

namespace EAST_COAST_RAIL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
;           BookingWindow window = new BookingWindow();
            window.Show();
            this.Close();
        }

        private void MANIFESTS_Click(object sender, RoutedEventArgs e)
        {
            ManifestWindow window = new ManifestWindow();
            window.Show();
            this.Close();
        }
    }
}
