namespace Zlatno_Burence
{
    partial class Zaposleni
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
            this.pićaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imeZapTxt = new System.Windows.Forms.TextBox();
            this.PrezZapTxt = new System.Windows.Forms.TextBox();
            this.dodajZapBtn = new System.Windows.Forms.Button();
            this.ZaposleniDg = new System.Windows.Forms.DataGridView();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.azurirajBtn = new System.Windows.Forms.Button();
            this.magacinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniDg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabavkaToolStripMenuItem,
            this.prodajaToolStripMenuItem,
            this.zaposleniToolStripMenuItem,
            this.pićaToolStripMenuItem,
            this.magacinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
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
            // 
            // pićaToolStripMenuItem
            // 
            this.pićaToolStripMenuItem.Name = "pićaToolStripMenuItem";
            this.pićaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.pićaToolStripMenuItem.Text = "Pića";
            this.pićaToolStripMenuItem.Click += new System.EventHandler(this.pićaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime Zaposlenog:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime Zaposlenog:";
            // 
            // imeZapTxt
            // 
            this.imeZapTxt.Location = new System.Drawing.Point(150, 80);
            this.imeZapTxt.Name = "imeZapTxt";
            this.imeZapTxt.Size = new System.Drawing.Size(162, 23);
            this.imeZapTxt.TabIndex = 5;
            // 
            // PrezZapTxt
            // 
            this.PrezZapTxt.Location = new System.Drawing.Point(150, 109);
            this.PrezZapTxt.Name = "PrezZapTxt";
            this.PrezZapTxt.Size = new System.Drawing.Size(162, 23);
            this.PrezZapTxt.TabIndex = 6;
            // 
            // dodajZapBtn
            // 
            this.dodajZapBtn.Location = new System.Drawing.Point(162, 151);
            this.dodajZapBtn.Name = "dodajZapBtn";
            this.dodajZapBtn.Size = new System.Drawing.Size(132, 23);
            this.dodajZapBtn.TabIndex = 7;
            this.dodajZapBtn.Text = "Dodaj Zaposlenog";
            this.dodajZapBtn.UseVisualStyleBackColor = true;
            this.dodajZapBtn.Click += new System.EventHandler(this.dodajZapBtn_Click);
            // 
            // ZaposleniDg
            // 
            this.ZaposleniDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZaposleniDg.Dock = System.Windows.Forms.DockStyle.Right;
            this.ZaposleniDg.Location = new System.Drawing.Point(470, 24);
            this.ZaposleniDg.Name = "ZaposleniDg";
            this.ZaposleniDg.RowTemplate.Height = 25;
            this.ZaposleniDg.Size = new System.Drawing.Size(330, 426);
            this.ZaposleniDg.TabIndex = 8;
            this.ZaposleniDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZaposleniDg_CellClick);
            this.ZaposleniDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZaposleniDg_CellContentClick);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(237, 200);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(75, 23);
            this.obrisiBtn.TabIndex = 9;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // azurirajBtn
            // 
            this.azurirajBtn.Location = new System.Drawing.Point(135, 200);
            this.azurirajBtn.Name = "azurirajBtn";
            this.azurirajBtn.Size = new System.Drawing.Size(75, 23);
            this.azurirajBtn.TabIndex = 10;
            this.azurirajBtn.Text = "Azuriraj";
            this.azurirajBtn.UseVisualStyleBackColor = true;
            this.azurirajBtn.Click += new System.EventHandler(this.azurirajBtn_Click);
            // 
            // magacinToolStripMenuItem
            // 
            this.magacinToolStripMenuItem.Name = "magacinToolStripMenuItem";
            this.magacinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.magacinToolStripMenuItem.Text = "Magacin";
            this.magacinToolStripMenuItem.Click += new System.EventHandler(this.magacinToolStripMenuItem_Click);
            // 
            // Zaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.azurirajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.ZaposleniDg);
            this.Controls.Add(this.dodajZapBtn);
            this.Controls.Add(this.PrezZapTxt);
            this.Controls.Add(this.imeZapTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Zaposleni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposleni";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Zaposleni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nabavkaToolStripMenuItem;
        private ToolStripMenuItem prodajaToolStripMenuItem;
        private ToolStripMenuItem zaposleniToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox imeZapTxt;
        private TextBox PrezZapTxt;
        private Button dodajZapBtn;
        private DataGridView ZaposleniDg;
        private Button obrisiBtn;
        private Button azurirajBtn;
        private ToolStripMenuItem pićaToolStripMenuItem;
        private ToolStripMenuItem magacinToolStripMenuItem;
    }
}