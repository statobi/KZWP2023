namespace IDEA.App
{
    partial class ZleceniaMagazynoweForm
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
            this.dgvObecneProcesy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMagazynProdukcja = new System.Windows.Forms.DataGridView();
            this.dgvMaterialyBrakujace = new System.Windows.Forms.DataGridView();
            this.btnOtwZlec = new FontAwesome.Sharp.IconButton();
            this.btnZamkZlec = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tbuwagi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmaterial = new System.Windows.Forms.ComboBox();
            this.cbpowr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btndodajdoListy = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbzwrot = new System.Windows.Forms.ComboBox();
            this.txtilosc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynProdukcja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialyBrakujace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtilosc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObecneProcesy
            // 
            this.dgvObecneProcesy.AllowUserToResizeRows = false;
            this.dgvObecneProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObecneProcesy.Location = new System.Drawing.Point(12, 47);
            this.dgvObecneProcesy.MultiSelect = false;
            this.dgvObecneProcesy.Name = "dgvObecneProcesy";
            this.dgvObecneProcesy.ReadOnly = true;
            this.dgvObecneProcesy.RowHeadersVisible = false;
            this.dgvObecneProcesy.RowHeadersWidth = 51;
            this.dgvObecneProcesy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObecneProcesy.Size = new System.Drawing.Size(960, 208);
            this.dgvObecneProcesy.TabIndex = 2;
            this.dgvObecneProcesy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellClick);
            this.dgvObecneProcesy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "ZlecenieMagazynowe";
            // 
            // dgvMagazynProdukcja
            // 
            this.dgvMagazynProdukcja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynProdukcja.Location = new System.Drawing.Point(27, 291);
            this.dgvMagazynProdukcja.Name = "dgvMagazynProdukcja";
            this.dgvMagazynProdukcja.Size = new System.Drawing.Size(372, 160);
            this.dgvMagazynProdukcja.TabIndex = 9;
            // 
            // dgvMaterialyBrakujace
            // 
            this.dgvMaterialyBrakujace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialyBrakujace.Location = new System.Drawing.Point(27, 477);
            this.dgvMaterialyBrakujace.Name = "dgvMaterialyBrakujace";
            this.dgvMaterialyBrakujace.Size = new System.Drawing.Size(372, 136);
            this.dgvMaterialyBrakujace.TabIndex = 10;
            this.dgvMaterialyBrakujace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialyBrakujace_CellClick);
            // 
            // btnOtwZlec
            // 
            this.btnOtwZlec.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOtwZlec.IconColor = System.Drawing.Color.Black;
            this.btnOtwZlec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOtwZlec.Location = new System.Drawing.Point(694, 613);
            this.btnOtwZlec.Name = "btnOtwZlec";
            this.btnOtwZlec.Size = new System.Drawing.Size(114, 49);
            this.btnOtwZlec.TabIndex = 11;
            this.btnOtwZlec.Text = "Otwórz Zlecenie";
            this.btnOtwZlec.UseVisualStyleBackColor = true;
            this.btnOtwZlec.Click += new System.EventHandler(this.btnOtwZlec_Click);
            // 
            // btnZamkZlec
            // 
            this.btnZamkZlec.Enabled = false;
            this.btnZamkZlec.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnZamkZlec.IconColor = System.Drawing.Color.Black;
            this.btnZamkZlec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZamkZlec.Location = new System.Drawing.Point(833, 613);
            this.btnZamkZlec.Name = "btnZamkZlec";
            this.btnZamkZlec.Size = new System.Drawing.Size(114, 49);
            this.btnZamkZlec.TabIndex = 12;
            this.btnZamkZlec.Text = "Zamknij Zlecenie";
            this.btnZamkZlec.UseVisualStyleBackColor = true;
            this.btnZamkZlec.Click += new System.EventHandler(this.btnZamkZlec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(672, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Pracownik:";
            // 
            // cbPracownik
            // 
            this.cbPracownik.Enabled = false;
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(763, 289);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(204, 28);
            this.cbPracownik.TabIndex = 44;
            this.cbPracownik.SelectedIndexChanged += new System.EventHandler(this.cbPracownik_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 322);
            this.dataGridView1.TabIndex = 46;
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpData.Location = new System.Drawing.Point(763, 323);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(204, 26);
            this.dtpData.TabIndex = 48;
            // 
            // tbuwagi
            // 
            this.tbuwagi.Enabled = false;
            this.tbuwagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbuwagi.Location = new System.Drawing.Point(798, 564);
            this.tbuwagi.Name = "tbuwagi";
            this.tbuwagi.Size = new System.Drawing.Size(169, 26);
            this.tbuwagi.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(735, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Uwagi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(700, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(687, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Materiał:";
            // 
            // cbmaterial
            // 
            this.cbmaterial.Enabled = false;
            this.cbmaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbmaterial.FormattingEnabled = true;
            this.cbmaterial.Location = new System.Drawing.Point(763, 360);
            this.cbmaterial.Name = "cbmaterial";
            this.cbmaterial.Size = new System.Drawing.Size(204, 28);
            this.cbmaterial.TabIndex = 53;
            // 
            // cbpowr
            // 
            this.cbpowr.Enabled = false;
            this.cbpowr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbpowr.FormattingEnabled = true;
            this.cbpowr.Location = new System.Drawing.Point(798, 491);
            this.cbpowr.Name = "cbpowr";
            this.cbpowr.Size = new System.Drawing.Size(82, 28);
            this.cbpowr.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(689, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Powracające:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(415, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Lista  Zamowienia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(23, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Stan Magazynu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(23, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Brakujące materiały";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(711, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Ilość:";
            // 
            // btndodajdoListy
            // 
            this.btndodajdoListy.Enabled = false;
            this.btndodajdoListy.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btndodajdoListy.IconColor = System.Drawing.Color.Black;
            this.btndodajdoListy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndodajdoListy.IconSize = 30;
            this.btndodajdoListy.Location = new System.Drawing.Point(763, 430);
            this.btndodajdoListy.Name = "btndodajdoListy";
            this.btndodajdoListy.Size = new System.Drawing.Size(48, 44);
            this.btndodajdoListy.TabIndex = 61;
            this.btndodajdoListy.UseVisualStyleBackColor = true;
            this.btndodajdoListy.Click += new System.EventHandler(this.btndodajdoListy_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnDelete.IconColor = System.Drawing.Color.Red;
            this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDelete.IconSize = 30;
            this.BtnDelete.Location = new System.Drawing.Point(817, 430);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(49, 44);
            this.BtnDelete.TabIndex = 62;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(735, 532);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Zwrot:";
            // 
            // cbzwrot
            // 
            this.cbzwrot.Enabled = false;
            this.cbzwrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbzwrot.FormattingEnabled = true;
            this.cbzwrot.Location = new System.Drawing.Point(798, 525);
            this.cbzwrot.Name = "cbzwrot";
            this.cbzwrot.Size = new System.Drawing.Size(82, 28);
            this.cbzwrot.TabIndex = 64;
            // 
            // txtilosc
            // 
            this.txtilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtilosc.Location = new System.Drawing.Point(763, 394);
            this.txtilosc.Name = "txtilosc";
            this.txtilosc.Size = new System.Drawing.Size(204, 26);
            this.txtilosc.TabIndex = 65;
            // 
            // ZleceniaMagazynoweForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.txtilosc);
            this.Controls.Add(this.cbzwrot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btndodajdoListy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbpowr);
            this.Controls.Add(this.cbmaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbuwagi);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.btnZamkZlec);
            this.Controls.Add(this.btnOtwZlec);
            this.Controls.Add(this.dgvMaterialyBrakujace);
            this.Controls.Add(this.dgvMagazynProdukcja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObecneProcesy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZleceniaMagazynoweForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFKlienciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObecneProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynProdukcja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialyBrakujace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtilosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvObecneProcesy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMagazynProdukcja;
        private System.Windows.Forms.DataGridView dgvMaterialyBrakujace;
        private FontAwesome.Sharp.IconButton btnOtwZlec;
        private FontAwesome.Sharp.IconButton btnZamkZlec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox tbuwagi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmaterial;
        private System.Windows.Forms.ComboBox cbpowr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btndodajdoListy;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbzwrot;
        private System.Windows.Forms.NumericUpDown txtilosc;
    }
}