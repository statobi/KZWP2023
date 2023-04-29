namespace IDEA.App.Formularze.Produkcja
{
    partial class DodajModelMaszynyForm
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
            this.txtModelMaszyny = new System.Windows.Forms.TextBox();
            this.dgvModelMaszyny = new System.Windows.Forms.DataGridView();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtNumerNormy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWartoscNominalnaParametru = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWartoscMaksymalnaParametru = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWartoscMinimalnaParametru = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRodzajStrategiiEksploatacji = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbParametrMaszyny = new System.Windows.Forms.ComboBox();
            this.txtMarkaMaszyny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRodzajMaszyny = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKosztRob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(306, 18);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(367, 25);
            this.lblKindWindow.TabIndex = 40;
            this.lblKindWindow.Text = "Dodawanie nowego modelu maszyny";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(28, 122);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(141, 24);
            this.lblImie.TabIndex = 41;
            this.lblImie.Text = "Model maszyny";
            // 
            // txtModelMaszyny
            // 
            this.txtModelMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModelMaszyny.Location = new System.Drawing.Point(328, 118);
            this.txtModelMaszyny.Name = "txtModelMaszyny";
            this.txtModelMaszyny.Size = new System.Drawing.Size(373, 29);
            this.txtModelMaszyny.TabIndex = 42;
            // 
            // dgvModelMaszyny
            // 
            this.dgvModelMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelMaszyny.Location = new System.Drawing.Point(48, 319);
            this.dgvModelMaszyny.Name = "dgvModelMaszyny";
            this.dgvModelMaszyny.RowHeadersWidth = 51;
            this.dgvModelMaszyny.Size = new System.Drawing.Size(806, 124);
            this.dgvModelMaszyny.TabIndex = 43;
            this.dgvModelMaszyny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelMaszyny_CellContentClick);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(772, 162);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 44;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(854, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(915, 388);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(53, 55);
            this.iBtnDelete.TabIndex = 46;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            // 
            // txtNumerNormy
            // 
            this.txtNumerNormy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerNormy.Location = new System.Drawing.Point(328, 611);
            this.txtNumerNormy.Name = "txtNumerNormy";
            this.txtNumerNormy.Size = new System.Drawing.Size(187, 29);
            this.txtNumerNormy.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(28, 611);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 24);
            this.label13.TabIndex = 62;
            this.label13.Text = "Numer normy";
            // 
            // txtWartoscNominalnaParametru
            // 
            this.txtWartoscNominalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscNominalnaParametru.Location = new System.Drawing.Point(328, 493);
            this.txtWartoscNominalnaParametru.Name = "txtWartoscNominalnaParametru";
            this.txtWartoscNominalnaParametru.Size = new System.Drawing.Size(187, 29);
            this.txtWartoscNominalnaParametru.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(30, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Wartość nominalna patametru";
            // 
            // txtWartoscMaksymalnaParametru
            // 
            this.txtWartoscMaksymalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscMaksymalnaParametru.Location = new System.Drawing.Point(328, 571);
            this.txtWartoscMaksymalnaParametru.Name = "txtWartoscMaksymalnaParametru";
            this.txtWartoscMaksymalnaParametru.Size = new System.Drawing.Size(187, 29);
            this.txtWartoscMaksymalnaParametru.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(28, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 24);
            this.label9.TabIndex = 58;
            this.label9.Text = "Wartość maksymalna patametru";
            // 
            // txtWartoscMinimalnaParametru
            // 
            this.txtWartoscMinimalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscMinimalnaParametru.Location = new System.Drawing.Point(328, 528);
            this.txtWartoscMinimalnaParametru.Name = "txtWartoscMinimalnaParametru";
            this.txtWartoscMinimalnaParametru.Size = new System.Drawing.Size(187, 29);
            this.txtWartoscMinimalnaParametru.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(28, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Wartość minimalna patametru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(28, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Parametr maszyny";
            // 
            // cbRodzajStrategiiEksploatacji
            // 
            this.cbRodzajStrategiiEksploatacji.FormattingEnabled = true;
            this.cbRodzajStrategiiEksploatacji.Location = new System.Drawing.Point(328, 207);
            this.cbRodzajStrategiiEksploatacji.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajStrategiiEksploatacji.Name = "cbRodzajStrategiiEksploatacji";
            this.cbRodzajStrategiiEksploatacji.Size = new System.Drawing.Size(373, 21);
            this.cbRodzajStrategiiEksploatacji.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(28, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "Rodzaj strategii eksploatacji";
            // 
            // cbParametrMaszyny
            // 
            this.cbParametrMaszyny.FormattingEnabled = true;
            this.cbParametrMaszyny.Location = new System.Drawing.Point(328, 460);
            this.cbParametrMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbParametrMaszyny.Name = "cbParametrMaszyny";
            this.cbParametrMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbParametrMaszyny.TabIndex = 64;
            // 
            // txtMarkaMaszyny
            // 
            this.txtMarkaMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMarkaMaszyny.Location = new System.Drawing.Point(328, 69);
            this.txtMarkaMaszyny.Name = "txtMarkaMaszyny";
            this.txtMarkaMaszyny.Size = new System.Drawing.Size(373, 29);
            this.txtMarkaMaszyny.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Marka maszyny";
            // 
            // cbRodzajMaszyny
            // 
            this.cbRodzajMaszyny.FormattingEnabled = true;
            this.cbRodzajMaszyny.Location = new System.Drawing.Point(328, 165);
            this.cbRodzajMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajMaszyny.Name = "cbRodzajMaszyny";
            this.cbRodzajMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbRodzajMaszyny.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Rodzaj maszyny";
            // 
            // txtKosztRob
            // 
            this.txtKosztRob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKosztRob.Location = new System.Drawing.Point(328, 251);
            this.txtKosztRob.Name = "txtKosztRob";
            this.txtKosztRob.Size = new System.Drawing.Size(373, 29);
            this.txtKosztRob.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Koszt roboczogodziny";
            // 
            // DodajModelMaszynyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 649);
            this.Controls.Add(this.txtKosztRob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRodzajMaszyny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarkaMaszyny);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbParametrMaszyny);
            this.Controls.Add(this.txtNumerNormy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtWartoscNominalnaParametru);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtWartoscMaksymalnaParametru);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWartoscMinimalnaParametru);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRodzajStrategiiEksploatacji);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvModelMaszyny);
            this.Controls.Add(this.txtModelMaszyny);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.lblKindWindow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajModelMaszynyForm";
            this.Text = "DodajModelMaszynyForm";
            this.Load += new System.EventHandler(this.DodajModelMaszynyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelMaszyny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox txtModelMaszyny;
        private System.Windows.Forms.DataGridView dgvModelMaszyny;
        private FontAwesome.Sharp.IconButton btnAccept;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.TextBox txtNumerNormy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWartoscNominalnaParametru;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWartoscMaksymalnaParametru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWartoscMinimalnaParametru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRodzajStrategiiEksploatacji;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbParametrMaszyny;
        private System.Windows.Forms.TextBox txtMarkaMaszyny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRodzajMaszyny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKosztRob;
        private System.Windows.Forms.Label label3;
    }
}