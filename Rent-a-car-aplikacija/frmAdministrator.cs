using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rent_a_car_aplikacija
{
    public partial class frmAdministrator : Form
    {
        List<Automobil> listaAuta;
        List<Kupac> listaKupaca;
        List<Ponuda> listaPonuda;

        public frmAdministrator()
        {
            InitializeComponent();
            listaAuta = new List<Automobil>();
            listaKupaca = new List<Kupac>();
            listaPonuda = new List<Ponuda>();
        }

        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            listaAuta = Administrator.DeserijalizujAute();

            foreach (Automobil auto in listaAuta)
            {
                if (!cbIDAuta.Items.Contains(auto.IdAutomobila))
                {
                    cbIDAuta.Items.Add(auto.IdAutomobila);
                }
                if (!cbPonudaIdAuta.Items.Contains(auto.IdAutomobila))
                {
                    cbPonudaIdAuta.Items.Add(auto.IdAutomobila);
                }
            }

            listaKupaca = Administrator.DeserijalizujKupce();

            foreach (Kupac kupac in listaKupaca)
            {
                if (!cbKupci.Items.Contains(kupac.IdKupca))
                {
                    cbKupci.Items.Add(kupac.IdKupca);
                }
            }

            listaPonuda = Administrator.DeserijalizujPonude();

            foreach (Ponuda ponuda in listaPonuda) {
                if (!cbSvePonude.Items.Contains(ponuda)) {
                    cbSvePonude.Items.Add(ponuda);
                }
            }

        }

        private void cbIDAuta_SelectedIndexChanged(object sender, EventArgs e)
        {   // ISPIS U TEXTBOX-ove
            int selektovani = (int)cbIDAuta.SelectedItem;

            foreach (Automobil auto in listaAuta) {
                if (selektovani == auto.IdAutomobila)
                {
                    txtMarka.Text = auto.Marka;
                    txtModel.Text = auto.Model;
                    txtGodiste.Text = auto.Godiste.ToString(); // int
                    txtKubikaza.Text = auto.Kubikaza.ToString(); // int
                    txtPogon.Text = auto.Pogon;
                    txtMenjac.Text = auto.VrstaMenjaca;
                    txtKaroserija.Text = auto.Karoserija;
                    txtGorivo.Text = auto.Gorivo;
                    txtBrVrata.Text = auto.BrojVrata.ToString(); // int
                }
            }
        }

        private void btnAzurirajAuto_Click(object sender, EventArgs e)
        {
            int selektovaniId = 0;

            if (cbIDAuta.SelectedItem == null)
            {
                MessageBox.Show("Nije izabran nijedan automobil!");
                return;
            }
            else {
                selektovaniId = (int)cbIDAuta.SelectedItem;
            }
;
            int intGodiste = 0;
            int intKubikaza = 0;
            int intBrVrata = 0;

            // PROVERE 
            // da li su polja prazna
            if (txtMarka.Text == "" ||
                txtModel.Text == "" ||
                txtGodiste.Text == "" ||
                txtKubikaza.Text == "" ||
                txtPogon.Text == "" ||
                txtMenjac.Text == "" ||
                txtKaroserija.Text == "" ||
                txtGorivo.Text == "" ||
                txtBrVrata.Text == "")
            {
                MessageBox.Show("Polja ne smeju ostati prazna!");
                return;
            }

            char[] nizKaraktera;

            // godiste
            nizKaraktera = txtGodiste.Text.ToCharArray();
            bool flag1 = false;
            foreach (char slovo in nizKaraktera)
            {
                if (!Char.IsDigit(slovo))
                {
                    MessageBox.Show("Godište sme sadržati samo broj godine!");
                    txtGodiste.BackColor = Color.Red;
                    flag1 = true;
                    return;
                }
            }
            if (nizKaraktera.Length != 4)
            {
                MessageBox.Show("Godište mora sadržati 4 cifre tj. broj godine!");
                txtGodiste.BackColor = Color.Red;
                return;
            }
            else if (!flag1)
            {
                intGodiste = int.Parse(txtGodiste.Text);
            }

            // kubikaza
            nizKaraktera = txtKubikaza.Text.ToCharArray();
            bool flag2 = false;
            foreach (char slovo in nizKaraktera)
            {
                if (!Char.IsDigit(slovo))
                {
                    MessageBox.Show("Kubikaža mora biti navedena ciframa u kW!");
                    txtKubikaza.BackColor = Color.Red;
                    flag2 = true;
                    return;
                }
            }
            if (!flag2)
            {
                intKubikaza = int.Parse(txtKubikaza.Text);
            }

            // broj vrata
            nizKaraktera = txtBrVrata.Text.ToCharArray();
            bool flag3 = false;
            foreach (char slovo in nizKaraktera)
            {
                if (!Char.IsDigit(slovo))
                {
                    MessageBox.Show("Broj vrata mora biti unet brojem, a ne slovima ili znakovima!");
                    txtBrVrata.BackColor = Color.Red;
                    flag3 = true;
                    return;
                }
            }
            if (!flag3)
            {
                intBrVrata = int.Parse(txtBrVrata.Text);
            }

            // id
            foreach (Automobil a in listaAuta)
            {
                if (txtNoviId.Text.Equals(a.IdAutomobila.ToString()))
                {
                    MessageBox.Show("Novi ID ne može biti ID koji već postoji!");
                    txtNoviId.BackColor = Color.Red;
                    return;
                }
            }

            foreach (Automobil auto in listaAuta)
            {
                if (selektovaniId == auto.IdAutomobila)
                {
                    if (!txtNoviId.Text.Equals(""))
                    {
                        auto.IdAutomobila = int.Parse(txtNoviId.Text); // int

                        foreach (Ponuda p in listaPonuda)
                        {
                            if (p.IdAuta == selektovaniId)
                            {
                                p.IdAuta = int.Parse(txtNoviId.Text);
                            }
                        }
                        Administrator.SerijalizuPonude(listaPonuda);
                        listaPonuda = Administrator.DeserijalizujPonude();

                        List<Rezervacija> listaRezervacija = Administrator.DeserijalizujRezervacije();
                        foreach (Rezervacija r in listaRezervacija) {
                            if (r.IdAuta == selektovaniId) {
                                r.IdAuta = int.Parse(txtNoviId.Text);
                            }
                        }
                        Administrator.SerijalizuRezervacije(listaRezervacija);
                    }

                    auto.Marka = txtMarka.Text;
                    auto.Model = txtModel.Text;
                    auto.Godiste = int.Parse(txtGodiste.Text); // int
                    auto.Kubikaza = int.Parse(txtKubikaza.Text); // int
                    auto.Pogon = txtPogon.Text;
                    auto.VrstaMenjaca = txtMenjac.Text;
                    auto.Karoserija = txtKaroserija.Text;
                    auto.Gorivo = txtGorivo.Text;
                    auto.BrojVrata = int.Parse(txtBrVrata.Text); // int
                }
            }

            Administrator.SerijalizujAute(listaAuta);
            MessageBox.Show("Uspešno ste ažurirali podatke o automobilu!");

            txtNoviId.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtGodiste.Clear();
            txtKubikaza.Clear();
            txtPogon.Clear();
            txtMenjac.Clear();
            txtKaroserija.Clear();
            txtGorivo.Clear();
            txtBrVrata.Clear();

            cbIDAuta.Items.Clear();
            cbIDAuta.Text = "";
            cbSvePonude.Items.Clear();
            cbPonudaIdAuta.Items.Clear();

            listaAuta = Administrator.DeserijalizujAute();

            foreach (Automobil auto in listaAuta)
            {
                if (!cbIDAuta.Items.Contains(auto.IdAutomobila))
                {
                    cbIDAuta.Items.Add(auto.IdAutomobila);
                }
                if (!cbPonudaIdAuta.Items.Contains(auto.IdAutomobila)) {
                    cbPonudaIdAuta.Items.Add(auto.IdAutomobila);
                }
            }

            foreach (Ponuda p in listaPonuda) {
                if (!cbSvePonude.Items.Contains(p))
                {
                    cbSvePonude.Items.Add(p);
                }
            }
        }

        private void btnDodajAuto_Click(object sender, EventArgs e)
        {
            frmDodajAutomobil formadodaj = new frmDodajAutomobil();
            Hide();
            formadodaj.ShowDialog();
            Close();
        }

        private void btnObrisiAuto_Click(object sender, EventArgs e)
        {
            frmObrisiAutomobil formaobrisi = new frmObrisiAutomobil();
            Hide();
            formaobrisi.ShowDialog();
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNoviId_TextChanged(object sender, EventArgs e)
        {
            txtNoviId.BackColor = DefaultBackColor;
        }

        private void txtGodiste_TextChanged(object sender, EventArgs e)
        {
            txtGodiste.BackColor = DefaultBackColor;
        }

        private void txtKubikaza_TextChanged(object sender, EventArgs e)
        {
            txtKubikaza.BackColor = DefaultBackColor;
        }

        private void txtBrVrata_TextChanged(object sender, EventArgs e)
        {
            txtBrVrata.BackColor = DefaultBackColor;
        }

        private void cbKupci_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ISPIS U TEXTBOX-ove

            int selektovani = (int)cbKupci.SelectedItem;

            foreach (Kupac k in listaKupaca)
            {
                if (selektovani == k.IdKupca)
                {
                    txtImeKupca.Text = k.Ime;
                    txtPrezimeKupca.Text = k.Prezime;
                    txtJmbgKupca.Text = k.Jmbg;
                    dtpDatRodjKupca.Value = k.DatumRodjenja;
                    txtTelefonKupca.Text = k.Telefon;
                    txtUsernameKupca.Text = k.Username;
                    txtPasswordKupca.Text = k.Password;
                }
            }
        }

        private void btnAzurirajKupca_Click(object sender, EventArgs e)
        {
            int selektovani = 0;

            if (cbKupci.SelectedItem == null)
            {
                MessageBox.Show("Nije izabran nijedan kupac!");
                return;
            }
            else
            {
                selektovani = (int)cbKupci.SelectedItem;
            }

            // PROVERE
            // da li su polja prazna
            if (txtImeKupca.Text.Equals("") ||
                txtPrezimeKupca.Text.Equals("") ||
                txtJmbgKupca.Text.Equals("") ||
                txtTelefonKupca.Text.Equals("") ||
                txtUsernameKupca.Text.Equals("") ||
                txtPasswordKupca.Text.Equals("")) {
                MessageBox.Show("Nijedno polje ne sme ostati prazno!");
                return;
            }

            char[] nizKaraktera;

            // provera imena
            nizKaraktera = txtImeKupca.Text.ToCharArray();

            foreach (char karakter in nizKaraktera)
            {
                if (char.IsDigit(karakter))
                {
                    MessageBox.Show("Ime ne sme sadržati cifru!");
                    txtImeKupca.BackColor = Color.Red;
                    return;
                }
            }

            // provera prezimena
            nizKaraktera = txtPrezimeKupca.Text.ToCharArray();
            foreach (char karakter in nizKaraktera)
            {
                if (char.IsDigit(karakter))
                {
                    MessageBox.Show("Prezime ne sme sadržati cifru!");
                    txtPrezimeKupca.BackColor = Color.Red;
                    return;
                }
            }

            // provera br. telefona
            nizKaraktera = txtTelefonKupca.Text.ToCharArray();
            foreach (char karakter in nizKaraktera)
            {
                if (!char.IsDigit(karakter))
                {
                    MessageBox.Show("Broj telefona mora sadržati samo cifre!");
                    txtTelefonKupca.BackColor = Color.Red;
                    return;
                }
            }
            if (nizKaraktera.Length > 10 || nizKaraktera.Length < 9)
            {
                MessageBox.Show("Uneli ste nepostojeći broj telefona!");
                txtTelefonKupca.BackColor = Color.Red;
                return;
            }
            if (!txtTelefonKupca.Text.StartsWith("06"))
            {
                MessageBox.Show("Molimo unesite broj u odgovarajućem formatu npr. 062111333!");
                txtTelefonKupca.BackColor = Color.Red;
                return;
            }

            // provera jmbg-a
            nizKaraktera = txtJmbgKupca.Text.ToCharArray();
            if (nizKaraktera.Length != 13)
            {
                MessageBox.Show("Jmbg mora sadržati tačno 13 cifara!");
                txtJmbgKupca.BackColor = Color.Red;
                return;
            }
            foreach (char karakter in nizKaraktera)
            {
                if (!char.IsDigit(karakter))
                {
                    MessageBox.Show("Jmbg mora sadržati samo cifre!");
                    txtJmbgKupca.BackColor = Color.Red;
                    return;
                }
            }

            // provera godina
            int izabranaGodina = dtpDatRodjKupca.Value.Year;

            if ((DateTime.Now.Year - izabranaGodina) < 18)
            {
                MessageBox.Show("Maloletna lica ne mogu imati nalog!");
                return;
            }

            // id
            foreach (Kupac kup in listaKupaca)
            {
                if (txtNoviIdKupca.Text.Equals(kup.IdKupca.ToString()))
                {
                    MessageBox.Show("Novi ID ne može biti ID koji već postoji!");
                    txtNoviIdKupca.BackColor = Color.Red;
                    return;
                }
            }

            // username
            if (txtUsernameKupca.Text.Equals(txtNoviUsername.Text)) {
                MessageBox.Show("Novo korisničko ime ne može biti isto kao staro!");
                txtNoviUsername.BackColor = Color.Red;
                return;
            }
            bool nadjeno = false;
            foreach (Kupac kup in listaKupaca)
            {
                if (kup.Username.Equals(txtNoviUsername.Text))
                {
                    nadjeno = true;
                }
            }
            if (nadjeno)
            {
                MessageBox.Show("Nalog sa unetim korisničkim imenom već postoji!");
                txtNoviUsername.BackColor = Color.Red;
                return;
            }

            foreach (Kupac k in listaKupaca)
            {
                if (selektovani == k.IdKupca)
                {
                    if (!txtNoviIdKupca.Text.Equals(""))
                    {
                        k.IdKupca = int.Parse(txtNoviIdKupca.Text); // int

                        List<Rezervacija> listaRezervacija = Administrator.DeserijalizujRezervacije();
                        foreach (Rezervacija r in listaRezervacija)
                        {
                            if (r.IdKupca == selektovani)
                            {
                                r.IdKupca = int.Parse(txtNoviIdKupca.Text);
                            }
                        }
                        Administrator.SerijalizuRezervacije(listaRezervacija);
                    }

                    k.Ime = txtImeKupca.Text;
                    k.Prezime = txtPrezimeKupca.Text;
                    k.Telefon = txtTelefonKupca.Text;
                    k.Jmbg = txtJmbgKupca.Text;
                    k.DatumRodjenja = dtpDatRodjKupca.Value;

                    if (!txtNoviUsername.Text.Equals(""))
                    {
                        k.Username = txtNoviUsername.Text;
                    }

                    k.Password = txtPasswordKupca.Text;
                }
            }


            Administrator.SerijalizujKupce(listaKupaca);
            MessageBox.Show("Uspešno ste ažurirali podatke o kupcu!");
            txtImeKupca.Clear();
            txtPrezimeKupca.Clear();
            txtJmbgKupca.Clear();
            txtTelefonKupca.Clear();
            txtUsernameKupca.Clear();
            txtNoviUsername.Clear();
            txtPasswordKupca.Clear();
            txtNoviIdKupca.Clear();

            cbKupci.Items.Clear();
            cbKupci.Text = "";

            listaKupaca = Administrator.DeserijalizujKupce();
            foreach (Kupac kupac in listaKupaca)
            {
                if (!cbKupci.Items.Contains(kupac.IdKupca))
                {
                    cbKupci.Items.Add(kupac.IdKupca);
                }
            }

        }

        private void txtNoviIdKupca_TextChanged(object sender, EventArgs e)
        {
            txtNoviIdKupca.BackColor = DefaultBackColor;
        }

        private void txtImeKupca_TextChanged(object sender, EventArgs e)
        {
            txtImeKupca.BackColor = DefaultBackColor;
        }

        private void txtPrezimeKupca_TextChanged(object sender, EventArgs e)
        {
            txtPrezimeKupca.BackColor = DefaultBackColor;
        }

        private void txtJmbgKupca_TextChanged(object sender, EventArgs e)
        {
            txtJmbgKupca.BackColor = DefaultBackColor;
        }

        private void txtTelefonKupca_TextChanged(object sender, EventArgs e)
        {
            txtTelefonKupca.BackColor = DefaultBackColor;
        }

        private void txtUsernameKupca_TextChanged(object sender, EventArgs e)
        {
            txtUsernameKupca.BackColor = DefaultBackColor;
        }

        private void txtNoviUsername_TextChanged(object sender, EventArgs e)
        {
            txtNoviUsername.BackColor = DefaultBackColor;
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            frmRegistracija frm = new frmRegistracija();
            Hide();
            frm.IsAdmin = true;
            frm.ShowDialog();
            Close();
        }

        private void btnObrisiKupca_Click(object sender, EventArgs e)
        {
            frmObrisiKupca frm = new frmObrisiKupca();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void btnDodajPonudu_Click(object sender, EventArgs e)
        {
            int selektovaniIdAuta = 0;
            DateTime selektovaniDatumOd;
            DateTime selektovaniDatumDo;
            int cenaPoDanu = 0;

            if (cbPonudaIdAuta.SelectedItem != null) {
                selektovaniIdAuta = (int)cbPonudaIdAuta.SelectedItem;
            }
            else
            {
                MessageBox.Show("Niste izabrali automobil!");
                return;
            }

            if (!string.IsNullOrEmpty(txtCenaPoDanu.Text))
            {
                char[] niz = txtCenaPoDanu.Text.ToCharArray();
                bool greska = false;
                foreach (char karakter in niz)
                {
                    if (!char.IsDigit(karakter)) { // ako jedan od karaktera nije broj
                        greska = true;
                    }
                }
                if (greska) {
                    MessageBox.Show("Cenu unesite brojevima, ne slovima!");
                    return;
                }
                else
                {
                    cenaPoDanu = int.Parse(txtCenaPoDanu.Text);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli cenu po danu!");
                return;
            }

            int provera = dateOd.Value.Date.CompareTo(DateTime.Now.Date);
            if (provera < 0) // ako je selektovani datum OD ranije od današnjeg dana
            {
                MessageBox.Show("Ne možete izabrati datum koji je već prošao!");
                return;
            }
            else
            {
                selektovaniDatumOd = dateOd.Value;
            }

            provera = dateDo.Value.Date.CompareTo(selektovaniDatumOd.Date);
            if (provera < 0) // ako je selektovani datum DO ranije od datuma OD
            {
                MessageBox.Show("Datum do kojeg traje ponuda mora biti posle datuma od kada ponuda počinje!");
                return;
            }
            else
            {
                selektovaniDatumDo = dateDo.Value;
            }

            Ponuda novaPounda = new Ponuda(selektovaniIdAuta, selektovaniDatumOd, selektovaniDatumDo, cenaPoDanu);

            int brojac = 0;
            int brojPonuda = 0;

            foreach (Ponuda p in listaPonuda)
            {
                if (selektovaniIdAuta == p.IdAuta) // ako za auto postoje ponude
                {
                    int proveri1 = novaPounda.DatumOd.Date.CompareTo(p.DatumOd.Date);
                    int proveri2 = novaPounda.DatumDo.Date.CompareTo(p.DatumDo.Date);
                    int proveri3 = novaPounda.DatumOd.Date.CompareTo(p.DatumDo.Date);
                    int proveri4 = novaPounda.DatumDo.Date.CompareTo(p.DatumOd.Date);

                    // ako za taj auto, već postoji ponuda koja pokriva vremenski period nove ponude
                    if ((proveri1 < 0 && proveri2 < 0 && proveri3 < 0 && proveri4 < 0)
                        || (proveri1 > 0 && proveri2 > 0 && proveri3 > 0 && proveri4 > 0))
                    {
                        brojac++;
                        
                    }
                    brojPonuda++;
                } 
            }

            if (brojac != brojPonuda) {
                MessageBox.Show("Vremenski period nove ponude je već sadržan u nekoj od postojećih ponuda!");
                return;
            }
            else {
                listaPonuda.Add(novaPounda);
                Administrator.SerijalizuPonude(listaPonuda);
                MessageBox.Show("Uspešno dodata ponuda!");

                cbPonudaIdAuta.Text = "";
                txtCenaPoDanu.Text = "";

                cbSvePonude.Items.Clear();
                cbSvePonude.Text = "";

                listaPonuda = Administrator.DeserijalizujPonude();

                foreach (Ponuda ponuda in listaPonuda)
                {
                    if (!cbSvePonude.Items.Contains(ponuda.ToString()))
                    {
                        cbSvePonude.Items.Add(ponuda);
                    }
                }
            }
        }

        private void btnObrisiPonudu_Click(object sender, EventArgs e)
        {
            Ponuda temp = cbSvePonude.SelectedItem as Ponuda;

            if (temp != null)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrištete ponudu " + temp.ToString() + "?", "Obriši", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    listaPonuda.Remove(temp);
                    Administrator.SerijalizuPonude(listaPonuda);
                    MessageBox.Show("Ponuda izbrisana!");
                    cbSvePonude.Items.Clear();
                    cbSvePonude.Text = "";

                    listaPonuda = Administrator.DeserijalizujPonude();

                    foreach (Ponuda ponuda in listaPonuda)
                    {
                        if (!cbSvePonude.Items.Contains(ponuda.ToString()))
                        {
                            cbSvePonude.Items.Add(ponuda);
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Ponuda nije izbrisana!");
                }
            }
            else
            {
                MessageBox.Show("Izaberite ponudu koju želite da obrišete!");
            }
        }

        private void btnAzurirajPonudu_Click(object sender, EventArgs e)
        {
            frmAzurirajPonudu frm = new frmAzurirajPonudu();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            frmLogin forma = new frmLogin();
            Hide();
            forma.ShowDialog();
            Close();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            frmAdminRezervacije forma = new frmAdminRezervacije();
            Hide();
            forma.ShowDialog();
            Close();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            frmStatistika forma = new frmStatistika();
            Hide();
            forma.ShowDialog();
            Close();
        }
    }

}
