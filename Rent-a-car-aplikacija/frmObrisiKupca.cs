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
    public partial class frmObrisiKupca : Form
    {
        List<Kupac> listaNaloga = new List<Kupac>();
        public frmObrisiKupca()
        {
            InitializeComponent();
        }

        private void frmObrisiKupca_Load(object sender, EventArgs e)
        {
            listaNaloga = Administrator.DeserijalizujKupce();

            foreach (Kupac kupac in listaNaloga) {
                if (!lbLista.Items.Contains(kupac)) {
                    lbLista.Items.Add(kupac);
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
            if (lbLista.SelectedItem != null)
            {
                
                Kupac temp = lbLista.SelectedItem as Kupac;
               
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrištete nalog pod korisničkim imenom " + temp.Username + "?", "Obriši", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    listaNaloga.Remove(temp);
                    Administrator.SerijalizujKupce(listaNaloga);
                    MessageBox.Show("Uspešno ste obrisali nalog pod korisničkim imenom: " + temp.Username);

                    List<Rezervacija> listaR = Administrator.DeserijalizujRezervacije();
                    List<Ponuda> listaP = Administrator.DeserijalizujPonude();

                    List<Rezervacija> listaZaBrisanjeR = new List<Rezervacija>();

                    foreach (Rezervacija r in listaR)
                    {
                        if (r.IdKupca == temp.IdKupca)
                        {
                            listaZaBrisanjeR.Add(r);
                        }
                    }

                    if (listaZaBrisanjeR.Count > 0)
                    {
                        foreach (Rezervacija rez in listaZaBrisanjeR)
                        {
                            listaR.Remove(rez);
                        }
                    }

                    Administrator.SerijalizuRezervacije(listaR);

                    lbLista.ClearSelected();
                    lbLista.Items.Clear();

                    foreach (Kupac kupac in listaNaloga)
                    {
                        if (!lbLista.Items.Contains(kupac))
                        {
                            lbLista.Items.Add(kupac.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nalog nije obrisan.");
                }
            }
            else {
                MessageBox.Show("Niste izabrali nijedan nalog!");
            }
        }

    }
}

