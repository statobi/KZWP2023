﻿namespace IDEA.App.Formularze.Produkcja
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
            this.dgvObslugi.Location = new System.Drawing.Point(53, 103);
            this.dgvObslugi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvObslugi.Name = "dgvObslugi";
            this.dgvObslugi.RowHeadersWidth = 51;
            this.dgvObslugi.RowTemplate.Height = 24;
            this.dgvObslugi.Size = new System.Drawing.Size(1040, 143);
            this.dgvObslugi.TabIndex = 0;
            this.dgvObslugi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObslugi_CellClick);
            this.dgvObslugi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObslugi_CellContentClick);
            // 
            // cbSymbolMaszyny
            // 
            this.cbSymbolMaszyny.FormattingEnabled = true;
            this.cbSymbolMaszyny.Location = new System.Drawing.Point(1091, 58);
            this.cbSymbolMaszyny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSymbolMaszyny.Name = "cbSymbolMaszyny";
            this.cbSymbolMaszyny.Size = new System.Drawing.Size(153, 24);
            this.cbSymbolMaszyny.TabIndex = 1;
            this.cbSymbolMaszyny.SelectedIndexChanged += new System.EventHandler(this.cbSymbolMaszyny_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(880, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Symbol maszyny";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(571, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 31);
            this.label7.TabIndex = 56;
            this.label7.Text = "Obsługi maszyn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 33);
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
            this.groupBox1.Location = new System.Drawing.Point(43, 423);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1059, 370);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nowa obsługa";
            this.groupBox1.Visible = false;
            // 
            // txtSymbolMaszyny
            // 
            this.txtSymbolMaszyny.Location = new System.Drawing.Point(323, 41);
            this.txtSymbolMaszyny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSymbolMaszyny.Name = "txtSymbolMaszyny";
            this.txtSymbolMaszyny.ReadOnly = true;
            this.txtSymbolMaszyny.Size = new System.Drawing.Size(100, 22);
            this.txtSymbolMaszyny.TabIndex = 93;
            this.txtSymbolMaszyny.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtopis
            // 
            this.txtopis.Location = new System.Drawing.Point(323, 335);
            this.txtopis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtopis.Name = "txtopis";
            this.txtopis.Size = new System.Drawing.Size(496, 22);
            this.txtopis.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(16, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 29);
            this.label9.TabIndex = 91;
            this.label9.Text = "Opis";
            // 
            // dtpZakonczenieObslugi
            // 
            this.dtpZakonczenieObslugi.Location = new System.Drawing.Point(323, 290);
            this.dtpZakonczenieObslugi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpZakonczenieObslugi.Name = "dtpZakonczenieObslugi";
            this.dtpZakonczenieObslugi.Size = new System.Drawing.Size(265, 22);
            this.dtpZakonczenieObslugi.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(16, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 29);
            this.label8.TabIndex = 89;
            this.label8.Text = "Zakończenie obsługi";
            // 
            // dtpRozpoczecieObslugi
            // 
            this.dtpRozpoczecieObslugi.Location = new System.Drawing.Point(323, 249);
            this.dtpRozpoczecieObslugi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRozpoczecieObslugi.Name = "dtpRozpoczecieObslugi";
            this.dtpRozpoczecieObslugi.Size = new System.Drawing.Size(265, 22);
            this.dtpRozpoczecieObslugi.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(16, 242);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 29);
            this.label11.TabIndex = 87;
            this.label11.Text = "Rozpoczęcie obsługi";
            // 
            // cbObsluga
            // 
            this.cbObsluga.FormattingEnabled = true;
            this.cbObsluga.Location = new System.Drawing.Point(323, 79);
            this.cbObsluga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbObsluga.Name = "cbObsluga";
            this.cbObsluga.Size = new System.Drawing.Size(496, 24);
            this.cbObsluga.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 85;
            this.label6.Text = "Obsługa";
            // 
            // txtKosztBrutto
            // 
            this.txtKosztBrutto.Location = new System.Drawing.Point(323, 209);
            this.txtKosztBrutto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKosztBrutto.Name = "txtKosztBrutto";
            this.txtKosztBrutto.ReadOnly = true;
            this.txtKosztBrutto.Size = new System.Drawing.Size(100, 22);
            this.txtKosztBrutto.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 83;
            this.label5.Text = "Koszt brutto";
            // 
            // txtKosztNetto
            // 
            this.txtKosztNetto.Location = new System.Drawing.Point(323, 162);
            this.txtKosztNetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKosztNetto.Name = "txtKosztNetto";
            this.txtKosztNetto.Size = new System.Drawing.Size(100, 22);
            this.txtKosztNetto.TabIndex = 82;
            this.txtKosztNetto.TextChanged += new System.EventHandler(this.txtKosztNetto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 80;
            this.label4.Text = "Koszt netto";
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(323, 118);
            this.cbPracownik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(496, 24);
            this.cbPracownik.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 78;
            this.label3.Text = "Pracownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "Symbol maszyny";
            // 
            // btnDodajObsluge
            // 
            this.btnDodajObsluge.Location = new System.Drawing.Point(1159, 464);
            this.btnDodajObsluge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajObsluge.Name = "btnDodajObsluge";
            this.btnDodajObsluge.Size = new System.Drawing.Size(129, 71);
            this.btnDodajObsluge.TabIndex = 59;
            this.btnDodajObsluge.Text = "Dodaj obsługę";
            this.btnDodajObsluge.UseVisualStyleBackColor = true;
            this.btnDodajObsluge.Click += new System.EventHandler(this.btnDodajObsluge_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 811);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 74);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iBtnDelete);
            this.panel3.Controls.Add(this.iBtnNew);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1070, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 74);
            this.panel3.TabIndex = 0;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(5, 7);
            this.iBtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(65, 62);
            this.iBtnDelete.TabIndex = 62;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(79, 5);
            this.iBtnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(100, 64);
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
            this.btnCancel.Location = new System.Drawing.Point(188, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 64);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(1149, 142);
            this.btnOdswiez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(139, 70);
            this.btnOdswiez.TabIndex = 61;
            this.btnOdswiez.Text = "Pokaż wszystkie obsługi maszyn";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(45, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "Wykonane obsługi";
            // 
            // dgvObslugaDoWykonaniaPP
            // 
            this.dgvObslugaDoWykonaniaPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObslugaDoWykonaniaPP.Location = new System.Drawing.Point(5, 21);
            this.dgvObslugaDoWykonaniaPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvObslugaDoWykonaniaPP.Name = "dgvObslugaDoWykonaniaPP";
            this.dgvObslugaDoWykonaniaPP.RowHeadersWidth = 51;
            this.dgvObslugaDoWykonaniaPP.RowTemplate.Height = 24;
            this.dgvObslugaDoWykonaniaPP.Size = new System.Drawing.Size(1045, 121);
            this.dgvObslugaDoWykonaniaPP.TabIndex = 78;
            // 
            // cbRodzajStrategiiEksploatacji
            // 
            this.cbRodzajStrategiiEksploatacji.FormattingEnabled = true;
            this.cbRodzajStrategiiEksploatacji.Location = new System.Drawing.Point(333, 58);
            this.cbRodzajStrategiiEksploatacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRodzajStrategiiEksploatacji.Name = "cbRodzajStrategiiEksploatacji";
            this.cbRodzajStrategiiEksploatacji.Size = new System.Drawing.Size(491, 24);
            this.cbRodzajStrategiiEksploatacji.TabIndex = 81;
            this.cbRodzajStrategiiEksploatacji.SelectedIndexChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(13, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 29);
            this.label10.TabIndex = 80;
            this.label10.Text = "Rodzaj strategii eksploatacji";
            // 
            // gbPP
            // 
            this.gbPP.Controls.Add(this.dgvObslugaDoWykonaniaPP);
            this.gbPP.Location = new System.Drawing.Point(38, 254);
            this.gbPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPP.Name = "gbPP";
            this.gbPP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPP.Size = new System.Drawing.Size(1064, 148);
            this.gbPP.TabIndex = 82;
            this.gbPP.TabStop = false;
            this.gbPP.Text = "Obsługi do wykonania";
            this.gbPP.Visible = false;
            // 
            // gbST
            // 
            this.gbST.Controls.Add(this.btnPrognozy);
            this.gbST.Controls.Add(this.dgvPrzekroczenieParametru);
            this.gbST.Controls.Add(this.cbParametry);
            this.gbST.Location = new System.Drawing.Point(43, 254);
            this.gbST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbST.Name = "gbST";
            this.gbST.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbST.Size = new System.Drawing.Size(1270, 148);
            this.gbST.TabIndex = 83;
            this.gbST.TabStop = false;
            this.gbST.Text = "Przekroczenie paratametru maszyny";
            this.gbST.Visible = false;
            this.gbST.Enter += new System.EventHandler(this.gbST_Enter);
            // 
            // dgvPrzekroczenieParametru
            // 
            this.dgvPrzekroczenieParametru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzekroczenieParametru.Location = new System.Drawing.Point(11, 21);
            this.dgvPrzekroczenieParametru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrzekroczenieParametru.Name = "dgvPrzekroczenieParametru";
            this.dgvPrzekroczenieParametru.RowHeadersWidth = 51;
            this.dgvPrzekroczenieParametru.RowTemplate.Height = 24;
            this.dgvPrzekroczenieParametru.Size = new System.Drawing.Size(1040, 121);
            this.dgvPrzekroczenieParametru.TabIndex = 78;
            // 
            // cbParametry
            // 
            this.cbParametry.FormattingEnabled = true;
            this.cbParametry.Location = new System.Drawing.Point(1085, 34);
            this.cbParametry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbParametry.Name = "cbParametry";
            this.cbParametry.Size = new System.Drawing.Size(160, 24);
            this.cbParametry.TabIndex = 84;
            // 
            // btnPrognozy
            // 
            this.btnPrognozy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrognozy.IconColor = System.Drawing.Color.Black;
            this.btnPrognozy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrognozy.Location = new System.Drawing.Point(1085, 66);
            this.btnPrognozy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrognozy.Name = "btnPrognozy";
            this.btnPrognozy.Size = new System.Drawing.Size(161, 60);
            this.btnPrognozy.TabIndex = 85;
            this.btnPrognozy.Text = "Wyznacz Date przeglądu";
            this.btnPrognozy.UseVisualStyleBackColor = true;
            this.btnPrognozy.Click += new System.EventHandler(this.btnPrognozy_Click);
            // 
            // ObslugaMaszynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 885);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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