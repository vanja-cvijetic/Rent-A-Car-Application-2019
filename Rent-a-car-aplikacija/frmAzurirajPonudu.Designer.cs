namespace Rent_a_car_aplikacija
{
    partial class frmAzurirajPonudu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.dateOd = new System.Windows.Forms.DateTimePicker();
            this.dateDo = new System.Windows.Forms.DateTimePicker();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.cbPonude = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automobil:";
            // 
            // txtAuto
            // 
            this.txtAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuto.Location = new System.Drawing.Point(90, 151);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.ReadOnly = true;
            this.txtAuto.Size = new System.Drawing.Size(333, 30);
            this.txtAuto.TabIndex = 1;
            // 
            // dateOd
            // 
            this.dateOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOd.Location = new System.Drawing.Point(90, 217);
            this.dateOd.Name = "dateOd";
            this.dateOd.Size = new System.Drawing.Size(333, 30);
            this.dateOd.TabIndex = 2;
            // 
            // dateDo
            // 
            this.dateDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDo.Location = new System.Drawing.Point(90, 287);
            this.dateDo.Name = "dateDo";
            this.dateDo.Size = new System.Drawing.Size(333, 30);
            this.dateDo.TabIndex = 3;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(90, 357);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(333, 30);
            this.txtCena.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena po danu (din):";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(158, 413);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(177, 42);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // cbPonude
            // 
            this.cbPonude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPonude.FormattingEnabled = true;
            this.cbPonude.Location = new System.Drawing.Point(90, 73);
            this.cbPonude.Name = "cbPonude";
            this.cbPonude.Size = new System.Drawing.Size(333, 33);
            this.cbPonude.Sorted = true;
            this.cbPonude.TabIndex = 9;
            this.cbPonude.SelectedIndexChanged += new System.EventHandler(this.cbPonude_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izaberite ponudu za ažuriranje:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(396, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 45);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAzurirajPonudu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPonude);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.dateDo);
            this.Controls.Add(this.dateOd);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.label1);
            this.Name = "frmAzurirajPonudu";
            this.Text = "Ažuriranje ponude";
            this.Load += new System.EventHandler(this.frmAzurirajPonudu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.DateTimePicker dateOd;
        private System.Windows.Forms.DateTimePicker dateDo;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.ComboBox cbPonude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
    }
}