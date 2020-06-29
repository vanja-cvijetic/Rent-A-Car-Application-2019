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
    public partial class frmDodajAutomobil : Form
    {
        List<Automobil> listaAuta = new List<Automobil>();
        bool greska = false;

        public frmDodajAutomobil()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdministrator forma = new frmAdministrator();
            Hide();
            forma.ShowDialog();
            Close();
        }

        private void frmDodajAutomobil_Load(object sender, EventArgs e)
        {
            listaAuta = Administrator.DeserijalizujAute();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // da li su polja prazna
            if (txtId.Text == "" ||
                txtMarka.Text == "" ||
                txtModel.Text == "" ||
                txtGodiste.Text == "" ||
                txtKubikaza.Text == "" ||
                txtPogon.Text == "" ||
                txtMenjac.Text == "" ||
                txtKaroserija.Text == "" ||
                txtGorivo.Text == "" ||
                txtBrVrata.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return;
            }

            string id = txtId.Text; // int
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string godiste = txtGodiste.Text; // int
            string kubikaza = txtKubikaza.Text; // int
            string pogon = txtPogon.Text;
            string menjac = txtMenjac.Text;
            string karoserija = txtKaroserija.Text;
            string gorivo = txtGorivo.Text;
            string brVrata = txtBrVrata.Text; // int

            int intGodiste = 0;
            int intKubikaza = 0;
            int intBrVrata = 0;
            int intId = 0;

            // PROVERE 
            char[] nizKaraktera;

            // ID
            nizKaraktera = id.ToCharArray();
            foreach (char slovo in nizKaraktera)
            {
                if (!Char.IsDigit(slovo)) {
                    MessageBox.Show("ID mora da se sastoji samo od cifara!");
                    txtId.BackColor = Color.Red;
                    return;
                }
            }
            foreach (Automobil a in listaAuta)
            {
                if (txtId.Text.Equals(a.IdAutomobila.ToString()))
                {
                    MessageBox.Show("Novi ID ne može biti ID koji već postoji!");
                    txtId.BackColor = Color.Red;
                    return;
                }
            }
            intId = int.Parse(id);

            // godiste
            nizKaraktera = godiste.ToCharArray();
            foreach (char slovo in nizKaraktera) {
                if (!Char.IsDigit(slovo))
                {
                    MessageBox.Show("Godište sme sadržati samo broj godine!");
                    txtGodiste.BackColor = Color.Red;
                    return;
                }
            }
            if (nizKaraktera.Length != 4) {
                MessageBox.Show("Godište mora sadržati 4 cifre tj. broj godine!");
                txtGodiste.BackColor = Color.Red;
                return;
            }
            intGodiste = int.Parse(godiste);


            // kubikaza
            nizKaraktera = kubikaza.ToCharArray();
            foreach (char slovo in nizKaraktera)
            {
                if (!Char.IsDigit(slovo))
                {
                    MessageBox.Show("Kubikaža mora biti navedena ciframa u kW!");
                    txtKubikaza.BackColor = Color.Red;
                    return;
                }
            }
            intKubikaza = int.Parse(kubikaza);


            // godiste
            nizKaraktera = brVrata.ToCharArray();
            foreach (char slovo in nizKaraktera)
            {
                if (!Char.IsDigit(slovo))
                {
                    MessageBox.Show("Broj vrata mora biti unet brojem, a ne slovima ili znakovima!");
                    txtBrVrata.BackColor = Color.Red;
                    return;
                } 
            }
            intBrVrata = int.Parse(brVrata);


            

            Automobil novi = new Automobil(intId, marka, model, intGodiste, intKubikaza, pogon, menjac, karoserija, gorivo, intBrVrata, false);
            listaAuta.Add(novi);
            Administrator.SerijalizujAute(listaAuta);

            MessageBox.Show("Uspešno dodat automobil!");

            txtId.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtGodiste.Clear();
            txtKubikaza.Clear();
            txtPogon.Clear();
            txtMenjac.Clear();
            txtKaroserija.Clear();
            txtGorivo.Clear();
            txtBrVrata.Clear();
            txtMarka.Focus();
            
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            txtId.BackColor = DefaultBackColor;
        }
    }
}
