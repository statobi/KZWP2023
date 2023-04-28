namespace IDEA.App
{
    partial class AFFakturyForm
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
            this.dgvFaktury = new System.Windows.Forms.DataGridView();
            this.iBtnEditFaktura = new FontAwesome.Sharp.IconButton();
            this.iBtnNewFaktura = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteFaktura = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaktury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaktury
            // 
            this.dgvFaktury.AllowUserToResizeRows = false;
            this.dgvFaktury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaktury.Location = new System.Drawing.Point(16, 58);
            this.dgvFaktury.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFaktury.MultiSelect = false;
            this.dgvFaktury.Name = "dgvFaktury";
            this.dgvFaktury.ReadOnly = true;
            this.dgvFaktury.RowHeadersVisible = false;
            this.dgvFaktury.RowHeadersWidth = 51;
            this.dgvFaktury.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaktury.Size = new System.Drawing.Size(1280, 655);
            this.dgvFaktury.TabIndex = 2;
            this.dgvFaktury.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaktury_CellClick);
            // 
            // iBtnEditFaktura
            // 
            this.iBtnEditFaktura.BackColor = System.Drawing.Color.White;
            this.iBtnEditFaktura.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEditFaktura.IconColor = System.Drawing.Color.Black;
            this.iBtnEditFaktura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditFaktura.Location = new System.Drawing.Point(184, 736);
            this.iBtnEditFaktura.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnEditFaktura.Name = "iBtnEditFaktura";
            this.iBtnEditFaktura.Size = new System.Drawing.Size(100, 87);
            this.iBtnEditFaktura.TabIndex = 3;
            this.iBtnEditFaktura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEditFaktura.UseVisualStyleBackColor = false;
            this.iBtnEditFaktura.Click += new System.EventHandler(this.iBtnEditFaktura_Click);
            // 
            // iBtnNewFaktura
            // 
            this.iBtnNewFaktura.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNewFaktura.IconColor = System.Drawing.Color.Black;
            this.iBtnNewFaktura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNewFaktura.Location = new System.Drawing.Point(16, 736);
            this.iBtnNewFaktura.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnNewFaktura.Name = "iBtnNewFaktura";
            this.iBtnNewFaktura.Size = new System.Drawing.Size(100, 87);
            this.iBtnNewFaktura.TabIndex = 4;
            this.iBtnNewFaktura.UseVisualStyleBackColor = true;
            this.iBtnNewFaktura.Click += new System.EventHandler(this.iBtnNewFaktura_Click);
            // 
            // iBtnDeleteFaktura
            // 
            this.iBtnDeleteFaktura.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDeleteFaktura.IconColor = System.Drawing.Color.Red;
            this.iBtnDeleteFaktura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteFaktura.Location = new System.Drawing.Point(1196, 736);
            this.iBtnDeleteFaktura.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnDeleteFaktura.Name = "iBtnDeleteFaktura";
            this.iBtnDeleteFaktura.Size = new System.Drawing.Size(100, 87);
            this.iBtnDeleteFaktura.TabIndex = 5;
            this.iBtnDeleteFaktura.UseVisualStyleBackColor = true;
            this.iBtnDeleteFaktura.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(71, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(396, 34);
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
            this.iconSearch.IconSize = 36;
            this.iconSearch.Location = new System.Drawing.Point(20, 11);
            this.iconSearch.Margin = new System.Windows.Forms.Padding(4);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(43, 36);
            this.iconSearch.TabIndex = 7;
            this.iconSearch.TabStop = false;
            // 
            // AFFakturyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 838);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iBtnDeleteFaktura);
            this.Controls.Add(this.iBtnNewFaktura);
            this.Controls.Add(this.iBtnEditFaktura);
            this.Controls.Add(this.dgvFaktury);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFFakturyForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFFakturyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaktury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFaktury;
        private FontAwesome.Sharp.IconButton iBtnEditFaktura;
        private FontAwesome.Sharp.IconButton iBtnNewFaktura;
        private FontAwesome.Sharp.IconButton iBtnDeleteFaktura;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
    }
}