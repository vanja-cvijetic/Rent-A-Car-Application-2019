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
    public partial class frmNalogKupca : Form
    {
        int idUlogovanog;
        List<Kupac> listaKupaca;
        Kupac ulogovani;

        public frmNalogKupca(int idUlogovanog)
        {
            InitializeComponent();
            this.idUlogovanog = idUlogovanog;
            listaKupaca = new List<Kupac>();
            ulogovani = null;

            this.Text = "";
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmNalogKupca_Load(object sender, EventArgs e)
        {
            listaKupaca = Administrator.DeserijalizujKupce();

            foreach (Kupac k in listaKupaca) {
                if (k.IdKupca == idUlogovanog) {
                    ulogovani = k;
                }
            }

            txtID.Text = ulogovani.IdKupca.ToString();
            txtIme.Text = ulogovani.Ime;
            txtPrezime.Text = ulogovani.Prezime;
            txtJmbg.Text = ulogovani.Jmbg;
            txtTelefon.Text = ulogovani.Telefon;
            dateDatRodj.Value = ulogovani.DatumRodjenja.Date;
            dateDatRodj.MinDate = ulogovani.DatumRodjenja.Date;
            dateDatRodj.MaxDate = ulogovani.DatumRodjenja.Date;

            txtKorisnicko.Text = ulogovani.Username;
            txtLozinka.Text = ulogovani.Password;
            txtLozinka.UseSystemPasswordChar = true;
            txtNovaLozinka.UseSystemPasswordChar = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNovoKorisnicko.Text)
                || !string.IsNullOrEmpty(txtNovaLozinka.Text)) 
                // ako je bar jedno popunjeno
            {
                bool nadjeno = false;
                foreach (Kupac kup in listaKupaca)
                {
                    if (kup.Username.Equals(txtNovoKorisnicko.Text))
                    { // ako postoji kupac sa tim kor. imenom  
                        nadjeno = true;
                    }
                }
                if (nadjeno)
                {
                    MessageBox.Show("Nalog sa unetim korisničkim imenom već postoji!");
                    txtNovoKorisnicko.BackColor = Color.Red;
                    return;
                }

                if (txtLozinka.Text.Equals(txtNovaLozinka.Text))
                {
                    MessageBox.Show("Nova loznika ne može biti ista kao i stara lozinka!");
                    txtNovaLozinka.BackColor = Color.Red;
                    return;
                }

                if (!string.IsNullOrEmpty(txtNovoKorisnicko.Text))
                    ulogovani.Username = txtNovoKorisnicko.Text;
                if (!string.IsNullOrEmpty(txtNovaLozinka.Text))
                    ulogovani.Password = txtNovaLozinka.Text;

                Administrator.SerijalizujKupce(listaKupaca);
                listaKupaca = Administrator.DeserijalizujKupce();
                MessageBox.Show("Promene su sačuvane!");

                txtNovoKorisnicko.Clear();
                txtNovaLozinka.Clear();
                txtKorisnicko.Text = ulogovani.Username;
                txtLozinka.Text = ulogovani.Password;
            }
            else {
                MessageBox.Show("Niste napravili izmene.");
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtLozinka.UseSystemPasswordChar = false;
            else if (!checkBox1.Checked)
                txtLozinka.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                txtNovaLozinka.UseSystemPasswordChar = false;
            else if (!checkBox2.Checked)
                txtNovaLozinka.UseSystemPasswordChar = true;
        }

        private void txtNovoKorisnicko_TextChanged(object sender, EventArgs e)
        {
            txtNovoKorisnicko.BackColor = DefaultBackColor;
        }

        private void txtNovaLozinka_TextChanged(object sender, EventArgs e)
        {
            txtNovaLozinka.BackColor = DefaultBackColor;
        }
    }
}
