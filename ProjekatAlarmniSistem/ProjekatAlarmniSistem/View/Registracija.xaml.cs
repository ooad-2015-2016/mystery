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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatAlarmniSistem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page

    {
        public object MessageBox { get; private set; }

        public Registracija()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String ime, prezime, username, password, jmbg, adresa;
            ime = ime_t.Text;
            prezime = prezime_t.Text;
            username = username_t.Text;
            jmbg = jmbg_t.Text;
            adresa = adresa_t.Text;
            password = pass_t.Password;
            if(!IsDigitsOnly(jmbg) || jmbg.Length < 13)
            {
                Ispis.Text = "JMBG mora sadrzavati samo brojeve i biti duzine 13";
            }
            else if(!IsLetterOnly(ime) || !IsLetterOnly(prezime))
            {
                Ispis.Text = "Ime i prezime moraju sadrzavati samo slova.";
            }
            else
            {
                Korisnik korisnik = new Korisnik(ime, prezime, username, jmbg, password, adresa);
                Kontenjer.korisnici.Add(korisnik);
                this.Frame.Navigate(typeof(MainPage), null);
            }
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        bool IsLetterOnly(string str)
        {
            foreach (char c in str)
            {
                if (!((c >= 'A' && c <= 'Z')||(c >='a' && c <= 'z')))
                    return false;
            }

            return true;
        }
    }
}
