using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Rent_a_car_aplikacija
{
    class Administrator : Korisnik
    {

        public Administrator() {
            this.username = "admin";
            this.password = "admin";
        }

        public static void SerijalizujAute(List<Automobil> proslednjenaLista) {

            FileStream fs = new FileStream("automobili.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, proslednjenaLista);
            fs.Dispose();
            fs.Close();
            
        }
        public static List<Automobil> DeserijalizujAute() {
            List<Automobil> lista = new List<Automobil>();

            FileStream fs = new FileStream("automobili.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            lista = bf.Deserialize(fs) as List<Automobil>;
            fs.Dispose();
            fs.Close();

            return lista;
        }
        public static void SerijalizujKupce(List<Kupac> proslednjenaLista)
        {
            FileStream fs = new FileStream("kupci.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();               
            bf.Serialize(fs, proslednjenaLista);
            fs.Dispose();
            fs.Close();            
        }
        public static List<Kupac> DeserijalizujKupce()
        {
            List<Kupac> lista = new List<Kupac>();

            FileStream fs = new FileStream("kupci.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            lista = bf.Deserialize(fs) as List<Kupac>;
            fs.Dispose();
            fs.Close();

            return lista;
        }
        public static void SerijalizuPonude(List<Ponuda> proslednjenaLista)
        {

            FileStream fs = new FileStream("ponude.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, proslednjenaLista);
            fs.Dispose();
            fs.Close();

        }
        public static List<Ponuda> DeserijalizujPonude()
        {
            List<Ponuda> lista = new List<Ponuda>();

            FileStream fs = new FileStream("ponude.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            lista = bf.Deserialize(fs) as List<Ponuda>;
            fs.Dispose();
            fs.Close();

            return lista;
        }
        public static void SerijalizuRezervacije(List<Rezervacija> proslednjenaLista)
        {
            FileStream fs = new FileStream("rezervacije.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, proslednjenaLista);
            fs.Dispose();
            fs.Close();

        }
        public static List<Rezervacija> DeserijalizujRezervacije()
        {
            List<Rezervacija> lista = new List<Rezervacija>();

            FileStream fs = new FileStream("rezervacije.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            lista = bf.Deserialize(fs) as List<Rezervacija>;
            fs.Dispose();
            fs.Close();

            return lista;
        }
    }
}
