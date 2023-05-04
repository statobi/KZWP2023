namespace IDEA.App.Formularze.Produkcja
{
    partial class MaszynyForm
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
            this.dgvMaszyny = new System.Windows.Forms.DataGridView();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEksploatacja = new System.Windows.Forms.Button();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.btnObsluga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaszyny
            // 
            this.dgvMaszyny.AllowUserToResizeRows = false;
            this.dgvMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyny.Location = new System.Drawing.Point(7, 119);
            this.dgvMaszyny.MultiSelect = false;
            this.dgvMaszyny.Name = "dgvMaszyny";
            this.dgvMaszyny.ReadOnly = true;
            this.dgvMaszyny.RowHeadersVisible = false;
            this.dgvMaszyny.RowHeadersWidth = 51;
            this.dgvMaszyny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaszyny.Size = new System.Drawing.Size(951, 244);
            this.dgvMaszyny.TabIndex = 3;
            this.dgvMaszyny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaszyny_CellContentClick);
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.SystemColors.Control;
            this.iconSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.IconSize = 29;
            this.iconSearch.Location = new System.Drawing.Point(10, 11);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(32, 29);
            this.iconSearch.TabIndex = 8;
            this.iconSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(48, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 29);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(10, 561);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(75, 71);
            this.iBtnNew.TabIndex = 10;
            this.iBtnNew.UseVisualStyleBackColor = true;
            this.iBtnNew.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // iBtnEdit
            // 
            this.iBtnEdit.BackColor = System.Drawing.Color.White;
            this.iBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEdit.Location = new System.Drawing.Point(91, 561);
            this.iBtnEdit.Name = "iBtnEdit";
            this.iBtnEdit.Size = new System.Drawing.Size(75, 71);
            this.iBtnEdit.TabIndex = 11;
            this.iBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEdit.UseVisualStyleBackColor = false;
            this.iBtnEdit.Click += new System.EventHandler(this.iBtnEdit_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(886, 561);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(75, 71);
            this.iBtnDelete.TabIndex = 12;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEksploatacja
            // 
            this.btnEksploatacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksploatacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEksploatacja.Location = new System.Drawing.Point(398, 11);
            this.btnEksploatacja.Name = "btnEksploatacja";
            this.btnEksploatacja.Size = new System.Drawing.Size(539, 29);
            this.btnEksploatacja.TabIndex = 13;
            this.btnEksploatacja.Text = "Eksploatacja Maszyn";
            this.btnEksploatacja.UseVisualStyleBackColor = true;
            this.btnEksploatacja.Click += new System.EventHandler(this.btnEksploatacja_Click);
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(71, 60);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(198, 25);
            this.lblKindWindow.TabIndex = 41;
            this.lblKindWindow.Text = "Maszyny na stanie:";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnObsluga
            // 
            this.btnObsluga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnObsluga.Location = new System.Drawing.Point(398, 56);
            this.btnObsluga.Name = "btnObsluga";
            this.btnObsluga.Size = new System.Drawing.Size(539, 29);
            this.btnObsluga.TabIndex = 42;
            this.btnObsluga.Text = "Obsługa Maszyn";
            this.btnObsluga.UseVisualStyleBackColor = true;
            this.btnObsluga.Click += new System.EventHandler(this.btnObsluga_Click);
            // 
            // MaszynyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 643);
            this.Controls.Add(this.btnObsluga);
            this.Controls.Add(this.lblKindWindow);
            this.Controls.Add(this.btnEksploatacja);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.iBtnEdit);
            this.Controls.Add(this.iBtnNew);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.dgvMaszyny);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaszynyForm";
            this.Text = "MaszynyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaszyny;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.Button btnEksploatacja;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Button btnObsluga;
    }
}