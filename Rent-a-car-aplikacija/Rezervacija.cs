using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_car_aplikacija
{
    [Serializable]
    class Rezervacija
    {
        private int idAuta;
        private int idKupca;
        private DateTime datumRezOd;
        private DateTime datumRezDo;
        private int cena;

        public Rezervacija(int idAuta, int idKupca, DateTime datumRezOd, DateTime datumRezDo, int cena)
        {
            this.idAuta = idAuta;
            this.idKupca = idKupca;
            this.datumRezOd = datumRezOd;
            this.datumRezDo = datumRezDo;
            this.cena = cena;
        }

        public Rezervacija() { }

        public override string ToString()
        {
            Automobil a = new Automobil();
            foreach (Automobil auto in Administrator.DeserijalizujAute()) {
                if (auto.IdAutomobila == idAuta) {
                    a = auto;
                }
            }
            return a.Marka + " " + a.Model + " termin: " + DatumRezOd.ToShortDateString() + "-" + datumRezDo.ToShortDateString() + " cena: " + cena + " din";
        }

        public int IdAuta { get { return idAuta; } set { idAuta = value; } }
        public int IdKupca { get { return idKupca; } set { idKupca = value; } }
        public int Cena { get { return cena; } set { cena = value; } }
        public DateTime DatumRezOd { get { return datumRezOd; } set { datumRezOd = value; } }
        public DateTime DatumRezDo { get { return datumRezDo; } set { datumRezDo = value; } }


    }
}
