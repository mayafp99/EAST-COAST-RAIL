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
using System.Windows.Shapes;

namespace EAST_COAST_RAIL
{
    /// <summary>
    /// Interaction logic for TicketManifestWindow.xaml
    /// </summary>
    public partial class TicketManifestWindow : Window
    {
        public TicketManifestWindow()
        {
            InitializeComponent();
            string bookings = System.IO.File.ReadAllText(@"C:\Users\Mayaf\OneDrive\Documents\40528965_CW2\EAST COAST RAIL\BOOKING MANIFEST.csv");
            string[] bookingList = bookings.Split(',');
        }

        public void finalBooking_Click(object sender, RoutedEventArgs e)
        {
            mealDisplay.Content = BookingWindow.getMeal;
            typeDisplay.Content = ticketType;
        }

        public void home3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }


    }
}
