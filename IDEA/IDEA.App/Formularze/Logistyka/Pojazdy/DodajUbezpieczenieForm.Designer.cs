namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    partial class DodajUbezpieczenieForm
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
            this.cb_rodzajUbezpieczenia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ubezpieczyciel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dDataZakupuUbezpieczenia = new System.Windows.Forms.DateTimePicker();
            this.cb_Pojazd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKosztNetto = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.txt_kosztBrutto = new System.Windows.Forms.TextBox();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_dodaj_ubezpieczenie = new System.Windows.Forms.Button();
            this.dataWaznosciUbezpieczenia = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_rodzajUbezpieczenia
            // 
            this.cb_rodzajUbezpieczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_rodzajUbezpieczenia.FormattingEnabled = true;
            this.cb_rodzajUbezpieczenia.Location = new System.Drawing.Point(259, 147);
            this.cb_rodzajUbezpieczenia.Margin = new System.Windows.Forms.Padding(2);
            this.cb_rodzajUbezpieczenia.Name = "cb_rodzajUbezpieczenia";
            this.cb_rodzajUbezpieczenia.Size = new System.Drawing.Size(340, 30);
            this.cb_rodzajUbezpieczenia.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(52, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Rodzaj ubezpieczenia:";
            // 
            // cb_ubezpieczyciel
            // 
            this.cb_ubezpieczyciel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_ubezpieczyciel.FormattingEnabled = true;
            this.cb_ubezpieczyciel.Location = new System.Drawing.Point(260, 110);
            this.cb_ubezpieczyciel.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ubezpieczyciel.Name = "cb_ubezpieczyciel";
            this.cb_ubezpieczyciel.Size = new System.Drawing.Size(338, 30);
            this.cb_ubezpieczyciel.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Ubezpieczyciel:";
            // 
            // dDataZakupuUbezpieczenia
            // 
            this.dDataZakupuUbezpieczenia.CustomFormat = "\"yyyy-MM-dd\"";
            this.dDataZakupuUbezpieczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dDataZakupuUbezpieczenia.Location = new System.Drawing.Point(259, 188);
            this.dDataZakupuUbezpieczenia.Margin = new System.Windows.Forms.Padding(2);
            this.dDataZakupuUbezpieczenia.Name = "dDataZakupuUbezpieczenia";
            this.dDataZakupuUbezpieczenia.Size = new System.Drawing.Size(338, 26);
            this.dDataZakupuUbezpieczenia.TabIndex = 75;
            // 
            // cb_Pojazd
            // 
            this.cb_Pojazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Pojazd.FormattingEnabled = true;
            this.cb_Pojazd.Location = new System.Drawing.Point(260, 71);
            this.cb_Pojazd.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Pojazd.Name = "cb_Pojazd";
            this.cb_Pojazd.Size = new System.Drawing.Size(338, 30);
            this.cb_Pojazd.TabIndex = 74;
            this.cb_Pojazd.SelectedIndexChanged += new System.EventHandler(this.cb_Pojazd_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(52, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 73;
            this.label6.Text = "Data zakupu: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Pojazd: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(52, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 85;
            this.label5.Text = "Koszt netto: *";
            // 
            // txtKosztNetto
            // 
            this.txtKosztNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKosztNetto.Location = new System.Drawing.Point(260, 293);
            this.txtKosztNetto.MaxLength = 30;
            this.txtKosztNetto.Name = "txtKosztNetto";
            this.txtKosztNetto.Size = new System.Drawing.Size(339, 29);
            this.txtKosztNetto.TabIndex = 84;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(52, 261);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(124, 24);
            this.lblImie.TabIndex = 83;
            this.lblImie.Text = "Koszt brutto: *";
            // 
            // txt_kosztBrutto
            // 
            this.txt_kosztBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_kosztBrutto.Location = new System.Drawing.Point(260, 258);
            this.txt_kosztBrutto.MaxLength = 30;
            this.txt_kosztBrutto.Name = "txt_kosztBrutto";
            this.txt_kosztBrutto.Size = new System.Drawing.Size(339, 29);
            this.txt_kosztBrutto.TabIndex = 82;
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(204, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(270, 25);
            this.lblKindWindow.TabIndex = 3;
            this.lblKindWindow.Text = "Dodaj nowe ubezpieczenie";
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
            this.panelMove.Size = new System.Drawing.Size(764, 49);
            this.panelMove.TabIndex = 86;
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(260, 363);
            this.btn_anuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(153, 50);
            this.btn_anuluj.TabIndex = 90;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(46, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 89;
            this.label8.Text = "Wymagane *";
            // 
            // btn_dodaj_ubezpieczenie
            // 
            this.btn_dodaj_ubezpieczenie.Location = new System.Drawing.Point(437, 363);
            this.btn_dodaj_ubezpieczenie.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj_ubezpieczenie.Name = "btn_dodaj_ubezpieczenie";
            this.btn_dodaj_ubezpieczenie.Size = new System.Drawing.Size(160, 51);
            this.btn_dodaj_ubezpieczenie.TabIndex = 88;
            this.btn_dodaj_ubezpieczenie.Text = "Dodaj ubezpieczenie";
            this.btn_dodaj_ubezpieczenie.UseVisualStyleBackColor = true;
            this.btn_dodaj_ubezpieczenie.Click += new System.EventHandler(this.btn_dodaj_ubezpieczenie_Click);
            // 
            // dataWaznosciUbezpieczenia
            // 
            this.dataWaznosciUbezpieczenia.CustomFormat = "\"yyyy-MM-dd\"";
            this.dataWaznosciUbezpieczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataWaznosciUbezpieczenia.Location = new System.Drawing.Point(261, 227);
            this.dataWaznosciUbezpieczenia.Margin = new System.Windows.Forms.Padding(2);
            this.dataWaznosciUbezpieczenia.Name = "dataWaznosciUbezpieczenia";
            this.dataWaznosciUbezpieczenia.Size = new System.Drawing.Size(338, 26);
            this.dataWaznosciUbezpieczenia.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(52, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 91;
            this.label4.Text = "Data ważności: *";
            // 
            // DodajUbezpieczenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 507);
            this.Controls.Add(this.dataWaznosciUbezpieczenia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_dodaj_ubezpieczenie);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKosztNetto);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.txt_kosztBrutto);
            this.Controls.Add(this.cb_rodzajUbezpieczenia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ubezpieczyciel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dDataZakupuUbezpieczenia);
            this.Controls.Add(this.cb_Pojazd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "DodajUbezpieczenieForm";
            this.Text = "DodajUbezpieczenieForm";
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_rodzajUbezpieczenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ubezpieczyciel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dDataZakupuUbezpieczenia;
        private System.Windows.Forms.ComboBox cb_Pojazd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKosztNetto;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox txt_kosztBrutto;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_dodaj_ubezpieczenie;
        private System.Windows.Forms.DateTimePicker dataWaznosciUbezpieczenia;
        private System.Windows.Forms.Label label4;
    }
}