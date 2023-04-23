namespace IDEA.App
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
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVSklad = new System.Windows.Forms.DataGridView();
            this.iBtnSprawdz = new System.Windows.Forms.Button();
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
            this.dgvVZamowienia.Size = new System.Drawing.Size(960, 265);
            this.dgvVZamowienia.TabIndex = 2;
            this.dgvVZamowienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellClick);
            // 
            // iBtnEdit
            // 
            this.iBtnEdit.BackColor = System.Drawing.Color.White;
            this.iBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEdit.Location = new System.Drawing.Point(138, 598);
            this.iBtnEdit.Name = "iBtnEdit";
            this.iBtnEdit.Size = new System.Drawing.Size(75, 71);
            this.iBtnEdit.TabIndex = 3;
            this.iBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEdit.UseVisualStyleBackColor = false;
            this.iBtnEdit.Click += new System.EventHandler(this.iBtnEdit_Click);
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(12, 598);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(75, 71);
            this.iBtnNew.TabIndex = 4;
            this.iBtnNew.UseVisualStyleBackColor = true;
            this.iBtnNew.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(897, 598);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(75, 71);
            this.iBtnDelete.TabIndex = 5;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ZAMOWIENIA";
            // 
            // dgvVSklad
            // 
            this.dgvVSklad.AllowUserToResizeRows = false;
            this.dgvVSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVSklad.Location = new System.Drawing.Point(12, 318);
            this.dgvVSklad.MultiSelect = false;
            this.dgvVSklad.Name = "dgvVSklad";
            this.dgvVSklad.ReadOnly = true;
            this.dgvVSklad.RowHeadersVisible = false;
            this.dgvVSklad.RowHeadersWidth = 51;
            this.dgvVSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVSklad.Size = new System.Drawing.Size(960, 265);
            this.dgvVSklad.TabIndex = 9;
            this.dgvVSklad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVSklad_CellClick);
            // 
            // iBtnSprawdz
            // 
            this.iBtnSprawdz.Location = new System.Drawing.Point(541, 598);
            this.iBtnSprawdz.Name = "iBtnSprawdz";
            this.iBtnSprawdz.Size = new System.Drawing.Size(59, 55);
            this.iBtnSprawdz.TabIndex = 10;
            this.iBtnSprawdz.Text = "Sprawdz";
            this.iBtnSprawdz.UseVisualStyleBackColor = true;
            // 
            // AFZamowieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.iBtnSprawdz);
            this.Controls.Add(this.dgvVSklad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.iBtnNew);
            this.Controls.Add(this.iBtnEdit);
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
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVSklad;
        private System.Windows.Forms.Button iBtnSprawdz;
    }
}