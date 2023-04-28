namespace IDEA.App.Formularze.Logistyka.Wysylki
{
    partial class WysylkiDodajForm
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
            this.BtnDodaj = new FontAwesome.Sharp.IconButton();
            this.tbIlosc = new System.Windows.Forms.TextBox();
            this.cbPojazd = new System.Windows.Forms.ComboBox();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            this.cbKierowca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.cbMagazynier = new System.Windows.Forms.ComboBox();
            this.cbMagazyn = new System.Windows.Forms.ComboBox();
            this.tbOdleglosc = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSkladWysylki = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladWysylki)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDodaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDodaj.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnDodaj.IconColor = System.Drawing.Color.Black;
            this.BtnDodaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDodaj.IconSize = 30;
            this.BtnDodaj.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnDodaj.Location = new System.Drawing.Point(554, 336);
            this.BtnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(243, 39);
            this.BtnDodaj.TabIndex = 21;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // tbIlosc
            // 
            this.tbIlosc.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIlosc.Location = new System.Drawing.Point(820, 229);
            this.tbIlosc.Name = "tbIlosc";
            this.tbIlosc.Size = new System.Drawing.Size(243, 28);
            this.tbIlosc.TabIndex = 20;
            // 
            // cbPojazd
            // 
            this.cbPojazd.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPojazd.FormattingEnabled = true;
            this.cbPojazd.Location = new System.Drawing.Point(554, 162);
            this.cbPojazd.Name = "cbPojazd";
            this.cbPojazd.Size = new System.Drawing.Size(243, 28);
            this.cbPojazd.TabIndex = 19;
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(554, 229);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(243, 28);
            this.cbZamowienie.TabIndex = 18;
            this.cbZamowienie.SelectedIndexChanged += new System.EventHandler(this.cbZamowienie_SelectedIndexChanged);
            // 
            // cbKierowca
            // 
            this.cbKierowca.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKierowca.FormattingEnabled = true;
            this.cbKierowca.Location = new System.Drawing.Point(820, 162);
            this.cbKierowca.Name = "cbKierowca";
            this.cbKierowca.Size = new System.Drawing.Size(243, 28);
            this.cbKierowca.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lista produktów gotowych do wysyłki:";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 34);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 47;
            this.dgvLista.Size = new System.Drawing.Size(516, 281);
            this.dgvLista.TabIndex = 14;
            // 
            // cbMagazynier
            // 
            this.cbMagazynier.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMagazynier.FormattingEnabled = true;
            this.cbMagazynier.Location = new System.Drawing.Point(820, 34);
            this.cbMagazynier.Name = "cbMagazynier";
            this.cbMagazynier.Size = new System.Drawing.Size(243, 28);
            this.cbMagazynier.TabIndex = 22;
            // 
            // cbMagazyn
            // 
            this.cbMagazyn.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMagazyn.FormattingEnabled = true;
            this.cbMagazyn.Location = new System.Drawing.Point(554, 34);
            this.cbMagazyn.Name = "cbMagazyn";
            this.cbMagazyn.Size = new System.Drawing.Size(243, 28);
            this.cbMagazyn.TabIndex = 23;
            // 
            // tbOdleglosc
            // 
            this.tbOdleglosc.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOdleglosc.Location = new System.Drawing.Point(820, 96);
            this.tbOdleglosc.Name = "tbOdleglosc";
            this.tbOdleglosc.Size = new System.Drawing.Size(243, 28);
            this.tbOdleglosc.TabIndex = 24;
            // 
            // tbAdres
            // 
            this.tbAdres.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdres.Location = new System.Drawing.Point(554, 96);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(243, 28);
            this.tbAdres.TabIndex = 25;
            // 
            // dtData
            // 
            this.dtData.CalendarFont = new System.Drawing.Font("Bookman Old Style", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.Font = new System.Drawing.Font("Bookman Old Style", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(554, 286);
            this.dtData.Name = "dtData";
            this.dtData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtData.Size = new System.Drawing.Size(243, 29);
            this.dtData.TabIndex = 27;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(645, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Produkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(641, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Magazyn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(920, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ilość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(649, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Pojazd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(907, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Kierowca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(898, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Magazynier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(649, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(907, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Odległość";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(649, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Adres";
            // 
            // dgvSkladWysylki
            // 
            this.dgvSkladWysylki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladWysylki.Location = new System.Drawing.Point(16, 380);
            this.dgvSkladWysylki.Name = "dgvSkladWysylki";
            this.dgvSkladWysylki.RowHeadersWidth = 47;
            this.dgvSkladWysylki.Size = new System.Drawing.Size(1047, 196);
            this.dgvSkladWysylki.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "Skład wysyłki:";
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
            this.btnSave.Location = new System.Drawing.Point(820, 336);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(243, 39);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Uratuj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // WysylkiDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 633);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvSkladWysylki);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbOdleglosc);
            this.Controls.Add(this.cbMagazyn);
            this.Controls.Add(this.cbMagazynier);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.tbIlosc);
            this.Controls.Add(this.cbPojazd);
            this.Controls.Add(this.cbZamowienie);
            this.Controls.Add(this.cbKierowca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLista);
            this.Name = "WysylkiDodajForm";
            this.Text = "Nowa wysyłka";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladWysylki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnDodaj;
        private System.Windows.Forms.TextBox tbIlosc;
        private System.Windows.Forms.ComboBox cbPojazd;
        private System.Windows.Forms.ComboBox cbZamowienie;
        private System.Windows.Forms.ComboBox cbKierowca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ComboBox cbMagazynier;
        private System.Windows.Forms.ComboBox cbMagazyn;
        private System.Windows.Forms.TextBox tbOdleglosc;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.DateTimePicker dtData;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSkladWysylki;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}