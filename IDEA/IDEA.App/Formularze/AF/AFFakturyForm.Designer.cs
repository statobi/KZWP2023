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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaktury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaktury
            // 
            this.dgvFaktury.AllowUserToResizeRows = false;
            this.dgvFaktury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaktury.Location = new System.Drawing.Point(12, 47);
            this.dgvFaktury.MultiSelect = false;
            this.dgvFaktury.Name = "dgvFaktury";
            this.dgvFaktury.ReadOnly = true;
            this.dgvFaktury.RowHeadersVisible = false;
            this.dgvFaktury.RowHeadersWidth = 51;
            this.dgvFaktury.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaktury.Size = new System.Drawing.Size(960, 532);
            this.dgvFaktury.TabIndex = 2;
            //this.dgvFaktury.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellClick);
            // 
            // iBtnEditFaktura
            // 
            this.iBtnEditFaktura.BackColor = System.Drawing.Color.White;
            this.iBtnEditFaktura.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEditFaktura.IconColor = System.Drawing.Color.Black;
            this.iBtnEditFaktura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditFaktura.Location = new System.Drawing.Point(138, 598);
            this.iBtnEditFaktura.Name = "iBtnEditFaktura";
            this.iBtnEditFaktura.Size = new System.Drawing.Size(75, 71);
            this.iBtnEditFaktura.TabIndex = 3;
            this.iBtnEditFaktura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEditFaktura.UseVisualStyleBackColor = false;
            //this.iBtnEditFaktura.Click += new System.EventHandler(this.iBtnEdit_Click);
            // 
            // iBtnNewFaktura
            // 
            this.iBtnNewFaktura.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNewFaktura.IconColor = System.Drawing.Color.Black;
            this.iBtnNewFaktura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNewFaktura.Location = new System.Drawing.Point(12, 598);
            this.iBtnNewFaktura.Name = "iBtnNewFaktura";
            this.iBtnNewFaktura.Size = new System.Drawing.Size(75, 71);
            this.iBtnNewFaktura.TabIndex = 4;
            this.iBtnNewFaktura.UseVisualStyleBackColor = true;
            //this.iBtnNewFaktura.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // iBtnDeleteFaktura
            // 
            this.iBtnDeleteFaktura.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDeleteFaktura.IconColor = System.Drawing.Color.Red;
            this.iBtnDeleteFaktura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteFaktura.Location = new System.Drawing.Point(897, 598);
            this.iBtnDeleteFaktura.Name = "iBtnDeleteFaktura";
            this.iBtnDeleteFaktura.Size = new System.Drawing.Size(75, 71);
            this.iBtnDeleteFaktura.TabIndex = 5;
            this.iBtnDeleteFaktura.UseVisualStyleBackColor = true;
            this.iBtnDeleteFaktura.Click += new System.EventHandler(this.iBtnDelete_Click);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(397, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Faktury";
            // 
            // AFFakturyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iBtnDeleteFaktura);
            this.Controls.Add(this.iBtnNewFaktura);
            this.Controls.Add(this.iBtnEditFaktura);
            this.Controls.Add(this.dgvFaktury);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AFFakturyForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            //this.Load += new System.EventHandler(this.AFKlienciForm_Load);
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
        private System.Windows.Forms.Label label1;
    }
}