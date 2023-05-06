namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    partial class DodajPojazdForm
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
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_dodaj_pojazd = new System.Windows.Forms.Button();
            this.lblImie = new System.Windows.Forms.Label();
            this.txt_stanLicznika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dDataPrzychodu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dRokProdukcji = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nr_rejestracyjny = new System.Windows.Forms.TextBox();
            this.btn_nowy_model = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_ModelPojazdu = new System.Windows.Forms.ComboBox();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.dDataRozchodu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_aktywuj_date_rozchodu = new System.Windows.Forms.CheckBox();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(300, 349);
            this.btn_anuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(153, 50);
            this.btn_anuluj.TabIndex = 107;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 106;
            this.label8.Text = "Wymagane *";
            // 
            // btn_dodaj_pojazd
            // 
            this.btn_dodaj_pojazd.Location = new System.Drawing.Point(478, 348);
            this.btn_dodaj_pojazd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj_pojazd.Name = "btn_dodaj_pojazd";
            this.btn_dodaj_pojazd.Size = new System.Drawing.Size(160, 51);
            this.btn_dodaj_pojazd.TabIndex = 105;
            this.btn_dodaj_pojazd.Text = "Dodaj pojazd";
            this.btn_dodaj_pojazd.UseVisualStyleBackColor = true;
            this.btn_dodaj_pojazd.Click += new System.EventHandler(this.btn_dodaj_pojazd_Click);
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(86, 154);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(130, 24);
            this.lblImie.TabIndex = 102;
            this.lblImie.Text = "Stan licznika: *";
            // 
            // txt_stanLicznika
            // 
            this.txt_stanLicznika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_stanLicznika.Location = new System.Drawing.Point(296, 154);
            this.txt_stanLicznika.MaxLength = 30;
            this.txt_stanLicznika.Name = "txt_stanLicznika";
            this.txt_stanLicznika.Size = new System.Drawing.Size(343, 29);
            this.txt_stanLicznika.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(85, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 99;
            this.label3.Text = "Numer rejestracyjny:*";
            // 
            // dDataPrzychodu
            // 
            this.dDataPrzychodu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dDataPrzychodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dDataPrzychodu.Location = new System.Drawing.Point(296, 238);
            this.dDataPrzychodu.Margin = new System.Windows.Forms.Padding(2);
            this.dDataPrzychodu.Name = "dDataPrzychodu";
            this.dDataPrzychodu.Size = new System.Drawing.Size(343, 26);
            this.dDataPrzychodu.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(85, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 94;
            this.label6.Text = "Data przychodu:*";
            // 
            // dRokProdukcji
            // 
            this.dRokProdukcji.CustomFormat = "\"yyyy-MM-dd\"";
            this.dRokProdukcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dRokProdukcji.Location = new System.Drawing.Point(296, 197);
            this.dRokProdukcji.Margin = new System.Windows.Forms.Padding(2);
            this.dRokProdukcji.Name = "dRokProdukcji";
            this.dRokProdukcji.Size = new System.Drawing.Size(341, 26);
            this.dRokProdukcji.TabIndex = 109;
            this.dRokProdukcji.Value = new System.DateTime(2018, 1, 1, 22, 26, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(86, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 108;
            this.label4.Text = "Rok produkcji:*";
            // 
            // txt_nr_rejestracyjny
            // 
            this.txt_nr_rejestracyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_nr_rejestracyjny.Location = new System.Drawing.Point(296, 81);
            this.txt_nr_rejestracyjny.MaxLength = 30;
            this.txt_nr_rejestracyjny.Name = "txt_nr_rejestracyjny";
            this.txt_nr_rejestracyjny.Size = new System.Drawing.Size(342, 29);
            this.txt_nr_rejestracyjny.TabIndex = 121;
            // 
            // btn_nowy_model
            // 
            this.btn_nowy_model.Location = new System.Drawing.Point(660, 107);
            this.btn_nowy_model.Name = "btn_nowy_model";
            this.btn_nowy_model.Size = new System.Drawing.Size(119, 50);
            this.btn_nowy_model.TabIndex = 124;
            this.btn_nowy_model.Text = "Dodaj nowy model pojazdu";
            this.btn_nowy_model.UseVisualStyleBackColor = true;
            this.btn_nowy_model.Click += new System.EventHandler(this.btn_nowy_model_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(86, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 24);
            this.label12.TabIndex = 122;
            this.label12.Text = "Model pojazdu: *";
            // 
            // cb_ModelPojazdu
            // 
            this.cb_ModelPojazdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_ModelPojazdu.FormattingEnabled = true;
            this.cb_ModelPojazdu.Location = new System.Drawing.Point(296, 115);
            this.cb_ModelPojazdu.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ModelPojazdu.Name = "cb_ModelPojazdu";
            this.cb_ModelPojazdu.Size = new System.Drawing.Size(342, 30);
            this.cb_ModelPojazdu.TabIndex = 123;
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(279, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(194, 25);
            this.lblKindWindow.TabIndex = 3;
            this.lblKindWindow.Text = "Dodaj nowy pojazd";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Controls.Add(this.lblKindWindow);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Margin = new System.Windows.Forms.Padding(2);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(796, 49);
            this.panelMove.TabIndex = 118;
            // 
            // dDataRozchodu
            // 
            this.dDataRozchodu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dDataRozchodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dDataRozchodu.Location = new System.Drawing.Point(296, 283);
            this.dDataRozchodu.Margin = new System.Windows.Forms.Padding(2);
            this.dDataRozchodu.Name = "dDataRozchodu";
            this.dDataRozchodu.Size = new System.Drawing.Size(343, 26);
            this.dDataRozchodu.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(85, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 125;
            this.label1.Text = "Data rozchodu:*";
            // 
            // cbx_aktywuj_date_rozchodu
            // 
            this.cbx_aktywuj_date_rozchodu.AutoSize = true;
            this.cbx_aktywuj_date_rozchodu.Location = new System.Drawing.Point(653, 289);
            this.cbx_aktywuj_date_rozchodu.Name = "cbx_aktywuj_date_rozchodu";
            this.cbx_aktywuj_date_rozchodu.Size = new System.Drawing.Size(63, 17);
            this.cbx_aktywuj_date_rozchodu.TabIndex = 127;
            this.cbx_aktywuj_date_rozchodu.Text = "Aktywuj";
            this.cbx_aktywuj_date_rozchodu.UseVisualStyleBackColor = true;
            this.cbx_aktywuj_date_rozchodu.CheckedChanged += new System.EventHandler(this.cbx_aktywuj_date_rozchodu_CheckedChanged);
            // 
            // DodajPojazdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 444);
            this.Controls.Add(this.cbx_aktywuj_date_rozchodu);
            this.Controls.Add(this.dDataRozchodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nowy_model);
            this.Controls.Add(this.cb_ModelPojazdu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_nr_rejestracyjny);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.dRokProdukcji);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_dodaj_pojazd);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.txt_stanLicznika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dDataPrzychodu);
            this.Controls.Add(this.label6);
            this.Name = "DodajPojazdForm";
            this.Text = "DodajPojazdForm";
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_dodaj_pojazd;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox txt_stanLicznika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dDataPrzychodu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dRokProdukcji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nr_rejestracyjny;
        private System.Windows.Forms.Button btn_nowy_model;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_ModelPojazdu;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.DateTimePicker dDataRozchodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_aktywuj_date_rozchodu;
    }
}