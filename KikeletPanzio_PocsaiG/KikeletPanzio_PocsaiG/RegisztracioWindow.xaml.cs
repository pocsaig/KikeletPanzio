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
    /// Interaction logic for RegisztracioWindow.xaml
    /// </summary>
    public partial class RegisztracioWindow : Window
    {
        public RegisztracioWindow()
        {
            InitializeComponent();
        }

        private void btnUgyfelRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxRegNev.Text != "")
            {
                if (dtPickerRegSzuletesiDatum.SelectedDate.HasValue == true && txtBoxRegEmail.Text != "") //van dátum, van email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, dtPickerRegSzuletesiDatum.SelectedDate.Value, txtBoxRegEmail.Text, true, false));
                }
                else if (dtPickerRegSzuletesiDatum.SelectedDate.HasValue == true && txtBoxRegEmail.Text == "") //van dátum, nincs email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, dtPickerRegSzuletesiDatum.SelectedDate.Value, txtBoxRegEmail.Text, false, false));
                }
                else if (dtPickerRegSzuletesiDatum.SelectedDate.HasValue == false && txtBoxRegEmail.Text != "") //nincs dátum, van email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, dtPickerRegSzuletesiDatum.SelectedDate.Value, txtBoxRegEmail.Text, false, false));  //Ha nincs value mivan?? meg kell nézni
                }
                else //nincs dátum, nincs email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, dtPickerRegSzuletesiDatum.SelectedDate.Value, txtBoxRegEmail.Text, false, false));
                }
            }
            else
            {
                MessageBox.Show("Nincs kitöltve a NÉV mező!");
            }
            MessageBox.Show(string.Join(" ", MainWindow.ugyfelek));

        }
    }
}
