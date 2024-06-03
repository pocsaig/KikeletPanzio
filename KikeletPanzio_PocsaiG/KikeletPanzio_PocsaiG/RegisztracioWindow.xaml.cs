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
        public static string nev;
        public static int ferohelyReg = 0;
        public static DatePicker ujDtPickerStartReg = new DatePicker();
        public static DatePicker ujDtPickerEndReg = new DatePicker();
        public RegisztracioWindow()
        {
            InitializeComponent();
            //ferohelyReg = Convert.ToInt32(FoglaloWindow.kattintottSzoba.Name[FoglaloWindow.kattintottSzoba.Name.Length - 1]);
            if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba1")
            {
                ferohelyReg = 2;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba2")
            {
                ferohelyReg = 3;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba3")
            {
                ferohelyReg = 4;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba4")
            {
                ferohelyReg = 2;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba5")
            {
                ferohelyReg = 4;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba6")
            {
                ferohelyReg = 4;
            }
        }

        private void btnUgyfelRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxRegNev.Text != "")
            {
                if (dtPickerRegSzuletesiDatum.SelectedDate.HasValue == true && txtBoxRegEmail.Text != "") //van dátum, van email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, dtPickerRegSzuletesiDatum.SelectedDate.Value, txtBoxRegEmail.Text, true, false));
                    Foglalasos();
                    
                }
                else if (dtPickerRegSzuletesiDatum.SelectedDate.HasValue == true && txtBoxRegEmail.Text == "") //van dátum, nincs email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, dtPickerRegSzuletesiDatum.SelectedDate.Value, txtBoxRegEmail.Text, false, false));
                    Foglalasos();
                    
                }
                else if (dtPickerRegSzuletesiDatum.SelectedDate.HasValue == false && txtBoxRegEmail.Text != "") //nincs dátum, van email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, dtPickerRegSzuletesiDatum.SelectedDate.Value, txtBoxRegEmail.Text, false, false));
                    Foglalasos();
                    
                }
                else //nincs dátum, nincs email
                {
                    MainWindow.ugyfelek.Add(new Ugyfel(txtBoxRegNev.Text, DateTime.MinValue, txtBoxRegEmail.Text, false, false));
                    Foglalasos();
                    FoglaloWindow ujFoglaloWindow = new FoglaloWindow();
                    ujFoglaloWindow.btnFoglalSzoba4.IsEnabled = false;
                    
                }
            }
            else
            {
                MessageBox.Show("Nincs kitöltve a NÉV mező!");
            }

            
        }

        

        private void Foglalasos()
        {
            for (int i = 0; i < MainWindow.ugyfelek.Count; i++)
            {
                if (txtBoxRegNev.Text == MainWindow.ugyfelek[i].Nev)
                {
                    MessageBox.Show("Beregisztrálva");
                    nev = txtBoxRegNev.Text;
                    stckPanelReg.Children.Clear();
                    Label ujLabelCMBreg = new Label();
                    ujLabelCMBreg.Content = "Hány fő:";
                    ujLabelCMBreg.Margin = new Thickness(10);
                    ComboBox ujComboBoxReg = new ComboBox();
                    ujComboBoxReg.Margin = new Thickness(10);
                    for (int j = 1; j < ferohelyReg + 1; j++)
                    {
                        ujComboBoxReg.Items.Add(j.ToString());
                    }
                    ujComboBoxReg.SelectedIndex = 0;
                    stckPanelReg.Children.Add(ujComboBoxReg);
                    Label ujLblStartReg = new Label();
                    ujLblStartReg.Margin = new Thickness(10);
                    ujLblStartReg.Content = "Mettől:";
                    stckPanelReg.Children.Add(ujLblStartReg);

                    ujDtPickerStartReg.Margin = new Thickness(10);
                    stckPanelReg.Children.Add(ujDtPickerStartReg);
                    Label ujLblEnd = new Label();
                    ujLblEnd.Margin = new Thickness(10);
                    ujLblEnd.Content = "Meddig:";
                    stckPanelReg.Children.Add(ujLblEnd);

                    ujDtPickerEndReg.Margin = new Thickness(10);
                    stckPanelReg.Children.Add(ujDtPickerEndReg);
                    Button ujBtnFoglalReg = new Button();
                    ujBtnFoglalReg.Content = "Foglalás";
                    ujBtnFoglalReg.Click += NevKereses_Click;
                    stckPanelReg.Children.Add(ujBtnFoglalReg);



                    return;
                }

            }
            MessageBox.Show("Nincs ilyen!");
        }

        private void NevKereses_Click(object sender, RoutedEventArgs e)
        {
            FoglaloWindow.kattintottSzoba.IsEnabled = false;
            for (int j = 0; j < MainWindow.ugyfelek.Count; j++)
            {
                if (MainWindow.ugyfelek[j].Nev == nev)
                {
                    FoglaloWindow.kattintottSzoba.Content = $"Foglalt: {MainWindow.ugyfelek[j].Nev}";
                    FoglaloWindow.kattintottSzoba.Content += $"\n{ujDtPickerStartReg.SelectedDate} - {ujDtPickerEndReg.SelectedDate}";
                    break;
                }
            }
            Close();
        }
    }
}
