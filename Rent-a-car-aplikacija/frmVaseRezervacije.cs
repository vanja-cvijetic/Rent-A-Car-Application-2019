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
    public partial class frmVaseRezervacije : Form
    {
        int idUlogovanog;
        List<Rezervacija> listaRezervacija;
        List<Ponuda> listaPonuda;

        public frmVaseRezervacije(int idUlogovanog)
        {
            InitializeComponent();
            this.idUlogovanog = idUlogovanog;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;
            this.listaRezervacija = new List<Rezervacija>();
            this.listaPonuda = new List<Ponuda>();
        }

        private void frmVaseRezervacije_Load(object sender, EventArgs e)
        {           
            foreach (Kupac kupac in Administrator.DeserijalizujKupce()) {
                if (idUlogovanog == kupac.IdKupca) {
                    lblUlogovaniSte.Text = "Ulogovani ste kao " + kupac.Username;
                }
            }

            listaPonuda = Administrator.DeserijalizujPonude();
            listaRezervacija = Administrator.DeserijalizujRezervacije();

            foreach (Rezervacija rez in listaRezervacija)
            {
                if (rez.IdKupca == idUlogovanog)
                {
                    if (!lbListaRezervacija.Items.Contains(rez))
                    {
                        lbListaRezervacija.Items.Add(rez);
                    }
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmRezervisi forma = new frmRezervisi(idUlogovanog);
            forma.MdiParent = this.MdiParent;           
            Hide();
            forma.Show();
            Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Rezervacija izabranaRezervacija = (Rezervacija)lbListaRezervacija.SelectedItem;

            if (izabranaRezervacija == null)
            {
                MessageBox.Show("Izaberite rezervaciju koju želite da izbrišete!");
            }
            else {
                DialogResult dr = MessageBox.Show("Da li ste sigurni da želite da otkažete" +
                    " izabranu rezervaciju: " + izabranaRezervacija.ToString() + "?", "Otkazivanje rezervacije", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    listaRezervacija.Remove(izabranaRezervacija);

                    TimeSpan dani = izabranaRezervacija.DatumRezDo - izabranaRezervacija.DatumRezOd;
                    int brDana = (int)dani.Days + 1;

                    int cenaPoDanu = izabranaRezervacija.Cena / brDana;

                    Ponuda p = new Ponuda(izabranaRezervacija.IdAuta, izabranaRezervacija.DatumRezOd, izabranaRezervacija.DatumRezDo, cenaPoDanu);

                    listaPonuda.Add(p);

                    Administrator.SerijalizuPonude(listaPonuda);
                    Administrator.SerijalizuRezervacije(listaRezervacija);

                    listaRezervacija = Administrator.DeserijalizujRezervacije();
                    listaPonuda = Administrator.DeserijalizujPonude();

                    lbListaRezervacija.Items.Clear();
                    foreach (Rezervacija r in listaRezervacija) {
                        if (r.IdKupca == idUlogovanog) {
                            if (!lbListaRezervacija.Items.Contains(r))
                            {
                                lbListaRezervacija.Items.Add(r);
                            }
                        }
                    }

                    MessageBox.Show("Rezervacija otkazana.");
                }
                else if (dr == DialogResult.No) {
                    MessageBox.Show("Rezervacija nije otkazana.");
                }

            }

        }
    }
}
