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
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRodzajStrategiiEksploatacji = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEksploatacjaMaszyn = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDodajBadaniePP = new FontAwesome.Sharp.IconButton();
            this.cbNormy = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIloscGodz = new System.Windows.Forms.TextBox();
            this.cbRodzajObslugi = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNowaObsluga = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDodajObslugePP = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNowaNorma = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDodajNorme = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDodajBadanie = new FontAwesome.Sharp.IconButton();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvObslugi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEksploatacjaMaszyn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugi)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(20, 21);
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
            this.panel1.Size = new System.Drawing.Size(970, 53);
            this.panel1.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(382, 9);
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
            this.dgvEksploatacjaMaszyn.Size = new System.Drawing.Size(914, 207);
            this.dgvEksploatacjaMaszyn.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(27, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 190);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry strategii";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.btnDodajBadaniePP);
            this.groupBox6.Controls.Add(this.cbNormy);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txtIloscGodz);
            this.groupBox6.Controls.Add(this.cbRodzajObslugi);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(594, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(303, 151);
            this.groupBox6.TabIndex = 106;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dodawanie rodzaju obsługi";
            // 
            // btnDodajBadaniePP
            // 
            this.btnDodajBadaniePP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajBadaniePP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajBadaniePP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajBadaniePP.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajBadaniePP.IconColor = System.Drawing.Color.Black;
            this.btnDodajBadaniePP.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDodajBadaniePP.IconSize = 15;
            this.btnDodajBadaniePP.Location = new System.Drawing.Point(27, 111);
            this.btnDodajBadaniePP.Name = "btnDodajBadaniePP";
            this.btnDodajBadaniePP.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.btnDodajBadaniePP.Size = new System.Drawing.Size(252, 32);
            this.btnDodajBadaniePP.TabIndex = 104;
            this.btnDodajBadaniePP.Text = "Dodaj badanie";
            this.btnDodajBadaniePP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajBadaniePP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajBadaniePP.UseVisualStyleBackColor = true;
            this.btnDodajBadaniePP.Click += new System.EventHandler(this.btnDodajBadaniePP_Click);
            // 
            // cbNormy
            // 
            this.cbNormy.FormattingEnabled = true;
            this.cbNormy.Location = new System.Drawing.Point(110, 18);
            this.cbNormy.Margin = new System.Windows.Forms.Padding(2);
            this.cbNormy.Name = "cbNormy";
            this.cbNormy.Size = new System.Drawing.Size(169, 21);
            this.cbNormy.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(20, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "Rodzaj obsługi";
            // 
            // txtIloscGodz
            // 
            this.txtIloscGodz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIloscGodz.Location = new System.Drawing.Point(110, 71);
            this.txtIloscGodz.Name = "txtIloscGodz";
            this.txtIloscGodz.Size = new System.Drawing.Size(169, 20);
            this.txtIloscGodz.TabIndex = 102;
            // 
            // cbRodzajObslugi
            // 
            this.cbRodzajObslugi.FormattingEnabled = true;
            this.cbRodzajObslugi.Location = new System.Drawing.Point(110, 43);
            this.cbRodzajObslugi.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajObslugi.Name = "cbRodzajObslugi";
            this.cbRodzajObslugi.Size = new System.Drawing.Size(169, 21);
            this.cbRodzajObslugi.TabIndex = 100;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.Location = new System.Drawing.Point(20, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 101;
            this.label17.Text = "Ilość godzin";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNowaObsluga);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.btnDodajObslugePP);
            this.groupBox5.Location = new System.Drawing.Point(293, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 151);
            this.groupBox5.TabIndex = 105;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodawanie rodzaju obsługi";
            // 
            // txtNowaObsluga
            // 
            this.txtNowaObsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNowaObsluga.Location = new System.Drawing.Point(119, 23);
            this.txtNowaObsluga.Name = "txtNowaObsluga";
            this.txtNowaObsluga.Size = new System.Drawing.Size(152, 20);
            this.txtNowaObsluga.TabIndex = 99;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label18.Location = new System.Drawing.Point(16, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 100;
            this.label18.Text = "Nowa obsługa";
            // 
            // btnDodajObslugePP
            // 
            this.btnDodajObslugePP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajObslugePP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajObslugePP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajObslugePP.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajObslugePP.IconColor = System.Drawing.Color.Black;
            this.btnDodajObslugePP.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDodajObslugePP.IconSize = 15;
            this.btnDodajObslugePP.Location = new System.Drawing.Point(19, 111);
            this.btnDodajObslugePP.Name = "btnDodajObslugePP";
            this.btnDodajObslugePP.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.btnDodajObslugePP.Size = new System.Drawing.Size(252, 32);
            this.btnDodajObslugePP.TabIndex = 98;
            this.btnDodajObslugePP.Text = "Dodaj obsluge";
            this.btnDodajObslugePP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajObslugePP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajObslugePP.UseVisualStyleBackColor = true;
            this.btnDodajObslugePP.Click += new System.EventHandler(this.btnDodajObslugePP_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbSymbol);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtNowaNorma);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnDodajNorme);
            this.groupBox4.Location = new System.Drawing.Point(6, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 151);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodawanie nowej normy";
            // 
            // cbSymbol
            // 
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Location = new System.Drawing.Point(109, 18);
            this.cbSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(152, 21);
            this.cbSymbol.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Model maszyny";
            // 
            // txtNowaNorma
            // 
            this.txtNowaNorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNowaNorma.Location = new System.Drawing.Point(109, 44);
            this.txtNowaNorma.Name = "txtNowaNorma";
            this.txtNowaNorma.Size = new System.Drawing.Size(152, 20);
            this.txtNowaNorma.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Nowy numer normy";
            // 
            // btnDodajNorme
            // 
            this.btnDodajNorme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajNorme.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajNorme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajNorme.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajNorme.IconColor = System.Drawing.Color.Black;
            this.btnDodajNorme.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDodajNorme.IconSize = 15;
            this.btnDodajNorme.Location = new System.Drawing.Point(9, 111);
            this.btnDodajNorme.Name = "btnDodajNorme";
            this.btnDodajNorme.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.btnDodajNorme.Size = new System.Drawing.Size(252, 32);
            this.btnDodajNorme.TabIndex = 98;
            this.btnDodajNorme.Text = "Dodaj norme";
            this.btnDodajNorme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajNorme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajNorme.UseVisualStyleBackColor = true;
            this.btnDodajNorme.Click += new System.EventHandler(this.btnDodajNorme_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPracownik);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnDodajBadanie);
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
            this.groupBox2.Location = new System.Drawing.Point(39, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 233);
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
            // btnDodajBadanie
            // 
            this.btnDodajBadanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajBadanie.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajBadanie.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajBadanie.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajBadanie.IconColor = System.Drawing.Color.Black;
            this.btnDodajBadanie.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDodajBadanie.IconSize = 15;
            this.btnDodajBadanie.Location = new System.Drawing.Point(525, 170);
            this.btnDodajBadanie.Name = "btnDodajBadanie";
            this.btnDodajBadanie.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.btnDodajBadanie.Size = new System.Drawing.Size(276, 32);
            this.btnDodajBadanie.TabIndex = 95;
            this.btnDodajBadanie.Text = "Dodaj badanie";
            this.btnDodajBadanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajBadanie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajBadanie.UseVisualStyleBackColor = true;
            this.btnDodajBadanie.Click += new System.EventHandler(this.btnDodajBadanie_Click);
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
            this.btnDodajParametr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajParametr.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajParametr.IconColor = System.Drawing.Color.Black;
            this.btnDodajParametr.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDodajParametr.IconSize = 15;
            this.btnDodajParametr.Location = new System.Drawing.Point(43, 170);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.btnDodajParametr.Size = new System.Drawing.Size(283, 32);
            this.btnDodajParametr.TabIndex = 81;
            this.btnDodajParametr.Text = "Dodaj nowy parametr";
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
            this.iBtnBack.Location = new System.Drawing.Point(878, 577);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(75, 54);
            this.iBtnBack.TabIndex = 80;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // dgvObslugi
            // 
            this.dgvObslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObslugi.Location = new System.Drawing.Point(301, 96);
            this.dgvObslugi.Name = "dgvObslugi";
            this.dgvObslugi.Size = new System.Drawing.Size(640, 207);
            this.dgvObslugi.TabIndex = 83;
            // 
            // EksploatacjaMaszynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 643);
            this.Controls.Add(this.dgvEksploatacjaMaszyn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iBtnBack);
            this.Controls.Add(this.btnPrzekroczeniaParametru);
            this.Controls.Add(this.cbRodzajStrategiiEksploatacji);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvObslugi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EksploatacjaMaszynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EksploatacjaMaszynForm";
            this.Shown += new System.EventHandler(this.EksploatacjaMaszynForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEksploatacjaMaszyn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNowaNorma;
        private FontAwesome.Sharp.IconButton btnDodajNorme;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbRodzajObslugi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIloscGodz;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private FontAwesome.Sharp.IconButton btnDodajBadaniePP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNowaObsluga;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btnDodajObslugePP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvObslugi;
    }
}