using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_car_aplikacija
{
    [Serializable]
    class Automobil
    {
        private int idAutomobila;
        private string marka;
        private string model;
        private int godiste;
        private int kubikaza;
        private string pogon;
        private string vrstaMenjaca;
        private string karoserija;
        private string gorivo;
        private int brojVrata;
        private bool rezervisan;

        public Automobil(int idAuta, string marka, string model, int godiste, int kubikaza, string pogon, string vrstaMenjaca, string karoserija, string gorivo, int brojVrata, bool rezervisan)
        {
            //List<Automobil> lista = Administrator.DeserijalizujAute();
            //Random r = new Random();
            //idAutomobila = r.Next(1000, 2000);

            //foreach (Automobil auto in lista)
            //{

            //    if (auto.idAutomobila == this.idAutomobila)
            //    {
            //        Random rnd = new Random();
            //        idAutomobila = rnd.Next(1000, 2000);
            //    }
            //}
            this.idAutomobila = idAuta;
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
            this.kubikaza = kubikaza;
            this.pogon = pogon;
            this.vrstaMenjaca = vrstaMenjaca;
            this.karoserija = karoserija;
            this.gorivo = gorivo;
            this.brojVrata = brojVrata;
            this.rezervisan = rezervisan;
        }
        public Automobil() { }
        public override string ToString()
        {
            return "ID: "+ IdAutomobila + ", marka: " +  marka + ", model: " + model + ", godište: " + godiste + ", kubikaža: "
                + kubikaza + ", pogon: " + pogon + ", vrsta menjača: " + vrstaMenjaca + ", karoserija: "
                + karoserija + ", gorivo: " + gorivo + ", broj vrata: " + brojVrata;
        }

        public string ispis() {
            return "ID: " + idAutomobila + ", " + marka + " " + model;
        }

        public int IdAutomobila { get { return idAutomobila; }  set { idAutomobila = value; } }
        public string Marka { get { return marka; } set { marka = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Pogon { get { return pogon; } set { pogon = value; } }
        public string VrstaMenjaca { get { return vrstaMenjaca; } set { vrstaMenjaca = value; } }
        public string Karoserija { get { return karoserija; } set { karoserija = value; } }
        public string Gorivo { get { return gorivo; } set { gorivo = value; } }
        public int Godiste { get { return godiste; } set { godiste = value; } }
        public int Kubikaza { get { return kubikaza; } set { kubikaza = value; } }
        public int BrojVrata { get { return brojVrata; } set { brojVrata = value; } }
        public bool Rezervisan { get { return rezervisan; } set { rezervisan = value; } }

    }
}
