namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    partial class DodajPrzegladForm
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
            this.cb_Pojazd = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dWykonaniaPrzegladu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dDataWaznosci = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kosztBrutto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KosztNetto = new System.Windows.Forms.TextBox();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_dodaj_przeglad = new System.Windows.Forms.Button();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Pojazd
            // 
            this.cb_Pojazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Pojazd.FormattingEnabled = true;
            this.cb_Pojazd.Location = new System.Drawing.Point(318, 78);
            this.cb_Pojazd.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Pojazd.Name = "cb_Pojazd";
            this.cb_Pojazd.Size = new System.Drawing.Size(342, 30);
            this.cb_Pojazd.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(108, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 24);
            this.label12.TabIndex = 126;
            this.label12.Text = "Pojazd: *";
            // 
            // dWykonaniaPrzegladu
            // 
            this.dWykonaniaPrzegladu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dWykonaniaPrzegladu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dWykonaniaPrzegladu.Location = new System.Drawing.Point(319, 123);
            this.dWykonaniaPrzegladu.Margin = new System.Windows.Forms.Padding(2);
            this.dWykonaniaPrzegladu.Name = "dWykonaniaPrzegladu";
            this.dWykonaniaPrzegladu.Size = new System.Drawing.Size(341, 26);
            this.dWykonaniaPrzegladu.TabIndex = 131;
            this.dWykonaniaPrzegladu.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(109, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 130;
            this.label4.Text = "Data wykonania: *";
            // 
            // dDataWaznosci
            // 
            this.dDataWaznosci.CustomFormat = "\"yyyy-MM-dd\"";
            this.dDataWaznosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dDataWaznosci.Location = new System.Drawing.Point(319, 164);
            this.dDataWaznosci.Margin = new System.Windows.Forms.Padding(2);
            this.dDataWaznosci.Name = "dDataWaznosci";
            this.dDataWaznosci.Size = new System.Drawing.Size(343, 26);
            this.dDataWaznosci.TabIndex = 129;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(108, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 128;
            this.label6.Text = "Data ważności: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(109, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 133;
            this.label1.Text = "Koszt brutto: *";
            // 
            // txt_kosztBrutto
            // 
            this.txt_kosztBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_kosztBrutto.Location = new System.Drawing.Point(319, 204);
            this.txt_kosztBrutto.MaxLength = 30;
            this.txt_kosztBrutto.Name = "txt_kosztBrutto";
            this.txt_kosztBrutto.Size = new System.Drawing.Size(343, 29);
            this.txt_kosztBrutto.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(109, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 135;
            this.label2.Text = "Koszt netto: *";
            // 
            // txt_KosztNetto
            // 
            this.txt_KosztNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_KosztNetto.Location = new System.Drawing.Point(319, 248);
            this.txt_KosztNetto.MaxLength = 30;
            this.txt_KosztNetto.Name = "txt_KosztNetto";
            this.txt_KosztNetto.Size = new System.Drawing.Size(343, 29);
            this.txt_KosztNetto.TabIndex = 134;
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(281, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(213, 25);
            this.lblKindWindow.TabIndex = 3;
            this.lblKindWindow.Text = "Dodaj nowy przegląd";
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
            this.panelMove.Size = new System.Drawing.Size(800, 49);
            this.panelMove.TabIndex = 136;
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(319, 306);
            this.btn_anuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(153, 50);
            this.btn_anuluj.TabIndex = 139;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(31, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 138;
            this.label8.Text = "Wymagane *";
            // 
            // btn_dodaj_przeglad
            // 
            this.btn_dodaj_przeglad.Location = new System.Drawing.Point(497, 305);
            this.btn_dodaj_przeglad.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj_przeglad.Name = "btn_dodaj_przeglad";
            this.btn_dodaj_przeglad.Size = new System.Drawing.Size(160, 51);
            this.btn_dodaj_przeglad.TabIndex = 137;
            this.btn_dodaj_przeglad.Text = "Dodaj przegląd";
            this.btn_dodaj_przeglad.UseVisualStyleBackColor = true;
            this.btn_dodaj_przeglad.Click += new System.EventHandler(this.btn_dodaj_przeglad_Click);
            // 
            // DodajPrzegladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_dodaj_przeglad);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_KosztNetto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kosztBrutto);
            this.Controls.Add(this.dWykonaniaPrzegladu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dDataWaznosci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Pojazd);
            this.Controls.Add(this.label12);
            this.Name = "DodajPrzegladForm";
            this.Text = "DodajPrzegladForm";
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Pojazd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dWykonaniaPrzegladu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dDataWaznosci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kosztBrutto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KosztNetto;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_dodaj_przeglad;
    }
}