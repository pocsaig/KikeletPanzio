using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace KikeletPanzio_PocsaiG
{
    /// <summary>
    /// Interaction logic for FoglaloWindow.xaml
    /// </summary>
    public partial class FoglaloWindow : Window
    {
        public static Button kattintottSzoba;
        public FoglaloWindow()
        {
            InitializeComponent();
            btnFoglalSzoba1.Content = MainWindow.szobak[0].KIIR();
            btnFoglalSzoba2.Content = "Foglalt: Admin";
            btnFoglalSzoba3.Content = MainWindow.szobak[2].KIIR();
            btnFoglalSzoba4.Content = MainWindow.szobak[3].KIIR();
            btnFoglalSzoba5.Content = MainWindow.szobak[4].KIIR();
            btnFoglalSzoba6.Content = MainWindow.szobak[5].KIIR();

            
        }

        public void btnFoglalSzoba1_Click(object sender, RoutedEventArgs e)
        {
            kattintottSzoba = sender as Button;
            BejelentkezesVRegisztracio();
        }

        private void btnFoglalSzoba2_Click(object sender, RoutedEventArgs e)
        {
            kattintottSzoba = sender as Button;
            BejelentkezesVRegisztracio();
        }

        private void btnFoglalSzoba3_Click(object sender, RoutedEventArgs e)
        {
            kattintottSzoba = sender as Button;
            BejelentkezesVRegisztracio();
        }

        private void btnFoglalSzoba4_Click(object sender, RoutedEventArgs e)
        {
            kattintottSzoba = sender as Button;
            BejelentkezesVRegisztracio();
        }

        private void btnFoglalSzoba5_Click(object sender, RoutedEventArgs e)
        {
            kattintottSzoba = sender as Button;
            BejelentkezesVRegisztracio();
        }

        private void btnFoglalSzoba6_Click(object sender, RoutedEventArgs e)
        {
            kattintottSzoba = sender as Button;
            BejelentkezesVRegisztracio();
        }

        private void BejelentkezesVRegisztracio()
        {
            if (MessageBox.Show("Visszatérő?", "idk", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                VisszaTeroWindow ujVisszateroWindow = new VisszaTeroWindow();
                ujVisszateroWindow.Show();
            }
            else
            {
                RegisztracioWindow ujRegisztracioWindow = new RegisztracioWindow();
                ujRegisztracioWindow.Show();
            }
        }

        private void menuUgyfelek_Click(object sender, RoutedEventArgs e)
        {
            UgyfelekWindow ujUgyfelekWindow = new UgyfelekWindow();
            Close();
            ujUgyfelekWindow.Show();
        }

        private void menuStats_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
