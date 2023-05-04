namespace IDEA.App
{
    partial class ZleceniaMagazynoweForm
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
            this.dgvObecneProcesy = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMagazynProdukcja = new System.Windows.Forms.DataGridView();
            this.dgvMaterialyBrakujace = new System.Windows.Forms.DataGridView();
            this.btnOtwZlec = new FontAwesome.Sharp.IconButton();
            this.btnZamkZlec = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynProdukcja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialyBrakujace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObecneProcesy
            // 
            this.dgvObecneProcesy.AllowUserToResizeRows = false;
            this.dgvObecneProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObecneProcesy.Location = new System.Drawing.Point(12, 47);
            this.dgvObecneProcesy.MultiSelect = false;
            this.dgvObecneProcesy.Name = "dgvObecneProcesy";
            this.dgvObecneProcesy.ReadOnly = true;
            this.dgvObecneProcesy.RowHeadersVisible = false;
            this.dgvObecneProcesy.RowHeadersWidth = 51;
            this.dgvObecneProcesy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObecneProcesy.Size = new System.Drawing.Size(960, 208);
            this.dgvObecneProcesy.TabIndex = 2;
            this.dgvObecneProcesy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellClick);
            this.dgvObecneProcesy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(53, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 29);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.SystemColors.Control;
            this.iconSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.IconSize = 29;
            this.iconSearch.Location = new System.Drawing.Point(15, 9);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(32, 29);
            this.iconSearch.TabIndex = 7;
            this.iconSearch.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "ZlecenieMagazynowe";
            // 
            // dgvMagazynProdukcja
            // 
            this.dgvMagazynProdukcja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynProdukcja.Location = new System.Drawing.Point(27, 291);
            this.dgvMagazynProdukcja.Name = "dgvMagazynProdukcja";
            this.dgvMagazynProdukcja.Size = new System.Drawing.Size(393, 160);
            this.dgvMagazynProdukcja.TabIndex = 9;
            // 
            // dgvMaterialyBrakujace
            // 
            this.dgvMaterialyBrakujace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialyBrakujace.Location = new System.Drawing.Point(27, 474);
            this.dgvMaterialyBrakujace.Name = "dgvMaterialyBrakujace";
            this.dgvMaterialyBrakujace.Size = new System.Drawing.Size(393, 136);
            this.dgvMaterialyBrakujace.TabIndex = 10;
            // 
            // btnOtwZlec
            // 
            this.btnOtwZlec.Enabled = false;
            this.btnOtwZlec.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOtwZlec.IconColor = System.Drawing.Color.Black;
            this.btnOtwZlec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOtwZlec.Location = new System.Drawing.Point(693, 598);
            this.btnOtwZlec.Name = "btnOtwZlec";
            this.btnOtwZlec.Size = new System.Drawing.Size(114, 49);
            this.btnOtwZlec.TabIndex = 11;
            this.btnOtwZlec.Text = "Otwórz Zlecenie";
            this.btnOtwZlec.UseVisualStyleBackColor = true;
            // 
            // btnZamkZlec
            // 
            this.btnZamkZlec.Enabled = false;
            this.btnZamkZlec.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnZamkZlec.IconColor = System.Drawing.Color.Black;
            this.btnZamkZlec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZamkZlec.Location = new System.Drawing.Point(834, 598);
            this.btnZamkZlec.Name = "btnZamkZlec";
            this.btnZamkZlec.Size = new System.Drawing.Size(114, 49);
            this.btnZamkZlec.TabIndex = 12;
            this.btnZamkZlec.Text = "Otwórz Zlecenie";
            this.btnZamkZlec.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(373, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Pracownik:";
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(481, 613);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(192, 21);
            this.cbPracownik.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 316);
            this.dataGridView1.TabIndex = 46;
            // 
            // ZleceniaMagazynoweForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.btnZamkZlec);
            this.Controls.Add(this.btnOtwZlec);
            this.Controls.Add(this.dgvMaterialyBrakujace);
            this.Controls.Add(this.dgvMagazynProdukcja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvObecneProcesy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZleceniaMagazynoweForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFKlienciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynProdukcja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialyBrakujace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvObecneProcesy;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMagazynProdukcja;
        private System.Windows.Forms.DataGridView dgvMaterialyBrakujace;
        private FontAwesome.Sharp.IconButton btnOtwZlec;
        private FontAwesome.Sharp.IconButton btnZamkZlec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}