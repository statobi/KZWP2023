using System;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    partial class DodajTransportWewnetrznyForm
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
            this.panelMove = new System.Windows.Forms.Panel();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.dDataRealizacjiTransportu = new System.Windows.Forms.DateTimePicker();
            this.cb_magazyn_poczatkowy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID_zlecenie_magazynowe = new System.Windows.Forms.Label();
            this.cb_magazyn_koncowy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Zlecenie_magazynowe = new System.Windows.Forms.ComboBox();
            this.cb_pracownik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_pojazd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_dodaj_transport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_sprawdz_stan = new System.Windows.Forms.Label();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Controls.Add(this.lblKindWindow);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Margin = new System.Windows.Forms.Padding(2);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(604, 49);
            this.panelMove.TabIndex = 46;
            this.panelMove.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMove_Paint);
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(124, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(334, 25);
            this.lblKindWindow.TabIndex = 3;
            this.lblKindWindow.Text = "Dodaj nowy transport wewnętrzny";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dDataRealizacjiTransportu
            // 
            this.dDataRealizacjiTransportu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dDataRealizacjiTransportu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dDataRealizacjiTransportu.Location = new System.Drawing.Point(224, 287);
            this.dDataRealizacjiTransportu.Margin = new System.Windows.Forms.Padding(2);
            this.dDataRealizacjiTransportu.Name = "dDataRealizacjiTransportu";
            this.dDataRealizacjiTransportu.Size = new System.Drawing.Size(338, 26);
            this.dDataRealizacjiTransportu.TabIndex = 52;
            // 
            // cb_magazyn_poczatkowy
            // 
            this.cb_magazyn_poczatkowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_magazyn_poczatkowy.FormattingEnabled = true;
            this.cb_magazyn_poczatkowy.Location = new System.Drawing.Point(224, 127);
            this.cb_magazyn_poczatkowy.Margin = new System.Windows.Forms.Padding(2);
            this.cb_magazyn_poczatkowy.Name = "cb_magazyn_poczatkowy";
            this.cb_magazyn_poczatkowy.Size = new System.Drawing.Size(338, 30);
            this.cb_magazyn_poczatkowy.TabIndex = 51;
            this.cb_magazyn_poczatkowy.SelectedIndexChanged += new System.EventHandler(this.cb_magazyn_poczatkowy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "Data realizacji: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Magazyn początkowy: *";
            // 
            // lblID_zlecenie_magazynowe
            // 
            this.lblID_zlecenie_magazynowe.AutoSize = true;
            this.lblID_zlecenie_magazynowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID_zlecenie_magazynowe.Location = new System.Drawing.Point(10, 91);
            this.lblID_zlecenie_magazynowe.Name = "lblID_zlecenie_magazynowe";
            this.lblID_zlecenie_magazynowe.Size = new System.Drawing.Size(218, 24);
            this.lblID_zlecenie_magazynowe.TabIndex = 48;
            this.lblID_zlecenie_magazynowe.Text = "Zlecenie magazynowe: *";
            // 
            // cb_magazyn_koncowy
            // 
            this.cb_magazyn_koncowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_magazyn_koncowy.FormattingEnabled = true;
            this.cb_magazyn_koncowy.Location = new System.Drawing.Point(224, 166);
            this.cb_magazyn_koncowy.Margin = new System.Windows.Forms.Padding(2);
            this.cb_magazyn_koncowy.Name = "cb_magazyn_koncowy";
            this.cb_magazyn_koncowy.Size = new System.Drawing.Size(338, 30);
            this.cb_magazyn_koncowy.TabIndex = 54;
            this.cb_magazyn_koncowy.SelectedIndexChanged += new System.EventHandler(this.cb_magazyn_koncowy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Magazyn końcowy: *";
            // 
            // cb_Zlecenie_magazynowe
            // 
            this.cb_Zlecenie_magazynowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Zlecenie_magazynowe.FormattingEnabled = true;
            this.cb_Zlecenie_magazynowe.Location = new System.Drawing.Point(224, 91);
            this.cb_Zlecenie_magazynowe.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Zlecenie_magazynowe.Name = "cb_Zlecenie_magazynowe";
            this.cb_Zlecenie_magazynowe.Size = new System.Drawing.Size(338, 30);
            this.cb_Zlecenie_magazynowe.TabIndex = 55;
            this.cb_Zlecenie_magazynowe.SelectedIndexChanged += new System.EventHandler(this.cb_Zlecenie_magazynowe_SelectedIndexChanged);
            // 
            // cb_pracownik
            // 
            this.cb_pracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_pracownik.FormattingEnabled = true;
            this.cb_pracownik.Location = new System.Drawing.Point(224, 203);
            this.cb_pracownik.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pracownik.Name = "cb_pracownik";
            this.cb_pracownik.Size = new System.Drawing.Size(338, 30);
            this.cb_pracownik.TabIndex = 57;
            this.cb_pracownik.SelectedIndexChanged += new System.EventHandler(this.cb_pracownik_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Kierowca: *";
            // 
            // cb_pojazd
            // 
            this.cb_pojazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_pojazd.FormattingEnabled = true;
            this.cb_pojazd.Location = new System.Drawing.Point(224, 240);
            this.cb_pojazd.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pojazd.Name = "cb_pojazd";
            this.cb_pojazd.Size = new System.Drawing.Size(338, 30);
            this.cb_pojazd.TabIndex = 59;
            this.cb_pojazd.SelectedIndexChanged += new System.EventHandler(this.cb_pojazd_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Pojazd: *";
            // 
            // btn_dodaj_transport
            // 
            this.btn_dodaj_transport.Location = new System.Drawing.Point(401, 387);
            this.btn_dodaj_transport.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj_transport.Name = "btn_dodaj_transport";
            this.btn_dodaj_transport.Size = new System.Drawing.Size(160, 51);
            this.btn_dodaj_transport.TabIndex = 60;
            this.btn_dodaj_transport.Text = "Dodaj transport";
            this.btn_dodaj_transport.UseVisualStyleBackColor = true;
            this.btn_dodaj_transport.Click += new System.EventHandler(this.btn_dodaj_transport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Wymagane *";
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(224, 387);
            this.btn_anuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(153, 50);
            this.btn_anuluj.TabIndex = 62;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "ObjPojazdu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "NosnoscPojazdu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "objProdukt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(470, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 70;
            this.label13.Text = "label13";
            // 
            // lbl_sprawdz_stan
            // 
            this.lbl_sprawdz_stan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sprawdz_stan.AutoSize = true;
            this.lbl_sprawdz_stan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_sprawdz_stan.Location = new System.Drawing.Point(20, 51);
            this.lbl_sprawdz_stan.Name = "lbl_sprawdz_stan";
            this.lbl_sprawdz_stan.Size = new System.Drawing.Size(68, 25);
            this.lbl_sprawdz_stan.TabIndex = 71;
            this.lbl_sprawdz_stan.Text = "STAN";
            this.lbl_sprawdz_stan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DodajTransportWewnetrznyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 462);
            this.Controls.Add(this.lbl_sprawdz_stan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_dodaj_transport);
            this.Controls.Add(this.cb_pojazd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_pracownik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Zlecenie_magazynowe);
            this.Controls.Add(this.cb_magazyn_koncowy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dDataRealizacjiTransportu);
            this.Controls.Add(this.cb_magazyn_poczatkowy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID_zlecenie_magazynowe);
            this.Controls.Add(this.panelMove);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajTransportWewnetrznyForm";
            this.Text = "TransportWewnetrznyCU";
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.DateTimePicker dDataRealizacjiTransportu;
        private System.Windows.Forms.ComboBox cb_magazyn_poczatkowy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID_zlecenie_magazynowe;
        private System.Windows.Forms.ComboBox cb_magazyn_koncowy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Zlecenie_magazynowe;
        private System.Windows.Forms.ComboBox cb_pracownik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_pojazd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dodaj_transport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_sprawdz_stan;
    }
}