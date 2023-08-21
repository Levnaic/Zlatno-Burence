namespace Zlatno_Burence
{
    partial class Magacin
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
            this.txtNaStanju = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAzurirajPice = new System.Windows.Forms.Button();
            this.btnObrisiPice = new System.Windows.Forms.Button();
            this.btnDodajPice = new System.Windows.Forms.Button();
            this.txtCenaPica = new System.Windows.Forms.TextBox();
            this.txtImePica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nabavkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pićaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magacinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMagacin = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaStanju
            // 
            this.txtNaStanju.Location = new System.Drawing.Point(118, 144);
            this.txtNaStanju.Name = "txtNaStanju";
            this.txtNaStanju.Size = new System.Drawing.Size(162, 23);
            this.txtNaStanju.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Na Stanju:";
            // 
            // btnAzurirajPice
            // 
            this.btnAzurirajPice.Location = new System.Drawing.Point(124, 245);
            this.btnAzurirajPice.Name = "btnAzurirajPice";
            this.btnAzurirajPice.Size = new System.Drawing.Size(75, 23);
            this.btnAzurirajPice.TabIndex = 28;
            this.btnAzurirajPice.Text = "Azuriraj";
            this.btnAzurirajPice.UseVisualStyleBackColor = true;
            this.btnAzurirajPice.Click += new System.EventHandler(this.btnAzurirajPice_Click);
            // 
            // btnObrisiPice
            // 
            this.btnObrisiPice.Location = new System.Drawing.Point(205, 245);
            this.btnObrisiPice.Name = "btnObrisiPice";
            this.btnObrisiPice.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiPice.TabIndex = 27;
            this.btnObrisiPice.Text = "Obriši";
            this.btnObrisiPice.UseVisualStyleBackColor = true;
            this.btnObrisiPice.Click += new System.EventHandler(this.btnObrisiPice_Click);
            // 
            // btnDodajPice
            // 
            this.btnDodajPice.Location = new System.Drawing.Point(138, 192);
            this.btnDodajPice.Name = "btnDodajPice";
            this.btnDodajPice.Size = new System.Drawing.Size(132, 23);
            this.btnDodajPice.TabIndex = 26;
            this.btnDodajPice.Text = "Dodaj Pice";
            this.btnDodajPice.UseVisualStyleBackColor = true;
            this.btnDodajPice.Click += new System.EventHandler(this.btnDodajPice_Click);
            // 
            // txtCenaPica
            // 
            this.txtCenaPica.Location = new System.Drawing.Point(118, 115);
            this.txtCenaPica.Name = "txtCenaPica";
            this.txtCenaPica.Size = new System.Drawing.Size(162, 23);
            this.txtCenaPica.TabIndex = 25;
            // 
            // txtImePica
            // 
            this.txtImePica.Location = new System.Drawing.Point(118, 86);
            this.txtImePica.Name = "txtImePica";
            this.txtImePica.Size = new System.Drawing.Size(162, 23);
            this.txtImePica.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cena Pica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ime Pica:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabavkaToolStripMenuItem,
            this.prodajaToolStripMenuItem,
            this.zaposleniToolStripMenuItem,
            this.pićaToolStripMenuItem,
            this.magacinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nabavkaToolStripMenuItem
            // 
            this.nabavkaToolStripMenuItem.Name = "nabavkaToolStripMenuItem";
            this.nabavkaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.nabavkaToolStripMenuItem.Text = "Nabavka";
            this.nabavkaToolStripMenuItem.Click += new System.EventHandler(this.nabavkaToolStripMenuItem_Click);
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
            // pićaToolStripMenuItem
            // 
            this.pićaToolStripMenuItem.Name = "pićaToolStripMenuItem";
            this.pićaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.pićaToolStripMenuItem.Text = "Pića";
            this.pićaToolStripMenuItem.Click += new System.EventHandler(this.pićaToolStripMenuItem_Click);
            // 
            // magacinToolStripMenuItem
            // 
            this.magacinToolStripMenuItem.Name = "magacinToolStripMenuItem";
            this.magacinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.magacinToolStripMenuItem.Text = "Magacin";
            // 
            // dgMagacin
            // 
            this.dgMagacin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMagacin.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgMagacin.Location = new System.Drawing.Point(373, 24);
            this.dgMagacin.Name = "dgMagacin";
            this.dgMagacin.RowTemplate.Height = 25;
            this.dgMagacin.Size = new System.Drawing.Size(427, 426);
            this.dgMagacin.TabIndex = 32;
            this.dgMagacin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMagacin_CellClick);
            // 
            // Magacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMagacin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtNaStanju);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAzurirajPice);
            this.Controls.Add(this.btnObrisiPice);
            this.Controls.Add(this.btnDodajPice);
            this.Controls.Add(this.txtCenaPica);
            this.Controls.Add(this.txtImePica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Magacin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magacin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Magacin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNaStanju;
        private Label label3;
        private Button btnAzurirajPice;
        private Button btnObrisiPice;
        private Button btnDodajPice;
        private TextBox txtCenaPica;
        private TextBox txtImePica;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nabavkaToolStripMenuItem;
        private ToolStripMenuItem prodajaToolStripMenuItem;
        private ToolStripMenuItem zaposleniToolStripMenuItem;
        private ToolStripMenuItem pićaToolStripMenuItem;
        private DataGridView dgMagacin;
        private ToolStripMenuItem magacinToolStripMenuItem;
    }
}