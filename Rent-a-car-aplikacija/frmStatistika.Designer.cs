namespace Rent_a_car_aplikacija
{
    partial class frmStatistika
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMeseci = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCrtanje = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMeseci);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberite mesec";
            // 
            // cbMeseci
            // 
            this.cbMeseci.FormattingEnabled = true;
            this.cbMeseci.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.cbMeseci.Location = new System.Drawing.Point(32, 58);
            this.cbMeseci.Name = "cbMeseci";
            this.cbMeseci.Size = new System.Drawing.Size(238, 33);
            this.cbMeseci.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Prikaži stastistiku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCrtanje
            // 
            this.panelCrtanje.Location = new System.Drawing.Point(410, 30);
            this.panelCrtanje.Name = "panelCrtanje";
            this.panelCrtanje.Size = new System.Drawing.Size(503, 452);
            this.panelCrtanje.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(782, 516);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelCrtanje);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCrtanje;
        private System.Windows.Forms.ComboBox cbMeseci;
        private System.Windows.Forms.Button btnBack;
    }
}