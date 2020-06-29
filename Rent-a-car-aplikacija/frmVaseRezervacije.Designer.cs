namespace Rent_a_car_aplikacija
{
    partial class frmVaseRezervacije
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUlogovaniSte = new System.Windows.Forms.Label();
            this.lbListaRezervacija = new System.Windows.Forms.ListBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUlogovaniSte
            // 
            this.lblUlogovaniSte.AutoSize = true;
            this.lblUlogovaniSte.BackColor = System.Drawing.Color.Transparent;
            this.lblUlogovaniSte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlogovaniSte.Location = new System.Drawing.Point(20, 47);
            this.lblUlogovaniSte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUlogovaniSte.Name = "lblUlogovaniSte";
            this.lblUlogovaniSte.Size = new System.Drawing.Size(153, 22);
            this.lblUlogovaniSte.TabIndex = 0;
            this.lblUlogovaniSte.Text = "Ulogovani ste kao";
            // 
            // lbListaRezervacija
            // 
            this.lbListaRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaRezervacija.FormattingEnabled = true;
            this.lbListaRezervacija.ItemHeight = 20;
            this.lbListaRezervacija.Location = new System.Drawing.Point(21, 37);
            this.lbListaRezervacija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbListaRezervacija.Name = "lbListaRezervacija";
            this.lbListaRezervacija.Size = new System.Drawing.Size(498, 224);
            this.lbListaRezervacija.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(172, 285);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(232, 40);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši rezervaciju";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(196, 452);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(232, 40);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj novu rezervaciju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbListaRezervacija);
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(534, 346);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaše rezervacije";
            // 
            // frmVaseRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(582, 621);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblUlogovaniSte);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVaseRezervacije";
            this.Text = "Vaše rezervacije";
            this.Load += new System.EventHandler(this.frmVaseRezervacije_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUlogovaniSte;
        private System.Windows.Forms.ListBox lbListaRezervacija;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}