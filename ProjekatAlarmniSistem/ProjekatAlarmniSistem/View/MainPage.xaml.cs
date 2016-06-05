using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjekatAlarmniSistem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija), null);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginKorisnik), null);
        }

        private void Ispisi_Click(object sender, RoutedEventArgs e)
        {
            if (Kontenjer.korisnici.Count() == 0) ime.Text = "Nema registrovanih korisnika";
            else
            {
                Korisnik k = Kontenjer.korisnici[0];
                ime.Text = k.Ime;
                prezime.Text = k.Prezime;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Help), null);
        }
    }
}
