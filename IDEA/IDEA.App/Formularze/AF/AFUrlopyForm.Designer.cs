namespace IDEA.App
{
    partial class AFUrlopyForm
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
            this.dgvUrlopy = new System.Windows.Forms.DataGridView();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxUrlopyPracownik = new System.Windows.Forms.ComboBox();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.iBtnEditZamowienie = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteZamowienie = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrlopy
            // 
            this.dgvUrlopy.AllowUserToResizeRows = false;
            this.dgvUrlopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlopy.Location = new System.Drawing.Point(12, 47);
            this.dgvUrlopy.MultiSelect = false;
            this.dgvUrlopy.Name = "dgvUrlopy";
            this.dgvUrlopy.ReadOnly = true;
            this.dgvUrlopy.RowHeadersVisible = false;
            this.dgvUrlopy.RowHeadersWidth = 51;
            this.dgvUrlopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrlopy.Size = new System.Drawing.Size(960, 532);
            this.dgvUrlopy.TabIndex = 2;
            this.dgvUrlopy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrlopy_CellClick);
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
            // comboBoxUrlopyPracownik
            // 
            this.comboBoxUrlopyPracownik.FormattingEnabled = true;
            this.comboBoxUrlopyPracownik.Location = new System.Drawing.Point(111, 12);
            this.comboBoxUrlopyPracownik.Name = "comboBoxUrlopyPracownik";
            this.comboBoxUrlopyPracownik.Size = new System.Drawing.Size(235, 21);
            this.comboBoxUrlopyPracownik.TabIndex = 9;
            this.comboBoxUrlopyPracownik.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrlopyPracownik_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnReset.IconColor = System.Drawing.Color.Black;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 36;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(366, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 37);
            this.btnReset.TabIndex = 10;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // iBtnEditZamowienie
            // 
            this.iBtnEditZamowienie.BackColor = System.Drawing.SystemColors.Control;
            this.iBtnEditZamowienie.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEditZamowienie.IconColor = System.Drawing.Color.Black;
            this.iBtnEditZamowienie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditZamowienie.IconSize = 40;
            this.iBtnEditZamowienie.Location = new System.Drawing.Point(222, 599);
            this.iBtnEditZamowienie.Name = "iBtnEditZamowienie";
            this.iBtnEditZamowienie.Size = new System.Drawing.Size(75, 70);
            this.iBtnEditZamowienie.TabIndex = 12;
            this.iBtnEditZamowienie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEditZamowienie.UseVisualStyleBackColor = false;
            this.iBtnEditZamowienie.Click += new System.EventHandler(this.iBtnEdit_Click);
            // 
            // iBtnDeleteZamowienie
            // 
            this.iBtnDeleteZamowienie.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDeleteZamowienie.IconColor = System.Drawing.Color.Red;
            this.iBtnDeleteZamowienie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteZamowienie.IconSize = 40;
            this.iBtnDeleteZamowienie.Location = new System.Drawing.Point(862, 597);
            this.iBtnDeleteZamowienie.Name = "iBtnDeleteZamowienie";
            this.iBtnDeleteZamowienie.Size = new System.Drawing.Size(72, 71);
            this.iBtnDeleteZamowienie.TabIndex = 13;
            this.iBtnDeleteZamowienie.UseVisualStyleBackColor = true;
            this.iBtnDeleteZamowienie.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // AFUrlopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.iBtnDeleteZamowienie);
            this.Controls.Add(this.iBtnEditZamowienie);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxUrlopyPracownik);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.iBtnNew);
            this.Controls.Add(this.dgvUrlopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AFUrlopyForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFKlienciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUrlopy;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.ComboBox comboBoxUrlopyPracownik;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton iBtnEditZamowienie;
        private FontAwesome.Sharp.IconButton iBtnDeleteZamowienie;
    }
}