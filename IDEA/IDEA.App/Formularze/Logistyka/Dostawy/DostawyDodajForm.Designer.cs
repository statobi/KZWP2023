namespace IDEA.App.Formularze.Logistyka.Dostawy
{
    partial class DostawyDodajForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDostawca = new System.Windows.Forms.ComboBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKosztN = new System.Windows.Forms.TextBox();
            this.tbIlosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKosztB = new System.Windows.Forms.TextBox();
            this.BtnDodaj = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMagazynier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.dgvSkladDostawy = new System.Windows.Forms.DataGridView();
            this.cbFaktura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladDostawy)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(94, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Materiał";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(307, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Dostawca";
            // 
            // cbDostawca
            // 
            this.cbDostawca.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDostawca.FormattingEnabled = true;
            this.cbDostawca.Location = new System.Drawing.Point(235, 30);
            this.cbDostawca.Name = "cbDostawca";
            this.cbDostawca.Size = new System.Drawing.Size(217, 28);
            this.cbDostawca.TabIndex = 35;
            this.cbDostawca.SelectedIndexChanged += new System.EventHandler(this.cbDostawca_SelectedIndexChanged);
            // 
            // cbMaterial
            // 
            this.cbMaterial.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(12, 30);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(217, 28);
            this.cbMaterial.TabIndex = 34;
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(76, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Koszt netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(104, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ilość";
            // 
            // tbKosztN
            // 
            this.tbKosztN.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKosztN.Location = new System.Drawing.Point(12, 140);
            this.tbKosztN.Name = "tbKosztN";
            this.tbKosztN.Size = new System.Drawing.Size(217, 28);
            this.tbKosztN.TabIndex = 43;
            this.tbKosztN.TextChanged += new System.EventHandler(this.tbKosztN_TextChanged);
            this.tbKosztN.Leave += new System.EventHandler(this.tbKosztN_Leave);
            // 
            // tbIlosc
            // 
            this.tbIlosc.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIlosc.Location = new System.Drawing.Point(12, 85);
            this.tbIlosc.Name = "tbIlosc";
            this.tbIlosc.Size = new System.Drawing.Size(217, 28);
            this.tbIlosc.TabIndex = 42;
            this.tbIlosc.TextChanged += new System.EventHandler(this.tbIlosc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(76, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Koszt brutto";
            // 
            // tbKosztB
            // 
            this.tbKosztB.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKosztB.Location = new System.Drawing.Point(12, 199);
            this.tbKosztB.Name = "tbKosztB";
            this.tbKosztB.Size = new System.Drawing.Size(217, 28);
            this.tbKosztB.TabIndex = 46;
            this.tbKosztB.TextChanged += new System.EventHandler(this.tbKosztB_TextChanged);
            this.tbKosztB.Leave += new System.EventHandler(this.tbKosztB_Leave);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDodaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDodaj.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnDodaj.IconColor = System.Drawing.Color.Black;
            this.BtnDodaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDodaj.IconSize = 30;
            this.BtnDodaj.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnDodaj.Location = new System.Drawing.Point(235, 192);
            this.BtnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(217, 39);
            this.BtnDodaj.TabIndex = 48;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Numer faktury (opcjonalnie)";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDelete.Location = new System.Drawing.Point(235, 234);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 39);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSave.Location = new System.Drawing.Point(235, 277);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 39);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(299, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Magazynier";
            // 
            // cbMagazynier
            // 
            this.cbMagazynier.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMagazynier.FormattingEnabled = true;
            this.cbMagazynier.Location = new System.Drawing.Point(235, 85);
            this.cbMagazynier.Name = "cbMagazynier";
            this.cbMagazynier.Size = new System.Drawing.Size(217, 28);
            this.cbMagazynier.TabIndex = 54;
            this.cbMagazynier.SelectedIndexChanged += new System.EventHandler(this.cbMagazynier_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(319, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 57;
            this.label8.Text = "Data";
            // 
            // dtData
            // 
            this.dtData.CalendarFont = new System.Drawing.Font("Bookman Old Style", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(235, 140);
            this.dtData.Name = "dtData";
            this.dtData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtData.Size = new System.Drawing.Size(217, 28);
            this.dtData.TabIndex = 56;
            this.dtData.ValueChanged += new System.EventHandler(this.dtData_ValueChanged);
            // 
            // dgvSkladDostawy
            // 
            this.dgvSkladDostawy.AllowUserToAddRows = false;
            this.dgvSkladDostawy.AllowUserToDeleteRows = false;
            this.dgvSkladDostawy.AllowUserToResizeColumns = false;
            this.dgvSkladDostawy.AllowUserToResizeRows = false;
            this.dgvSkladDostawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladDostawy.Location = new System.Drawing.Point(458, 8);
            this.dgvSkladDostawy.Name = "dgvSkladDostawy";
            this.dgvSkladDostawy.ReadOnly = true;
            this.dgvSkladDostawy.RowHeadersWidth = 47;
            this.dgvSkladDostawy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladDostawy.Size = new System.Drawing.Size(594, 308);
            this.dgvSkladDostawy.TabIndex = 58;
            this.dgvSkladDostawy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladDostawy_CellClick);
            // 
            // cbFaktura
            // 
            this.cbFaktura.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFaktura.FormattingEnabled = true;
            this.cbFaktura.Location = new System.Drawing.Point(12, 288);
            this.cbFaktura.Name = "cbFaktura";
            this.cbFaktura.Size = new System.Drawing.Size(217, 28);
            this.cbFaktura.TabIndex = 59;
            // 
            // DostawyDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 325);
            this.Controls.Add(this.cbFaktura);
            this.Controls.Add(this.dgvSkladDostawy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMagazynier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKosztB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKosztN);
            this.Controls.Add(this.tbIlosc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDostawca);
            this.Controls.Add(this.cbMaterial);
            this.Name = "DostawyDodajForm";
            this.Text = "DostawyDodaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DostawyDodajForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladDostawy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDostawca;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKosztN;
        private System.Windows.Forms.TextBox tbIlosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKosztB;
        private FontAwesome.Sharp.IconButton BtnDodaj;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMagazynier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.DataGridView dgvSkladDostawy;
        private System.Windows.Forms.ComboBox cbFaktura;
    }
}