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
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(394, 9);
            this.lblKindWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(462, 31);
            this.lblKindWindow.TabIndex = 40;
            this.lblKindWindow.Text = "Dodawanie nowego modelu maszyny";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(33, 85);
            this.lblImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(178, 29);
            this.lblImie.TabIndex = 41;
            this.lblImie.Text = "Model maszyny";
            // 
            // txtModelMaszyny
            // 
            this.txtModelMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModelMaszyny.Location = new System.Drawing.Point(433, 80);
            this.txtModelMaszyny.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelMaszyny.Name = "txtModelMaszyny";
            this.txtModelMaszyny.Size = new System.Drawing.Size(496, 34);
            this.txtModelMaszyny.TabIndex = 42;
            // 
            // dgvModelMaszyny
            // 
            this.dgvModelMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelMaszyny.Location = new System.Drawing.Point(55, 439);
            this.dgvModelMaszyny.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModelMaszyny.Name = "dgvModelMaszyny";
            this.dgvModelMaszyny.RowHeadersWidth = 51;
            this.dgvModelMaszyny.Size = new System.Drawing.Size(1142, 153);
            this.dgvModelMaszyny.TabIndex = 43;
            this.dgvModelMaszyny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelMaszyny_CellContentClick);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(1030, 199);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 64);
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
            this.btnCancel.Location = new System.Drawing.Point(1138, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 64);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(1223, 524);
            this.iBtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(71, 68);
            this.iBtnDelete.TabIndex = 46;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            // 
            // txtNumerNormy
            // 
            this.txtNumerNormy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerNormy.Location = new System.Drawing.Point(433, 374);
            this.txtNumerNormy.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumerNormy.Name = "txtNumerNormy";
            this.txtNumerNormy.Size = new System.Drawing.Size(248, 34);
            this.txtNumerNormy.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(33, 374);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 29);
            this.label13.TabIndex = 62;
            this.label13.Text = "Numer normy";
            // 
            // txtWartoscNominalnaParametru
            // 
            this.txtWartoscNominalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscNominalnaParametru.Location = new System.Drawing.Point(433, 229);
            this.txtWartoscNominalnaParametru.Margin = new System.Windows.Forms.Padding(4);
            this.txtWartoscNominalnaParametru.Name = "txtWartoscNominalnaParametru";
            this.txtWartoscNominalnaParametru.Size = new System.Drawing.Size(248, 34);
            this.txtWartoscNominalnaParametru.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(36, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(330, 29);
            this.label10.TabIndex = 60;
            this.label10.Text = "Wartość nominalna patametru";
            // 
            // txtWartoscMaksymalnaParametru
            // 
            this.txtWartoscMaksymalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscMaksymalnaParametru.Location = new System.Drawing.Point(433, 325);
            this.txtWartoscMaksymalnaParametru.Margin = new System.Windows.Forms.Padding(4);
            this.txtWartoscMaksymalnaParametru.Name = "txtWartoscMaksymalnaParametru";
            this.txtWartoscMaksymalnaParametru.Size = new System.Drawing.Size(248, 34);
            this.txtWartoscMaksymalnaParametru.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(33, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 29);
            this.label9.TabIndex = 58;
            this.label9.Text = "Wartość maksymalna patametru";
            // 
            // txtWartoscMinimalnaParametru
            // 
            this.txtWartoscMinimalnaParametru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscMinimalnaParametru.Location = new System.Drawing.Point(433, 272);
            this.txtWartoscMinimalnaParametru.Margin = new System.Windows.Forms.Padding(4);
            this.txtWartoscMinimalnaParametru.Name = "txtWartoscMinimalnaParametru";
            this.txtWartoscMinimalnaParametru.Size = new System.Drawing.Size(248, 34);
            this.txtWartoscMinimalnaParametru.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(33, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Wartość minimalna patametru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(33, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "Parametr maszyny";
            // 
            // cbRodzajStrategiiEksploatacji
            // 
            this.cbRodzajStrategiiEksploatacji.FormattingEnabled = true;
            this.cbRodzajStrategiiEksploatacji.Location = new System.Drawing.Point(433, 140);
            this.cbRodzajStrategiiEksploatacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRodzajStrategiiEksploatacji.Name = "cbRodzajStrategiiEksploatacji";
            this.cbRodzajStrategiiEksploatacji.Size = new System.Drawing.Size(496, 24);
            this.cbRodzajStrategiiEksploatacji.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(33, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Rodzaj strategii eksploatacji";
            // 
            // cbParametrMaszyny
            // 
            this.cbParametrMaszyny.FormattingEnabled = true;
            this.cbParametrMaszyny.Location = new System.Drawing.Point(433, 188);
            this.cbParametrMaszyny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbParametrMaszyny.Name = "cbParametrMaszyny";
            this.cbParametrMaszyny.Size = new System.Drawing.Size(496, 24);
            this.cbParametrMaszyny.TabIndex = 64;
            // 
            // DodajModelMaszynyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 633);
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
    }
}