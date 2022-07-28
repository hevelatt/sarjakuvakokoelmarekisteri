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
            this.tableLayoutPanelAvaa = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPohja.SuspendLayout();
            this.tableLayoutPanelLuo.SuspendLayout();
            this.tableLayoutPanelAvaa.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxKokoelmat
            // 
            this.listBoxKokoelmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKokoelmat.FormattingEnabled = true;
            this.listBoxKokoelmat.ItemHeight = 15;
            this.listBoxKokoelmat.Location = new System.Drawing.Point(3, 3);
            this.listBoxKokoelmat.Name = "listBoxKokoelmat";
            this.listBoxKokoelmat.Size = new System.Drawing.Size(576, 409);
            this.listBoxKokoelmat.TabIndex = 0;
            this.listBoxKokoelmat.SelectedIndexChanged += new System.EventHandler(this.listBoxKokoelmat_SelectedIndexChanged);
            // 
            // buttonAvaa
            // 
            this.buttonAvaa.Enabled = false;
            this.buttonAvaa.Location = new System.Drawing.Point(3, 418);
            this.buttonAvaa.Name = "buttonAvaa";
            this.buttonAvaa.Size = new System.Drawing.Size(75, 23);
            this.buttonAvaa.TabIndex = 1;
            this.buttonAvaa.Text = "Avaa";
            this.buttonAvaa.UseVisualStyleBackColor = true;
            this.buttonAvaa.Click += new System.EventHandler(this.buttonAvaa_Click);
            // 
            // buttonLuo
            // 
            this.buttonLuo.Location = new System.Drawing.Point(3, 32);
            this.buttonLuo.Name = "buttonLuo";
            this.buttonLuo.Size = new System.Drawing.Size(75, 23);
            this.buttonLuo.TabIndex = 2;
            this.buttonLuo.Text = "Luo";
            this.buttonLuo.UseVisualStyleBackColor = true;
            // 
            // textBoxNimi
            // 
            this.textBoxNimi.Location = new System.Drawing.Point(3, 3);
            this.textBoxNimi.Name = "textBoxNimi";
            this.textBoxNimi.Size = new System.Drawing.Size(200, 23);
            this.textBoxNimi.TabIndex = 3;
            // 
            // tableLayoutPanelPohja
            // 
            this.tableLayoutPanelPohja.ColumnCount = 2;
            this.tableLayoutPanelPohja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPohja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPohja.Controls.Add(this.tableLayoutPanelLuo, 0, 0);
            this.tableLayoutPanelPohja.Controls.Add(this.tableLayoutPanelAvaa, 1, 0);
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
            // tableLayoutPanelAvaa
            // 
            this.tableLayoutPanelAvaa.ColumnCount = 1;
            this.tableLayoutPanelAvaa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAvaa.Controls.Add(this.listBoxKokoelmat, 0, 0);
            this.tableLayoutPanelAvaa.Controls.Add(this.buttonAvaa, 0, 1);
            this.tableLayoutPanelAvaa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAvaa.Location = new System.Drawing.Point(215, 3);
            this.tableLayoutPanelAvaa.Name = "tableLayoutPanelAvaa";
            this.tableLayoutPanelAvaa.RowCount = 2;
            this.tableLayoutPanelAvaa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAvaa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAvaa.Size = new System.Drawing.Size(582, 444);
            this.tableLayoutPanelAvaa.TabIndex = 1;
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
            this.tableLayoutPanelAvaa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxKokoelmat;
        private Button buttonAvaa;
        private Button buttonLuo;
        private TextBox textBoxNimi;
        private TableLayoutPanel tableLayoutPanelPohja;
        private TableLayoutPanel tableLayoutPanelLuo;
        private TableLayoutPanel tableLayoutPanelAvaa;
    }
}