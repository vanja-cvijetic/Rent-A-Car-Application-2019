using System;
using System.Collections.Generic;

namespace Rent_a_car_aplikacija
{
    [Serializable]
    class Kupac : Korisnik
    {
        private int idKupca;
        private string ime, prezime, telefon, jmbg;
        private DateTime datumRodjenja;

        public Kupac(string ime, string prezime, string telefon, string jmbg, DateTime datumRodjenja,string username, string password)
        {
            List<Kupac> lista = Administrator.DeserijalizujKupce();

            Random r = new Random();
            idKupca = r.Next(100, 200);

            foreach (Kupac kupac in lista)
            {
                if (kupac.idKupca == this.idKupca)
                {
                    //int indeks = lista.Count;
                    //this.idKupca = lista[indeks - 1].idKupca + 1;
                    Random rnd = new Random();
                    idKupca = rnd.Next(100, 200);
                }
            }
            
            this.ime = ime;
            this.prezime = prezime;
            this.telefon = telefon;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.username = username;
            this.password = password;
        }

        public Kupac() {
            ime = "Unknown";
            prezime = "Unknown";
            jmbg = "Unknown";
            telefon = "Unknown";
            datumRodjenja = DateTime.Now;
            username = "None";
            password = "None";
        }

        public override string ToString()
        {
            return idKupca + " - " + ime + " " + prezime + ", jmbg: " + jmbg + ", kontakt telefon: " + telefon + ", datum rođenja:  " + datumRodjenja.ToShortDateString();
        }

        public int IdKupca { get { return idKupca; } set { idKupca = value; } }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }
        public string Telefon { get { return telefon; } set { telefon = value; } }
        public string Jmbg { get { return jmbg; } set { jmbg = value; } }
        public DateTime DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }
    }

    

}
