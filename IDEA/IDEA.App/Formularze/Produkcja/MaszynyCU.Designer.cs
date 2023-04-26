namespace IDEA.App.Formularze.Produkcja
{
    partial class MaszynyCU
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
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbolMaszyny = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkaMaszyny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDataPrzychodu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDataRozchodu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.cbRodzajStrategiiEksploatacji = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParametrMaszyny = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWartoscMinimalnaParametru = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWartoscMaksymalnaParametru = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWartoscNominalnaParametru = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrzebiegPoczatkowy = new System.Windows.Forms.TextBox();
            this.txtKosztRoboczogodziny = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumerNormy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDodajRodzMaszyny = new System.Windows.Forms.Button();
            this.cbRodzajMaszyny = new System.Windows.Forms.ComboBox();
            this.cbModelMaszyny = new System.Windows.Forms.ComboBox();
            this.btnDodajModelMaszyny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(302, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(276, 25);
            this.lblKindWindow.TabIndex = 3;
            this.lblKindWindow.Text = "Dodawanie Nowej Maszyny";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(10, 73);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(146, 24);
            this.lblImie.TabIndex = 4;
            this.lblImie.Text = "Rodzaj maszyny";
            this.lblImie.Click += new System.EventHandler(this.lblImie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Symbol maszyny";
            // 
            // txtSymbolMaszyny
            // 
            this.txtSymbolMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSymbolMaszyny.Location = new System.Drawing.Point(310, 142);
            this.txtSymbolMaszyny.Name = "txtSymbolMaszyny";
            this.txtSymbolMaszyny.Size = new System.Drawing.Size(373, 29);
            this.txtSymbolMaszyny.TabIndex = 7;
            this.txtSymbolMaszyny.TextChanged += new System.EventHandler(this.txtSymbolMaszyny_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marka maszyny";
            // 
            // txtMarkaMaszyny
            // 
            this.txtMarkaMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMarkaMaszyny.Location = new System.Drawing.Point(310, 177);
            this.txtMarkaMaszyny.Name = "txtMarkaMaszyny";
            this.txtMarkaMaszyny.Size = new System.Drawing.Size(373, 29);
            this.txtMarkaMaszyny.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model maszyny";
            // 
            // dateDataPrzychodu
            // 
            this.dateDataPrzychodu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataPrzychodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataPrzychodu.Location = new System.Drawing.Point(310, 290);
            this.dateDataPrzychodu.Margin = new System.Windows.Forms.Padding(2);
            this.dateDataPrzychodu.Name = "dateDataPrzychodu";
            this.dateDataPrzychodu.Size = new System.Drawing.Size(340, 26);
            this.dateDataPrzychodu.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Data przychodu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateDataRozchodu
            // 
            this.dateDataRozchodu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataRozchodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataRozchodu.Location = new System.Drawing.Point(310, 328);
            this.dateDataRozchodu.Margin = new System.Windows.Forms.Padding(2);
            this.dateDataRozchodu.Name = "dateDataRozchodu";
            this.dateDataRozchodu.Size = new System.Drawing.Size(340, 26);
            this.dateDataRozchodu.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Data rozchodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Rodzaj strategii eksploatacji";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(708, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(627, 583);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 35;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbRodzajStrategiiEksploatacji
            // 
            this.cbRodzajStrategiiEksploatacji.FormattingEnabled = true;
            this.cbRodzajStrategiiEksploatacji.Location = new System.Drawing.Point(310, 374);
            this.cbRodzajStrategiiEksploatacji.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajStrategiiEksploatacji.Name = "cbRodzajStrategiiEksploatacji";
            this.cbRodzajStrategiiEksploatacji.Size = new System.Drawing.Size(373, 21);
            this.cbRodzajStrategiiEksploatacji.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(10, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Parametr maszyny";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtParametrMaszyny
            // 
            this.txtParametrMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParametrMaszyny.Location = new System.Drawing.Point(310, 406);
            this.txtParametrMaszyny.Name = "txtParametrMaszyny";
            this.txtParametrMaszyny.Size = new System.Drawing.Size(373, 29);
            this.txtParametrMaszyny.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(10, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Wartość minimalna patametru";
            // 
            // txtWartoscMinimalnaParametru
            // 
            this.txtWartoscMinimalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscMinimalnaParametru.Location = new System.Drawing.Point(310, 481);
            this.txtWartoscMinimalnaParametru.Name = "txtWartoscMinimalnaParametru";
            this.txtWartoscMinimalnaParametru.Size = new System.Drawing.Size(187, 29);
            this.txtWartoscMinimalnaParametru.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(10, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Wartość maksymalna patametru";
            // 
            // txtWartoscMaksymalnaParametru
            // 
            this.txtWartoscMaksymalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscMaksymalnaParametru.Location = new System.Drawing.Point(310, 524);
            this.txtWartoscMaksymalnaParametru.Name = "txtWartoscMaksymalnaParametru";
            this.txtWartoscMaksymalnaParametru.Size = new System.Drawing.Size(187, 29);
            this.txtWartoscMaksymalnaParametru.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Wartość nominalna patametru";
            // 
            // txtWartoscNominalnaParametru
            // 
            this.txtWartoscNominalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscNominalnaParametru.Location = new System.Drawing.Point(310, 446);
            this.txtWartoscNominalnaParametru.Name = "txtWartoscNominalnaParametru";
            this.txtWartoscNominalnaParametru.Size = new System.Drawing.Size(187, 29);
            this.txtWartoscNominalnaParametru.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(10, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Przebieg poczatkowy";
            // 
            // txtPrzebiegPoczatkowy
            // 
            this.txtPrzebiegPoczatkowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzebiegPoczatkowy.Location = new System.Drawing.Point(310, 208);
            this.txtPrzebiegPoczatkowy.Name = "txtPrzebiegPoczatkowy";
            this.txtPrzebiegPoczatkowy.Size = new System.Drawing.Size(187, 29);
            this.txtPrzebiegPoczatkowy.TabIndex = 47;
            // 
            // txtKosztRoboczogodziny
            // 
            this.txtKosztRoboczogodziny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKosztRoboczogodziny.Location = new System.Drawing.Point(310, 248);
            this.txtKosztRoboczogodziny.Name = "txtKosztRoboczogodziny";
            this.txtKosztRoboczogodziny.Size = new System.Drawing.Size(187, 29);
            this.txtKosztRoboczogodziny.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(10, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 24);
            this.label12.TabIndex = 48;
            this.label12.Text = "Koszt roboczogodziny";
            // 
            // txtNumerNormy
            // 
            this.txtNumerNormy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerNormy.Location = new System.Drawing.Point(310, 564);
            this.txtNumerNormy.Name = "txtNumerNormy";
            this.txtNumerNormy.Size = new System.Drawing.Size(187, 29);
            this.txtNumerNormy.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(10, 564);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "Numer normy";
            // 
            // btnDodajRodzMaszyny
            // 
            this.btnDodajRodzMaszyny.Location = new System.Drawing.Point(719, 112);
            this.btnDodajRodzMaszyny.Name = "btnDodajRodzMaszyny";
            this.btnDodajRodzMaszyny.Size = new System.Drawing.Size(131, 24);
            this.btnDodajRodzMaszyny.TabIndex = 52;
            this.btnDodajRodzMaszyny.Text = "Dodaj rodzaj maszyny";
            this.btnDodajRodzMaszyny.UseVisualStyleBackColor = true;
            this.btnDodajRodzMaszyny.Click += new System.EventHandler(this.btnDodajRodzMaszyny_Click_1);
            // 
            // cbRodzajMaszyny
            // 
            this.cbRodzajMaszyny.FormattingEnabled = true;
            this.cbRodzajMaszyny.Location = new System.Drawing.Point(310, 76);
            this.cbRodzajMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajMaszyny.Name = "cbRodzajMaszyny";
            this.cbRodzajMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbRodzajMaszyny.TabIndex = 36;
            this.cbRodzajMaszyny.SelectedIndexChanged += new System.EventHandler(this.cbRodzajMaszyny_SelectedIndexChanged);
            this.cbRodzajMaszyny.Click += new System.EventHandler(this.cbRodzajMaszyny_Click);
            // 
            // cbModelMaszyny
            // 
            this.cbModelMaszyny.FormattingEnabled = true;
            this.cbModelMaszyny.Location = new System.Drawing.Point(310, 110);
            this.cbModelMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbModelMaszyny.Name = "cbModelMaszyny";
            this.cbModelMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbModelMaszyny.TabIndex = 53;
            // 
            // btnDodajModelMaszyny
            // 
            this.btnDodajModelMaszyny.Location = new System.Drawing.Point(719, 76);
            this.btnDodajModelMaszyny.Name = "btnDodajModelMaszyny";
            this.btnDodajModelMaszyny.Size = new System.Drawing.Size(131, 24);
            this.btnDodajModelMaszyny.TabIndex = 54;
            this.btnDodajModelMaszyny.Text = "Dodaj model maszyny";
            this.btnDodajModelMaszyny.UseVisualStyleBackColor = true;
            this.btnDodajModelMaszyny.Click += new System.EventHandler(this.btnDodajModelMaszyny_Click);
            // 
            // MaszynyCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 647);
            this.Controls.Add(this.btnDodajModelMaszyny);
            this.Controls.Add(this.cbModelMaszyny);
            this.Controls.Add(this.btnDodajRodzMaszyny);
            this.Controls.Add(this.txtNumerNormy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKosztRoboczogodziny);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrzebiegPoczatkowy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtWartoscNominalnaParametru);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtWartoscMaksymalnaParametru);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWartoscMinimalnaParametru);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtParametrMaszyny);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRodzajStrategiiEksploatacji);
            this.Controls.Add(this.cbRodzajMaszyny);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateDataRozchodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateDataPrzychodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarkaMaszyny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSymbolMaszyny);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.lblKindWindow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaszynyCU";
            this.Text = "MaszynyCU";
            this.Load += new System.EventHandler(this.MaszynyCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymbolMaszyny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarkaMaszyny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDataPrzychodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDataRozchodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.ComboBox cbRodzajStrategiiEksploatacji;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtParametrMaszyny;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWartoscMinimalnaParametru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWartoscMaksymalnaParametru;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWartoscNominalnaParametru;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrzebiegPoczatkowy;
        private System.Windows.Forms.TextBox txtKosztRoboczogodziny;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumerNormy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDodajRodzMaszyny;
        private System.Windows.Forms.ComboBox cbRodzajMaszyny;
        private System.Windows.Forms.ComboBox cbModelMaszyny;
        private System.Windows.Forms.Button btnDodajModelMaszyny;
    }
}