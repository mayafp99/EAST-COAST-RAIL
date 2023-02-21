using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Permissions;
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
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        public BookingWindow()
        {
            InitializeComponent();
            {
                
            }
        }
        /* --- departure + stop + arrival storage ---
         * cycle through the different checkboxes.
         * if one is checked, meaning its corresponding boolean is set to "true",
         * we set the corresponding variable (departure/arrival)
         * to the location corresponding to the checked box.
         */
         
        string departureStop;
        string trainStops;
        string destinationStop;
        string meal;
        string ticketType;
        private void departureWaverley_Checked(object sender, RoutedEventArgs e)
        {
            if (departureWaverley.IsChecked == true)
            {
                departureStop = "Edinburgh Waverley";
            }

        }
        private void departureLondon_Checked(object sender, RoutedEventArgs e)
        {
            if (departureLondon.IsChecked == true)
            {
                departureStop = "London King's Cross";
            }
        }
        private void departureStops_Checked(object sender, RoutedEventArgs e)
        {
            if (stopDeparture.IsChecked == true)
            {
                departureStop = "Newcastle/York";
            }
        }

        private void interStops_Checked(object sender, RoutedEventArgs e)
        {
            if (interStops.IsChecked == true)
            {

                trainStops = "Else";
            }
            else
            {
                trainStops = "No";
            }
        }
        private void waverleyArrival_Checked(object sender, RoutedEventArgs e)
        {
            if (waverleyArrival.IsChecked == true)
            {
                destinationStop = "Edinburgh Waverley";
            }
        }

        private void londonArrival_Checked(object sender, RoutedEventArgs e)
        {
            if (londonArrival.IsChecked == true)
            {
                destinationStop = "London King's Cross";
            }
        }
        private void stopsArrival_Checked(object sender, RoutedEventArgs e)
        {
            if (stopsArrival.IsChecked == true)
            {
                destinationStop = "Newcastle/York";
            }
        }
        /* --- window buttons ---
         * if home is clicked the main window shows and this one quits.
         * if generate manifest is clicked, that window shows, and this one quits.
         */
        private void home_click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void manifest_click(object sender, RoutedEventArgs e)
        {
            TicketManifestWindow window = new TicketManifestWindow();

            window.Show();
            this.Close();
        }
        /* --- class selection --
         * if first class is selected, a secondary window pops up
         * prompting the user to select 
         * whether they would like to book a meal or not.
         */


        /* --- booked ticket input ---
         * stores how many tickets a user booked into
         * 
         */

        public void yesSeats_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void yesMeal_Checked(object sender, RoutedEventArgs e)
        {
             meal = "yes"; 
        }

        public void noMeal_Checked(object sender, RoutedEventArgs e)
        {
             meal = "no";
        }

        public void firstClass_Checked(object sender, RoutedEventArgs e)
        {
             ticketType = "First";
        }
        public void Standard_Checked(object sender, RoutedEventArgs e)
        {
             ticketType = "Standard";
        }
        public void seatCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string seatCodeNumber;
            seatCodeNumber = seatCode.Text;
        }

        public void tktNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tixNum;
            tixNum = tktNumber.Text;
        }

        public string getMeal()
        {
            return this.meal;
        }
    }
}
    
