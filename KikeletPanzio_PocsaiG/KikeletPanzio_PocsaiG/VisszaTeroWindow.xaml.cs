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
using System.Threading;
using System.Windows.Threading;

namespace KikeletPanzio_PocsaiG
{
    /// <summary>
    /// Interaction logic for VisszaTeroWindow.xaml
    /// </summary>
    public partial class VisszaTeroWindow : Window
    {
        public static string email;
        public static int ferohely = 0;
        public static DatePicker ujDtPickerStart = new DatePicker();
        public static DatePicker ujDtPickerEnd = new DatePicker();
        public VisszaTeroWindow()
        {
            InitializeComponent();
            if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba1")
            {
                ferohely = 2;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba2")
            {
                ferohely = 3;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba3")
            {
                ferohely = 4;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba4")
            {
                ferohely = 2;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba5")
            {
                ferohely = 4;
            }
            else if (FoglaloWindow.kattintottSzoba.Name == "btnFoglalSzoba6")
            {
                ferohely = 4;
            }

        }

        private async void btnVisszateroBejelentkezes_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxVisszateroEmail.Text != "")
            {
                for (int i = 0; i < MainWindow.ugyfelek.Count; i++)
                {
                    if (txtBoxVisszateroEmail.Text == MainWindow.ugyfelek[i].Email)
                    {
                        MessageBox.Show("Beazonosítva");
                        email = txtBoxVisszateroEmail.Text;
                        stckPanelVisszaTero.Children.Clear();
                        Label ujLabelCMB = new Label();
                        ujLabelCMB.Content = "Hány fő:";
                        ujLabelCMB.Margin = new Thickness(10);
                        ComboBox ujComboBox = new ComboBox();
                        ujComboBox.Margin = new Thickness(10);
                        for (int j = 1; j < ferohely + 1; j++)
                        {
                            ujComboBox.Items.Add(j.ToString());
                        }
                        ujComboBox.SelectedIndex = 0;
                        stckPanelVisszaTero.Children.Add(ujComboBox);
                        Label ujLblStart = new Label();
                        ujLblStart.Margin = new Thickness(10);
                        ujLblStart.Content = "Mettől:";
                        stckPanelVisszaTero.Children.Add(ujLblStart);
                        
                        ujDtPickerStart.Margin = new Thickness(10);
                        stckPanelVisszaTero.Children.Add(ujDtPickerStart);
                        Label ujLblEnd = new Label();
                        ujLblEnd.Margin = new Thickness(10);
                        ujLblEnd.Content = "Meddig:";
                        stckPanelVisszaTero.Children.Add(ujLblEnd);
                        
                        ujDtPickerEnd.Margin = new Thickness(10);
                        stckPanelVisszaTero.Children.Add(ujDtPickerEnd);
                        Button ujBtnFoglal = new Button();
                        ujBtnFoglal.Content = "Foglalás";
                        ujBtnFoglal.Click += EmailKereses_Click;
                        stckPanelVisszaTero.Children.Add(ujBtnFoglal);



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

        private void EmailKereses_Click(object sender, RoutedEventArgs e)
        {
            FoglaloWindow.kattintottSzoba.IsEnabled = false;
            for (int j = 0; j < MainWindow.ugyfelek.Count; j++)
            {
                if (MainWindow.ugyfelek[j].Email == email)
                {
                    FoglaloWindow.kattintottSzoba.Content = $"Foglalt: {MainWindow.ugyfelek[j].Nev}";
                    FoglaloWindow.kattintottSzoba.Content += $"\n{ujDtPickerStart.SelectedDate} - {ujDtPickerEnd.SelectedDate}";
                    break;
                }
            }
            Close();
        }
    }
}
