namespace Rent_a_car_aplikacija
{
    partial class frmAdminRezervacije
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
            this.cbKupci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.cbRezervacijeZaBrisanje = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajRez = new System.Windows.Forms.Button();
            this.txtCenaPoDanuDodavanje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateVracanjeDodavanje = new System.Windows.Forms.DateTimePicker();
            this.datePreuzimanjeDodavanje = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAutomobili = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAutoAzuiraranje = new System.Windows.Forms.TextBox();
            this.txtNovaUkupnaCenaAzuiranje = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtCenaPoDanuAzuriranje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRezervacijeZaAzuriranje = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateVracanjeAzuriranje = new System.Windows.Forms.DateTimePicker();
            this.datePreuzimanjeAzuriranje = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKupci
            // 
            this.cbKupci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKupci.FormattingEnabled = true;
            this.cbKupci.Location = new System.Drawing.Point(37, 93);
            this.cbKupci.Name = "cbKupci";
            this.cbKupci.Size = new System.Drawing.Size(1028, 33);
            this.cbKupci.TabIndex = 0;
            this.cbKupci.SelectedIndexChanged += new System.EventHandler(this.cbKupci_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite kupca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rezervacije";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOtkazi);
            this.groupBox1.Controls.Add(this.cbRezervacijeZaBrisanje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otkazivanje";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(11, 149);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(581, 49);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži rezervaciju";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // cbRezervacijeZaBrisanje
            // 
            this.cbRezervacijeZaBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRezervacijeZaBrisanje.FormattingEnabled = true;
            this.cbRezervacijeZaBrisanje.Location = new System.Drawing.Point(11, 85);
            this.cbRezervacijeZaBrisanje.Name = "cbRezervacijeZaBrisanje";
            this.cbRezervacijeZaBrisanje.Size = new System.Drawing.Size(581, 33);
            this.cbRezervacijeZaBrisanje.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Izaberite rezervaciju koju želite da otkažete:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajRez);
            this.groupBox2.Controls.Add(this.txtCenaPoDanuDodavanje);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateVracanjeDodavanje);
            this.groupBox2.Controls.Add(this.datePreuzimanjeDodavanje);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbAutomobili);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(668, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 290);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje rezervacije";
            // 
            // btnDodajRez
            // 
            this.btnDodajRez.Location = new System.Drawing.Point(69, 210);
            this.btnDodajRez.Name = "btnDodajRez";
            this.btnDodajRez.Size = new System.Drawing.Size(248, 48);
            this.btnDodajRez.TabIndex = 13;
            this.btnDodajRez.Text = "Rezerviši";
            this.btnDodajRez.UseVisualStyleBackColor = true;
            this.btnDodajRez.Click += new System.EventHandler(this.btnDodajRez_Click);
            // 
            // txtCenaPoDanuDodavanje
            // 
            this.txtCenaPoDanuDodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenaPoDanuDodavanje.Location = new System.Drawing.Point(18, 149);
            this.txtCenaPoDanuDodavanje.Name = "txtCenaPoDanuDodavanje";
            this.txtCenaPoDanuDodavanje.Size = new System.Drawing.Size(137, 28);
            this.txtCenaPoDanuDodavanje.TabIndex = 12;
            this.txtCenaPoDanuDodavanje.TabStop = false;
            this.txtCenaPoDanuDodavanje.TextChanged += new System.EventHandler(this.txtCenaPoDanuDodavanje_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Preuzimanje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vraćanje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cena po danu:";
            // 
            // dateVracanjeDodavanje
            // 
            this.dateVracanjeDodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVracanjeDodavanje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVracanjeDodavanje.Location = new System.Drawing.Point(226, 149);
            this.dateVracanjeDodavanje.Name = "dateVracanjeDodavanje";
            this.dateVracanjeDodavanje.Size = new System.Drawing.Size(137, 28);
            this.dateVracanjeDodavanje.TabIndex = 7;
            // 
            // datePreuzimanjeDodavanje
            // 
            this.datePreuzimanjeDodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePreuzimanjeDodavanje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePreuzimanjeDodavanje.Location = new System.Drawing.Point(226, 75);
            this.datePreuzimanjeDodavanje.Name = "datePreuzimanjeDodavanje";
            this.datePreuzimanjeDodavanje.Size = new System.Drawing.Size(137, 28);
            this.datePreuzimanjeDodavanje.TabIndex = 6;
            this.datePreuzimanjeDodavanje.ValueChanged += new System.EventHandler(this.datePreuzimanjeDodavanje_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Automobil:";
            // 
            // cbAutomobili
            // 
            this.cbAutomobili.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutomobili.FormattingEnabled = true;
            this.cbAutomobili.Location = new System.Drawing.Point(18, 73);
            this.cbAutomobili.Name = "cbAutomobili";
            this.cbAutomobili.Size = new System.Drawing.Size(137, 30);
            this.cbAutomobili.Sorted = true;
            this.cbAutomobili.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtAutoAzuiraranje);
            this.groupBox3.Controls.Add(this.txtNovaUkupnaCenaAzuiranje);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnAzuriraj);
            this.groupBox3.Controls.Add(this.txtCenaPoDanuAzuriranje);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbRezervacijeZaAzuriranje);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dateVracanjeAzuriranje);
            this.groupBox3.Controls.Add(this.datePreuzimanjeAzuriranje);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 273);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ažuiranje";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(524, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "RSD";
            // 
            // txtAutoAzuiraranje
            // 
            this.txtAutoAzuiraranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoAzuiraranje.Location = new System.Drawing.Point(11, 148);
            this.txtAutoAzuiraranje.Name = "txtAutoAzuiraranje";
            this.txtAutoAzuiraranje.ReadOnly = true;
            this.txtAutoAzuiraranje.Size = new System.Drawing.Size(137, 28);
            this.txtAutoAzuiraranje.TabIndex = 24;
            this.txtAutoAzuiraranje.TabStop = false;
            // 
            // txtNovaUkupnaCenaAzuiranje
            // 
            this.txtNovaUkupnaCenaAzuiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaUkupnaCenaAzuiranje.Location = new System.Drawing.Point(384, 152);
            this.txtNovaUkupnaCenaAzuiranje.Name = "txtNovaUkupnaCenaAzuiranje";
            this.txtNovaUkupnaCenaAzuiranje.ReadOnly = true;
            this.txtNovaUkupnaCenaAzuiranje.Size = new System.Drawing.Size(137, 28);
            this.txtNovaUkupnaCenaAzuiranje.TabIndex = 23;
            this.txtNovaUkupnaCenaAzuiranje.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(379, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Nova ukupna cena:";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(384, 217);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(193, 48);
            this.btnAzuriraj.TabIndex = 14;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txtCenaPoDanuAzuriranje
            // 
            this.txtCenaPoDanuAzuriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenaPoDanuAzuriranje.Location = new System.Drawing.Point(11, 226);
            this.txtCenaPoDanuAzuriranje.Name = "txtCenaPoDanuAzuriranje";
            this.txtCenaPoDanuAzuriranje.Size = new System.Drawing.Size(137, 28);
            this.txtCenaPoDanuAzuriranje.TabIndex = 21;
            this.txtCenaPoDanuAzuriranje.TabStop = false;
            this.txtCenaPoDanuAzuriranje.TextChanged += new System.EventHandler(this.txtCenaPoDanuAzuriranje_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Izaberite rezervaciju koju želite da ažurirate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Preuzimanje:";
            // 
            // cbRezervacijeZaAzuriranje
            // 
            this.cbRezervacijeZaAzuriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRezervacijeZaAzuriranje.FormattingEnabled = true;
            this.cbRezervacijeZaAzuriranje.Location = new System.Drawing.Point(11, 67);
            this.cbRezervacijeZaAzuriranje.Name = "cbRezervacijeZaAzuriranje";
            this.cbRezervacijeZaAzuriranje.Size = new System.Drawing.Size(581, 33);
            this.cbRezervacijeZaAzuriranje.TabIndex = 6;
            this.cbRezervacijeZaAzuriranje.SelectedIndexChanged += new System.EventHandler(this.cbRezervacijeZaAzuriranje_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vraćanje:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Automobil:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cena po danu:";
            // 
            // dateVracanjeAzuriranje
            // 
            this.dateVracanjeAzuriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVracanjeAzuriranje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVracanjeAzuriranje.Location = new System.Drawing.Point(202, 226);
            this.dateVracanjeAzuriranje.Name = "dateVracanjeAzuriranje";
            this.dateVracanjeAzuriranje.Size = new System.Drawing.Size(137, 28);
            this.dateVracanjeAzuriranje.TabIndex = 17;
            this.dateVracanjeAzuriranje.ValueChanged += new System.EventHandler(this.dateVracanjeAzuriranje_ValueChanged);
            // 
            // datePreuzimanjeAzuriranje
            // 
            this.datePreuzimanjeAzuriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePreuzimanjeAzuriranje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePreuzimanjeAzuriranje.Location = new System.Drawing.Point(202, 148);
            this.datePreuzimanjeAzuriranje.Name = "datePreuzimanjeAzuriranje";
            this.datePreuzimanjeAzuriranje.Size = new System.Drawing.Size(137, 28);
            this.datePreuzimanjeAzuriranje.TabIndex = 16;
            this.datePreuzimanjeAzuriranje.ValueChanged += new System.EventHandler(this.datePreuzimanjeAzuriranje_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(949, 633);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 53);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAdminRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 698);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKupci);
            this.Name = "frmAdminRezervacije";
            this.Text = "Upravljaj rezervacijama";
            this.Load += new System.EventHandler(this.frmAdminRezervacije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKupci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ComboBox cbRezervacijeZaBrisanje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajRez;
        private System.Windows.Forms.TextBox txtCenaPoDanuDodavanje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateVracanjeDodavanje;
        private System.Windows.Forms.DateTimePicker datePreuzimanjeDodavanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAutomobili;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtCenaPoDanuAzuriranje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRezervacijeZaAzuriranje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateVracanjeAzuriranje;
        private System.Windows.Forms.DateTimePicker datePreuzimanjeAzuriranje;
        private System.Windows.Forms.TextBox txtAutoAzuiraranje;
        private System.Windows.Forms.TextBox txtNovaUkupnaCenaAzuiranje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label14;
    }
}