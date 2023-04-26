namespace IDEA.App
{
    partial class AFFakturyCU
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
            this.txtID_Faktury = new System.Windows.Forms.TextBox();
            this.lblID_Faktury = new System.Windows.Forms.Label();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwa_Podmiotu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKwota_Netto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.maskTxtKod = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTermin_Platnosci = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKwota_Brutto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbRodzajFaktury = new System.Windows.Forms.ComboBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.cbStanFaktury = new System.Windows.Forms.ComboBox();
            this.dDataWplywu = new System.Windows.Forms.DateTimePicker();
            this.dDataZaplaty = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtID_Faktury
            // 
            this.txtID_Faktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtID_Faktury.Location = new System.Drawing.Point(175, 58);
            this.txtID_Faktury.Name = "txtID_Faktury";
            this.txtID_Faktury.Size = new System.Drawing.Size(373, 29);
            this.txtID_Faktury.TabIndex = 0;
            this.txtID_Faktury.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            // 
            // lblID_Faktury
            // 
            this.lblID_Faktury.AutoSize = true;
            this.lblID_Faktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID_Faktury.Location = new System.Drawing.Point(12, 61);
            this.lblID_Faktury.Name = "lblID_Faktury";
            this.lblID_Faktury.Size = new System.Drawing.Size(98, 24);
            this.lblID_Faktury.TabIndex = 1;
            this.lblID_Faktury.Text = "ID Faktury:";
            this.lblID_Faktury.Click += new System.EventHandler(this.lblImie_Click);
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(170, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(262, 25);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Dodawanie Nowej Faktury";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKindWindow.Click += new System.EventHandler(this.lblKindWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rodzaj Faktury:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwa Podmiotu:";
            // 
            // txtNazwa_Podmiotu
            // 
            this.txtNazwa_Podmiotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa_Podmiotu.Location = new System.Drawing.Point(175, 236);
            this.txtNazwa_Podmiotu.Name = "txtNazwa_Podmiotu";
            this.txtNazwa_Podmiotu.Size = new System.Drawing.Size(373, 29);
            this.txtNazwa_Podmiotu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIP:";
            // 
            // txtNIP
            // 
            this.txtNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNIP.Location = new System.Drawing.Point(175, 273);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(373, 29);
            this.txtNIP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ulica:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUlica.Location = new System.Drawing.Point(175, 308);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(373, 29);
            this.txtUlica.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kod Pocztowy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Miasto:";
            // 
            // txtMiasto
            // 
            this.txtMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMiasto.Location = new System.Drawing.Point(175, 376);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(373, 29);
            this.txtMiasto.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kwota Netto:";
            // 
            // txtKwota_Netto
            // 
            this.txtKwota_Netto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKwota_Netto.Location = new System.Drawing.Point(175, 411);
            this.txtKwota_Netto.Name = "txtKwota_Netto";
            this.txtKwota_Netto.Size = new System.Drawing.Size(373, 29);
            this.txtKwota_Netto.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Stan Faktury:";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(175, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(473, 582);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // maskTxtKod
            // 
            this.maskTxtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskTxtKod.Location = new System.Drawing.Point(175, 344);
            this.maskTxtKod.Mask = "00-000";
            this.maskTxtKod.Name = "maskTxtKod";
            this.maskTxtKod.Size = new System.Drawing.Size(83, 26);
            this.maskTxtKod.TabIndex = 23;
            this.maskTxtKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Data Wpływu:";
            // 
            // txtTermin_Platnosci
            // 
            this.txtTermin_Platnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTermin_Platnosci.Location = new System.Drawing.Point(175, 166);
            this.txtTermin_Platnosci.Name = "txtTermin_Platnosci";
            this.txtTermin_Platnosci.Size = new System.Drawing.Size(373, 29);
            this.txtTermin_Platnosci.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Termin Płatności:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Pracownik:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(12, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "Kwota Brutto:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtKwota_Brutto
            // 
            this.txtKwota_Brutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKwota_Brutto.Location = new System.Drawing.Point(175, 446);
            this.txtKwota_Brutto.Name = "txtKwota_Brutto";
            this.txtKwota_Brutto.Size = new System.Drawing.Size(373, 29);
            this.txtKwota_Brutto.TabIndex = 30;
            this.txtKwota_Brutto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(12, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 24);
            this.label13.TabIndex = 33;
            this.label13.Text = "Data Zapłaty:";
            // 
            // cbRodzajFaktury
            // 
            this.cbRodzajFaktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRodzajFaktury.FormattingEnabled = true;
            this.cbRodzajFaktury.Location = new System.Drawing.Point(175, 96);
            this.cbRodzajFaktury.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajFaktury.Name = "cbRodzajFaktury";
            this.cbRodzajFaktury.Size = new System.Drawing.Size(373, 30);
            this.cbRodzajFaktury.TabIndex = 34;
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(175, 201);
            this.cbPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(373, 30);
            this.cbPracownik.TabIndex = 35;
            // 
            // cbStanFaktury
            // 
            this.cbStanFaktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStanFaktury.FormattingEnabled = true;
            this.cbStanFaktury.Location = new System.Drawing.Point(175, 519);
            this.cbStanFaktury.Margin = new System.Windows.Forms.Padding(2);
            this.cbStanFaktury.Name = "cbStanFaktury";
            this.cbStanFaktury.Size = new System.Drawing.Size(373, 30);
            this.cbStanFaktury.TabIndex = 36;
            // 
            // dDataWplywu
            // 
            this.dDataWplywu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dDataWplywu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dDataWplywu.Location = new System.Drawing.Point(175, 135);
            this.dDataWplywu.Margin = new System.Windows.Forms.Padding(2);
            this.dDataWplywu.Name = "dDataWplywu";
            this.dDataWplywu.Size = new System.Drawing.Size(373, 26);
            this.dDataWplywu.TabIndex = 37;
            // 
            // dDataZaplaty
            // 
            this.dDataZaplaty.CustomFormat = "\"yyyy-MM-dd\"";
            this.dDataZaplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dDataZaplaty.Location = new System.Drawing.Point(175, 484);
            this.dDataZaplaty.Margin = new System.Windows.Forms.Padding(2);
            this.dDataZaplaty.Name = "dDataZaplaty";
            this.dDataZaplaty.Size = new System.Drawing.Size(373, 26);
            this.dDataZaplaty.TabIndex = 38;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(553, 484);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(36, 40);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AFFakturyCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 646);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dDataZaplaty);
            this.Controls.Add(this.dDataWplywu);
            this.Controls.Add(this.cbStanFaktury);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.cbRodzajFaktury);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtKwota_Brutto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTermin_Platnosci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskTxtKod);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKwota_Netto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwa_Podmiotu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKindWindow);
            this.Controls.Add(this.lblID_Faktury);
            this.Controls.Add(this.txtID_Faktury);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AFFakturyCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.Load += new System.EventHandler(this.AFKlienciCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID_Faktury;
        private System.Windows.Forms.Label lblID_Faktury;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwa_Podmiotu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKwota_Netto;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.MaskedTextBox maskTxtKod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTermin_Platnosci;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKwota_Brutto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbRodzajFaktury;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.ComboBox cbStanFaktury;
        private System.Windows.Forms.DateTimePicker dDataWplywu;
        private System.Windows.Forms.DateTimePicker dDataZaplaty;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}