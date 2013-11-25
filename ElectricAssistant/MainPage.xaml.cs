using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace ElectricAssistant
{
    public partial class MainPage : PhoneApplicationPage
    {
        private double digito1, digito2, digito3, multi, tol;


        public MainPage()
        {
            Thread.Sleep(650);
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            if (Lista4 != null) Lista4.Visibility = Visibility.Collapsed;
            if (caixa != null) caixa.Visibility = Visibility.Collapsed;

        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }
        private void About1(object sender, EventArgs eventArgs)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void Lista1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lista1 != null && Lista1.SelectedItem.ToString() == "Blue")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.Blue);
                digito1 = 6;
            }
            else if (Lista1 != null && Lista1.SelectedItem.ToString() == "Red")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.Red);
                digito1 = 2;
            }
            else if (Lista1 != null && Lista1.SelectedItem.ToString() == "White")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.White);
                digito1 = 9;
            }
            else if (Lista1 != null && Lista1.SelectedItem.ToString() == "Orange")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.Orange);
                digito1 = 3;
            }
            else if (Lista1 != null && Lista1.SelectedItem.ToString() == "Gray")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.Gray);
                digito1 = 8;
            }
            else if (Lista1 != null && Lista1.SelectedItem.ToString() ==
                     "Green")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.Green);
                digito1 = 5;
            }
            else if (
                Lista1 != null && Lista1.SelectedItem.ToString() ==
                "Violet")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.Purple);
                digito1 = 7;
            }
            else if
                (Lista1 != null && Lista1.SelectedItem.ToString() == "Yellow")
            {
                if (Colo1 != null) Colo1.Fill = new SolidColorBrush(Colors.Yellow);
                digito1 = 4;
            }
            else if (Lista1 != null && Lista1.SelectedItem.ToString() == "Black")
            {
                if (Colo1 != null)
                    Colo1.Fill = new SolidColorBrush(Colors.Black);
                digito1 = 0;
            }

            else
            {
                if (Colo1 != null)
                {
                    Colo1.Fill = new SolidColorBrush(Color.FromArgb(180, 210, 105, 30));
                    digito1 = 1;
                }
            }
            Calc_Click();
        }

        private void Lista2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lista2 != null && Lista2.SelectedItem.ToString() == "Blue")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.Blue);
                digito2 = 6;
            }
            else if (Lista2 != null && Lista2.SelectedItem.ToString() == "Red")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.Red);
                digito2 = 2;
            }
            else if (Lista2 != null && Lista2.SelectedItem.ToString() == "White")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.White);
                digito2 = 9;
            }
            else if (Lista2 != null && Lista2.SelectedItem.ToString() == "Orange")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.Orange);
                digito2 = 3;
            }
            else if (Lista2 != null && Lista2.SelectedItem.ToString() == "Gray")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.Gray);
                digito2 = 8;
            }
            else if (Lista2 != null && Lista2.SelectedItem.ToString() ==
                     "Green")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.Green);
                digito2 = 5;
            }
            else if (
                Lista2 != null && Lista2.SelectedItem.ToString() ==
                "Violet")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.Purple);
                digito2 = 7;
            }
            else if
                (Lista2 != null && Lista2.SelectedItem.ToString() == "Yellow")
            {
                if (Colo2 != null) Colo2.Fill = new SolidColorBrush(Colors.Yellow);
                digito2 = 4;
            }
            else if (Lista2 != null && Lista2.SelectedItem.ToString() == "Black")
            {
                if (Colo2 != null)
                    Colo2.Fill = new SolidColorBrush(Colors.Black);
                digito2 = 0;
            }

            else
            {
                if (Colo2 != null)
                {
                    Colo2.Fill = new SolidColorBrush(Color.FromArgb(180, 210, 105, 30));
                    digito2 = 1;
                }
            }
            Calc_Click();
        }


        private void Lista3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lista3 != null && Lista3.SelectedItem.ToString() == "Blue")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Colors.Blue);
                multi = 1000000;
            }
            else if (Lista3 != null && Lista3.SelectedItem.ToString() == "Red")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Colors.Red);
                multi = 100;
            }

            else if (Lista3 != null && Lista3.SelectedItem.ToString() == "Orange")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Colors.Orange);
                multi = 1000;
            }

            else if (Lista3 != null && Lista3.SelectedItem.ToString() ==
                     "Green")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Colors.Green);
                multi = 100000;
            }
            else if (
                Lista3 != null && Lista3.SelectedItem.ToString() ==
                "Violet")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Colors.Purple);
                multi = 10000000;
            }
            else if
                (Lista3 != null && Lista3.SelectedItem.ToString() == "Yellow")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Colors.Yellow);
                multi = 10000;
            }
            else if (Lista3 != null && Lista3.SelectedItem.ToString() == "Black")
            {
                if (Colo3 != null)
                    Colo3.Fill = new SolidColorBrush(Colors.Black);
                multi = 1;
            }
            else if (Lista3 != null && Lista3.SelectedItem.ToString() == "Gold")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 215, 0));
                multi = 0.1;
            }
            else if (Lista3 != null && Lista3.SelectedItem.ToString() == "Silver")
            {
                if (Colo3 != null) Colo3.Fill = new SolidColorBrush(Color.FromArgb(255, 192, 192, 192));
                multi = 0.01;
            }
            else
            {
                if (Colo3 != null)
                {
                    Colo3.Fill = new SolidColorBrush(Color.FromArgb(180, 210, 105, 30));
                    multi = 10;
                }
            }
            Calc_Click();
        }

        private void Lista4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (C2 != null && C2.IsEnabled)
            {
                if (Lista4 != null && Lista4.SelectedItem.ToString() == "Blue")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.Blue);
                    digito3 = 6;
                }
                else if (Lista4 != null && Lista4.SelectedItem.ToString() == "Red")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.Red);
                    digito3 = 2;
                }
                else if (Lista4 != null && Lista4.SelectedItem.ToString() == "White")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.White);
                    digito3 = 9;
                }
                else if (Lista4 != null && Lista4.SelectedItem.ToString() == "Orange")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.Orange);
                    digito3 = 3;
                }
                else if (Lista4 != null && Lista4.SelectedItem.ToString() == "Gray")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.Gray);
                    digito3 = 8;
                }
                else if (Lista4 != null && Lista4.SelectedItem.ToString() ==
                         "Green")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.Green);
                    digito3 = 5;
                }
                else if (
                    Lista4 != null && Lista4.SelectedItem.ToString() ==
                    "Violet")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.Purple);
                    digito3 = 7;
                }
                else if
                    (Lista4 != null && Lista4.SelectedItem.ToString() == "Yellow")
                {
                    if (Colo4 != null) Colo4.Fill = new SolidColorBrush(Colors.Yellow);
                    digito3 = 4;
                }
                else if (Lista4 != null && Lista4.SelectedItem.ToString() == "Black")
                {
                    if (Colo4 != null)
                        Colo4.Fill = new SolidColorBrush(Colors.Black);
                    digito3 = 0;
                }

                else
                {
                    if (Colo4 != null)
                    {
                        Colo4.Fill = new SolidColorBrush(Color.FromArgb(180, 210, 105, 30));
                        digito3 = 1;
                    }
                }
                Calc_Click();
            }
        }

        private void Lista5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lista5 != null && Lista5.SelectedItem.ToString() == "Gold")
            {
                if (Colo5 != null) Colo5.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 215, 0));
                tol = 5;
            }
            else if (Lista5 != null && Lista5.SelectedItem.ToString() == "Silver")
            {
                if (Colo5 != null) Colo5.Fill = new SolidColorBrush(Color.FromArgb(255, 192, 192, 192));
                tol = 10;
            }
            else if (Lista5 != null && Lista5.SelectedItem.ToString() == "None")
            {
                if (Colo5 != null) Colo5.Fill = new SolidColorBrush(Color.FromArgb(255, 244, 164, 96));
                tol = 0;
            }
            Calc_Click();
        }


        private void C2_Checked(object sender, RoutedEventArgs e)
        {
            if (Lista4 != null) Lista4.Visibility = Visibility.Visible;
            if (Colo4 != null) Colo4.Visibility = Visibility.Visible;
            if (caixa != null) caixa.Visibility = Visibility.Visible;
            Calc_Click();
        }

        private void C1_Checked(object sender, RoutedEventArgs e)
        {
            if (Lista4 != null) Lista4.Visibility = Visibility.Collapsed;
            if (Colo4 != null) Colo4.Visibility = Visibility.Collapsed;
            if (caixa != null) caixa.Visibility = Visibility.Collapsed;
            Calc_Click();
        }

        private void Calc_Click()
        {
            if (C1 != null && (C1.IsChecked != null && (bool) C1.IsChecked))
                result.Text = ((digito1*10 + digito2)*multi) + " +/- " + tol + "% \u2126";
            else if (C2 != null && (C2.IsChecked != null && (bool) C2.IsChecked))
                result.Text = ((digito1*100 + digito2*10 + digito3)*multi) + " +/- " + tol + "% \u2126";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double volt;
            double curr;
            double watt;
            double resist;

            if ((V.Text.Trim().Length != 0 && I.Text.Trim().Length != 0 && P.Text.Trim().Length == 0 &&
                 R.Text.Trim().Length == 0)
                && (double.TryParse(V.Text, out volt) && double.TryParse(I.Text, out curr)))
            {
                R.Text = Math.Round((volt/curr), 14).ToString();
                P.Text = Math.Round((volt*curr), 14).ToString();
            }
            
            else if ((V.Text.Trim().Length != 0 && I.Text.Trim().Length == 0 && P.Text.Trim().Length != 0 &&
                      R.Text.Trim().Length == 0)
                     && (double.TryParse(V.Text, out volt) && double.TryParse(P.Text, out watt)))
            {
                R.Text = Math.Round(((volt*volt)/watt), 14).ToString();
                I.Text = Math.Round((volt/double.Parse(R.Text)), 14).ToString();
            }
            else if (V.Text.Trim().Length == 0 && I.Text.Trim().Length != 0 && P.Text.Trim().Length != 0 &&
                  R.Text.Trim().Length == 0
                 && double.TryParse(P.Text, out watt) && double.TryParse(I.Text, out curr))
            {
                R.Text = Math.Round((watt / (curr * curr)), 14).ToString();
                V.Text = Math.Round((watt / curr), 14).ToString();
            }
            else if ((V.Text.Trim().Length != 0 && I.Text.Trim().Length == 0 && P.Text.Trim().Length == 0 &&
                      R.Text.Trim().Length != 0)
                     && (double.TryParse(V.Text, out volt) && double.TryParse(R.Text, out resist)))
            {
                P.Text = Math.Round(((volt*volt)/resist), 14).ToString();
                I.Text = Math.Round((double.Parse(P.Text)/volt), 14).ToString();
            }
            else if ((V.Text.Trim().Length == 0 && I.Text.Trim().Length == 0 && P.Text.Trim().Length != 0 &&
                      R.Text.Trim().Length != 0)
                     && (double.TryParse(P.Text, out watt) && double.TryParse(R.Text, out resist)))
            {
                V.Text = Math.Round((Math.Sqrt(watt*resist)), 14).ToString();
                I.Text = Math.Round((watt/double.Parse(V.Text)), 14).ToString();
            }
            else if ((V.Text.Trim().Length == 0 && I.Text.Trim().Length != 0 && R.Text.Trim().Length != 0 &&
                    P.Text.Trim().Length == 0)
                    && (double.TryParse(I.Text, out curr) && double.TryParse(R.Text, out resist)))
            {
                V.Text = Math.Round((curr*resist), 14).ToString();
                P.Text = Math.Round((curr* double.Parse(V.Text)), 14).ToString();
            }
            else
                MessageBox.Show("No sufficient or correct data!", "", MessageBoxButton.OK);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            R.Text = "";
            I.Text = "";
            V.Text = "";
            P.Text = "";
        }

        private void wave_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e == null) throw new ArgumentNullException("e");
            if (Wave != null && Wave.Value == 760)
            {
                if (Texto != null)
                    Texto.Text = Wave.Value + "λ" +
                                 "\nΔV < 1.63 \nGallium arsenide (GaAs) \nAluminium gallium arsenide (AlGaAs)\n";
            }
            else if (Wave != null && (Wave.Value < 760 && Wave.Value > 610))
            {
                if (Texto != null)
                    Texto.Text = ((int) Wave.Value) + "λ\n" +
                                 "1.63 < ΔV < 2.03\nAluminium gallium arsenide (AlGaAs) \nGallium arsenide phosphide (GaAsP)\nAluminium gallium indium phosphide (AlGaInP)\nGallium(III) phosphide (GaP)";
            }
            else if (Wave != null && (Wave.Value < 610 && Wave.Value > 590))
            {
                if (Texto != null)
                    Texto.Text = ((int) Wave.Value) + "λ\n" +
                                 "2.03 < ΔV < 2.10\nGallium arsenide phosphide (GaAsP)\nAluminium gallium indium phosphide (AlGaInP)\nGallium(III) phosphide (GaP)";
            }
            else if (Wave != null && (Wave.Value < 590 && Wave.Value > 570))
            {
                if (Texto != null)
                    Texto.Text = ((int) Wave.Value) + "λ\n" +
                                 "2.10 < ΔV < 2.18\nGallium arsenide phosphide (GaAsP)\nAluminium gallium indium phosphide (AlGaInP)\nGallium(III) phosphide (GaP)";
            }
            else if (Wave != null && (Wave.Value < 570 && Wave.Value > 500))
            {
                if (Texto != null)
                    Texto.Text = ((int) Wave.Value) + "λ\n" +
                                 "1.9 < ΔV < 4.0\nTraditional green:\nGallium(III) phosphide (GaP)\nAluminium gallium indium phosphide (AlGaInP)\nAluminium gallium phosphide (AlGaP)\n";
            }
            else if (Wave != null && (Wave.Value < 500 && Wave.Value > 450))
            {
                if (Texto != null)
                    Texto.Text = ((int) Wave.Value) + "λ\n" +
                                 "2.48 < ΔV < 3.7\nZinc selenide (ZnSe)\nIndium gallium nitride (InGaN)\nSilicon carbide (SiC)";
            }
            else if (Wave != null && (Wave.Value < 450 && Wave.Value > 400))
            {
                if (Texto != null)
                    Texto.Text = ((int) Wave.Value) + "λ\n" + "2.76 < ΔV < 4.0\nIndium gallium nitride (InGaN)";
            }
            else if (Wave != null && Wave.Value == 400)
            {
                if (Texto != null)
                    Texto.Text = "Multiple Values of λ\n " +
                                 "2.48 < ΔV < 3.7\nDual blue/red LEDs,\nblue with red phosphor,\nor white with purple plastic";
            }
            else if (Wave != null && Wave.Value < 400 && Wave.Value > 300)
            {
                if (Texto != null)
                    Texto.Text = "< 400 λ\n" +
                                 "3.1 < ΔV < 4.4\nDiamond\nBoron nitride (215 nm)\nAluminium nitride (AlN)\nAluminium gallium nitride (AlGaN)\nAluminium gallium indium nitride (AlGaInN)";
            }
            else if (Wave != null && (Wave.Value < 300 && Wave.Value > 250))
            {
                if (Texto != null)
                    Texto.Text = "Multiple Values of λ\n" +
                                 "ΔV ~ 3.3 \n Blue with one or two phosphor layers:\nyellow with red, orange or pink phosphor,\nor white with pink pigment";
            }
            else
            {
                if (Texto != null) Texto.Text = "Broad spectrum\n ΔV = 3.5\nBlue/UV diode with\nyellow phosphor";
            }
        }
    }
}