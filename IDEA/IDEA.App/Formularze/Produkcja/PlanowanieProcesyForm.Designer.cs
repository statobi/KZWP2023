namespace IDEA.App.Formularze.Produkcja
{
    partial class PlanowanieProcesyForm
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
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.dgvProcesy = new System.Windows.Forms.DataGridView();
            this.dgvZaplanowaneProcesy = new System.Windows.Forms.DataGridView();
            this.dgvSkladZamowienia = new System.Windows.Forms.DataGridView();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.cbNazwaProcesu = new System.Windows.Forms.ComboBox();
            this.tbIloscProduktow = new System.Windows.Forms.TextBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataRozpoczecia = new System.Windows.Forms.Label();
            this.txtDataZakonczenia = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.Label();
            this.dtpDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.dtpDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.tbIDSklad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaszyna = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chBEdutuj = new System.Windows.Forms.CheckBox();
            this.cheBRealnaDataRozp = new System.Windows.Forms.CheckBox();
            this.cheBRealnaDataZak = new System.Windows.Forms.CheckBox();
            this.btnKontrolaJakosci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaplanowaneProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(45, 587);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(75, 71);
            this.iBtnNew.TabIndex = 5;
            this.iBtnNew.UseVisualStyleBackColor = true;
            this.iBtnNew.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(148, 587);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(75, 71);
            this.iBtnDelete.TabIndex = 7;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // iBtnEdit
            // 
            this.iBtnEdit.BackColor = System.Drawing.Color.White;
            this.iBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEdit.Location = new System.Drawing.Point(252, 587);
            this.iBtnEdit.Name = "iBtnEdit";
            this.iBtnEdit.Size = new System.Drawing.Size(75, 71);
            this.iBtnEdit.TabIndex = 6;
            this.iBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEdit.UseVisualStyleBackColor = false;
            this.iBtnEdit.Click += new System.EventHandler(this.iBtnEdit_Click);
            // 
            // dgvProcesy
            // 
            this.dgvProcesy.AllowUserToResizeRows = false;
            this.dgvProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesy.Location = new System.Drawing.Point(354, 365);
            this.dgvProcesy.MultiSelect = false;
            this.dgvProcesy.Name = "dgvProcesy";
            this.dgvProcesy.ReadOnly = true;
            this.dgvProcesy.RowHeadersVisible = false;
            this.dgvProcesy.RowHeadersWidth = 51;
            this.dgvProcesy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcesy.Size = new System.Drawing.Size(618, 216);
            this.dgvProcesy.TabIndex = 8;
            this.dgvProcesy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesy_CellContentClick);
            // 
            // dgvZaplanowaneProcesy
            // 
            this.dgvZaplanowaneProcesy.AllowUserToResizeRows = false;
            this.dgvZaplanowaneProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaplanowaneProcesy.Location = new System.Drawing.Point(45, 187);
            this.dgvZaplanowaneProcesy.MultiSelect = false;
            this.dgvZaplanowaneProcesy.Name = "dgvZaplanowaneProcesy";
            this.dgvZaplanowaneProcesy.ReadOnly = true;
            this.dgvZaplanowaneProcesy.RowHeadersVisible = false;
            this.dgvZaplanowaneProcesy.RowHeadersWidth = 51;
            this.dgvZaplanowaneProcesy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaplanowaneProcesy.Size = new System.Drawing.Size(927, 130);
            this.dgvZaplanowaneProcesy.TabIndex = 9;
            this.dgvZaplanowaneProcesy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaplanowaneProcesy_CellClick);
            // 
            // dgvSkladZamowienia
            // 
            this.dgvSkladZamowienia.AllowUserToResizeRows = false;
            this.dgvSkladZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladZamowienia.Location = new System.Drawing.Point(518, 38);
            this.dgvSkladZamowienia.MultiSelect = false;
            this.dgvSkladZamowienia.Name = "dgvSkladZamowienia";
            this.dgvSkladZamowienia.ReadOnly = true;
            this.dgvSkladZamowienia.RowHeadersVisible = false;
            this.dgvSkladZamowienia.RowHeadersWidth = 51;
            this.dgvSkladZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladZamowienia.Size = new System.Drawing.Size(369, 91);
            this.dgvSkladZamowienia.TabIndex = 10;
            this.dgvSkladZamowienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladZamowienia_CellClick);
            this.dgvSkladZamowienia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladZamowienia_CellContentClick);
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(349, 337);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(229, 25);
            this.lblKindWindow.TabIndex = 11;
            this.lblKindWindow.Text = "Proces technologiczny";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Zaplanowane procesy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 13;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvZamowienia
            // 
            this.dgvZamowienia.AllowUserToResizeRows = false;
            this.dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienia.Location = new System.Drawing.Point(45, 38);
            this.dgvZamowienia.MultiSelect = false;
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.ReadOnly = true;
            this.dgvZamowienia.RowHeadersVisible = false;
            this.dgvZamowienia.RowHeadersWidth = 51;
            this.dgvZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZamowienia.Size = new System.Drawing.Size(374, 91);
            this.dgvZamowienia.TabIndex = 14;
            this.dgvZamowienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZamowienia_CellClick);
            // 
            // cbNazwaProcesu
            // 
            this.cbNazwaProcesu.FormattingEnabled = true;
            this.cbNazwaProcesu.Location = new System.Drawing.Point(148, 343);
            this.cbNazwaProcesu.Name = "cbNazwaProcesu";
            this.cbNazwaProcesu.Size = new System.Drawing.Size(192, 21);
            this.cbNazwaProcesu.TabIndex = 15;
            this.cbNazwaProcesu.SelectedIndexChanged += new System.EventHandler(this.cbNazwaProcesu_SelectedIndexChanged);
            this.cbNazwaProcesu.Click += new System.EventHandler(this.cbNazwaProcesu_Click);
            this.cbNazwaProcesu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbNazwaProcesu_MouseClick);
            this.cbNazwaProcesu.MouseCaptureChanged += new System.EventHandler(this.cbNazwaProcesu_MouseCaptureChanged);
            // 
            // tbIloscProduktow
            // 
            this.tbIloscProduktow.Location = new System.Drawing.Point(148, 475);
            this.tbIloscProduktow.Name = "tbIloscProduktow";
            this.tbIloscProduktow.Size = new System.Drawing.Size(192, 20);
            this.tbIloscProduktow.TabIndex = 16;
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(148, 431);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(192, 21);
            this.cbPracownik.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(174, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rodzaj procesu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(177, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pracownik:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDataRozpoczecia
            // 
            this.txtDataRozpoczecia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataRozpoczecia.AutoSize = true;
            this.txtDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDataRozpoczecia.Location = new System.Drawing.Point(174, 498);
            this.txtDataRozpoczecia.Name = "txtDataRozpoczecia";
            this.txtDataRozpoczecia.Size = new System.Drawing.Size(122, 17);
            this.txtDataRozpoczecia.TabIndex = 20;
            this.txtDataRozpoczecia.Text = "Data rozpoczęcia:";
            this.txtDataRozpoczecia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDataZakonczenia
            // 
            this.txtDataZakonczenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataZakonczenia.AutoSize = true;
            this.txtDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDataZakonczenia.Location = new System.Drawing.Point(177, 541);
            this.txtDataZakonczenia.Name = "txtDataZakonczenia";
            this.txtDataZakonczenia.Size = new System.Drawing.Size(125, 17);
            this.txtDataZakonczenia.TabIndex = 21;
            this.txtDataZakonczenia.Text = "Data zakończenia:";
            this.txtDataZakonczenia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIlosc
            // 
            this.txtIlosc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIlosc.AutoSize = true;
            this.txtIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtIlosc.Location = new System.Drawing.Point(174, 455);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(40, 17);
            this.txtIlosc.TabIndex = 22;
            this.txtIlosc.Text = "Ilość:";
            this.txtIlosc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDataRozpoczecia
            // 
            this.dtpDataRozpoczecia.Location = new System.Drawing.Point(148, 518);
            this.dtpDataRozpoczecia.Name = "dtpDataRozpoczecia";
            this.dtpDataRozpoczecia.Size = new System.Drawing.Size(200, 20);
            this.dtpDataRozpoczecia.TabIndex = 23;
            // 
            // dtpDataZakonczenia
            // 
            this.dtpDataZakonczenia.Location = new System.Drawing.Point(148, 561);
            this.dtpDataZakonczenia.Name = "dtpDataZakonczenia";
            this.dtpDataZakonczenia.Size = new System.Drawing.Size(200, 20);
            this.dtpDataZakonczenia.TabIndex = 24;
            // 
            // tbIDSklad
            // 
            this.tbIDSklad.Location = new System.Drawing.Point(63, 343);
            this.tbIDSklad.Name = "tbIDSklad";
            this.tbIDSklad.Size = new System.Drawing.Size(56, 20);
            this.tbIDSklad.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID_Składu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(177, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Maszyna";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbMaszyna
            // 
            this.cbMaszyna.FormattingEnabled = true;
            this.cbMaszyna.Location = new System.Drawing.Point(148, 387);
            this.cbMaszyna.Name = "cbMaszyna";
            this.cbMaszyna.Size = new System.Drawing.Size(192, 21);
            this.cbMaszyna.TabIndex = 28;
            this.cbMaszyna.Click += new System.EventHandler(this.cbMaszyna_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(513, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Skład zamówienia";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(40, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Zamówienia";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chBEdutuj
            // 
            this.chBEdutuj.AutoSize = true;
            this.chBEdutuj.Location = new System.Drawing.Point(269, 164);
            this.chBEdutuj.Name = "chBEdutuj";
            this.chBEdutuj.Size = new System.Drawing.Size(55, 17);
            this.chBEdutuj.TabIndex = 31;
            this.chBEdutuj.Text = "Edytuj";
            this.chBEdutuj.UseVisualStyleBackColor = true;
            this.chBEdutuj.CheckedChanged += new System.EventHandler(this.chBEdutuj_CheckedChanged);
            // 
            // cheBRealnaDataRozp
            // 
            this.cheBRealnaDataRozp.AutoSize = true;
            this.cheBRealnaDataRozp.Location = new System.Drawing.Point(63, 523);
            this.cheBRealnaDataRozp.Name = "cheBRealnaDataRozp";
            this.cheBRealnaDataRozp.Size = new System.Drawing.Size(85, 17);
            this.cheBRealnaDataRozp.TabIndex = 32;
            this.cheBRealnaDataRozp.Text = "Rzeczywista";
            this.cheBRealnaDataRozp.UseVisualStyleBackColor = true;
            this.cheBRealnaDataRozp.CheckedChanged += new System.EventHandler(this.cheBRealnaDataRozp_CheckedChanged);
            // 
            // cheBRealnaDataZak
            // 
            this.cheBRealnaDataZak.AutoSize = true;
            this.cheBRealnaDataZak.Location = new System.Drawing.Point(63, 564);
            this.cheBRealnaDataZak.Name = "cheBRealnaDataZak";
            this.cheBRealnaDataZak.Size = new System.Drawing.Size(85, 17);
            this.cheBRealnaDataZak.TabIndex = 33;
            this.cheBRealnaDataZak.Text = "Rzeczywista";
            this.cheBRealnaDataZak.UseVisualStyleBackColor = true;
            this.cheBRealnaDataZak.CheckedChanged += new System.EventHandler(this.cheBRealnaDataZak_CheckedChanged);
            // 
            // btnKontrolaJakosci
            // 
            this.btnKontrolaJakosci.Location = new System.Drawing.Point(372, 588);
            this.btnKontrolaJakosci.Name = "btnKontrolaJakosci";
            this.btnKontrolaJakosci.Size = new System.Drawing.Size(147, 70);
            this.btnKontrolaJakosci.TabIndex = 34;
            this.btnKontrolaJakosci.Text = "Wyślij do Kontroli jakości";
            this.btnKontrolaJakosci.UseVisualStyleBackColor = true;
            // 
            // PlanowanieProcesyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.btnKontrolaJakosci);
            this.Controls.Add(this.cheBRealnaDataZak);
            this.Controls.Add(this.cheBRealnaDataRozp);
            this.Controls.Add(this.chBEdutuj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMaszyna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIDSklad);
            this.Controls.Add(this.dtpDataZakonczenia);
            this.Controls.Add(this.dtpDataRozpoczecia);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.txtDataZakonczenia);
            this.Controls.Add(this.txtDataRozpoczecia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.tbIloscProduktow);
            this.Controls.Add(this.cbNazwaProcesu);
            this.Controls.Add(this.dgvZamowienia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKindWindow);
            this.Controls.Add(this.dgvSkladZamowienia);
            this.Controls.Add(this.dgvZaplanowaneProcesy);
            this.Controls.Add(this.dgvProcesy);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.iBtnEdit);
            this.Controls.Add(this.iBtnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanowanieProcesyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanowanieProcesyForm";
            this.Load += new System.EventHandler(this.PlanowanieProcesyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaplanowaneProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private System.Windows.Forms.DataGridView dgvProcesy;
        private System.Windows.Forms.DataGridView dgvZaplanowaneProcesy;
        private System.Windows.Forms.DataGridView dgvSkladZamowienia;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvZamowienia;
        private System.Windows.Forms.ComboBox cbNazwaProcesu;
        private System.Windows.Forms.TextBox tbIloscProduktow;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDataRozpoczecia;
        private System.Windows.Forms.Label txtDataZakonczenia;
        private System.Windows.Forms.Label txtIlosc;
        private System.Windows.Forms.DateTimePicker dtpDataRozpoczecia;
        private System.Windows.Forms.DateTimePicker dtpDataZakonczenia;
        private System.Windows.Forms.TextBox tbIDSklad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaszyna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chBEdutuj;
        private System.Windows.Forms.CheckBox cheBRealnaDataRozp;
        private System.Windows.Forms.CheckBox cheBRealnaDataZak;
        private System.Windows.Forms.Button btnKontrolaJakosci;
    }
}