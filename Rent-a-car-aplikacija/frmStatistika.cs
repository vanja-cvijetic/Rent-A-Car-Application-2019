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
    public partial class frmStatistika : Form
    {
        List<Rezervacija> listaRezervacija;
        List<Automobil> listaAutomobila;
        public frmStatistika()
        {
            InitializeComponent();
            listaRezervacija = new List<Rezervacija>();
            listaAutomobila = new List<Automobil>();

        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            listaRezervacija = Administrator.DeserijalizujRezervacije();
            listaAutomobila = Administrator.DeserijalizujAute();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbMeseci.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali mesec!");
            }
            else {
                int mesec = cbMeseci.SelectedIndex + 1;
                nacrtajGrafik(mesec);
            }
        }

        public void nacrtajGrafik(int mesec)
        {
            Graphics graphics = panelCrtanje.CreateGraphics();
            // panel je površina za crtanje

            List<float> sweepAngles = new List<float>();
            List <float> startAngles = new List<float>();
            List<float> procenti = new List<float>();
            startAngles.Add(-90); // početni ugao crtanja

            float brojRezZaAuto = 0;
            float ukupanBrRezUMesecu = 0;

            foreach(Rezervacija rez in listaRezervacija)
            {
                if (rez.DatumRezOd.Month == mesec)
                {
                    ukupanBrRezUMesecu++;
                }
            }

            List<Label> lblZaBrisanje = new List<Label>();

            if (ukupanBrRezUMesecu == 0) {

                MessageBox.Show("U izabranom mesecu nema rezervacija.");
                panelCrtanje.Invalidate();

                foreach (Control ctr in this.Controls)
                {
                    if(ctr is Label)
                    {
                        lblZaBrisanje.Add((Label)ctr);
                    }
                }

                if(lblZaBrisanje.Count > 0) { 
                    foreach(Label l in lblZaBrisanje)
                    {
                        this.Controls.Remove(l);
                    }
                }

                return;
            }

            foreach (Automobil auto in listaAutomobila)
            {
                foreach (Rezervacija rezervacija in listaRezervacija)
                { // izbrojati koliko koji auto ima rezervacija
                    if (rezervacija.DatumRezOd.Month == mesec)
                    {
                        if (rezervacija.IdAuta == auto.IdAutomobila)
                        {
                            brojRezZaAuto++;
                        }
                    }
                }

                float ugao = (brojRezZaAuto / ukupanBrRezUMesecu) * 360;
                float procenat = (brojRezZaAuto / ukupanBrRezUMesecu) * 100;

                sweepAngles.Add(ugao);
                procenti.Add(procenat);

                brojRezZaAuto = 0;              
            }

           // dodavanje početnih uglova
            for(int i=0; i<sweepAngles.Count; i++)
            {
                startAngles.Add(startAngles[i]+sweepAngles[i]);
            }

            foreach (Control ctr in this.Controls)
            {
                if (ctr is Label)
                {
                    lblZaBrisanje.Add((Label)ctr);
                }
            }

            if (lblZaBrisanje.Count > 0)
            {
                foreach (Label l in lblZaBrisanje)
                {
                    this.Controls.Remove(l);
                }
            }

            Random rnd = new Random();
            Rectangle rec = new Rectangle((panelCrtanje.Width / 2) - 100, (panelCrtanje.Height / 2) - 100, 200, 200);
            graphics.FillEllipse(Brushes.Blue, rec);
            List<Color> listaBoja = new List<Color>();
            int top = 200;
            int left = 36;
            int j = 0;
            int k = 0;
            
            for (int i = 0; i < sweepAngles.Count; i++) { 
                int r, g, b;
                r = rnd.Next(0, 256);
                g = rnd.Next(0, 256);
                b = rnd.Next(0, 256);
                Color boja = Color.FromArgb(r, g, b);
                SolidBrush brush = new SolidBrush(boja);
                graphics.FillPie(brush, rec, startAngles[i], sweepAngles[i]);
                listaBoja.Add(boja);

                Label labela = new Label();
                labela.Top = top;
                labela.Left = left;
                labela.BackColor = listaBoja[j++];
                labela.Text = listaAutomobila[i].Marka + " " + listaAutomobila[i].Model + " - " + procenti[k++].ToString("0.00") + "%";
                labela.TextAlign = ContentAlignment.MiddleCenter;
                labela.Font = new Font("Arial", 10, FontStyle.Bold);
                labela.Width = 210;
                labela.Name = "label" + i;
                this.Controls.Add(labela);
                top += 25;

            }      

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdministrator frm = new frmAdministrator();
            Hide();
            frm.ShowDialog();
            Close();
        }
    }
}
