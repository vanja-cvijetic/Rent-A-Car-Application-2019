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
    public partial class frmAzurirajPonudu : Form
    {
        private List<Ponuda> listaPonuda;
        public frmAzurirajPonudu()
        {
            InitializeComponent();
            listaPonuda = new List<Ponuda>();
        }

        private void frmAzurirajPonudu_Load(object sender, EventArgs e)
        {
            listaPonuda = Administrator.DeserijalizujPonude();

            foreach(Ponuda p in listaPonuda)
            {
                if (!cbPonude.Items.Contains(p))
                {
                    cbPonude.Items.Add(p);
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

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Ponuda stara = (Ponuda)cbPonude.SelectedItem;

            int novaCenaPoDanu = 0;

            if (!string.IsNullOrEmpty(txtCena.Text))
            {
                char[] niz = txtCena.Text.ToCharArray();
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
                    MessageBox.Show("Cenu unesite brojevima, ne slovima!");
                    return;
                }
                else
                {
                    novaCenaPoDanu = int.Parse(txtCena.Text);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli cenu po danu!");
                return;
            }

            DateTime noviSelektovaniDatumOd;
            DateTime noviSelektovaniDatumDo;

            int provera = dateOd.Value.Date.CompareTo(DateTime.Now.Date);

            if (provera < 0) // ako je selektovaniDatumOD ranije od današnjeg dana
            {
                MessageBox.Show("Ne možete izabrati datum koji je već prošao!");
                return;
            }
            else
            {
                noviSelektovaniDatumOd = dateOd.Value;
            }

            provera = dateDo.Value.Date.CompareTo(noviSelektovaniDatumOd.Date);
            if (provera < 0) // ako je selektovani datum DO ranije od datuma OD
            {
                MessageBox.Show("Datum do kojeg traje ponuda mora biti posle datuma od kada ponuda počinje!");
                return;
            }
            else
            {
                noviSelektovaniDatumDo = dateDo.Value;
            }

            Ponuda azurirana = new Ponuda(stara.IdAuta, noviSelektovaniDatumOd, noviSelektovaniDatumDo, novaCenaPoDanu);

            listaPonuda.Remove(stara); // obriši staru (zbog provere vremena)

            int brojac = 0;
            int brojPonuda = 0;

            foreach (Ponuda p in listaPonuda)
            {
                if (stara.IdAuta == p.IdAuta) // ako za auto postoje ponude
                {
                    int proveri1 = azurirana.DatumOd.Date.CompareTo(p.DatumOd.Date);
                    int proveri2 = azurirana.DatumDo.Date.CompareTo(p.DatumDo.Date);
                    int proveri3 = azurirana.DatumOd.Date.CompareTo(p.DatumDo.Date);
                    int proveri4 = azurirana.DatumDo.Date.CompareTo(p.DatumOd.Date);

                    // da li nova ponuda ne preklapa termin ponude iz liste
                    if ((proveri1 < 0 && proveri2 < 0 && proveri3 < 0 && proveri4 < 0)
                        || (proveri1 > 0 && proveri2 > 0 && proveri3 > 0 && proveri4 > 0))
                    {
                        brojac++;
                    }
                    brojPonuda++;
                }
            }

            if (brojac != brojPonuda)
            {
                listaPonuda.Add(stara);
                Administrator.SerijalizuPonude(listaPonuda);
                MessageBox.Show("Vremenski period nove ponude je već sadržan u nekoj od postojećih ponuda!");
                return;
            }
            else {
                listaPonuda.Add(azurirana);
                Administrator.SerijalizuPonude(listaPonuda);
                MessageBox.Show("Uspešno izmenjena ponuda!");

                cbPonude.Items.Clear();
                cbPonude.Text = "";
                listaPonuda = Administrator.DeserijalizujPonude();

                foreach (Ponuda pon in listaPonuda)
                {
                    if (!cbPonude.Items.Contains(pon.ToString()))
                    {
                        cbPonude.Items.Add(pon);
                    }
                }
            }
        }

        private void cbPonude_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)cbPonude.SelectedItem;

            List<Automobil> auti = Administrator.DeserijalizujAute();
            Automobil auto = null;

            foreach(Automobil a in auti)
            {
                if (ponuda.IdAuta == a.IdAutomobila) {
                    auto = a;
                }
            }

            txtAuto.Text = auto.ispis();
            txtAuto.ReadOnly = true;

            dateOd.Value = ponuda.DatumOd;
            dateDo.Value = ponuda.DatumDo;

            txtCena.Text = ponuda.CenaPoDanu.ToString();
        }
    }
}
