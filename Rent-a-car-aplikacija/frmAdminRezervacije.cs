using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_car_aplikacija
{
    public partial class frmAdminRezervacije : Form
    {
        List<Kupac> listaKupaca;
        List<Rezervacija> listaRezervacija;
        List<Ponuda> listaPonuda;
        Rezervacija izabranaRez;

        Kupac izabraniKupac;
        public frmAdminRezervacije()
        {
            InitializeComponent();
            listaKupaca = new List<Kupac>();
            listaRezervacija = new List<Rezervacija>();
            listaPonuda = new List<Ponuda>();
            izabraniKupac = null;
        }

        private void frmAdminRezervacije_Load(object sender, EventArgs e)
        {
            listaKupaca = Administrator.DeserijalizujKupce();
            listaPonuda = Administrator.DeserijalizujPonude();
            listaRezervacija = Administrator.DeserijalizujRezervacije();

            foreach (Kupac kupac in listaKupaca)
            {
                if (!cbKupci.Items.Contains(kupac))
                {
                    cbKupci.Items.Add(kupac);
                }
            }

           
        }

        private void cbKupci_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRezervacijeZaBrisanje.Items.Clear();
            cbAutomobili.Items.Clear();
            cbRezervacijeZaAzuriranje.Items.Clear();
            cbRezervacijeZaBrisanje.Text = "";
            cbAutomobili.Text = "";
            cbRezervacijeZaAzuriranje.Text = "";

            izabraniKupac = cbKupci.SelectedItem as Kupac;

            foreach (Rezervacija r in listaRezervacija)
            {
                if (r.IdKupca == izabraniKupac.IdKupca)
                {
                    if (!cbRezervacijeZaBrisanje.Items.Contains(r))
                    {
                        cbRezervacijeZaBrisanje.Items.Add(r);
                    }
                    if (!cbRezervacijeZaAzuriranje.Items.Contains(r))
                    {
                        cbRezervacijeZaAzuriranje.Items.Add(r);
                    }
                }
            }

            foreach (Automobil a in Administrator.DeserijalizujAute())
            {
                if (!cbAutomobili.Items.Contains(a))
                {
                    cbAutomobili.Items.Add(a.IdAutomobila);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdministrator frm = new frmAdministrator();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            izabranaRez = cbRezervacijeZaBrisanje.SelectedItem as Rezervacija;

            if (izabranaRez == null)
            {
                MessageBox.Show("Izaberite rezervaciju koju želite da otkažete!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Da li ste sigurni da želite da otkažete" +
                    " izabranu rezervaciju: " + izabranaRez.ToString() + "?", "Otkazivanje rezervacije", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    listaRezervacija.Remove(izabranaRez);

                    TimeSpan dani = izabranaRez.DatumRezDo - izabranaRez.DatumRezOd;
                    int brDana = (int)dani.Days + 1;

                    int cenaPoDanu = izabranaRez.Cena / brDana;

                    Ponuda p = new Ponuda(izabranaRez.IdAuta, izabranaRez.DatumRezOd, izabranaRez.DatumRezDo, cenaPoDanu);

                    listaPonuda.Add(p);

                    Administrator.SerijalizuPonude(listaPonuda);
                    Administrator.SerijalizuRezervacije(listaRezervacija);

                    listaRezervacija = Administrator.DeserijalizujRezervacije();
                    listaPonuda = Administrator.DeserijalizujPonude();

                    cbRezervacijeZaBrisanje.Items.Clear();
                    cbAutomobili.Items.Clear();
                    cbRezervacijeZaAzuriranje.Items.Clear();
                    cbRezervacijeZaBrisanje.Text = "";
                    cbAutomobili.Text = "";
                    cbRezervacijeZaAzuriranje.Text = "";

                    foreach (Rezervacija r in listaRezervacija)
                    {
                        if (r.IdKupca == izabraniKupac.IdKupca)
                        {
                            if (!cbRezervacijeZaBrisanje.Items.Contains(r))
                            {
                                cbRezervacijeZaBrisanje.Items.Add(r);
                            }
                            if (!cbRezervacijeZaAzuriranje.Items.Contains(r))
                            {
                                cbRezervacijeZaAzuriranje.Items.Add(r);
                            }
                        }
                    }

                    foreach (Automobil a in Administrator.DeserijalizujAute())
                    {
                        if (!cbAutomobili.Items.Contains(a))
                        {
                            cbAutomobili.Items.Add(a.IdAutomobila);
                        }
                    }

                    MessageBox.Show("Rezervacija otkazana.");
                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("Rezervacija nije otkazana.");
                }

            }
        }

        private void btnDodajRez_Click(object sender, EventArgs e)
        {  
            if (cbAutomobili.SelectedItem == null)
            {
                MessageBox.Show("Izaberite automobil!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtCenaPoDanuDodavanje.Text))
                {
                    MessageBox.Show("Niste uneli cenu!");
                    return;
                }

                int IdIzabranogAuta = (int)cbAutomobili.SelectedItem;
                int datumiSeNePoklapajuSaPostojecomPonudom = 0;
                int brojPonudaZaTajAuto = 0;

                foreach (Ponuda ponuda in listaPonuda)
                {
                    if (ponuda.IdAuta == IdIzabranogAuta)
                    {
                        //da su oba datuma kasnije ili ranije od već postojeće ponude
                        //i da je datum OD ranije od datuma DO
                        if (
                            (datePreuzimanjeDodavanje.Value.Date.CompareTo(ponuda.DatumOd.Date) > 0
                            && dateVracanjeDodavanje.Value.Date.CompareTo(ponuda.DatumDo.Date) > 0
                            && datePreuzimanjeDodavanje.Value.Date.CompareTo(ponuda.DatumDo.Date) > 0
                            && dateVracanjeDodavanje.Value.Date.CompareTo(ponuda.DatumOd.Date) > 0)
                            ||
                            (datePreuzimanjeDodavanje.Value.Date.CompareTo(ponuda.DatumOd.Date) < 0
                            && dateVracanjeDodavanje.Value.Date.CompareTo(ponuda.DatumDo.Date) < 0
                            && datePreuzimanjeDodavanje.Value.Date.CompareTo(ponuda.DatumDo.Date) < 0
                            && dateVracanjeDodavanje.Value.Date.CompareTo(ponuda.DatumOd.Date) < 0)

                            && datePreuzimanjeDodavanje.Value.Date.CompareTo(dateVracanjeDodavanje.Value.Date) <= 0)
                        {
                            datumiSeNePoklapajuSaPostojecomPonudom++;
                        }
                        brojPonudaZaTajAuto++;
                    }
                    
                }

                if (datumiSeNePoklapajuSaPostojecomPonudom != brojPonudaZaTajAuto)
                {
                    MessageBox.Show("Vaši datumi se poklapaju sa nekom od postojećih ponuda!");
                    return;
                }
                else
                {
                    TimeSpan dani = dateVracanjeDodavanje.Value - datePreuzimanjeDodavanje.Value;
                    int brDana = (int)dani.Days + 1;

                    int ukupnaCena = brDana * int.Parse(txtCenaPoDanuDodavanje.Text);
                    Rezervacija nova = new Rezervacija(IdIzabranogAuta, izabraniKupac.IdKupca, datePreuzimanjeDodavanje.Value, dateVracanjeDodavanje.Value, ukupnaCena);

                    listaRezervacija.Add(nova);

                    Administrator.SerijalizuRezervacije(listaRezervacija);

                    MessageBox.Show("Uspešno ste dodali rezervaciju!\n" +
                        "Termin: " + nova.DatumRezOd.Date.ToShortDateString() + "-" + nova.DatumRezDo.Date.ToShortDateString()
                        + "\nCena: " + nova.Cena.ToString() + " din");

                    listaRezervacija = Administrator.DeserijalizujRezervacije();

                    cbRezervacijeZaBrisanje.Items.Clear();
                    cbAutomobili.Items.Clear();
                    cbRezervacijeZaAzuriranje.Items.Clear();
                    cbRezervacijeZaBrisanje.Text = "";
                    cbAutomobili.Text = "";
                    cbRezervacijeZaAzuriranje.Text = "";

                    foreach (Rezervacija r in listaRezervacija)
                    {
                        if (r.IdKupca == izabraniKupac.IdKupca)
                        {
                            if (!cbRezervacijeZaBrisanje.Items.Contains(r))
                            {
                                cbRezervacijeZaBrisanje.Items.Add(r);
                            }
                            if (!cbRezervacijeZaAzuriranje.Items.Contains(r))
                            {
                                cbRezervacijeZaAzuriranje.Items.Add(r);
                            }
                        }
                    }

                    foreach (Automobil a in Administrator.DeserijalizujAute())
                    {
                        if (!cbAutomobili.Items.Contains(a))
                        {
                            cbAutomobili.Items.Add(a.IdAutomobila);
                        }
                    }
                }
            }
        }

        private void cbRezervacijeZaAzuriranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabranaRez = cbRezervacijeZaAzuriranje.SelectedItem as Rezervacija;

            txtAutoAzuiraranje.Text = izabranaRez.IdAuta.ToString();

            datePreuzimanjeAzuriranje.Value = izabranaRez.DatumRezOd.Date;
            dateVracanjeAzuriranje.Value = izabranaRez.DatumRezDo.Date;

            TimeSpan dani = dateVracanjeAzuriranje.Value - datePreuzimanjeAzuriranje.Value;
            int brDana = (int)dani.Days;
            txtCenaPoDanuAzuriranje.Text = (izabranaRez.Cena / brDana).ToString();

            txtNovaUkupnaCenaAzuiranje.Text = izabranaRez.Cena.ToString();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            izabranaRez = cbRezervacijeZaAzuriranje.SelectedItem as Rezervacija;

            if (izabranaRez == null)
            {
                MessageBox.Show("Izaberite rezervaciju koju želite da ažurirate!");
            }
            else
            {

                int datumiSeNePoklapajuSaPostojecomPonudom = 0;
                int brojPonuda = 0;
                foreach (Ponuda ponuda in listaPonuda)
                {
                    if (txtAutoAzuiraranje.Text.Equals(ponuda.IdAuta.ToString()))
                    {
                        //da su oba datuma kasnije ili ranije od već postojeće ponude
                        //i da je datum OD ranije od datuma DO
                        if (
                            (datePreuzimanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumOd.Date) > 0 
                            && dateVracanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumDo.Date) > 0
                            && datePreuzimanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumDo.Date) > 0
                            && dateVracanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumOd.Date) > 0) 
                            ||
                            (datePreuzimanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumOd.Date) < 0
                            && dateVracanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumDo.Date) < 0
                            && datePreuzimanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumDo.Date) < 0
                            && dateVracanjeAzuriranje.Value.Date.CompareTo(ponuda.DatumOd.Date) < 0)

                            && datePreuzimanjeAzuriranje.Value.Date.CompareTo(dateVracanjeAzuriranje.Value.Date) <= 0)
                        {
                            datumiSeNePoklapajuSaPostojecomPonudom++;
                        }
                        brojPonuda++;
                    }
                }

                if (datumiSeNePoklapajuSaPostojecomPonudom != brojPonuda)
                {
                    MessageBox.Show("Vaši datumi se poklapaju sa nekom od postojećih ponuda!");
                    return;
                }
                else
                {
                    listaRezervacija.Remove(izabranaRez);
                    izabranaRez = new Rezervacija(izabranaRez.IdAuta, izabranaRez.IdKupca, datePreuzimanjeAzuriranje.Value, dateVracanjeAzuriranje.Value, izabranaRez.Cena);
                    listaRezervacija.Add(izabranaRez);

                    Administrator.SerijalizuRezervacije(listaRezervacija);

                    MessageBox.Show("Uspešno ste ažurirali rezervaciju!\n" +
                        "Termin: " + izabranaRez.DatumRezOd.Date.ToShortDateString()
                        + "-" + izabranaRez.DatumRezDo.Date.ToShortDateString()
                        + "\nCena: " + izabranaRez.Cena.ToString() + " din");

                    listaRezervacija = Administrator.DeserijalizujRezervacije();

                    cbRezervacijeZaBrisanje.Items.Clear();
                    cbAutomobili.Items.Clear();
                    cbRezervacijeZaAzuriranje.Items.Clear();
                    cbRezervacijeZaBrisanje.Text = "";
                    cbAutomobili.Text = "";
                    cbRezervacijeZaAzuriranje.Text = "";

                    foreach (Rezervacija r in listaRezervacija)
                    {
                        if (r.IdKupca == izabraniKupac.IdKupca)
                        {
                            if (!cbRezervacijeZaBrisanje.Items.Contains(r))
                            {
                                cbRezervacijeZaBrisanje.Items.Add(r);
                            }
                            if (!cbRezervacijeZaAzuriranje.Items.Contains(r))
                            {
                                cbRezervacijeZaAzuriranje.Items.Add(r);
                            }
                        }
                    }

                    foreach (Automobil a in Administrator.DeserijalizujAute())
                    {
                        if (!cbAutomobili.Items.Contains(a))
                        {
                            cbAutomobili.Items.Add(a.IdAutomobila);
                        }
                    }
                }
            }

        }

        private void datePreuzimanjeAzuriranje_ValueChanged(object sender, EventArgs e)
        {
            dateVracanjeAzuriranje.MinDate = datePreuzimanjeAzuriranje.Value;

            TimeSpan dani = dateVracanjeAzuriranje.Value - datePreuzimanjeAzuriranje.Value;
            int brDana = (int)dani.Days + 1;

            if (!string.IsNullOrEmpty(txtCenaPoDanuAzuriranje.Text))
            {
                int ukupna = int.Parse(txtCenaPoDanuAzuriranje.Text) * brDana;
                txtNovaUkupnaCenaAzuiranje.Text = ukupna.ToString();
            }
            else
            {
                txtNovaUkupnaCenaAzuiranje.Text = 0.ToString();
            }
        }

        private void dateVracanjeAzuriranje_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan dani = dateVracanjeAzuriranje.Value - datePreuzimanjeAzuriranje.Value;
            int brDana = (int)dani.Days + 1;

            if (!string.IsNullOrEmpty(txtCenaPoDanuAzuriranje.Text))
            {
                int ukupna = int.Parse(txtCenaPoDanuAzuriranje.Text) * brDana;
                txtNovaUkupnaCenaAzuiranje.Text = ukupna.ToString();
            }
            else
            {
                txtNovaUkupnaCenaAzuiranje.Text = 0.ToString();
            }
        }

        private void txtCenaPoDanuAzuriranje_TextChanged(object sender, EventArgs e)
        {
            TimeSpan dani = dateVracanjeAzuriranje.Value - datePreuzimanjeAzuriranje.Value;
            int brDana = (int)dani.Days + 1;

            int novaCenaPoDanu = 0;
            if (!string.IsNullOrEmpty(txtCenaPoDanuAzuriranje.Text))
            {
                char[] niz = txtCenaPoDanuAzuriranje.Text.ToCharArray();
                bool greska = false;
                foreach (char karakter in niz)
                {
                    if (!char.IsDigit(karakter))
                    { // ako jedan od karaktera nije broj
                        greska = true;
                    }
                }
                if (greska)
                {
                    MessageBox.Show("Cenu po danu unesite brojevima, ne slovima!");
                    return;
                }
                else
                {
                    novaCenaPoDanu = int.Parse(txtCenaPoDanuAzuriranje.Text);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli cenu po danu!");
                return;
            }

            if (!string.IsNullOrEmpty(txtCenaPoDanuAzuriranje.Text))
            {
                int ukupna = int.Parse(txtCenaPoDanuAzuriranje.Text) * brDana;
                txtNovaUkupnaCenaAzuiranje.Text = ukupna.ToString();
            }
            else
            {
                txtNovaUkupnaCenaAzuiranje.Text = 0.ToString();
            }

        }

        private void txtCenaPoDanuDodavanje_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCenaPoDanuDodavanje.Text))
            {
                char[] niz = txtCenaPoDanuDodavanje.Text.ToCharArray();
                bool greska = false;
                foreach (char karakter in niz)
                {
                    if (!char.IsDigit(karakter))
                    { // ako jedan od karaktera nije broj
                        greska = true;
                    }
                }
                if (greska)
                {
                    MessageBox.Show("Cenu po danu unesite brojevima, ne slovima!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Niste uneli cenu po danu!");
                return;
            }

        }

        private void datePreuzimanjeDodavanje_ValueChanged(object sender, EventArgs e)
        {
            dateVracanjeDodavanje.MinDate = datePreuzimanjeDodavanje.Value;
        }
    }
}
