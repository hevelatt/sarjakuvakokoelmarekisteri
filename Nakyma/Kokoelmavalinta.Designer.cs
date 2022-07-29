namespace Sarjakuvakokoelmarekisteri.Nakyma
{
    partial class Kokoelmavalinta
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
            this.listBoxKokoelmat = new System.Windows.Forms.ListBox();
            this.buttonAvaa = new System.Windows.Forms.Button();
            this.buttonLuo = new System.Windows.Forms.Button();
            this.textBoxNimi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelPohja = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLuo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLista = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelListaOhjaimet = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPoista = new System.Windows.Forms.Button();
            this.tableLayoutPanelPohja.SuspendLayout();
            this.tableLayoutPanelLuo.SuspendLayout();
            this.tableLayoutPanelLista.SuspendLayout();
            this.tableLayoutPanelListaOhjaimet.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxKokoelmat
            // 
            this.listBoxKokoelmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKokoelmat.FormattingEnabled = true;
            this.listBoxKokoelmat.ItemHeight = 15;
            this.listBoxKokoelmat.Location = new System.Drawing.Point(3, 3);
            this.listBoxKokoelmat.Name = "listBoxKokoelmat";
            this.listBoxKokoelmat.Size = new System.Drawing.Size(576, 403);
            this.listBoxKokoelmat.TabIndex = 0;
            this.listBoxKokoelmat.SelectedIndexChanged += new System.EventHandler(this.listBoxKokoelmat_SelectedIndexChanged);
            // 
            // buttonAvaa
            // 
            this.buttonAvaa.Enabled = false;
            this.buttonAvaa.Location = new System.Drawing.Point(3, 3);
            this.buttonAvaa.Name = "buttonAvaa";
            this.buttonAvaa.Size = new System.Drawing.Size(75, 23);
            this.buttonAvaa.TabIndex = 1;
            this.buttonAvaa.Text = "Avaa";
            this.buttonAvaa.UseVisualStyleBackColor = true;
            this.buttonAvaa.Click += new System.EventHandler(this.buttonAvaa_Click);
            // 
            // buttonLuo
            // 
            this.buttonLuo.Enabled = false;
            this.buttonLuo.Location = new System.Drawing.Point(3, 32);
            this.buttonLuo.Name = "buttonLuo";
            this.buttonLuo.Size = new System.Drawing.Size(75, 23);
            this.buttonLuo.TabIndex = 2;
            this.buttonLuo.Text = "Luo";
            this.buttonLuo.UseVisualStyleBackColor = true;
            this.buttonLuo.Click += new System.EventHandler(this.buttonLuo_Click);
            // 
            // textBoxNimi
            // 
            this.textBoxNimi.Location = new System.Drawing.Point(3, 3);
            this.textBoxNimi.Name = "textBoxNimi";
            this.textBoxNimi.Size = new System.Drawing.Size(200, 23);
            this.textBoxNimi.TabIndex = 3;
            this.textBoxNimi.TextChanged += new System.EventHandler(this.textBoxNimi_TextChanged);
            // 
            // tableLayoutPanelPohja
            // 
            this.tableLayoutPanelPohja.ColumnCount = 2;
            this.tableLayoutPanelPohja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPohja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPohja.Controls.Add(this.tableLayoutPanelLuo, 0, 0);
            this.tableLayoutPanelPohja.Controls.Add(this.tableLayoutPanelLista, 1, 0);
            this.tableLayoutPanelPohja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPohja.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPohja.Name = "tableLayoutPanelPohja";
            this.tableLayoutPanelPohja.RowCount = 1;
            this.tableLayoutPanelPohja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPohja.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelPohja.TabIndex = 4;
            // 
            // tableLayoutPanelLuo
            // 
            this.tableLayoutPanelLuo.AutoSize = true;
            this.tableLayoutPanelLuo.ColumnCount = 1;
            this.tableLayoutPanelLuo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLuo.Controls.Add(this.textBoxNimi, 0, 0);
            this.tableLayoutPanelLuo.Controls.Add(this.buttonLuo, 0, 1);
            this.tableLayoutPanelLuo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLuo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLuo.Name = "tableLayoutPanelLuo";
            this.tableLayoutPanelLuo.RowCount = 2;
            this.tableLayoutPanelLuo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLuo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLuo.Size = new System.Drawing.Size(206, 444);
            this.tableLayoutPanelLuo.TabIndex = 0;
            // 
            // tableLayoutPanelLista
            // 
            this.tableLayoutPanelLista.ColumnCount = 1;
            this.tableLayoutPanelLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLista.Controls.Add(this.listBoxKokoelmat, 0, 0);
            this.tableLayoutPanelLista.Controls.Add(this.tableLayoutPanelListaOhjaimet, 0, 1);
            this.tableLayoutPanelLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLista.Location = new System.Drawing.Point(215, 3);
            this.tableLayoutPanelLista.Name = "tableLayoutPanelLista";
            this.tableLayoutPanelLista.RowCount = 2;
            this.tableLayoutPanelLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLista.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLista.Size = new System.Drawing.Size(582, 444);
            this.tableLayoutPanelLista.TabIndex = 1;
            // 
            // tableLayoutPanelListaOhjaimet
            // 
            this.tableLayoutPanelListaOhjaimet.AutoSize = true;
            this.tableLayoutPanelListaOhjaimet.ColumnCount = 2;
            this.tableLayoutPanelListaOhjaimet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelListaOhjaimet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelListaOhjaimet.Controls.Add(this.buttonAvaa, 0, 0);
            this.tableLayoutPanelListaOhjaimet.Controls.Add(this.buttonPoista, 1, 0);
            this.tableLayoutPanelListaOhjaimet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelListaOhjaimet.Location = new System.Drawing.Point(3, 412);
            this.tableLayoutPanelListaOhjaimet.Name = "tableLayoutPanelListaOhjaimet";
            this.tableLayoutPanelListaOhjaimet.RowCount = 1;
            this.tableLayoutPanelListaOhjaimet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelListaOhjaimet.Size = new System.Drawing.Size(576, 29);
            this.tableLayoutPanelListaOhjaimet.TabIndex = 2;
            // 
            // buttonPoista
            // 
            this.buttonPoista.Enabled = false;
            this.buttonPoista.Location = new System.Drawing.Point(84, 3);
            this.buttonPoista.Name = "buttonPoista";
            this.buttonPoista.Size = new System.Drawing.Size(75, 23);
            this.buttonPoista.TabIndex = 2;
            this.buttonPoista.Text = "Poista";
            this.buttonPoista.UseVisualStyleBackColor = true;
            this.buttonPoista.Click += new System.EventHandler(this.buttonPoista_Click);
            // 
            // Kokoelmavalinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelPohja);
            this.Name = "Kokoelmavalinta";
            this.Text = "Valitse kokoelma";
            this.tableLayoutPanelPohja.ResumeLayout(false);
            this.tableLayoutPanelPohja.PerformLayout();
            this.tableLayoutPanelLuo.ResumeLayout(false);
            this.tableLayoutPanelLuo.PerformLayout();
            this.tableLayoutPanelLista.ResumeLayout(false);
            this.tableLayoutPanelLista.PerformLayout();
            this.tableLayoutPanelListaOhjaimet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxKokoelmat;
        private Button buttonAvaa;
        private Button buttonLuo;
        private TextBox textBoxNimi;
        private TableLayoutPanel tableLayoutPanelPohja;
        private TableLayoutPanel tableLayoutPanelLuo;
        private TableLayoutPanel tableLayoutPanelListaOhjaimet;
        private Button buttonPoista;
        private TableLayoutPanel tableLayoutPanelLista;
    }
}