﻿namespace IDEA.App
{
    partial class AFZamowieniaForm
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
            this.dgvVZamowienia = new System.Windows.Forms.DataGridView();
            this.iBtnEditZamowienie = new FontAwesome.Sharp.IconButton();
            this.iBtnNewZamowienie = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteZamowienie = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.dgvVSklad = new System.Windows.Forms.DataGridView();
            this.iBtnSprawdz = new System.Windows.Forms.Button();
            this.iBtnNewSklad = new FontAwesome.Sharp.IconButton();
            this.iBtnEditSklad = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteSklad = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSklad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVZamowienia
            // 
            this.dgvVZamowienia.AllowUserToResizeRows = false;
            this.dgvVZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVZamowienia.Location = new System.Drawing.Point(12, 47);
            this.dgvVZamowienia.MultiSelect = false;
            this.dgvVZamowienia.Name = "dgvVZamowienia";
            this.dgvVZamowienia.ReadOnly = true;
            this.dgvVZamowienia.RowHeadersVisible = false;
            this.dgvVZamowienia.RowHeadersWidth = 51;
            this.dgvVZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVZamowienia.Size = new System.Drawing.Size(960, 245);
            this.dgvVZamowienia.TabIndex = 2;
            this.dgvVZamowienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVZamowienia_CellClick);
            this.dgvVZamowienia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVZamowienia_CellContentClick);
            // 
            // iBtnEditZamowienie
            // 
            this.iBtnEditZamowienie.BackColor = System.Drawing.SystemColors.Control;
            this.iBtnEditZamowienie.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEditZamowienie.IconColor = System.Drawing.Color.Black;
            this.iBtnEditZamowienie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditZamowienie.IconSize = 40;
            this.iBtnEditZamowienie.Location = new System.Drawing.Point(106, 298);
            this.iBtnEditZamowienie.Name = "iBtnEditZamowienie";
            this.iBtnEditZamowienie.Size = new System.Drawing.Size(47, 51);
            this.iBtnEditZamowienie.TabIndex = 3;
            this.iBtnEditZamowienie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEditZamowienie.UseVisualStyleBackColor = false;
            this.iBtnEditZamowienie.Click += new System.EventHandler(this.iBtnEdit_Click);
            // 
            // iBtnNewZamowienie
            // 
            this.iBtnNewZamowienie.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNewZamowienie.IconColor = System.Drawing.Color.Black;
            this.iBtnNewZamowienie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNewZamowienie.IconSize = 40;
            this.iBtnNewZamowienie.Location = new System.Drawing.Point(15, 298);
            this.iBtnNewZamowienie.Name = "iBtnNewZamowienie";
            this.iBtnNewZamowienie.Size = new System.Drawing.Size(47, 51);
            this.iBtnNewZamowienie.TabIndex = 4;
            this.iBtnNewZamowienie.UseVisualStyleBackColor = true;
            this.iBtnNewZamowienie.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // iBtnDeleteZamowienie
            // 
            this.iBtnDeleteZamowienie.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDeleteZamowienie.IconColor = System.Drawing.Color.Red;
            this.iBtnDeleteZamowienie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteZamowienie.IconSize = 40;
            this.iBtnDeleteZamowienie.Location = new System.Drawing.Point(909, 298);
            this.iBtnDeleteZamowienie.Name = "iBtnDeleteZamowienie";
            this.iBtnDeleteZamowienie.Size = new System.Drawing.Size(47, 51);
            this.iBtnDeleteZamowienie.TabIndex = 5;
            this.iBtnDeleteZamowienie.UseVisualStyleBackColor = true;
            this.iBtnDeleteZamowienie.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(53, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 29);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.SystemColors.Control;
            this.iconSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.IconSize = 29;
            this.iconSearch.Location = new System.Drawing.Point(15, 9);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(32, 29);
            this.iconSearch.TabIndex = 7;
            this.iconSearch.TabStop = false;
            // 
            // dgvVSklad
            // 
            this.dgvVSklad.AllowUserToResizeRows = false;
            this.dgvVSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVSklad.Location = new System.Drawing.Point(12, 356);
            this.dgvVSklad.MultiSelect = false;
            this.dgvVSklad.Name = "dgvVSklad";
            this.dgvVSklad.ReadOnly = true;
            this.dgvVSklad.RowHeadersVisible = false;
            this.dgvVSklad.RowHeadersWidth = 51;
            this.dgvVSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVSklad.Size = new System.Drawing.Size(960, 244);
            this.dgvVSklad.TabIndex = 9;
            // 
            // iBtnSprawdz
            // 
            this.iBtnSprawdz.Location = new System.Drawing.Point(544, 298);
            this.iBtnSprawdz.Name = "iBtnSprawdz";
            this.iBtnSprawdz.Size = new System.Drawing.Size(57, 51);
            this.iBtnSprawdz.TabIndex = 10;
            this.iBtnSprawdz.Text = "Sprawdz";
            this.iBtnSprawdz.UseVisualStyleBackColor = true;
            this.iBtnSprawdz.Click += new System.EventHandler(this.iBtnSprawdz_Click);
            // 
            // iBtnNewSklad
            // 
            this.iBtnNewSklad.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNewSklad.IconColor = System.Drawing.Color.Black;
            this.iBtnNewSklad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNewSklad.IconSize = 40;
            this.iBtnNewSklad.Location = new System.Drawing.Point(15, 618);
            this.iBtnNewSklad.Name = "iBtnNewSklad";
            this.iBtnNewSklad.Size = new System.Drawing.Size(47, 51);
            this.iBtnNewSklad.TabIndex = 11;
            this.iBtnNewSklad.UseVisualStyleBackColor = true;
            // 
            // iBtnEditSklad
            // 
            this.iBtnEditSklad.BackColor = System.Drawing.SystemColors.Control;
            this.iBtnEditSklad.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEditSklad.IconColor = System.Drawing.Color.Black;
            this.iBtnEditSklad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditSklad.IconSize = 40;
            this.iBtnEditSklad.Location = new System.Drawing.Point(106, 618);
            this.iBtnEditSklad.Name = "iBtnEditSklad";
            this.iBtnEditSklad.Size = new System.Drawing.Size(47, 51);
            this.iBtnEditSklad.TabIndex = 12;
            this.iBtnEditSklad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEditSklad.UseVisualStyleBackColor = false;
            // 
            // iBtnDeleteSklad
            // 
            this.iBtnDeleteSklad.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDeleteSklad.IconColor = System.Drawing.Color.Red;
            this.iBtnDeleteSklad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteSklad.IconSize = 40;
            this.iBtnDeleteSklad.Location = new System.Drawing.Point(909, 618);
            this.iBtnDeleteSklad.Name = "iBtnDeleteSklad";
            this.iBtnDeleteSklad.Size = new System.Drawing.Size(47, 51);
            this.iBtnDeleteSklad.TabIndex = 13;
            this.iBtnDeleteSklad.UseVisualStyleBackColor = true;
            // 
            // AFZamowieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.iBtnDeleteSklad);
            this.Controls.Add(this.iBtnEditSklad);
            this.Controls.Add(this.iBtnNewSklad);
            this.Controls.Add(this.iBtnSprawdz);
            this.Controls.Add(this.dgvVSklad);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iBtnDeleteZamowienie);
            this.Controls.Add(this.iBtnNewZamowienie);
            this.Controls.Add(this.iBtnEditZamowienie);
            this.Controls.Add(this.dgvVZamowienia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AFZamowieniaForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFKlienciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSklad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVZamowienia;
        private FontAwesome.Sharp.IconButton iBtnEditZamowienie;
        private FontAwesome.Sharp.IconButton iBtnNewZamowienie;
        private FontAwesome.Sharp.IconButton iBtnDeleteZamowienie;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.DataGridView dgvVSklad;
        private System.Windows.Forms.Button iBtnSprawdz;
        private FontAwesome.Sharp.IconButton iBtnNewSklad;
        private FontAwesome.Sharp.IconButton iBtnEditSklad;
        private FontAwesome.Sharp.IconButton iBtnDeleteSklad;
    }
}