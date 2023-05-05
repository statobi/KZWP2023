namespace IDEA.App.Formularze.Produkcja
{
    partial class EksploatacjaMaszynForm
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
            this.txtNumerNormy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRodzajStrategiiEksploatacji = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEksploatacjaMaszyn = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNormy = new System.Windows.Forms.ComboBox();
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.btnDodajBadanie = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSymbolMaszyny = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWartosc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbParametrMaszyny = new System.Windows.Forms.ComboBox();
            this.txtParametrMaszyny = new System.Windows.Forms.TextBox();
            this.dtpDataBadania = new System.Windows.Forms.DateTimePicker();
            this.cbModelMaszyny = new System.Windows.Forms.ComboBox();
            this.btnDodajParametr = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZbadana = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrzekroczeniaParametru = new System.Windows.Forms.Button();
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEksploatacjaMaszyn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumerNormy
            // 
            this.txtNumerNormy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerNormy.Location = new System.Drawing.Point(162, 100);
            this.txtNumerNormy.Name = "txtNumerNormy";
            this.txtNumerNormy.Size = new System.Drawing.Size(187, 29);
            this.txtNumerNormy.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(50, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Numer normy";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 53);
            this.panel1.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Eksploatacja maszyn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbRodzajStrategiiEksploatacji
            // 
            this.cbRodzajStrategiiEksploatacji.FormattingEnabled = true;
            this.cbRodzajStrategiiEksploatacji.Location = new System.Drawing.Point(323, 53);
            this.cbRodzajStrategiiEksploatacji.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajStrategiiEksploatacji.Name = "cbRodzajStrategiiEksploatacji";
            this.cbRodzajStrategiiEksploatacji.Size = new System.Drawing.Size(373, 21);
            this.cbRodzajStrategiiEksploatacji.TabIndex = 77;
            this.cbRodzajStrategiiEksploatacji.SelectedIndexChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 76;
            this.label6.Text = "Rodzaj strategii eksploatacji";
            // 
            // dgvEksploatacjaMaszyn
            // 
            this.dgvEksploatacjaMaszyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEksploatacjaMaszyn.Location = new System.Drawing.Point(27, 96);
            this.dgvEksploatacjaMaszyn.Name = "dgvEksploatacjaMaszyn";
            this.dgvEksploatacjaMaszyn.Size = new System.Drawing.Size(843, 207);
            this.dgvEksploatacjaMaszyn.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNormy);
            this.groupBox1.Controls.Add(this.cbSymbol);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNumerNormy);
            this.groupBox1.Location = new System.Drawing.Point(27, 588);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 291);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry strategii";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // cbNormy
            // 
            this.cbNormy.FormattingEnabled = true;
            this.cbNormy.Location = new System.Drawing.Point(162, 63);
            this.cbNormy.Margin = new System.Windows.Forms.Padding(2);
            this.cbNormy.Name = "cbNormy";
            this.cbNormy.Size = new System.Drawing.Size(187, 21);
            this.cbNormy.TabIndex = 80;
            // 
            // cbSymbol
            // 
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Location = new System.Drawing.Point(162, 22);
            this.cbSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(187, 21);
            this.cbSymbol.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(48, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Symbol maszyny";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPracownik);
            this.groupBox2.Controls.Add(this.btnDodajBadanie);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbSymbolMaszyny);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtWartosc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbParametrMaszyny);
            this.groupBox2.Controls.Add(this.txtParametrMaszyny);
            this.groupBox2.Controls.Add(this.dtpDataBadania);
            this.groupBox2.Controls.Add(this.cbModelMaszyny);
            this.groupBox2.Controls.Add(this.btnDodajParametr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMinP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaxP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtZbadana);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(27, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 247);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry strategii";
            this.groupBox2.MouseCaptureChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(627, 47);
            this.cbPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(187, 21);
            this.cbPracownik.TabIndex = 96;
            // 
            // btnDodajBadanie
            // 
            this.btnDodajBadanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajBadanie.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajBadanie.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajBadanie.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajBadanie.IconColor = System.Drawing.Color.Black;
            this.btnDodajBadanie.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDodajBadanie.IconSize = 15;
            this.btnDodajBadanie.Location = new System.Drawing.Point(555, 209);
            this.btnDodajBadanie.Name = "btnDodajBadanie";
            this.btnDodajBadanie.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.btnDodajBadanie.Size = new System.Drawing.Size(209, 32);
            this.btnDodajBadanie.TabIndex = 95;
            this.btnDodajBadanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajBadanie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajBadanie.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.Location = new System.Drawing.Point(468, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 93;
            this.label16.Text = "Data";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.Location = new System.Drawing.Point(468, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "Wartość";
            // 
            // cbSymbolMaszyny
            // 
            this.cbSymbolMaszyny.FormattingEnabled = true;
            this.cbSymbolMaszyny.Location = new System.Drawing.Point(627, 22);
            this.cbSymbolMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbSymbolMaszyny.Name = "cbSymbolMaszyny";
            this.cbSymbolMaszyny.Size = new System.Drawing.Size(187, 21);
            this.cbSymbolMaszyny.TabIndex = 88;
            this.cbSymbolMaszyny.SelectedIndexChanged += new System.EventHandler(this.cbSymbolMaszyny_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(468, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Symbol maszyny";
            // 
            // txtWartosc
            // 
            this.txtWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtWartosc.Location = new System.Drawing.Point(627, 106);
            this.txtWartosc.Name = "txtWartosc";
            this.txtWartosc.Size = new System.Drawing.Size(187, 20);
            this.txtWartosc.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(468, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Pracownik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(468, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Badany parametr maszyny";
            // 
            // cbParametrMaszyny
            // 
            this.cbParametrMaszyny.FormattingEnabled = true;
            this.cbParametrMaszyny.Location = new System.Drawing.Point(627, 76);
            this.cbParametrMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbParametrMaszyny.Name = "cbParametrMaszyny";
            this.cbParametrMaszyny.Size = new System.Drawing.Size(187, 21);
            this.cbParametrMaszyny.TabIndex = 83;
            // 
            // txtParametrMaszyny
            // 
            this.txtParametrMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtParametrMaszyny.Location = new System.Drawing.Point(174, 51);
            this.txtParametrMaszyny.Name = "txtParametrMaszyny";
            this.txtParametrMaszyny.Size = new System.Drawing.Size(187, 20);
            this.txtParametrMaszyny.TabIndex = 82;
            // 
            // dtpDataBadania
            // 
            this.dtpDataBadania.Location = new System.Drawing.Point(627, 132);
            this.dtpDataBadania.Name = "dtpDataBadania";
            this.dtpDataBadania.Size = new System.Drawing.Size(187, 20);
            this.dtpDataBadania.TabIndex = 77;
            // 
            // cbModelMaszyny
            // 
            this.cbModelMaszyny.FormattingEnabled = true;
            this.cbModelMaszyny.Location = new System.Drawing.Point(174, 25);
            this.cbModelMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbModelMaszyny.Name = "cbModelMaszyny";
            this.cbModelMaszyny.Size = new System.Drawing.Size(187, 21);
            this.cbModelMaszyny.TabIndex = 76;
            // 
            // btnDodajParametr
            // 
            this.btnDodajParametr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajParametr.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajParametr.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajParametr.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajParametr.IconColor = System.Drawing.Color.Black;
            this.btnDodajParametr.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDodajParametr.IconSize = 15;
            this.btnDodajParametr.Location = new System.Drawing.Point(162, 209);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.btnDodajParametr.Size = new System.Drawing.Size(83, 32);
            this.btnDodajParametr.TabIndex = 81;
            this.btnDodajParametr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajParametr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajParametr.UseVisualStyleBackColor = true;
            this.btnDodajParametr.Click += new System.EventHandler(this.btnDodajParametr_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Model maszyny";
            // 
            // txtMinP
            // 
            this.txtMinP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMinP.Location = new System.Drawing.Point(174, 80);
            this.txtMinP.Name = "txtMinP";
            this.txtMinP.Size = new System.Drawing.Size(187, 20);
            this.txtMinP.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nowy parametr maszyny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Wartość minimalna patametru";
            // 
            // txtMaxP
            // 
            this.txtMaxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMaxP.Location = new System.Drawing.Point(174, 106);
            this.txtMaxP.Name = "txtMaxP";
            this.txtMaxP.Size = new System.Drawing.Size(187, 20);
            this.txtMaxP.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Wartość maksymalna patametru";
            // 
            // txtZbadana
            // 
            this.txtZbadana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtZbadana.Location = new System.Drawing.Point(174, 132);
            this.txtZbadana.Name = "txtZbadana";
            this.txtZbadana.Size = new System.Drawing.Size(187, 20);
            this.txtZbadana.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(16, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Wartość nominalna";
            // 
            // btnPrzekroczeniaParametru
            // 
            this.btnPrzekroczeniaParametru.Location = new System.Drawing.Point(692, 387);
            this.btnPrzekroczeniaParametru.Name = "btnPrzekroczeniaParametru";
            this.btnPrzekroczeniaParametru.Size = new System.Drawing.Size(130, 45);
            this.btnPrzekroczeniaParametru.TabIndex = 81;
            this.btnPrzekroczeniaParametru.Text = "Przycisk testowy przekroczenia parametru";
            this.btnPrzekroczeniaParametru.UseVisualStyleBackColor = true;
            this.btnPrzekroczeniaParametru.Click += new System.EventHandler(this.btnPrzekroczeniaParametru_Click);
            // 
            // iBtnBack
            // 
            this.iBtnBack.ForeColor = System.Drawing.Color.Coral;
            this.iBtnBack.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iBtnBack.IconColor = System.Drawing.Color.Red;
            this.iBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBack.Location = new System.Drawing.Point(809, 597);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(75, 52);
            this.iBtnBack.TabIndex = 80;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // EksploatacjaMaszynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.iBtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEksploatacjaMaszyn);
            this.Controls.Add(this.btnPrzekroczeniaParametru);
            this.Controls.Add(this.cbRodzajStrategiiEksploatacji);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EksploatacjaMaszynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EksploatacjaMaszynForm";
            this.Shown += new System.EventHandler(this.EksploatacjaMaszynForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEksploatacjaMaszyn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumerNormy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRodzajStrategiiEksploatacji;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEksploatacjaMaszyn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMinP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZbadana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbModelMaszyny;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataBadania;
        private System.Windows.Forms.ComboBox cbSymbol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrzekroczeniaParametru;
        private System.Windows.Forms.ComboBox cbNormy;
        private FontAwesome.Sharp.IconButton iBtnBack;
        private FontAwesome.Sharp.IconButton btnDodajParametr;
        private System.Windows.Forms.TextBox txtParametrMaszyny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbParametrMaszyny;
        private System.Windows.Forms.TextBox txtWartosc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPracownik;
        private FontAwesome.Sharp.IconButton btnDodajBadanie;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSymbolMaszyny;
        private System.Windows.Forms.Label label12;
    }
}