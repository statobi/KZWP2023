namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    partial class TransportWewnetrznyKonfiguracjaZleceniaMagazynProdukcjiForm
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
            this.CmbKierowca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbPojazd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRemoveFromStagedSingle = new FontAwesome.Sharp.IconButton();
            this.BtnAddToStagedSingle = new FontAwesome.Sharp.IconButton();
            this.BtnRemoveFromStaged = new FontAwesome.Sharp.IconButton();
            this.BtnAddToStaged = new FontAwesome.Sharp.IconButton();
            this.DGVStaged = new System.Windows.Forms.DataGridView();
            this.CmbMagazyn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.DGVSkladMagazynu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSkladMagazynu)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbKierowca
            // 
            this.CmbKierowca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKierowca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbKierowca.FormattingEnabled = true;
            this.CmbKierowca.Location = new System.Drawing.Point(705, 229);
            this.CmbKierowca.Margin = new System.Windows.Forms.Padding(2);
            this.CmbKierowca.Name = "CmbKierowca";
            this.CmbKierowca.Size = new System.Drawing.Size(267, 25);
            this.CmbKierowca.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(680, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Kierowca";
            // 
            // CmbPojazd
            // 
            this.CmbPojazd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPojazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbPojazd.FormattingEnabled = true;
            this.CmbPojazd.Location = new System.Drawing.Point(705, 159);
            this.CmbPojazd.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPojazd.Name = "CmbPojazd";
            this.CmbPojazd.Size = new System.Drawing.Size(267, 25);
            this.CmbPojazd.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(680, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Pojazd";
            // 
            // BtnRemoveFromStagedSingle
            // 
            this.BtnRemoveFromStagedSingle.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.BtnRemoveFromStagedSingle.IconColor = System.Drawing.Color.Black;
            this.BtnRemoveFromStagedSingle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRemoveFromStagedSingle.IconSize = 44;
            this.BtnRemoveFromStagedSingle.Location = new System.Drawing.Point(157, 333);
            this.BtnRemoveFromStagedSingle.Name = "BtnRemoveFromStagedSingle";
            this.BtnRemoveFromStagedSingle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnRemoveFromStagedSingle.Size = new System.Drawing.Size(50, 46);
            this.BtnRemoveFromStagedSingle.TabIndex = 74;
            this.BtnRemoveFromStagedSingle.UseVisualStyleBackColor = true;
            this.BtnRemoveFromStagedSingle.Click += new System.EventHandler(this.BtnRemoveFromStagedSingle_Click);
            // 
            // BtnAddToStagedSingle
            // 
            this.BtnAddToStagedSingle.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.BtnAddToStagedSingle.IconColor = System.Drawing.Color.Black;
            this.BtnAddToStagedSingle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddToStagedSingle.IconSize = 44;
            this.BtnAddToStagedSingle.Location = new System.Drawing.Point(12, 333);
            this.BtnAddToStagedSingle.Name = "BtnAddToStagedSingle";
            this.BtnAddToStagedSingle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnAddToStagedSingle.Size = new System.Drawing.Size(50, 46);
            this.BtnAddToStagedSingle.TabIndex = 73;
            this.BtnAddToStagedSingle.UseVisualStyleBackColor = true;
            this.BtnAddToStagedSingle.Click += new System.EventHandler(this.BtnAddToStagedSingle_Click);
            // 
            // BtnRemoveFromStaged
            // 
            this.BtnRemoveFromStaged.IconChar = FontAwesome.Sharp.IconChar.ArrowUpShortWide;
            this.BtnRemoveFromStaged.IconColor = System.Drawing.Color.Black;
            this.BtnRemoveFromStaged.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRemoveFromStaged.IconSize = 44;
            this.BtnRemoveFromStaged.Location = new System.Drawing.Point(213, 333);
            this.BtnRemoveFromStaged.Name = "BtnRemoveFromStaged";
            this.BtnRemoveFromStaged.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnRemoveFromStaged.Size = new System.Drawing.Size(50, 46);
            this.BtnRemoveFromStaged.TabIndex = 72;
            this.BtnRemoveFromStaged.UseVisualStyleBackColor = true;
            this.BtnRemoveFromStaged.Click += new System.EventHandler(this.BtnRemoveFromStaged_Click);
            // 
            // BtnAddToStaged
            // 
            this.BtnAddToStaged.IconChar = FontAwesome.Sharp.IconChar.ArrowDownShortWide;
            this.BtnAddToStaged.IconColor = System.Drawing.Color.Black;
            this.BtnAddToStaged.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddToStaged.IconSize = 44;
            this.BtnAddToStaged.Location = new System.Drawing.Point(68, 333);
            this.BtnAddToStaged.Name = "BtnAddToStaged";
            this.BtnAddToStaged.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnAddToStaged.Size = new System.Drawing.Size(50, 46);
            this.BtnAddToStaged.TabIndex = 71;
            this.BtnAddToStaged.UseVisualStyleBackColor = true;
            this.BtnAddToStaged.Click += new System.EventHandler(this.BtnAddToStaged_Click);
            // 
            // DGVStaged
            // 
            this.DGVStaged.AllowUserToAddRows = false;
            this.DGVStaged.AllowUserToDeleteRows = false;
            this.DGVStaged.AllowUserToResizeColumns = false;
            this.DGVStaged.AllowUserToResizeRows = false;
            this.DGVStaged.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStaged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStaged.Location = new System.Drawing.Point(12, 385);
            this.DGVStaged.Name = "DGVStaged";
            this.DGVStaged.ReadOnly = true;
            this.DGVStaged.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStaged.Size = new System.Drawing.Size(662, 294);
            this.DGVStaged.TabIndex = 70;
            // 
            // CmbMagazyn
            // 
            this.CmbMagazyn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMagazyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbMagazyn.FormattingEnabled = true;
            this.CmbMagazyn.Location = new System.Drawing.Point(705, 90);
            this.CmbMagazyn.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMagazyn.Name = "CmbMagazyn";
            this.CmbMagazyn.Size = new System.Drawing.Size(267, 25);
            this.CmbMagazyn.TabIndex = 69;
            this.CmbMagazyn.SelectedIndexChanged += new System.EventHandler(this.CmbMagazyn_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(680, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Magazyn";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdd.Location = new System.Drawing.Point(705, 385);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(267, 44);
            this.BtnAdd.TabIndex = 67;
            this.BtnAdd.Text = "Dodaj do transportu";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnBack.IconColor = System.Drawing.Color.Black;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(12, 11);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnBack.Size = new System.Drawing.Size(48, 35);
            this.BtnBack.TabIndex = 66;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DGVSkladMagazynu
            // 
            this.DGVSkladMagazynu.AllowUserToAddRows = false;
            this.DGVSkladMagazynu.AllowUserToDeleteRows = false;
            this.DGVSkladMagazynu.AllowUserToResizeColumns = false;
            this.DGVSkladMagazynu.AllowUserToResizeRows = false;
            this.DGVSkladMagazynu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSkladMagazynu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSkladMagazynu.Location = new System.Drawing.Point(12, 58);
            this.DGVSkladMagazynu.Name = "DGVSkladMagazynu";
            this.DGVSkladMagazynu.ReadOnly = true;
            this.DGVSkladMagazynu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSkladMagazynu.Size = new System.Drawing.Size(662, 269);
            this.DGVSkladMagazynu.TabIndex = 65;
            // 
            // TransportWewnetrznyKonfiguracjaZleceniaMagazynProdukcjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.CmbKierowca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbPojazd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemoveFromStagedSingle);
            this.Controls.Add(this.BtnAddToStagedSingle);
            this.Controls.Add(this.BtnRemoveFromStaged);
            this.Controls.Add(this.BtnAddToStaged);
            this.Controls.Add(this.DGVStaged);
            this.Controls.Add(this.CmbMagazyn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DGVSkladMagazynu);
            this.Name = "TransportWewnetrznyKonfiguracjaZleceniaMagazynProdukcjiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportWewnetrznyKonfiguracjaZleceniaMagazynProdukcjiForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransportWewnetrznyKonfiguracjaZleceniaMagazynProdukcjiForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSkladMagazynu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbKierowca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbPojazd;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnRemoveFromStagedSingle;
        private FontAwesome.Sharp.IconButton BtnAddToStagedSingle;
        private FontAwesome.Sharp.IconButton BtnRemoveFromStaged;
        private FontAwesome.Sharp.IconButton BtnAddToStaged;
        private System.Windows.Forms.DataGridView DGVStaged;
        private System.Windows.Forms.ComboBox CmbMagazyn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.DataGridView DGVSkladMagazynu;
    }
}