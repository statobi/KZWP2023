namespace IDEA.App.Formularze.Produkcja
{
    partial class ObslugaMaszynForm
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
            this.dgvObslugi = new System.Windows.Forms.DataGridView();
            this.cbSymbolMaszyny = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSymbolMaszyny = new System.Windows.Forms.TextBox();
            this.txtopis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpZakonczenieObslugi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpRozpoczecieObslugi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbObsluga = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKosztBrutto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKosztNetto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajObsluge = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvObslugaDoWykonaniaPP = new System.Windows.Forms.DataGridView();
            this.cbRodzajStrategiiEksploatacji = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbPP = new System.Windows.Forms.GroupBox();
            this.gbST = new System.Windows.Forms.GroupBox();
            this.dgvPrzekroczenieParametru = new System.Windows.Forms.DataGridView();
            this.cbParametry = new System.Windows.Forms.ComboBox();
            this.btnPrognozy = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugi)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugaDoWykonaniaPP)).BeginInit();
            this.gbPP.SuspendLayout();
            this.gbST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzekroczenieParametru)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObslugi
            // 
            this.dgvObslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObslugi.Location = new System.Drawing.Point(40, 84);
            this.dgvObslugi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvObslugi.Name = "dgvObslugi";
            this.dgvObslugi.RowHeadersWidth = 51;
            this.dgvObslugi.RowTemplate.Height = 24;
            this.dgvObslugi.Size = new System.Drawing.Size(780, 116);
            this.dgvObslugi.TabIndex = 0;
            this.dgvObslugi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObslugi_CellClick);
            this.dgvObslugi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObslugi_CellContentClick);
            // 
            // cbSymbolMaszyny
            // 
            this.cbSymbolMaszyny.FormattingEnabled = true;
            this.cbSymbolMaszyny.Location = new System.Drawing.Point(818, 47);
            this.cbSymbolMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbSymbolMaszyny.Name = "cbSymbolMaszyny";
            this.cbSymbolMaszyny.Size = new System.Drawing.Size(116, 21);
            this.cbSymbolMaszyny.TabIndex = 1;
            this.cbSymbolMaszyny.SelectedIndexChanged += new System.EventHandler(this.cbSymbolMaszyny_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(660, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Symbol maszyny";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(428, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Obsługi maszyn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 27);
            this.panel1.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSymbolMaszyny);
            this.groupBox1.Controls.Add(this.txtopis);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpZakonczenieObslugi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpRozpoczecieObslugi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbObsluga);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKosztBrutto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKosztNetto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbPracownik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 344);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(794, 301);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nowa obsługa";
            this.groupBox1.Visible = false;
            // 
            // txtSymbolMaszyny
            // 
            this.txtSymbolMaszyny.Location = new System.Drawing.Point(242, 33);
            this.txtSymbolMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.txtSymbolMaszyny.Name = "txtSymbolMaszyny";
            this.txtSymbolMaszyny.ReadOnly = true;
            this.txtSymbolMaszyny.Size = new System.Drawing.Size(76, 20);
            this.txtSymbolMaszyny.TabIndex = 93;
            this.txtSymbolMaszyny.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtopis
            // 
            this.txtopis.Location = new System.Drawing.Point(242, 272);
            this.txtopis.Margin = new System.Windows.Forms.Padding(2);
            this.txtopis.Name = "txtopis";
            this.txtopis.Size = new System.Drawing.Size(373, 20);
            this.txtopis.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 24);
            this.label9.TabIndex = 91;
            this.label9.Text = "Opis";
            // 
            // dtpZakonczenieObslugi
            // 
            this.dtpZakonczenieObslugi.Location = new System.Drawing.Point(242, 236);
            this.dtpZakonczenieObslugi.Name = "dtpZakonczenieObslugi";
            this.dtpZakonczenieObslugi.Size = new System.Drawing.Size(200, 20);
            this.dtpZakonczenieObslugi.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 89;
            this.label8.Text = "Zakończenie obsługi";
            // 
            // dtpRozpoczecieObslugi
            // 
            this.dtpRozpoczecieObslugi.Location = new System.Drawing.Point(242, 202);
            this.dtpRozpoczecieObslugi.Name = "dtpRozpoczecieObslugi";
            this.dtpRozpoczecieObslugi.Size = new System.Drawing.Size(200, 20);
            this.dtpRozpoczecieObslugi.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 24);
            this.label11.TabIndex = 87;
            this.label11.Text = "Rozpoczęcie obsługi";
            // 
            // cbObsluga
            // 
            this.cbObsluga.FormattingEnabled = true;
            this.cbObsluga.Location = new System.Drawing.Point(242, 64);
            this.cbObsluga.Margin = new System.Windows.Forms.Padding(2);
            this.cbObsluga.Name = "cbObsluga";
            this.cbObsluga.Size = new System.Drawing.Size(373, 21);
            this.cbObsluga.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 85;
            this.label6.Text = "Obsługa";
            // 
            // txtKosztBrutto
            // 
            this.txtKosztBrutto.Location = new System.Drawing.Point(242, 170);
            this.txtKosztBrutto.Margin = new System.Windows.Forms.Padding(2);
            this.txtKosztBrutto.Name = "txtKosztBrutto";
            this.txtKosztBrutto.ReadOnly = true;
            this.txtKosztBrutto.Size = new System.Drawing.Size(76, 20);
            this.txtKosztBrutto.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 83;
            this.label5.Text = "Koszt brutto";
            // 
            // txtKosztNetto
            // 
            this.txtKosztNetto.Location = new System.Drawing.Point(242, 132);
            this.txtKosztNetto.Margin = new System.Windows.Forms.Padding(2);
            this.txtKosztNetto.Name = "txtKosztNetto";
            this.txtKosztNetto.Size = new System.Drawing.Size(76, 20);
            this.txtKosztNetto.TabIndex = 82;
            this.txtKosztNetto.TextChanged += new System.EventHandler(this.txtKosztNetto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 80;
            this.label4.Text = "Koszt netto";
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(242, 96);
            this.cbPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(373, 21);
            this.cbPracownik.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Pracownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Symbol maszyny";
            // 
            // btnDodajObsluge
            // 
            this.btnDodajObsluge.Location = new System.Drawing.Point(862, 243);
            this.btnDodajObsluge.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajObsluge.Name = "btnDodajObsluge";
            this.btnDodajObsluge.Size = new System.Drawing.Size(97, 58);
            this.btnDodajObsluge.TabIndex = 59;
            this.btnDodajObsluge.Text = "Dodaj obsługę";
            this.btnDodajObsluge.UseVisualStyleBackColor = true;
            this.btnDodajObsluge.Click += new System.EventHandler(this.btnDodajObsluge_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 659);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 60);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iBtnDelete);
            this.panel3.Controls.Add(this.iBtnNew);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(802, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 60);
            this.panel3.TabIndex = 0;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(4, 6);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(49, 50);
            this.iBtnDelete.TabIndex = 62;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(59, 4);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(75, 52);
            this.iBtnNew.TabIndex = 94;
            this.iBtnNew.UseVisualStyleBackColor = true;
            this.iBtnNew.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(141, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(862, 115);
            this.btnOdswiez.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(104, 57);
            this.btnOdswiez.TabIndex = 61;
            this.btnOdswiez.Text = "Pokaż wszystkie obsługi maszyn";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(34, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Wykonane obsługi";
            // 
            // dgvObslugaDoWykonaniaPP
            // 
            this.dgvObslugaDoWykonaniaPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObslugaDoWykonaniaPP.Location = new System.Drawing.Point(4, 17);
            this.dgvObslugaDoWykonaniaPP.Margin = new System.Windows.Forms.Padding(2);
            this.dgvObslugaDoWykonaniaPP.Name = "dgvObslugaDoWykonaniaPP";
            this.dgvObslugaDoWykonaniaPP.RowHeadersWidth = 51;
            this.dgvObslugaDoWykonaniaPP.RowTemplate.Height = 24;
            this.dgvObslugaDoWykonaniaPP.Size = new System.Drawing.Size(784, 98);
            this.dgvObslugaDoWykonaniaPP.TabIndex = 78;
            // 
            // cbRodzajStrategiiEksploatacji
            // 
            this.cbRodzajStrategiiEksploatacji.FormattingEnabled = true;
            this.cbRodzajStrategiiEksploatacji.Location = new System.Drawing.Point(250, 47);
            this.cbRodzajStrategiiEksploatacji.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajStrategiiEksploatacji.Name = "cbRodzajStrategiiEksploatacji";
            this.cbRodzajStrategiiEksploatacji.Size = new System.Drawing.Size(369, 21);
            this.cbRodzajStrategiiEksploatacji.TabIndex = 81;
            this.cbRodzajStrategiiEksploatacji.SelectedIndexChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(10, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "Rodzaj strategii eksploatacji";
            // 
            // gbPP
            // 
            this.gbPP.Controls.Add(this.dgvObslugaDoWykonaniaPP);
            this.gbPP.Location = new System.Drawing.Point(27, 206);
            this.gbPP.Margin = new System.Windows.Forms.Padding(2);
            this.gbPP.Name = "gbPP";
            this.gbPP.Padding = new System.Windows.Forms.Padding(2);
            this.gbPP.Size = new System.Drawing.Size(798, 120);
            this.gbPP.TabIndex = 82;
            this.gbPP.TabStop = false;
            this.gbPP.Text = "Obsługi do wykonania";
            this.gbPP.Visible = false;
            // 
            // gbST
            // 
            this.gbST.Controls.Add(this.dgvPrzekroczenieParametru);
            this.gbST.Location = new System.Drawing.Point(32, 206);
            this.gbST.Margin = new System.Windows.Forms.Padding(2);
            this.gbST.Name = "gbST";
            this.gbST.Padding = new System.Windows.Forms.Padding(2);
            this.gbST.Size = new System.Drawing.Size(794, 120);
            this.gbST.TabIndex = 83;
            this.gbST.TabStop = false;
            this.gbST.Text = "Przekroczenie paratametru maszyny";
            this.gbST.Visible = false;
            // 
            // dgvPrzekroczenieParametru
            // 
            this.dgvPrzekroczenieParametru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzekroczenieParametru.Location = new System.Drawing.Point(8, 17);
            this.dgvPrzekroczenieParametru.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrzekroczenieParametru.Name = "dgvPrzekroczenieParametru";
            this.dgvPrzekroczenieParametru.RowHeadersWidth = 51;
            this.dgvPrzekroczenieParametru.RowTemplate.Height = 24;
            this.dgvPrzekroczenieParametru.Size = new System.Drawing.Size(780, 98);
            this.dgvPrzekroczenieParametru.TabIndex = 78;
            // 
            // cbParametry
            // 
            this.cbParametry.FormattingEnabled = true;
            this.cbParametry.Location = new System.Drawing.Point(831, 402);
            this.cbParametry.Name = "cbParametry";
            this.cbParametry.Size = new System.Drawing.Size(121, 21);
            this.cbParametry.TabIndex = 84;
            // 
            // btnPrognozy
            // 
            this.btnPrognozy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrognozy.IconColor = System.Drawing.Color.Black;
            this.btnPrognozy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrognozy.Location = new System.Drawing.Point(831, 430);
            this.btnPrognozy.Name = "btnPrognozy";
            this.btnPrognozy.Size = new System.Drawing.Size(121, 49);
            this.btnPrognozy.TabIndex = 85;
            this.btnPrognozy.Text = "Wyznacz Date przeglądu";
            this.btnPrognozy.UseVisualStyleBackColor = true;
            this.btnPrognozy.Click += new System.EventHandler(this.btnPrognozy_Click);
            // 
            // ObslugaMaszynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 719);
            this.Controls.Add(this.btnPrognozy);
            this.Controls.Add(this.cbParametry);
            this.Controls.Add(this.gbPP);
            this.Controls.Add(this.gbST);
            this.Controls.Add(this.cbRodzajStrategiiEksploatacji);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDodajObsluge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSymbolMaszyny);
            this.Controls.Add(this.dgvObslugi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObslugaMaszynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObslugaMaszynForm";
            this.Load += new System.EventHandler(this.ObslugaMaszynForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugaDoWykonaniaPP)).EndInit();
            this.gbPP.ResumeLayout(false);
            this.gbST.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzekroczenieParametru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObslugi;
        private System.Windows.Forms.ComboBox cbSymbolMaszyny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbObsluga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKosztBrutto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKosztNetto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpZakonczenieObslugi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpRozpoczecieObslugi;
        private System.Windows.Forms.Button btnDodajObsluge;
        private System.Windows.Forms.TextBox txtopis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSymbolMaszyny;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private System.Windows.Forms.Button btnOdswiez;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvObslugaDoWykonaniaPP;
        private System.Windows.Forms.ComboBox cbRodzajStrategiiEksploatacji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbPP;
        private System.Windows.Forms.GroupBox gbST;
        private System.Windows.Forms.DataGridView dgvPrzekroczenieParametru;
        private System.Windows.Forms.ComboBox cbParametry;
        private FontAwesome.Sharp.IconButton btnPrognozy;
    }
}