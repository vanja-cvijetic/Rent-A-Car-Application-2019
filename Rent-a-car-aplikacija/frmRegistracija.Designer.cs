namespace Rent_a_car_aplikacija
{
    partial class frmRegistracija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSifra = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDatumRodj = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(219, 25);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(230, 46);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Registracija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Molimo popunite podatke";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSifra);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblLozinka);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblDatumRodj);
            this.groupBox1.Controls.Add(this.dtpDatumRodjenja);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.txtJmbg);
            this.groupBox1.Controls.Add(this.lblJmbg);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(581, 530);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otvaranje novog naloga";
            // 
            // cbSifra
            // 
            this.cbSifra.AutoSize = true;
            this.cbSifra.Location = new System.Drawing.Point(299, 402);
            this.cbSifra.Margin = new System.Windows.Forms.Padding(4);
            this.cbSifra.Name = "cbSifra";
            this.cbSifra.Size = new System.Drawing.Size(120, 24);
            this.cbSifra.TabIndex = 15;
            this.cbSifra.Text = "Prikaži šifru";
            this.cbSifra.UseVisualStyleBackColor = true;
            this.cbSifra.CheckedChanged += new System.EventHandler(this.cbSifra_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(176, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Otvori nalog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(299, 362);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(272, 30);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(8, 362);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(272, 30);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.Location = new System.Drawing.Point(293, 334);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(86, 25);
            this.lblLozinka.TabIndex = 11;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 334);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 25);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblDatumRodj
            // 
            this.lblDatumRodj.AutoSize = true;
            this.lblDatumRodj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodj.Location = new System.Drawing.Point(215, 249);
            this.lblDatumRodj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumRodj.Name = "lblDatumRodj";
            this.lblDatumRodj.Size = new System.Drawing.Size(145, 25);
            this.lblDatumRodj.TabIndex = 9;
            this.lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(164, 277);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumRodjenja.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(265, 30);
            this.dtpDatumRodjenja.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(299, 172);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(272, 30);
            this.txtTelefon.TabIndex = 7;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(293, 119);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(163, 50);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Broj telefona: \r\n(npr. 062111333)\r\n";
            // 
            // txtJmbg
            // 
            this.txtJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJmbg.Location = new System.Drawing.Point(8, 172);
            this.txtJmbg.Margin = new System.Windows.Forms.Padding(4);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.Size = new System.Drawing.Size(272, 30);
            this.txtJmbg.TabIndex = 5;
            this.txtJmbg.TextChanged += new System.EventHandler(this.txtJmbg_TextChanged);
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmbg.Location = new System.Drawing.Point(3, 144);
            this.lblJmbg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(67, 25);
            this.lblJmbg.TabIndex = 4;
            this.lblJmbg.Text = "Jmbg:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(299, 74);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(272, 30);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(8, 74);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(272, 30);
            this.txtIme.TabIndex = 2;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(293, 46);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(89, 25);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(3, 46);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(50, 25);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(503, 679);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Povratak";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 731);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistracija";
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDatumRodj;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbSifra;
    }
}