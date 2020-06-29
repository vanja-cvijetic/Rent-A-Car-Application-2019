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
    public partial class frmLogin : Form
    {
        public string unosKorisnickogImena;
        public string unosLozinke;
        List<Kupac> listaKupaca;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        { 
            unosKorisnickogImena = txtUsername.Text;
            unosLozinke = txtPassword.Text;

            if(string.IsNullOrEmpty(unosKorisnickogImena) || string.IsNullOrEmpty(unosLozinke))
            {
                MessageBox.Show("Polja ne mogu biti prazna!");
            }
            else { 
                if (cbAdmin.Checked)
                {
                    Administrator admin = new Administrator();

                    if (unosKorisnickogImena.Equals("admin"))
                    { // da li je korisnicko ime tacno
                        if (admin.daLiJeSifraTacna(unosLozinke,admin.Password)) // da li je sifra tacna
                        {
                            frmAdministrator forma = new frmAdministrator();
                            Hide();
                            forma.ShowDialog();
                            Close();
                        }
                        else
                        { // ako sifra nije tacna
                            txtPassword.BackColor = Color.Red;
                            MessageBox.Show("Lozinka koju ste uneli nije tačna!");
                        }
                    }
                    else
                    { // ako korisnicko ime nije tacno
                        txtUsername.BackColor = Color.Red;
                        MessageBox.Show("Netačno korisničko ime za administratora!");
                    }
                }
                else {
                 
                    bool nadjen = false;
                    bool nadjenoIme = false;

                    if (unosKorisnickogImena.Equals("admin")) {
                        MessageBox.Show("Pokušali ste da se ulogujete kao administrator!\nMolimo označite da to želite iznad!");
                    }
                    else if (unosKorisnickogImena.Equals("") || unosLozinke.Equals(""))
                    {
                        MessageBox.Show("Polja ne mogu ostati prazna!");
                    }
                    else {   
                        foreach (Kupac kupac in listaKupaca)
                        {
                            if (kupac.Username.Equals(unosKorisnickogImena))
                            { // ako postoji kupac sa tim kor. imenom
                                nadjenoIme = true;
                                if (kupac.daLiJeSifraTacna(unosLozinke, kupac.Password))
                                { // ako postoji to ime sa tom lozinkom
                                    nadjen = true;
                                }
                            }
                        }

                        if (nadjenoIme)
                        {
                            if (nadjen)
                            {
                                frmKupac forma = new frmKupac();
                                foreach (Kupac k in listaKupaca) {
                                    if (k.Username == unosKorisnickogImena) {
                                        forma.idKupac = k.IdKupca;
                                    }
                                }
                                Hide();
                                forma.ShowDialog();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Lozinka koju ste uneli nije tačna!");
                                txtPassword.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            txtUsername.BackColor = Color.Red;
                            DialogResult dr = MessageBox.Show("Ne postoji nalog sa tim korisničkim imenom!\nDa li želite da se registrujete?", "Nalog ne postoji", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes) {
                                frmRegistracija forma = new frmRegistracija();
                                Hide();
                                forma.ShowDialog();
                                Close();
                            }
                        }
                    }
                    }
            }
        }

        private void lblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistracija forma = new frmRegistracija();
            Hide();
            forma.ShowDialog();
            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = DefaultBackColor;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = DefaultBackColor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            listaKupaca = Administrator.DeserijalizujKupce();
            //listaKupaca = new List<Kupac>();
            //Kupac k = new Kupac("Vanja", "Cvijetić", "062394193", "1307998826271", new DateTime(1998, 7, 13), "vanja", "vanja");
            //listaKupaca.Add(k);
            //Administrator.SerijalizujKupce(listaKupaca);  
        }
    }
}
