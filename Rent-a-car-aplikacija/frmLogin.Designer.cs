namespace Rent_a_car_aplikacija
{
    partial class frmLogin
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
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDodatniTekst = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(172, 33);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(217, 48);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Rent-a-car";
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(212, 81);
            this.lblDobrodosli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(141, 29);
            this.lblDobrodosli.TabIndex = 1;
            this.lblDobrodosli.Text = "Dobrodošli!";
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.cbAdmin);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.btnPrijaviSe);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblUsername);
            this.gbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(45, 142);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(4);
            this.gbLogin.Size = new System.Drawing.Size(472, 255);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Prijavljivanje";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmin.Location = new System.Drawing.Point(173, 27);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(135, 28);
            this.cbAdmin.TabIndex = 5;
            this.cbAdmin.Text = "Administator";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(173, 123);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(279, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(173, 71);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(279, 30);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.Location = new System.Drawing.Point(196, 185);
            this.btnPrijaviSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(227, 47);
            this.btnPrijaviSe.TabIndex = 2;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(75, 130);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Lozinka:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(13, 79);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblDodatniTekst
            // 
            this.lblDodatniTekst.AutoSize = true;
            this.lblDodatniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodatniTekst.Location = new System.Drawing.Point(84, 430);
            this.lblDodatniTekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDodatniTekst.Name = "lblDodatniTekst";
            this.lblDodatniTekst.Size = new System.Drawing.Size(138, 24);
            this.lblDodatniTekst.TabIndex = 3;
            this.lblDodatniTekst.Text = "Nemate nalog?";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracija.Location = new System.Drawing.Point(236, 427);
            this.lblRegistracija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(243, 25);
            this.lblRegistracija.TabIndex = 4;
            this.lblRegistracija.TabStop = true;
            this.lblRegistracija.Text = "Registrujte se klikom ovde!";
            this.lblRegistracija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistracija_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(465, 495);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(571, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.lblDodatniTekst);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.lblNaslov);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDodatniTekst;
        private System.Windows.Forms.LinkLabel lblRegistracija;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Button btnExit;
    }
}

