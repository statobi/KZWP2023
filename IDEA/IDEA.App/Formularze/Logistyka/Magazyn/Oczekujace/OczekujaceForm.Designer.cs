namespace IDEA.App.Formularze.Logistyka.Magazyn.Nieprzypisane
{
    partial class OczekujaceForm
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
            this.DGVOczekujace = new System.Windows.Forms.DataGridView();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnArrange = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbMagazyn = new System.Windows.Forms.ComboBox();
            this.DGVStaged = new System.Windows.Forms.DataGridView();
            this.BtnAddToStaged = new FontAwesome.Sharp.IconButton();
            this.BtnRemoveFromStaged = new FontAwesome.Sharp.IconButton();
            this.BtnAddToStagedSingle = new FontAwesome.Sharp.IconButton();
            this.BtnRemoveFromStagedSingle = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOczekujace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaged)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVOczekujace
            // 
            this.DGVOczekujace.AllowUserToAddRows = false;
            this.DGVOczekujace.AllowUserToDeleteRows = false;
            this.DGVOczekujace.AllowUserToResizeColumns = false;
            this.DGVOczekujace.AllowUserToResizeRows = false;
            this.DGVOczekujace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOczekujace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOczekujace.Location = new System.Drawing.Point(12, 58);
            this.DGVOczekujace.Name = "DGVOczekujace";
            this.DGVOczekujace.ReadOnly = true;
            this.DGVOczekujace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVOczekujace.Size = new System.Drawing.Size(662, 269);
            this.DGVOczekujace.TabIndex = 0;
            this.DGVOczekujace.SelectionChanged += new System.EventHandler(this.DGVOczekujace_SelectionChanged);
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
            this.BtnBack.TabIndex = 8;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnArrange
            // 
            this.BtnArrange.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnArrange.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnArrange.IconColor = System.Drawing.Color.Black;
            this.BtnArrange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnArrange.Location = new System.Drawing.Point(705, 155);
            this.BtnArrange.Name = "BtnArrange";
            this.BtnArrange.Size = new System.Drawing.Size(267, 44);
            this.BtnArrange.TabIndex = 9;
            this.BtnArrange.Text = "Rozmieść asortyment w magazynie";
            this.BtnArrange.UseVisualStyleBackColor = true;
            this.BtnArrange.Click += new System.EventHandler(this.BtnArrange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(680, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Magazyn";
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
            this.CmbMagazyn.TabIndex = 45;
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
            this.DGVStaged.TabIndex = 46;
            this.DGVStaged.SelectionChanged += new System.EventHandler(this.DGVStaged_SelectionChanged);
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
            this.BtnAddToStaged.TabIndex = 47;
            this.BtnAddToStaged.UseVisualStyleBackColor = true;
            this.BtnAddToStaged.Click += new System.EventHandler(this.BtnAddToStaged_Click);
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
            this.BtnRemoveFromStaged.TabIndex = 48;
            this.BtnRemoveFromStaged.UseVisualStyleBackColor = true;
            this.BtnRemoveFromStaged.Click += new System.EventHandler(this.BtnRemoveFromStaged_Click);
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
            this.BtnAddToStagedSingle.TabIndex = 49;
            this.BtnAddToStagedSingle.UseVisualStyleBackColor = true;
            this.BtnAddToStagedSingle.Click += new System.EventHandler(this.BtnAddToStagedSingle_Click);
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
            this.BtnRemoveFromStagedSingle.TabIndex = 50;
            this.BtnRemoveFromStagedSingle.UseVisualStyleBackColor = true;
            this.BtnRemoveFromStagedSingle.Click += new System.EventHandler(this.BtnRemoveFromStagedSingle_Click);
            // 
            // OczekujaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.BtnRemoveFromStagedSingle);
            this.Controls.Add(this.BtnAddToStagedSingle);
            this.Controls.Add(this.BtnRemoveFromStaged);
            this.Controls.Add(this.BtnAddToStaged);
            this.Controls.Add(this.DGVStaged);
            this.Controls.Add(this.CmbMagazyn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnArrange);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DGVOczekujace);
            this.Name = "OczekujaceForm";
            this.Text = "NieprzypisaneForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NieprzypisaneForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOczekujace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaged)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVOczekujace;
        private FontAwesome.Sharp.IconButton BtnBack;
        private FontAwesome.Sharp.IconButton BtnArrange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbMagazyn;
        private System.Windows.Forms.DataGridView DGVStaged;
        private FontAwesome.Sharp.IconButton BtnAddToStaged;
        private FontAwesome.Sharp.IconButton BtnRemoveFromStaged;
        private FontAwesome.Sharp.IconButton BtnAddToStagedSingle;
        private FontAwesome.Sharp.IconButton BtnRemoveFromStagedSingle;
    }
}