using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_car_aplikacija
{
    [Serializable]
    class Ponuda
    {
        private int idAuta;
        private DateTime datumOd;
        private DateTime datumDo;
        private int cenaPoDanu;

        public Ponuda(int idAuta, DateTime datumOd, DateTime datumDo, int cenaPoDanu)
        {
            this.idAuta = idAuta;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.cenaPoDanu = cenaPoDanu;
        }

        public override string ToString()
        {
            return "Auto: " + idAuta + ", " + DatumOd.ToShortDateString() + "-" + DatumDo.ToShortDateString();
        }

        public string ispis() {
            return DatumOd.ToShortDateString() + "-" + DatumDo.ToShortDateString() + 
                " Cena: " + cenaPoDanu + " din po danu";
        }
        public int IdAuta { get { return idAuta; } set { idAuta = value; } }
        public int CenaPoDanu { get { return cenaPoDanu; } set { cenaPoDanu = value; } }
        public DateTime DatumOd { get { return datumOd; } set { datumOd = value; } }
        public DateTime DatumDo { get { return datumDo; } set { datumDo = value; } }
    }
}
