namespace Zlatno_Burence
{
    partial class Nabavka
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
            this.nabavkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabavkaToolStripMenuItem,
            this.prodajaToolStripMenuItem,
            this.zaposleniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nabavkaToolStripMenuItem
            // 
            this.nabavkaToolStripMenuItem.Name = "nabavkaToolStripMenuItem";
            this.nabavkaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.nabavkaToolStripMenuItem.Text = "Nabavka";
            // 
            // prodajaToolStripMenuItem
            // 
            this.prodajaToolStripMenuItem.Name = "prodajaToolStripMenuItem";
            this.prodajaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.prodajaToolStripMenuItem.Text = "Prodaja";
            this.prodajaToolStripMenuItem.Click += new System.EventHandler(this.prodajaToolStripMenuItem_Click);
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            this.zaposleniToolStripMenuItem.Click += new System.EventHandler(this.zaposleniToolStripMenuItem_Click);
            // 
            // Nabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Nabavka";
            this.Text = "Nabavka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nabavkaToolStripMenuItem;
        private ToolStripMenuItem prodajaToolStripMenuItem;
        private ToolStripMenuItem zaposleniToolStripMenuItem;
    }
}