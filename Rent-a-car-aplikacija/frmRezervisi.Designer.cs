namespace Rent_a_car_aplikacija
{
    partial class frmRezervisi
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.cbKubikaza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGorivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPogon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKaroserija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMenjac = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBrVrata = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGodiste = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.listBoxPonude = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datePreuzimanje = new System.Windows.Forms.DateTimePicker();
            this.dateVracanje = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(263, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(257, 29);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Rezervišite automobil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite marku:";
            // 
            // cbMarka
            // 
            this.cbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(21, 85);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(191, 30);
            this.cbMarka.TabIndex = 3;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // cbKubikaza
            // 
            this.cbKubikaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKubikaza.FormattingEnabled = true;
            this.cbKubikaza.Location = new System.Drawing.Point(293, 85);
            this.cbKubikaza.Name = "cbKubikaza";
            this.cbKubikaza.Size = new System.Drawing.Size(191, 30);
            this.cbKubikaza.TabIndex = 5;
            this.cbKubikaza.SelectedIndexChanged += new System.EventHandler(this.cbKubikaza_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberite kubikažu:";
            // 
            // cbGorivo
            // 
            this.cbGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGorivo.FormattingEnabled = true;
            this.cbGorivo.Location = new System.Drawing.Point(562, 85);
            this.cbGorivo.Name = "cbGorivo";
            this.cbGorivo.Size = new System.Drawing.Size(191, 30);
            this.cbGorivo.TabIndex = 7;
            this.cbGorivo.SelectedIndexChanged += new System.EventHandler(this.cbGorivo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odaberite gorivo:";
            // 
            // cbPogon
            // 
            this.cbPogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPogon.FormattingEnabled = true;
            this.cbPogon.Location = new System.Drawing.Point(562, 163);
            this.cbPogon.Name = "cbPogon";
            this.cbPogon.Size = new System.Drawing.Size(191, 30);
            this.cbPogon.TabIndex = 13;
            this.cbPogon.SelectedIndexChanged += new System.EventHandler(this.cbPogon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Odaberite pogon:";
            // 
            // cbKaroserija
            // 
            this.cbKaroserija.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKaroserija.FormattingEnabled = true;
            this.cbKaroserija.Location = new System.Drawing.Point(293, 163);
            this.cbKaroserija.Name = "cbKaroserija";
            this.cbKaroserija.Size = new System.Drawing.Size(191, 30);
            this.cbKaroserija.TabIndex = 11;
            this.cbKaroserija.SelectedIndexChanged += new System.EventHandler(this.cbKaroserija_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Odaberite karoseriju:";
            // 
            // cbModel
            // 
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(21, 163);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(191, 30);
            this.cbModel.TabIndex = 9;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Odaberite model:";
            // 
            // cbMenjac
            // 
            this.cbMenjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenjac.FormattingEnabled = true;
            this.cbMenjac.Location = new System.Drawing.Point(563, 241);
            this.cbMenjac.Name = "cbMenjac";
            this.cbMenjac.Size = new System.Drawing.Size(191, 30);
            this.cbMenjac.TabIndex = 19;
            this.cbMenjac.SelectedIndexChanged += new System.EventHandler(this.cbMenjac_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(558, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Odaberite menjač:";
            // 
            // cbBrVrata
            // 
            this.cbBrVrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrVrata.FormattingEnabled = true;
            this.cbBrVrata.Location = new System.Drawing.Point(294, 241);
            this.cbBrVrata.Name = "cbBrVrata";
            this.cbBrVrata.Size = new System.Drawing.Size(191, 30);
            this.cbBrVrata.TabIndex = 17;
            this.cbBrVrata.SelectedIndexChanged += new System.EventHandler(this.cbBrVrata_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Odaberite broj vrata:";
            // 
            // cbGodiste
            // 
            this.cbGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGodiste.FormattingEnabled = true;
            this.cbGodiste.Location = new System.Drawing.Point(22, 241);
            this.cbGodiste.Name = "cbGodiste";
            this.cbGodiste.Size = new System.Drawing.Size(191, 30);
            this.cbGodiste.TabIndex = 15;
            this.cbGodiste.SelectedIndexChanged += new System.EventHandler(this.cbGodiste_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Odaberite godište:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(20, 295);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(732, 56);
            this.btnPrikazi.TabIndex = 20;
            this.btnPrikazi.Text = "Prikaži dostupne termine odabranog automobila:";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // listBoxPonude
            // 
            this.listBoxPonude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPonude.FormattingEnabled = true;
            this.listBoxPonude.ItemHeight = 25;
            this.listBoxPonude.Location = new System.Drawing.Point(20, 370);
            this.listBoxPonude.Name = "listBoxPonude";
            this.listBoxPonude.Size = new System.Drawing.Size(732, 154);
            this.listBoxPonude.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Odaberite datum preuzimanja:";
            // 
            // datePreuzimanje
            // 
            this.datePreuzimanje.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePreuzimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePreuzimanje.Location = new System.Drawing.Point(30, 561);
            this.datePreuzimanje.Name = "datePreuzimanje";
            this.datePreuzimanje.Size = new System.Drawing.Size(310, 26);
            this.datePreuzimanje.TabIndex = 23;
            this.datePreuzimanje.ValueChanged += new System.EventHandler(this.datePreuzimanje_ValueChanged);
            // 
            // dateVracanje
            // 
            this.dateVracanje.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVracanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVracanje.Location = new System.Drawing.Point(30, 635);
            this.dateVracanje.Name = "dateVracanje";
            this.dateVracanje.Size = new System.Drawing.Size(310, 26);
            this.dateVracanje.TabIndex = 24;
            this.dateVracanje.ValueChanged += new System.EventHandler(this.dateVracanje_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 607);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Odaberite datum vraćanja:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(550, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 50);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ukupna cena\r\nrezervacije:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupnaCena.Location = new System.Drawing.Point(555, 603);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(197, 32);
            this.txtUkupnaCena.TabIndex = 27;
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(22, 681);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(732, 56);
            this.btnRezervisi.TabIndex = 28;
            this.btnRezervisi.Text = "Rezerviši";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // frmRezervisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(776, 764);
            this.ControlBox = false;
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateVracanje);
            this.Controls.Add(this.datePreuzimanje);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxPonude);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cbMenjac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBrVrata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbGodiste);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPogon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKaroserija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGorivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKubikaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Name = "frmRezervisi";
            this.Text = "Rezerviši";
            this.Load += new System.EventHandler(this.frmRezervisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbKubikaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGorivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPogon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKaroserija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMenjac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBrVrata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGodiste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ListBox listBoxPonude;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datePreuzimanje;
        private System.Windows.Forms.DateTimePicker dateVracanje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Button btnRezervisi;
    }
}