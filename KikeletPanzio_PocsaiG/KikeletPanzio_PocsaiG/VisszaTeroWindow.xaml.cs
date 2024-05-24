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

namespace KikeletPanzio_PocsaiG
{
    /// <summary>
    /// Interaction logic for VisszaTeroWindow.xaml
    /// </summary>
    public partial class VisszaTeroWindow : Window
    {
        public VisszaTeroWindow()
        {
            InitializeComponent();
        }

        private void btnVisszateroBejelentkezes_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxVisszateroEmail.Text != "")
            {
                for (int i = 0; i < MainWindow.ugyfelek.Count; i++)
                {
                    if (txtBoxVisszateroEmail.Text == MainWindow.ugyfelek[i].Email)
                    {
                        MessageBox.Show("Beazonosítva: ");
                        Close();
                        return;
                    }
                    
                }
                MessageBox.Show("Nincs ilyen!");
            }
            else
            {
                MessageBox.Show("Üres mező!");
            }

        }
    }
}
