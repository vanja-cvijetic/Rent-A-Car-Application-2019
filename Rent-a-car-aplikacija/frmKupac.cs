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
    public partial class frmKupac : Form
    {
        public int idKupac = 0;
        public frmKupac()
        {
            InitializeComponent(); 
        }

        public int IdKupac { get { return idKupac; } set { idKupac = value; } }

        private void frmKupac_Load(object sender, EventArgs e)
        {
            frmVaseRezervacije frmRez = new frmVaseRezervacije(idKupac);
            frmRez.MdiParent = this;
            frmRez.Show();
        }

        private void vašeRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVaseRezervacije frmRez = new frmVaseRezervacije(idKupac);
            frmRez.MdiParent = this;
            frmRez.Show();
        } 

        private void rezervišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervisi frmRezervisi = new frmRezervisi(idKupac);
            frmRezervisi.MdiParent = this;           
            frmRezervisi.Show();           
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void nalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNalogKupca frm = new frmNalogKupca(idKupac);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
