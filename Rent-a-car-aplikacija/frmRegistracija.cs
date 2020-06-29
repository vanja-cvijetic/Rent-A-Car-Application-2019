using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_car_aplikacija
{
    public partial class frmRegistracija : Form
    {
        List<Kupac> listaKupaca;
        public static bool isAdmin;     

        public frmRegistracija()
        {
            InitializeComponent();
            listaKupaca = new List<Kupac>();
            isAdmin = false;
        }

        public bool IsAdmin { get { return isAdmin; } set { isAdmin = value; } }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isAdmin) {
                frmAdministrator forma = new frmAdministrator();
                Hide();
                forma.ShowDialog();
                Close();
            }
            else { 
                frmLogin forma = new frmLogin();
                Hide();
                forma.ShowDialog();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string ime, prezime, telefon, jmbg, korisnickoIme, lozinka;
            DateTime datumRodjenja;

            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            telefon = txtTelefon.Text;
            korisnickoIme = txtUsername.Text;
            lozinka = txtPassword.Text;
            jmbg = txtJmbg.Text;
            datumRodjenja = dtpDatumRodjenja.Value;


            // PROVERE

            // provera da li su polja prazna
            if (txtIme.Text.Equals("") ||
                txtPrezime.Text.Equals("") ||
                txtTelefon.Text.Equals("") ||
                txtJmbg.Text.Equals("") ||
                txtUsername.Text.Equals("") ||
                txtPassword.Text.Equals("")
                )
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            char[] nizKaraktera;

            // provera imena
            nizKaraktera = ime.ToCharArray();

            foreach (char karakter in nizKaraktera)
            {
                if (char.IsDigit(karakter))
                {
                    MessageBox.Show("Ime ne sme sadržati cifru!");
                    txtIme.BackColor = Color.Red;
                    return;
                }
            }

            // provera prezimena
            nizKaraktera = prezime.ToCharArray();
            foreach (char karakter in nizKaraktera)
            {
                if (char.IsDigit(karakter))
                {
                    MessageBox.Show("Prezime ne sme sadržati cifru!");
                    txtPrezime.BackColor = Color.Red;
                    return;
                }
            }

            // provera br. telefona
            nizKaraktera = telefon.ToCharArray();
            foreach (char karakter in nizKaraktera)
            {
                if (!char.IsDigit(karakter))
                {
                    MessageBox.Show("Broj telefona mora sadržati samo cifre!");
                    txtTelefon.BackColor = Color.Red;
                    return;
                }
            }
            if (nizKaraktera.Length > 10 || nizKaraktera.Length < 9)
            {
                MessageBox.Show("Uneli ste nepostojeći broj telefona!");
                txtTelefon.BackColor = Color.Red;
                return;
            }
            if (!telefon.StartsWith("06")) {
                MessageBox.Show("Molimo unesite broj u odgovarajućem formatu npr. 062111333!");
                txtTelefon.BackColor = Color.Red;
                return;
            }

            // provera jmbg-a
             nizKaraktera = txtJmbg.Text.ToCharArray();
             if (nizKaraktera.Length != 13)
             {
                MessageBox.Show("Jmbg mora sadržati tačno 13 cifara!");
                txtJmbg.BackColor = Color.Red;
                return;
             }
             foreach (char karakter in nizKaraktera)
             {
                 if (!char.IsDigit(karakter))
                 {
                    MessageBox.Show("Jmbg mora sadržati samo cifre!");
                    txtJmbg.BackColor = Color.Red;
                    return;
                 }
             }
            
            // provera godina
            int izabranaGodina = dtpDatumRodjenja.Value.Year;
           
            if ((DateTime.Now.Year-izabranaGodina)<18)
            {
                MessageBox.Show("Maloletna lica ne mogu da otvore nalog!");
                return;
            }

            // provera username-a  
            bool nadjeno = false;
            foreach (Kupac kup in listaKupaca)
            {
                if (kup.Username.Equals(korisnickoIme))
                { // ako postoji kupac sa tim kor. imenom  
                    nadjeno = true;
                }
            }
            if (nadjeno)
            {
                MessageBox.Show("Nalog sa unetim korisničkim imenom već postoji!");
                txtUsername.BackColor = Color.Red;
                return;
            }

            // ako je sve OK
            Kupac novi = new Kupac(ime, prezime, telefon, jmbg, datumRodjenja, korisnickoIme, lozinka);
            listaKupaca.Add(novi);

            MessageBox.Show("Nalog uspešno napravljen!");

            Administrator.SerijalizujKupce(listaKupaca);

            if (isAdmin)
            { // ako je admin pozvao ovu formu
                frmAdministrator admin = new frmAdministrator();
                Hide();
                admin.ShowDialog();
                Close();
            }
            else {
                frmKupac frmKupac = new frmKupac();
                listaKupaca = Administrator.DeserijalizujKupce(); // vrati ponovo listu, ovaj put sa upisanim novim objektom
                int id = 0;
                foreach (Kupac k in listaKupaca)
                {
                    if (k.Username.Equals(korisnickoIme)) { // nadji username kupca koji je sad registrovao i uhvati njegov id
                        id = k.IdKupca;
                    }
                }
                frmKupac.IdKupac = id;

                Hide();
                frmKupac.ShowDialog();
                Close();
            }

            
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            txtIme.BackColor = DefaultBackColor;
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            txtPrezime.BackColor = DefaultBackColor;
        }

        private void txtJmbg_TextChanged(object sender, EventArgs e)
        {
            txtJmbg.BackColor = DefaultBackColor;
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            txtTelefon.BackColor = DefaultBackColor;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = DefaultBackColor;
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            listaKupaca = Administrator.DeserijalizujKupce();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void cbSifra_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifra.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else if (!cbSifra.Checked)
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
