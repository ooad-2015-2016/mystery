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
    public sealed partial class LoginKorisnik : Page
    {
        public LoginKorisnik()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int duzina = Kontenjer.korisnici.Count();
            String username = user_t.Text;
            String password = pass_t.Password;
            for(int i=0;i< duzina;i++)
            {
                Korisnik k = Kontenjer.korisnici[i];
                if (username.Equals(k.Username))
                {
                    if(password.Equals(k.Password))
                    {
                        this.Frame.Navigate(typeof(Aktivacija), null);
                    }
                } 
            }
            ispis.Text = "Korisnik nepostoji";
        }
    }
}
