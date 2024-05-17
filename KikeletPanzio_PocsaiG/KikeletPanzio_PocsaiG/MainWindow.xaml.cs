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

namespace KikeletPanzio_PocsaiG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Szoba> szobak = new List<Szoba>();
        public static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        public MainWindow()
        {
            InitializeComponent();
            szobak.Add(new Szoba(1, 2, 6000, false));
            szobak.Add(new Szoba(2, 3, 8000, false));
            szobak.Add(new Szoba(3, 4, 10500, false));
            szobak.Add(new Szoba(4, 2, 7500, false));
            szobak.Add(new Szoba(5, 4, 11000, false));
            szobak.Add(new Szoba(6, 4, 12000, false));
            
        }

        private void btnBejelentkezes_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxAdminF.Text == "admin" && txtBoxAdminJ.Text == "asd")
            {
                FoglaloWindow ujFoglaloWindow = new FoglaloWindow();
                ujFoglaloWindow.Show();
            }
            else
            {
                MessageBox.Show("Helytelen felhasználónév, vagy jelszó!");
            }
        }
    }
}
