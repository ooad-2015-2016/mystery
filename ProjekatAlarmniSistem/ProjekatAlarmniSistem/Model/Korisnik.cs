using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAlarmniSistem
{
    public class Korisnik
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Adresa { get; set; }
        public String JMBG { get; set; }
        public Korisnik(String ime,String prezime,String username,String jmbg,String password,String adresa)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
            this.Adresa = adresa;
            this.JMBG = jmbg;
        }
    }
}
