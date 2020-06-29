using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rent_a_car_aplikacija
{
    public partial class frmRezervisi : Form
    {
        int idUlogovanog;
        List<Ponuda> listaPonuda;
        List<Ponuda> dostupnePonude;
        List<Automobil> listaAuta;
        List<Rezervacija> listaRezervacija;
        string marka, model, karoserija, gorivo, pogon, menjac;
        int godiste, brVrata, kubikaza, idIzabranogAuta, brojDana, ukupnaCena;

        public frmRezervisi(int idUlogovani)
        {
            InitializeComponent();
            this.idUlogovanog = idUlogovani;
            this.Text = "";
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.listaPonuda = new List<Ponuda>();
            this.listaAuta = new List<Automobil>();
            this.dostupnePonude = new List<Ponuda>();
            this.listaRezervacija = new List<Rezervacija>();
        }

        private void frmRezervisi_Load(object sender, EventArgs e)
        {
            listaPonuda = Administrator.DeserijalizujPonude();
            listaAuta = Administrator.DeserijalizujAute();
            listaRezervacija = Administrator.DeserijalizujRezervacije();

            datePreuzimanje.MinDate = DateTime.Now;

            foreach(Automobil auto in listaAuta)
            {
                if (!cbMarka.Items.Contains(auto.Marka)) {
                    cbMarka.Items.Add(auto.Marka);
                }
            }
        }

        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Items.Clear();
            cbGodiste.Items.Clear();
            cbKubikaza.Items.Clear();
            cbKaroserija.Items.Clear();
            cbBrVrata.Items.Clear();
            cbGorivo.Items.Clear();
            cbPogon.Items.Clear();
            cbMenjac.Items.Clear();

            cbModel.Text = "";
            cbGodiste.Text = "";
            cbKubikaza.Text = "";
            cbKaroserija.Text = "";
            cbBrVrata.Text = "";
            cbGorivo.Text = "";
            cbPogon.Text = "";
            cbMenjac.Text = "";
            
            string izabranaMarka = (string)cbMarka.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.Marka.Equals(izabranaMarka)) {
                    if (!cbModel.Items.Contains(auto.Model))
                    {
                        cbModel.Items.Add(auto.Model);
                    }
                    marka = auto.Marka;
                }
            }

            if (cbModel.Items.Count == 1) {
                cbModel.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGodiste.Items.Clear();
            cbKubikaza.Items.Clear();
            cbKaroserija.Items.Clear();
            cbBrVrata.Items.Clear();
            cbGorivo.Items.Clear();
            cbPogon.Items.Clear();
            cbMenjac.Items.Clear();

            cbGodiste.Text = "";
            cbKubikaza.Text = "";
            cbKaroserija.Text = "";
            cbBrVrata.Text = "";
            cbGorivo.Text = "";
            cbPogon.Text = "";
            cbMenjac.Text = "";

            string izabraniModel = (string)cbModel.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.Model.Equals(izabraniModel) && auto.Marka.Equals(marka))
                {
                    if (!cbGodiste.Items.Contains(auto.Godiste))
                    {
                        cbGodiste.Items.Add(auto.Godiste);
                    }
                    model = auto.Model;
                }
            }

            if (cbGodiste.Items.Count == 1)
            {
                cbGodiste.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbGodiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKubikaza.Items.Clear();
            cbKaroserija.Items.Clear();
            cbBrVrata.Items.Clear();
            cbGorivo.Items.Clear();
            cbPogon.Items.Clear();
            cbMenjac.Items.Clear();

            cbKubikaza.Text = "";
            cbKaroserija.Text = "";
            cbBrVrata.Text = "";
            cbGorivo.Text = "";
            cbPogon.Text = "";
            cbMenjac.Text = "";

            int izabranoGodiste = (int)cbGodiste.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.Godiste == izabranoGodiste && auto.Marka.Equals(marka) && auto.Model.Equals(model))
                {
                    if (!cbKubikaza.Items.Contains(auto.Kubikaza))
                    {
                        cbKubikaza.Items.Add(auto.Kubikaza);
                    }
                    godiste = auto.Godiste;
                }
            }

            if (cbKubikaza.Items.Count == 1)
            {
                cbKubikaza.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbKubikaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKaroserija.Items.Clear();
            cbBrVrata.Items.Clear();
            cbGorivo.Items.Clear();
            cbPogon.Items.Clear();
            cbMenjac.Items.Clear();

            cbKaroserija.Text = "";
            cbBrVrata.Text = "";
            cbGorivo.Text = "";
            cbPogon.Text = "";
            cbMenjac.Text = "";

            int izabranaKubikaza = (int)cbKubikaza.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.Kubikaza == izabranaKubikaza && auto.Marka.Equals(marka) 
                    && auto.Model.Equals(model) && auto.Godiste == godiste)
                {
                    if (!cbKaroserija.Items.Contains(auto.Karoserija))
                    {
                        cbKaroserija.Items.Add(auto.Karoserija);
                    }
                     kubikaza = auto.Kubikaza;
                }
            }

            if (cbKaroserija.Items.Count == 1)
            {
                cbKaroserija.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbKaroserija_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBrVrata.Items.Clear();
            cbGorivo.Items.Clear();
            cbPogon.Items.Clear();
            cbMenjac.Items.Clear();

            cbBrVrata.Text = "";
            cbGorivo.Text = "";
            cbPogon.Text = "";
            cbMenjac.Text = "";

            string izabranaKaroserija = (string)cbKaroserija.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.Karoserija.Equals(izabranaKaroserija) 
                    && auto.Kubikaza == kubikaza && auto.Marka.Equals(marka)
                    && auto.Model.Equals(model) && auto.Godiste == godiste)
                {
                    if (!cbBrVrata.Items.Contains(auto.BrojVrata))
                    {
                        cbBrVrata.Items.Add(auto.BrojVrata);
                    }
                    karoserija = auto.Karoserija;
                }
            }

            if (cbBrVrata.Items.Count == 1)
            {
                cbBrVrata.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbBrVrata_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGorivo.Items.Clear();
            cbPogon.Items.Clear();
            cbMenjac.Items.Clear();

            cbGorivo.Text = "";
            cbPogon.Text = "";
            cbMenjac.Text = "";

            int izabraniBrVrata = (int)cbBrVrata.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.BrojVrata==izabraniBrVrata && auto.Kubikaza == kubikaza && auto.Marka.Equals(marka)
                    && auto.Model.Equals(model) && auto.Godiste == godiste 
                    && auto.Karoserija.Equals(karoserija))
                {
                    if (!cbGorivo.Items.Contains(auto.Gorivo))
                    {
                        cbGorivo.Items.Add(auto.Gorivo);
                    }
                    brVrata = auto.BrojVrata;
                }
            }

            if (cbGorivo.Items.Count == 1)
            {
                cbGorivo.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbGorivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPogon.Items.Clear();
            cbMenjac.Items.Clear();

            cbPogon.Text = "";
            cbMenjac.Text = "";

            string izabranoGorivo = (string)cbGorivo.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.Gorivo.Equals(izabranoGorivo) && auto.Kubikaza == kubikaza && auto.Marka.Equals(marka)
                    && auto.Model.Equals(model) && auto.Godiste == godiste
                    && auto.Karoserija.Equals(karoserija) && auto.BrojVrata==brVrata)
                {
                    if (!cbPogon.Items.Contains(auto.Pogon))
                    {
                        cbPogon.Items.Add(auto.Pogon);
                    }
                    gorivo = auto.Gorivo;
                }
            }

            if (cbPogon.Items.Count == 1)
            {
                cbPogon.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbPogon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMenjac.Items.Clear();

            cbMenjac.Text = "";

            string izabraniPogon = (string)cbPogon.SelectedItem;

            foreach (Automobil auto in listaAuta)
            {
                if (auto.Pogon.Equals(izabraniPogon) && auto.Kubikaza == kubikaza && auto.Marka.Equals(marka)
                    && auto.Model.Equals(model) && auto.Godiste == godiste
                    && auto.Karoserija.Equals(karoserija) && auto.BrojVrata == brVrata 
                    && auto.Gorivo.Equals(gorivo))
                {
                    if (!cbMenjac.Items.Contains(auto.VrstaMenjaca))
                    {
                        cbMenjac.Items.Add(auto.VrstaMenjaca);
                    }
                    pogon = auto.Pogon;
                }
            }

            if (cbMenjac.Items.Count == 1)
            {
                cbMenjac.SelectedIndex = 0;
            }

            listBoxPonude.Items.Clear();
        }

        private void cbMenjac_SelectedIndexChanged(object sender, EventArgs e)
        {
            menjac = (string)cbMenjac.SelectedItem;
            listBoxPonude.Items.Clear();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            listBoxPonude.Items.Clear();
            dostupnePonude = new List<Ponuda>(); // svaki put kad se klikne lista se isprazni

            if (cbMarka.SelectedItem == null ||
                cbModel.SelectedItem == null ||
                cbGodiste.SelectedItem == null ||
                cbKubikaza.SelectedItem == null ||
                cbKaroserija.SelectedItem == null ||
                cbBrVrata.SelectedItem == null ||
                cbGorivo.SelectedItem == null ||
                cbPogon.SelectedItem == null ||
                cbMenjac.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati sva polja!");
            }
            else { // hvatanje ID-a automobila
                foreach (Automobil auto in listaAuta) {
                    if (auto.Model.Equals(model) && auto.Marka.Equals(marka) &&
                        auto.Godiste == godiste && auto.Kubikaza == kubikaza &&
                        auto.Karoserija.Equals(karoserija) && auto.BrojVrata == brVrata &&
                        auto.Gorivo.Equals(gorivo) && auto.Pogon.Equals(pogon) &&
                        auto.VrstaMenjaca.Equals(menjac)) {
                        idIzabranogAuta = auto.IdAutomobila;
                    }
                }

                foreach (Ponuda ponuda in listaPonuda) {
                    if (ponuda.IdAuta == idIzabranogAuta)
                    {
                        if (!listBoxPonude.Items.Contains(ponuda)) {
                            listBoxPonude.Items.Add(ponuda.ispis());
                            dostupnePonude.Add(ponuda);
                            // puni se samo onim ponudama koje su dostupne za taj auto
                        }
                    }
                }
            }
        }

        private void datePreuzimanje_ValueChanged(object sender, EventArgs e)
        {
            dateVracanje.MinDate = datePreuzimanje.Value;
            
            foreach (Ponuda ponuda in dostupnePonude)
            {
                if (datePreuzimanje.Value.Date.CompareTo(ponuda.DatumOd.Date) >= 0
                        && dateVracanje.Value.Date.CompareTo(ponuda.DatumDo.Date) <= 0
                        && datePreuzimanje.Value.Date.CompareTo(dateVracanje.Value.Date) <= 0)
                {
                    brojDana = 0;
                    TimeSpan brDana = dateVracanje.Value - datePreuzimanje.Value;
                    brojDana = (int)brDana.Days + 1;

                    ukupnaCena = brojDana * ponuda.CenaPoDanu;
                    txtUkupnaCena.Text = ukupnaCena.ToString() + " din";
                    return;
                }
            }
            
        }

        private void dateVracanje_ValueChanged(object sender, EventArgs e)
        {
            foreach (Ponuda ponuda in dostupnePonude)
            {
                if (datePreuzimanje.Value.Date.CompareTo(ponuda.DatumOd.Date) >= 0
                        && dateVracanje.Value.Date.CompareTo(ponuda.DatumDo.Date) <= 0
                        && datePreuzimanje.Value.Date.CompareTo(dateVracanje.Value.Date) <= 0)
                {
                    brojDana = 0;
                    TimeSpan brDana = dateVracanje.Value - datePreuzimanje.Value;
                    brojDana = (int)brDana.Days + 1;

                    ukupnaCena = brojDana * ponuda.CenaPoDanu;
                    txtUkupnaCena.Text = ukupnaCena.ToString() + " din";
                    return;
                }
            }        
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            if (dostupnePonude.Count <= 0)
            {
                MessageBox.Show("Prvo izaberite automobil!");
            }
            else
            {
                Rezervacija rezervacija = null;
                Ponuda rezervisanaPonuda = null;

                // >= 0 kasnije ili isti dan
                // <= 0 ranije ili isti dan
                foreach (Ponuda ponuda in dostupnePonude)
                {

                    if (datePreuzimanje.Value.Date.CompareTo(ponuda.DatumOd.Date) >= 0
                        && dateVracanje.Value.Date.CompareTo(ponuda.DatumDo.Date) <= 0
                        && datePreuzimanje.Value.Date.CompareTo(dateVracanje.Value.Date) <= 0)
                    {
                        rezervacija = new Rezervacija(idIzabranogAuta, idUlogovanog, datePreuzimanje.Value, dateVracanje.Value, ukupnaCena);
                        listaRezervacija.Add(rezervacija);

                        Administrator.SerijalizuRezervacije(listaRezervacija);

                        rezervisanaPonuda = ponuda;

                        MessageBox.Show("Uspešno ste rezervisali automobil u terminu: "
                            + datePreuzimanje.Value.ToShortDateString() + "-" 
                            + dateVracanje.Value.ToShortDateString()
                            + " po ceni od " + ukupnaCena + "din");

                    }
                }

                if (rezervacija == null)
                {
                    MessageBox.Show("Vaši datumi se ne poklapaju ni sa jednim dostupnim terminom!");
                    return;
                }

                if (rezervisanaPonuda != null)
                {
                    listaPonuda.Remove(rezervisanaPonuda);

                    if (rezervacija.DatumRezOd.Date.CompareTo(rezervisanaPonuda.DatumOd.Date) == 0
                        && rezervacija.DatumRezDo.Date.CompareTo(rezervisanaPonuda.DatumDo.Date) != 0)
                    {
                        Ponuda p = new Ponuda(idIzabranogAuta, rezervacija.DatumRezDo.Date.AddDays(1),
                            rezervisanaPonuda.DatumDo.Date, rezervisanaPonuda.CenaPoDanu);

                        listaPonuda.Add(p);
                        Administrator.SerijalizuPonude(listaPonuda);
                        listaPonuda = Administrator.DeserijalizujPonude();
                    }

                    else if (rezervacija.DatumRezDo.Date.CompareTo(rezervisanaPonuda.DatumDo.Date) == 0
                            && rezervacija.DatumRezOd.Date.CompareTo(rezervisanaPonuda.DatumOd.Date) != 0)
                    {
                        Ponuda p = new Ponuda(idIzabranogAuta, rezervisanaPonuda.DatumOd.Date,
                            rezervacija.DatumRezOd.Date.AddDays(-1), rezervisanaPonuda.CenaPoDanu);

                        listaPonuda.Add(p);
                        Administrator.SerijalizuPonude(listaPonuda);
                        listaPonuda = Administrator.DeserijalizujPonude();
                    }

                    else if (rezervacija.DatumRezOd.Date.CompareTo(rezervisanaPonuda.DatumOd.Date) > 0 && rezervacija.DatumRezDo.Date.CompareTo(rezervisanaPonuda.DatumDo) < 0)
                    {
                        Ponuda p1 = new Ponuda(idIzabranogAuta,
                        rezervisanaPonuda.DatumOd.Date,
                        rezervacija.DatumRezOd.Date.AddDays(-1),
                        rezervisanaPonuda.CenaPoDanu);

                        Ponuda p2 = new Ponuda(idIzabranogAuta,
                        rezervacija.DatumRezDo.Date.AddDays(1),
                        rezervisanaPonuda.DatumDo.Date,
                        rezervisanaPonuda.CenaPoDanu);

                        listaPonuda.Add(p1);
                        listaPonuda.Add(p2);
                        Administrator.SerijalizuPonude(listaPonuda);
                        listaPonuda = Administrator.DeserijalizujPonude();
                    }

                    Administrator.SerijalizuPonude(listaPonuda);
                    frmVaseRezervacije frmVaseRez = new frmVaseRezervacije(idUlogovanog);
                    frmVaseRez.MdiParent = this.MdiParent;
                    Hide();
                    frmVaseRez.Show();
                    Close();
                }
            
            }

        }
    }
}
