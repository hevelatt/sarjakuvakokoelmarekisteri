namespace Sarjakuvakokoelmarekisteri.Nakyma
{
    partial class Paaikkuna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripPaavalikko = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaKokoelmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxHaku = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelHakuOhjaimet = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxHakusana = new System.Windows.Forms.TextBox();
            this.comboBoxHakuehto = new System.Windows.Forms.ComboBox();
            this.buttonHae = new System.Windows.Forms.Button();
            this.tableLayoutPanelTiedotKentat = new System.Windows.Forms.TableLayoutPanel();
            this.labelNimi = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelSarja = new System.Windows.Forms.Label();
            this.labelVuosi = new System.Windows.Forms.Label();
            this.textBoxNimi = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.comboBoxSarja = new System.Windows.Forms.ComboBox();
            this.textBoxVuosi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelJulkaisuOhjaimet = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLisaa = new System.Windows.Forms.Button();
            this.buttonPoista = new System.Windows.Forms.Button();
            this.tableLayoutPanelOhjaimet = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTiedot = new System.Windows.Forms.GroupBox();
            this.splitContainerPohja = new System.Windows.Forms.SplitContainer();
            this.listViewJulkaisut = new System.Windows.Forms.ListView();
            this.columnHeaderNimi = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNumero = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSarja = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderVuosi = new System.Windows.Forms.ColumnHeader();
            this.menuStripPaavalikko.SuspendLayout();
            this.groupBoxHaku.SuspendLayout();
            this.tableLayoutPanelHakuOhjaimet.SuspendLayout();
            this.tableLayoutPanelTiedotKentat.SuspendLayout();
            this.tableLayoutPanelJulkaisuOhjaimet.SuspendLayout();
            this.tableLayoutPanelOhjaimet.SuspendLayout();
            this.groupBoxTiedot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPohja)).BeginInit();
            this.splitContainerPohja.Panel1.SuspendLayout();
            this.splitContainerPohja.Panel2.SuspendLayout();
            this.splitContainerPohja.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPaavalikko
            // 
            this.menuStripPaavalikko.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuStripPaavalikko.Location = new System.Drawing.Point(0, 0);
            this.menuStripPaavalikko.Name = "menuStripPaavalikko";
            this.menuStripPaavalikko.Size = new System.Drawing.Size(800, 24);
            this.menuStripPaavalikko.TabIndex = 0;
            this.menuStripPaavalikko.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaKokoelmaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // avaaKokoelmaToolStripMenuItem
            // 
            this.avaaKokoelmaToolStripMenuItem.Name = "avaaKokoelmaToolStripMenuItem";
            this.avaaKokoelmaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.avaaKokoelmaToolStripMenuItem.Text = "Avaa kokoelma";
            this.avaaKokoelmaToolStripMenuItem.Click += new System.EventHandler(this.avaaKokoelmaToolStripMenuItem_Click);
            // 
            // groupBoxHaku
            // 
            this.groupBoxHaku.AutoSize = true;
            this.groupBoxHaku.Controls.Add(this.tableLayoutPanelHakuOhjaimet);
            this.groupBoxHaku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxHaku.Location = new System.Drawing.Point(3, 3);
            this.groupBoxHaku.Name = "groupBoxHaku";
            this.groupBoxHaku.Size = new System.Drawing.Size(267, 109);
            this.groupBoxHaku.TabIndex = 1;
            this.groupBoxHaku.TabStop = false;
            this.groupBoxHaku.Text = "Haku";
            // 
            // tableLayoutPanelHakuOhjaimet
            // 
            this.tableLayoutPanelHakuOhjaimet.AutoSize = true;
            this.tableLayoutPanelHakuOhjaimet.ColumnCount = 1;
            this.tableLayoutPanelHakuOhjaimet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHakuOhjaimet.Controls.Add(this.textBoxHakusana, 0, 0);
            this.tableLayoutPanelHakuOhjaimet.Controls.Add(this.comboBoxHakuehto, 0, 1);
            this.tableLayoutPanelHakuOhjaimet.Controls.Add(this.buttonHae, 0, 2);
            this.tableLayoutPanelHakuOhjaimet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHakuOhjaimet.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelHakuOhjaimet.Name = "tableLayoutPanelHakuOhjaimet";
            this.tableLayoutPanelHakuOhjaimet.RowCount = 3;
            this.tableLayoutPanelHakuOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHakuOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHakuOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHakuOhjaimet.Size = new System.Drawing.Size(261, 87);
            this.tableLayoutPanelHakuOhjaimet.TabIndex = 0;
            // 
            // textBoxHakusana
            // 
            this.textBoxHakusana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHakusana.Location = new System.Drawing.Point(3, 3);
            this.textBoxHakusana.Name = "textBoxHakusana";
            this.textBoxHakusana.Size = new System.Drawing.Size(255, 23);
            this.textBoxHakusana.TabIndex = 0;
            // 
            // comboBoxHakuehto
            // 
            this.comboBoxHakuehto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHakuehto.FormattingEnabled = true;
            this.comboBoxHakuehto.Location = new System.Drawing.Point(3, 32);
            this.comboBoxHakuehto.Name = "comboBoxHakuehto";
            this.comboBoxHakuehto.Size = new System.Drawing.Size(255, 23);
            this.comboBoxHakuehto.TabIndex = 1;
            // 
            // buttonHae
            // 
            this.buttonHae.Location = new System.Drawing.Point(3, 61);
            this.buttonHae.Name = "buttonHae";
            this.buttonHae.Size = new System.Drawing.Size(75, 23);
            this.buttonHae.TabIndex = 2;
            this.buttonHae.Text = "Hae";
            this.buttonHae.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTiedotKentat
            // 
            this.tableLayoutPanelTiedotKentat.AutoSize = true;
            this.tableLayoutPanelTiedotKentat.ColumnCount = 2;
            this.tableLayoutPanelTiedotKentat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTiedotKentat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.labelNimi, 0, 0);
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.labelNumero, 0, 1);
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.labelSarja, 0, 2);
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.labelVuosi, 0, 3);
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.textBoxNimi, 1, 0);
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.textBoxNumero, 1, 1);
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.comboBoxSarja, 1, 2);
            this.tableLayoutPanelTiedotKentat.Controls.Add(this.textBoxVuosi, 1, 3);
            this.tableLayoutPanelTiedotKentat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTiedotKentat.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelTiedotKentat.Name = "tableLayoutPanelTiedotKentat";
            this.tableLayoutPanelTiedotKentat.RowCount = 4;
            this.tableLayoutPanelTiedotKentat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTiedotKentat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTiedotKentat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTiedotKentat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTiedotKentat.Size = new System.Drawing.Size(261, 116);
            this.tableLayoutPanelTiedotKentat.TabIndex = 2;
            // 
            // labelNimi
            // 
            this.labelNimi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNimi.AutoSize = true;
            this.labelNimi.Location = new System.Drawing.Point(46, 7);
            this.labelNimi.Name = "labelNimi";
            this.labelNimi.Size = new System.Drawing.Size(33, 15);
            this.labelNimi.TabIndex = 0;
            this.labelNimi.Text = "Nimi";
            // 
            // labelNumero
            // 
            this.labelNumero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(28, 36);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(51, 15);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Numero";
            // 
            // labelSarja
            // 
            this.labelSarja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSarja.AutoSize = true;
            this.labelSarja.Location = new System.Drawing.Point(47, 65);
            this.labelSarja.Name = "labelSarja";
            this.labelSarja.Size = new System.Drawing.Size(32, 15);
            this.labelSarja.TabIndex = 2;
            this.labelSarja.Text = "Sarja";
            // 
            // labelVuosi
            // 
            this.labelVuosi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVuosi.AutoSize = true;
            this.labelVuosi.Location = new System.Drawing.Point(3, 94);
            this.labelVuosi.Name = "labelVuosi";
            this.labelVuosi.Size = new System.Drawing.Size(76, 15);
            this.labelVuosi.TabIndex = 3;
            this.labelVuosi.Text = "Julkaisuvuosi";
            // 
            // textBoxNimi
            // 
            this.textBoxNimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNimi.Location = new System.Drawing.Point(85, 3);
            this.textBoxNimi.Name = "textBoxNimi";
            this.textBoxNimi.Size = new System.Drawing.Size(173, 23);
            this.textBoxNimi.TabIndex = 5;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumero.Location = new System.Drawing.Point(85, 32);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(173, 23);
            this.textBoxNumero.TabIndex = 6;
            // 
            // comboBoxSarja
            // 
            this.comboBoxSarja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSarja.FormattingEnabled = true;
            this.comboBoxSarja.Location = new System.Drawing.Point(85, 61);
            this.comboBoxSarja.Name = "comboBoxSarja";
            this.comboBoxSarja.Size = new System.Drawing.Size(173, 23);
            this.comboBoxSarja.TabIndex = 9;
            // 
            // textBoxVuosi
            // 
            this.textBoxVuosi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVuosi.Location = new System.Drawing.Point(85, 90);
            this.textBoxVuosi.Name = "textBoxVuosi";
            this.textBoxVuosi.Size = new System.Drawing.Size(173, 23);
            this.textBoxVuosi.TabIndex = 8;
            // 
            // tableLayoutPanelJulkaisuOhjaimet
            // 
            this.tableLayoutPanelJulkaisuOhjaimet.AutoSize = true;
            this.tableLayoutPanelJulkaisuOhjaimet.ColumnCount = 2;
            this.tableLayoutPanelJulkaisuOhjaimet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelJulkaisuOhjaimet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelJulkaisuOhjaimet.Controls.Add(this.buttonLisaa, 0, 0);
            this.tableLayoutPanelJulkaisuOhjaimet.Controls.Add(this.buttonPoista, 1, 0);
            this.tableLayoutPanelJulkaisuOhjaimet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelJulkaisuOhjaimet.Location = new System.Drawing.Point(3, 262);
            this.tableLayoutPanelJulkaisuOhjaimet.Name = "tableLayoutPanelJulkaisuOhjaimet";
            this.tableLayoutPanelJulkaisuOhjaimet.RowCount = 1;
            this.tableLayoutPanelJulkaisuOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJulkaisuOhjaimet.Size = new System.Drawing.Size(267, 161);
            this.tableLayoutPanelJulkaisuOhjaimet.TabIndex = 3;
            // 
            // buttonLisaa
            // 
            this.buttonLisaa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLisaa.Location = new System.Drawing.Point(29, 3);
            this.buttonLisaa.Name = "buttonLisaa";
            this.buttonLisaa.Size = new System.Drawing.Size(75, 23);
            this.buttonLisaa.TabIndex = 0;
            this.buttonLisaa.Text = "Lisää julkaisu";
            this.buttonLisaa.UseVisualStyleBackColor = true;
            // 
            // buttonPoista
            // 
            this.buttonPoista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPoista.Enabled = false;
            this.buttonPoista.Location = new System.Drawing.Point(162, 3);
            this.buttonPoista.Name = "buttonPoista";
            this.buttonPoista.Size = new System.Drawing.Size(75, 23);
            this.buttonPoista.TabIndex = 1;
            this.buttonPoista.Text = "Poista";
            this.buttonPoista.UseVisualStyleBackColor = true;
            this.buttonPoista.Click += new System.EventHandler(this.buttonPoista_Click);
            // 
            // tableLayoutPanelOhjaimet
            // 
            this.tableLayoutPanelOhjaimet.ColumnCount = 1;
            this.tableLayoutPanelOhjaimet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOhjaimet.Controls.Add(this.groupBoxHaku, 0, 0);
            this.tableLayoutPanelOhjaimet.Controls.Add(this.groupBoxTiedot, 0, 1);
            this.tableLayoutPanelOhjaimet.Controls.Add(this.tableLayoutPanelJulkaisuOhjaimet, 0, 2);
            this.tableLayoutPanelOhjaimet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOhjaimet.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOhjaimet.Name = "tableLayoutPanelOhjaimet";
            this.tableLayoutPanelOhjaimet.RowCount = 3;
            this.tableLayoutPanelOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOhjaimet.Size = new System.Drawing.Size(273, 426);
            this.tableLayoutPanelOhjaimet.TabIndex = 4;
            // 
            // groupBoxTiedot
            // 
            this.groupBoxTiedot.AutoSize = true;
            this.groupBoxTiedot.Controls.Add(this.tableLayoutPanelTiedotKentat);
            this.groupBoxTiedot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTiedot.Location = new System.Drawing.Point(3, 118);
            this.groupBoxTiedot.Name = "groupBoxTiedot";
            this.groupBoxTiedot.Size = new System.Drawing.Size(267, 138);
            this.groupBoxTiedot.TabIndex = 3;
            this.groupBoxTiedot.TabStop = false;
            this.groupBoxTiedot.Text = "Julkaisun tiedot";
            // 
            // splitContainerPohja
            // 
            this.splitContainerPohja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPohja.Location = new System.Drawing.Point(0, 24);
            this.splitContainerPohja.Name = "splitContainerPohja";
            // 
            // splitContainerPohja.Panel1
            // 
            this.splitContainerPohja.Panel1.Controls.Add(this.tableLayoutPanelOhjaimet);
            // 
            // splitContainerPohja.Panel2
            // 
            this.splitContainerPohja.Panel2.Controls.Add(this.listViewJulkaisut);
            this.splitContainerPohja.Size = new System.Drawing.Size(800, 426);
            this.splitContainerPohja.SplitterDistance = 273;
            this.splitContainerPohja.TabIndex = 3;
            // 
            // listViewJulkaisut
            // 
            this.listViewJulkaisut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNimi,
            this.columnHeaderNumero,
            this.columnHeaderSarja,
            this.columnHeaderVuosi});
            this.listViewJulkaisut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewJulkaisut.FullRowSelect = true;
            this.listViewJulkaisut.Location = new System.Drawing.Point(0, 0);
            this.listViewJulkaisut.MultiSelect = false;
            this.listViewJulkaisut.Name = "listViewJulkaisut";
            this.listViewJulkaisut.Size = new System.Drawing.Size(523, 426);
            this.listViewJulkaisut.TabIndex = 0;
            this.listViewJulkaisut.UseCompatibleStateImageBehavior = false;
            this.listViewJulkaisut.View = System.Windows.Forms.View.Details;
            this.listViewJulkaisut.SelectedIndexChanged += new System.EventHandler(this.listViewJulkaisut_SelectedIndexChanged);
            // 
            // columnHeaderNimi
            // 
            this.columnHeaderNimi.Text = "Nimi";
            this.columnHeaderNimi.Width = 240;
            // 
            // columnHeaderNumero
            // 
            this.columnHeaderNumero.Text = "Numero";
            // 
            // columnHeaderSarja
            // 
            this.columnHeaderSarja.Text = "Sarja";
            this.columnHeaderSarja.Width = 150;
            // 
            // columnHeaderVuosi
            // 
            this.columnHeaderVuosi.Text = "Vuosi";
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerPohja);
            this.Controls.Add(this.menuStripPaavalikko);
            this.MainMenuStrip = this.menuStripPaavalikko;
            this.Name = "Paaikkuna";
            this.Text = "Sarjakuvakokoelma";
            this.menuStripPaavalikko.ResumeLayout(false);
            this.menuStripPaavalikko.PerformLayout();
            this.groupBoxHaku.ResumeLayout(false);
            this.groupBoxHaku.PerformLayout();
            this.tableLayoutPanelHakuOhjaimet.ResumeLayout(false);
            this.tableLayoutPanelHakuOhjaimet.PerformLayout();
            this.tableLayoutPanelTiedotKentat.ResumeLayout(false);
            this.tableLayoutPanelTiedotKentat.PerformLayout();
            this.tableLayoutPanelJulkaisuOhjaimet.ResumeLayout(false);
            this.tableLayoutPanelOhjaimet.ResumeLayout(false);
            this.tableLayoutPanelOhjaimet.PerformLayout();
            this.groupBoxTiedot.ResumeLayout(false);
            this.groupBoxTiedot.PerformLayout();
            this.splitContainerPohja.Panel1.ResumeLayout(false);
            this.splitContainerPohja.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPohja)).EndInit();
            this.splitContainerPohja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripPaavalikko;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private GroupBox groupBoxHaku;
        private TableLayoutPanel tableLayoutPanelHakuOhjaimet;
        private TextBox textBoxHakusana;
        private ComboBox comboBoxHakuehto;
        private Button buttonHae;
        private TableLayoutPanel tableLayoutPanelOhjaimet;
        private GroupBox groupBoxTiedot;
        private TableLayoutPanel tableLayoutPanelTiedotKentat;
        private TextBox textBoxVuosi;
        private TextBox textBoxNumero;
        private Label labelNimi;
        private Label labelNumero;
        private Label labelSarja;
        private Label labelVuosi;
        private TextBox textBoxNimi;
        private TableLayoutPanel tableLayoutPanelJulkaisuOhjaimet;
        private Button buttonLisaa;
        private Button buttonPoista;
        private SplitContainer splitContainerPohja;
        private ComboBox comboBoxSarja;
        private ToolStripMenuItem avaaKokoelmaToolStripMenuItem;
        private ListView listViewJulkaisut;
        private ColumnHeader columnHeaderNimi;
        private ColumnHeader columnHeaderNumero;
        private ColumnHeader columnHeaderSarja;
        private ColumnHeader columnHeaderVuosi;
    }
}