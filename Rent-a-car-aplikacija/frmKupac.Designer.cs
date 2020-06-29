namespace Rent_a_car_aplikacija
{
    partial class frmKupac
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vašeRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vašeRezervacijeToolStripMenuItem,
            this.rezervišiToolStripMenuItem,
            this.nalogToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(776, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vašeRezervacijeToolStripMenuItem
            // 
            this.vašeRezervacijeToolStripMenuItem.Name = "vašeRezervacijeToolStripMenuItem";
            this.vašeRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.vašeRezervacijeToolStripMenuItem.Text = "Vaše rezervacije";
            this.vašeRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.vašeRezervacijeToolStripMenuItem_Click);
            // 
            // rezervišiToolStripMenuItem
            // 
            this.rezervišiToolStripMenuItem.Name = "rezervišiToolStripMenuItem";
            this.rezervišiToolStripMenuItem.Size = new System.Drawing.Size(99, 32);
            this.rezervišiToolStripMenuItem.Text = "Rezerviši";
            this.rezervišiToolStripMenuItem.Click += new System.EventHandler(this.rezervišiToolStripMenuItem_Click);
            // 
            // nalogToolStripMenuItem
            // 
            this.nalogToolStripMenuItem.Name = "nalogToolStripMenuItem";
            this.nalogToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.nalogToolStripMenuItem.Text = "Nalog";
            this.nalogToolStripMenuItem.Click += new System.EventHandler(this.nalogToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // frmKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(776, 764);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKupac";
            this.Text = "Rent-a-car";
            this.Load += new System.EventHandler(this.frmKupac_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vašeRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
    }
}