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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.dtpDataBadania = new System.Windows.Forms.DateTimePicker();
            this.cbSymbolMaszyny = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZbadana = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParametrMaszyny = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPrzekroczeniaParametru = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEksploatacjaMaszyn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumerNormy
            // 
            this.txtNumerNormy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerNormy.Location = new System.Drawing.Point(348, 65);
            this.txtNumerNormy.Name = "txtNumerNormy";
            this.txtNumerNormy.Size = new System.Drawing.Size(187, 29);
            this.txtNumerNormy.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(50, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 24);
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
            this.dgvEksploatacjaMaszyn.Location = new System.Drawing.Point(27, 111);
            this.dgvEksploatacjaMaszyn.Name = "dgvEksploatacjaMaszyn";
            this.dgvEksploatacjaMaszyn.Size = new System.Drawing.Size(840, 170);
            this.dgvEksploatacjaMaszyn.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNumerNormy);
            this.groupBox1.Location = new System.Drawing.Point(50, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 291);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry strategii";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(373, 21);
            this.comboBox1.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(48, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 24);
            this.label8.TabIndex = 77;
            this.label8.Text = "Symbol maszyny";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrzekroczeniaParametru);
            this.groupBox2.Controls.Add(this.iBtnNew);
            this.groupBox2.Controls.Add(this.dtpDataBadania);
            this.groupBox2.Controls.Add(this.cbSymbolMaszyny);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMinP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaxP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtZbadana);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbParametrMaszyny);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(44, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 291);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry strategii";
            this.groupBox2.MouseCaptureChanged += new System.EventHandler(this.cbRodzajStrategiiEksploatacji_SelectedIndexChanged);
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(731, 214);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(75, 71);
            this.iBtnNew.TabIndex = 78;
            this.iBtnNew.UseVisualStyleBackColor = true;
            this.iBtnNew.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // dtpDataBadania
            // 
            this.dtpDataBadania.Location = new System.Drawing.Point(348, 225);
            this.dtpDataBadania.Name = "dtpDataBadania";
            this.dtpDataBadania.Size = new System.Drawing.Size(200, 20);
            this.dtpDataBadania.TabIndex = 77;
            // 
            // cbSymbolMaszyny
            // 
            this.cbSymbolMaszyny.FormattingEnabled = true;
            this.cbSymbolMaszyny.Location = new System.Drawing.Point(348, 28);
            this.cbSymbolMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbSymbolMaszyny.Name = "cbSymbolMaszyny";
            this.cbSymbolMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbSymbolMaszyny.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(48, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 75;
            this.label7.Text = "Symbol maszyny";
            // 
            // txtMinP
            // 
            this.txtMinP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMinP.Location = new System.Drawing.Point(348, 96);
            this.txtMinP.Name = "txtMinP";
            this.txtMinP.Size = new System.Drawing.Size(187, 29);
            this.txtMinP.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(48, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Parametr maszyny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Wartość minimalna patametru";
            // 
            // txtMaxP
            // 
            this.txtMaxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMaxP.Location = new System.Drawing.Point(348, 139);
            this.txtMaxP.Name = "txtMaxP";
            this.txtMaxP.Size = new System.Drawing.Size(187, 29);
            this.txtMaxP.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Wartość maksymalna patametru";
            // 
            // txtZbadana
            // 
            this.txtZbadana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZbadana.Location = new System.Drawing.Point(348, 181);
            this.txtZbadana.Name = "txtZbadana";
            this.txtZbadana.Size = new System.Drawing.Size(187, 29);
            this.txtZbadana.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(48, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Wartość nominalna";
            // 
            // cbParametrMaszyny
            // 
            this.cbParametrMaszyny.FormattingEnabled = true;
            this.cbParametrMaszyny.Location = new System.Drawing.Point(348, 63);
            this.cbParametrMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbParametrMaszyny.Name = "cbParametrMaszyny";
            this.cbParametrMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbParametrMaszyny.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(48, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 24);
            this.label11.TabIndex = 72;
            this.label11.Text = "Data badania";
            // 
            // btnPrzekroczeniaParametru
            // 
            this.btnPrzekroczeniaParametru.Location = new System.Drawing.Point(597, 139);
            this.btnPrzekroczeniaParametru.Name = "btnPrzekroczeniaParametru";
            this.btnPrzekroczeniaParametru.Size = new System.Drawing.Size(130, 45);
            this.btnPrzekroczeniaParametru.TabIndex = 81;
            this.btnPrzekroczeniaParametru.Text = "Przycisk testowy przekroczenia parametru";
            this.btnPrzekroczeniaParametru.UseVisualStyleBackColor = true;
            this.btnPrzekroczeniaParametru.Click += new System.EventHandler(this.btnPrzekroczeniaParametru_Click);
            // 
            // EksploatacjaMaszynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEksploatacjaMaszyn);
            this.Controls.Add(this.cbRodzajStrategiiEksploatacji);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.ComboBox cbParametrMaszyny;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSymbolMaszyny;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataBadania;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private System.Windows.Forms.Button btnPrzekroczeniaParametru;
    }
}