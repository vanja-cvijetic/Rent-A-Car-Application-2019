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
    public partial class frmObrisiAutomobil : Form
    {
        List<Automobil> lista;
        public frmObrisiAutomobil()
        {
            InitializeComponent();
        }

        private void frmObrisiAutomobil_Load(object sender, EventArgs e)
        {
            lista = Administrator.DeserijalizujAute();

            foreach (Automobil auto in lista)
            {
                if (!cbAutomobili.Items.Contains(auto))
                {
                    cbAutomobili.Items.Add(auto);
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (cbAutomobili.SelectedItem != null)
            {
                Automobil temp = null;
                foreach (Automobil auto in lista)
                {
                    if (auto.ToString().Equals(cbAutomobili.SelectedItem.ToString()))
                    {
                        temp = auto;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrištete automobil " + temp.ispis() + "?", "Obriši", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lista.Remove(temp);
                    Administrator.SerijalizujAute(lista);
                    MessageBox.Show("Uspešno ste obrisali automobil " + temp.ispis());

                    List<Rezervacija> listaR = Administrator.DeserijalizujRezervacije();
                    List<Ponuda> listaP = Administrator.DeserijalizujPonude();

                    List<Rezervacija> listaZaBrisanjeR = new List<Rezervacija>();
                    List<Ponuda> listaZaBrisanjeP = new List<Ponuda>();

                    foreach (Rezervacija r in listaR)
                    {
                        if (r.IdAuta == temp.IdAutomobila) {
                            listaZaBrisanjeR.Add(r);
                        }
                    }

                    if(listaZaBrisanjeR.Count > 0)
                    {
                        foreach (Rezervacija rez in listaZaBrisanjeR)
                        {
                            listaR.Remove(rez);
                        }
                    }
                        
                    foreach (Ponuda p in listaP)
                    {
                        if (p.IdAuta == temp.IdAutomobila)
                        {
                            listaZaBrisanjeP.Add(p);
                        }
                    }

                    if (listaZaBrisanjeP.Count > 0)
                    {
                        foreach (Ponuda pon in listaZaBrisanjeP)
                        {
                            listaP.Remove(pon);
                        }
                    }

                    Administrator.SerijalizuPonude(listaP);
                    Administrator.SerijalizuRezervacije(listaR);

                    cbAutomobili.Items.Clear();
                    cbAutomobili.Text = "";

                    foreach (Automobil auto in lista)
                    {
                        if (!cbAutomobili.Items.Contains(auto))
                        {
                            cbAutomobili.Items.Add(auto);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Automobil nije obrisan.");
                }

            }
            else {
                MessageBox.Show("Nijedan automobil nije izabran!");
            }
        }
    }
}
