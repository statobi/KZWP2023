using System.Windows.Forms;

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
            this.cbKierowca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.cbMagazynier = new System.Windows.Forms.ComboBox();
            this.cbMagazyn = new System.Windows.Forms.ComboBox();
            this.tbOdleglosc = new System.Windows.Forms.TextBox();
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
            this.dgvSkladWysylki = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.lblLadownosc = new System.Windows.Forms.Label();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.iconDropDownButton2 = new FontAwesome.Sharp.IconDropDownButton();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladWysylki)).BeginInit();
            this.SuspendLayout();
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
            this.BtnDodaj.Location = new System.Drawing.Point(623, 233);
            this.BtnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(217, 39);
            this.BtnDodaj.TabIndex = 21;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // tbIlosc
            // 
            this.tbIlosc.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIlosc.Location = new System.Drawing.Point(846, 196);
            this.tbIlosc.Name = "tbIlosc";
            this.tbIlosc.Size = new System.Drawing.Size(217, 28);
            this.tbIlosc.TabIndex = 20;
            this.tbIlosc.TextChanged += new System.EventHandler(this.tbIlosc_TextChanged);
            // 
            // cbPojazd
            // 
            this.cbPojazd.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPojazd.FormattingEnabled = true;
            this.cbPojazd.Location = new System.Drawing.Point(623, 34);
            this.cbPojazd.Name = "cbPojazd";
            this.cbPojazd.Size = new System.Drawing.Size(217, 28);
            this.cbPojazd.TabIndex = 19;
            this.cbPojazd.SelectedIndexChanged += new System.EventHandler(this.cbPojazd_SelectedIndexChanged);
            // 
            // cbKierowca
            // 
            this.cbKierowca.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKierowca.FormattingEnabled = true;
            this.cbKierowca.Location = new System.Drawing.Point(846, 34);
            this.cbKierowca.Name = "cbKierowca";
            this.cbKierowca.Size = new System.Drawing.Size(217, 28);
            this.cbKierowca.TabIndex = 17;
            this.cbKierowca.SelectedIndexChanged += new System.EventHandler(this.cbKierowca_SelectedIndexChanged);
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
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 47;
            this.dgvLista.Size = new System.Drawing.Size(605, 281);
            this.dgvLista.TabIndex = 14;
            // 
            // cbMagazynier
            // 
            this.cbMagazynier.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMagazynier.FormattingEnabled = true;
            this.cbMagazynier.Location = new System.Drawing.Point(846, 88);
            this.cbMagazynier.Name = "cbMagazynier";
            this.cbMagazynier.Size = new System.Drawing.Size(217, 28);
            this.cbMagazynier.TabIndex = 22;
            this.cbMagazynier.SelectedIndexChanged += new System.EventHandler(this.cbMagazynier_SelectedIndexChanged);
            // 
            // cbMagazyn
            // 
            this.cbMagazyn.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMagazyn.FormattingEnabled = true;
            this.cbMagazyn.Location = new System.Drawing.Point(623, 88);
            this.cbMagazyn.Name = "cbMagazyn";
            this.cbMagazyn.Size = new System.Drawing.Size(217, 28);
            this.cbMagazyn.TabIndex = 23;
            this.cbMagazyn.SelectedIndexChanged += new System.EventHandler(this.cbMagazyn_SelectedIndexChanged);
            // 
            // tbOdleglosc
            // 
            this.tbOdleglosc.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOdleglosc.Location = new System.Drawing.Point(846, 143);
            this.tbOdleglosc.Name = "tbOdleglosc";
            this.tbOdleglosc.Size = new System.Drawing.Size(217, 28);
            this.tbOdleglosc.TabIndex = 24;
            this.tbOdleglosc.TextChanged += new System.EventHandler(this.tbOdleglosc_TextChanged);
            // 
            // dtData
            // 
            this.dtData.CalendarFont = new System.Drawing.Font("Bookman Old Style", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(623, 142);
            this.dtData.Name = "dtData";
            this.dtData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtData.Size = new System.Drawing.Size(217, 28);
            this.dtData.TabIndex = 27;
            this.dtData.ValueChanged += new System.EventHandler(this.dtData_ValueChanged);
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
            this.label2.Location = new System.Drawing.Point(703, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Produkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(703, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Magazyn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(933, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ilość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(703, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Pojazd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(914, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Kierowca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(910, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Magazynier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(714, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(910, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Odległość";
            // 
            // dgvSkladWysylki
            // 
            this.dgvSkladWysylki.AllowUserToAddRows = false;
            this.dgvSkladWysylki.AllowUserToDeleteRows = false;
            this.dgvSkladWysylki.AllowUserToResizeColumns = false;
            this.dgvSkladWysylki.AllowUserToResizeRows = false;
            this.dgvSkladWysylki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladWysylki.Location = new System.Drawing.Point(16, 345);
            this.dgvSkladWysylki.Name = "dgvSkladWysylki";
            this.dgvSkladWysylki.ReadOnly = true;
            this.dgvSkladWysylki.RowHeadersWidth = 47;
            this.dgvSkladWysylki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladWysylki.Size = new System.Drawing.Size(1047, 276);
            this.dgvSkladWysylki.TabIndex = 37;
            this.dgvSkladWysylki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladWysylki_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "Skład wysyłki:";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSave.Location = new System.Drawing.Point(846, 276);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 39);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLadownosc
            // 
            this.lblLadownosc.AutoSize = true;
            this.lblLadownosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLadownosc.ForeColor = System.Drawing.Color.Red;
            this.lblLadownosc.Location = new System.Drawing.Point(302, 318);
            this.lblLadownosc.Name = "lblLadownosc";
            this.lblLadownosc.Size = new System.Drawing.Size(619, 24);
            this.lblLadownosc.TabIndex = 41;
            this.lblLadownosc.Text = "Przekroczono dopuszczalną objętość załadunkową ładowność pojazdu!";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEdit.Location = new System.Drawing.Point(623, 276);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(217, 39);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(846, 233);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 39);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // iconDropDownButton2
            // 
            this.iconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton2.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton2.Name = "iconDropDownButton2";
            this.iconDropDownButton2.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton2.Text = "iconDropDownButton2";
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(623, 196);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(217, 28);
            this.cbZamowienie.TabIndex = 18;
            this.cbZamowienie.SelectedIndexChanged += new System.EventHandler(this.cbZamowienie_SelectedIndexChanged);
            // 
            // WysylkiDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 633);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblLadownosc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvSkladWysylki);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtData);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WysylkiDodajForm_FormClosing);
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
        private System.Windows.Forms.DataGridView dgvSkladWysylki;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label lblLadownosc;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton2;
    }
}