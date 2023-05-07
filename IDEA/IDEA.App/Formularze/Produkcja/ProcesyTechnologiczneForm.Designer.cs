namespace IDEA.App.Formularze.Produkcja
{
    partial class ProcesyTechnologiczneForm
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
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProcesyTechnologiczne = new System.Windows.Forms.DataGridView();
            this.cbRodzajMaszyny = new System.Windows.Forms.ComboBox();
            this.cbNazwaProcesu = new System.Windows.Forms.ComboBox();
            this.numIloscGodzin = new System.Windows.Forms.NumericUpDown();
            this.numIloscPracownikow = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.dgvProces_Materialy = new System.Windows.Forms.DataGridView();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.btnAddMaterial = new FontAwesome.Sharp.IconButton();
            this.numIloscMaterial = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteProcesTechnologicznyMaterial = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyTechnologiczne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscGodzin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscPracownikow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProces_Materialy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(897, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 71);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Procesy Technologiczne";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvProcesyTechnologiczne
            // 
            this.dgvProcesyTechnologiczne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesyTechnologiczne.Location = new System.Drawing.Point(20, 47);
            this.dgvProcesyTechnologiczne.Name = "dgvProcesyTechnologiczne";
            this.dgvProcesyTechnologiczne.Size = new System.Drawing.Size(546, 239);
            this.dgvProcesyTechnologiczne.TabIndex = 57;
            this.dgvProcesyTechnologiczne.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesyTechnologiczne_CellClick);
            this.dgvProcesyTechnologiczne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesyTechnologiczne_CellContentClick);
            // 
            // cbRodzajMaszyny
            // 
            this.cbRodzajMaszyny.Enabled = false;
            this.cbRodzajMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRodzajMaszyny.FormattingEnabled = true;
            this.cbRodzajMaszyny.Location = new System.Drawing.Point(589, 47);
            this.cbRodzajMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajMaszyny.Name = "cbRodzajMaszyny";
            this.cbRodzajMaszyny.Size = new System.Drawing.Size(318, 30);
            this.cbRodzajMaszyny.TabIndex = 61;
            // 
            // cbNazwaProcesu
            // 
            this.cbNazwaProcesu.Enabled = false;
            this.cbNazwaProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNazwaProcesu.FormattingEnabled = true;
            this.cbNazwaProcesu.Location = new System.Drawing.Point(589, 81);
            this.cbNazwaProcesu.Margin = new System.Windows.Forms.Padding(2);
            this.cbNazwaProcesu.Name = "cbNazwaProcesu";
            this.cbNazwaProcesu.Size = new System.Drawing.Size(318, 30);
            this.cbNazwaProcesu.TabIndex = 62;
            // 
            // numIloscGodzin
            // 
            this.numIloscGodzin.Enabled = false;
            this.numIloscGodzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIloscGodzin.Location = new System.Drawing.Point(803, 115);
            this.numIloscGodzin.Margin = new System.Windows.Forms.Padding(2);
            this.numIloscGodzin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIloscGodzin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIloscGodzin.Name = "numIloscGodzin";
            this.numIloscGodzin.Size = new System.Drawing.Size(104, 28);
            this.numIloscGodzin.TabIndex = 63;
            this.numIloscGodzin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIloscGodzin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numIloscPracownikow
            // 
            this.numIloscPracownikow.Enabled = false;
            this.numIloscPracownikow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIloscPracownikow.Location = new System.Drawing.Point(803, 147);
            this.numIloscPracownikow.Margin = new System.Windows.Forms.Padding(2);
            this.numIloscPracownikow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIloscPracownikow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIloscPracownikow.Name = "numIloscPracownikow";
            this.numIloscPracownikow.Size = new System.Drawing.Size(104, 28);
            this.numIloscPracownikow.TabIndex = 64;
            this.numIloscPracownikow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIloscPracownikow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(832, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 52);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Enabled = false;
            this.btnAddCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnAddCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnAddCancel.IconColor = System.Drawing.Color.Red;
            this.btnAddCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCancel.Location = new System.Drawing.Point(751, 202);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 52);
            this.btnAddCancel.TabIndex = 65;
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNew.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNew.Location = new System.Drawing.Point(670, 202);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 52);
            this.btnNew.TabIndex = 67;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.IconSize = 40;
            this.iBtnDelete.Location = new System.Drawing.Point(519, 292);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(47, 51);
            this.iBtnDelete.TabIndex = 68;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // dgvProces_Materialy
            // 
            this.dgvProces_Materialy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProces_Materialy.Location = new System.Drawing.Point(12, 508);
            this.dgvProces_Materialy.Name = "dgvProces_Materialy";
            this.dgvProces_Materialy.Size = new System.Drawing.Size(209, 161);
            this.dgvProces_Materialy.TabIndex = 69;
            this.dgvProces_Materialy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProces_Materialy_CellContentClick);
            // 
            // cbMaterial
            // 
            this.cbMaterial.Enabled = false;
            this.cbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(307, 518);
            this.cbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(244, 30);
            this.cbMaterial.TabIndex = 70;
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Enabled = false;
            this.btnAddMaterial.ForeColor = System.Drawing.Color.Coral;
            this.btnAddMaterial.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnAddMaterial.IconColor = System.Drawing.Color.Red;
            this.btnAddMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMaterial.Location = new System.Drawing.Point(227, 508);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(75, 52);
            this.btnAddMaterial.TabIndex = 71;
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // numIloscMaterial
            // 
            this.numIloscMaterial.Enabled = false;
            this.numIloscMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIloscMaterial.Location = new System.Drawing.Point(447, 552);
            this.numIloscMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.numIloscMaterial.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIloscMaterial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIloscMaterial.Name = "numIloscMaterial";
            this.numIloscMaterial.Size = new System.Drawing.Size(104, 28);
            this.numIloscMaterial.TabIndex = 72;
            this.numIloscMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIloscMaterial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDeleteProcesTechnologicznyMaterial
            // 
            this.btnDeleteProcesTechnologicznyMaterial.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteProcesTechnologicznyMaterial.IconColor = System.Drawing.Color.Red;
            this.btnDeleteProcesTechnologicznyMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteProcesTechnologicznyMaterial.IconSize = 40;
            this.btnDeleteProcesTechnologicznyMaterial.Location = new System.Drawing.Point(240, 566);
            this.btnDeleteProcesTechnologicznyMaterial.Name = "btnDeleteProcesTechnologicznyMaterial";
            this.btnDeleteProcesTechnologicznyMaterial.Size = new System.Drawing.Size(47, 51);
            this.btnDeleteProcesTechnologicznyMaterial.TabIndex = 73;
            this.btnDeleteProcesTechnologicznyMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteProcesTechnologicznyMaterial.Click += new System.EventHandler(this.btnDeleteProcesTechnologicznyMaterial_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.Location = new System.Drawing.Point(589, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 52);
            this.btnEdit.TabIndex = 74;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Materiały w procesie:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProcesyTechnologiczneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteProcesTechnologicznyMaterial);
            this.Controls.Add(this.numIloscMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.dgvProces_Materialy);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.numIloscPracownikow);
            this.Controls.Add(this.numIloscGodzin);
            this.Controls.Add(this.cbNazwaProcesu);
            this.Controls.Add(this.cbRodzajMaszyny);
            this.Controls.Add(this.dgvProcesyTechnologiczne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcesyTechnologiczneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProcesyTechnologiczneForm";
            this.Load += new System.EventHandler(this.ProcesyTechnologiczneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyTechnologiczne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscGodzin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscPracownikow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProces_Materialy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProcesyTechnologiczne;
        private System.Windows.Forms.ComboBox cbRodzajMaszyny;
        private System.Windows.Forms.ComboBox cbNazwaProcesu;
        private System.Windows.Forms.NumericUpDown numIloscGodzin;
        private System.Windows.Forms.NumericUpDown numIloscPracownikow;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.DataGridView dgvProces_Materialy;
        private System.Windows.Forms.ComboBox cbMaterial;
        private FontAwesome.Sharp.IconButton btnAddMaterial;
        private System.Windows.Forms.NumericUpDown numIloscMaterial;
        private FontAwesome.Sharp.IconButton btnDeleteProcesTechnologicznyMaterial;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Label label1;
    }
}