namespace IDEA.App
{
    partial class ProduktyForm
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
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesyTechnologiczne = new System.Windows.Forms.Button();
            this.btnDokumentacja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.AllowUserToResizeRows = false;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Location = new System.Drawing.Point(12, 47);
            this.dgvProdukty.MultiSelect = false;
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.ReadOnly = true;
            this.dgvProdukty.RowHeadersVisible = false;
            this.dgvProdukty.RowHeadersWidth = 51;
            this.dgvProdukty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdukty.Size = new System.Drawing.Size(960, 437);
            this.dgvProdukty.TabIndex = 2;
            this.dgvProdukty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukty_CellClick);
            this.dgvProdukty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukty_CellContentClick);
            // 
            // iBtnEdit
            // 
            this.iBtnEdit.BackColor = System.Drawing.Color.White;
            this.iBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEdit.Location = new System.Drawing.Point(105, 598);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(850, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produkty";
            // 
            // btnProcesyTechnologiczne
            // 
            this.btnProcesyTechnologiczne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProcesyTechnologiczne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcesyTechnologiczne.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcesyTechnologiczne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcesyTechnologiczne.Location = new System.Drawing.Point(245, 599);
            this.btnProcesyTechnologiczne.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcesyTechnologiczne.Name = "btnProcesyTechnologiczne";
            this.btnProcesyTechnologiczne.Size = new System.Drawing.Size(248, 71);
            this.btnProcesyTechnologiczne.TabIndex = 9;
            this.btnProcesyTechnologiczne.Text = "Procesy Technologiczne";
            this.btnProcesyTechnologiczne.UseVisualStyleBackColor = false;
            this.btnProcesyTechnologiczne.Click += new System.EventHandler(this.btnProcesyTechnologiczne_Click);
            // 
            // btnDokumentacja
            // 
            this.btnDokumentacja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDokumentacja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDokumentacja.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDokumentacja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDokumentacja.Location = new System.Drawing.Point(551, 598);
            this.btnDokumentacja.Margin = new System.Windows.Forms.Padding(2);
            this.btnDokumentacja.Name = "btnDokumentacja";
            this.btnDokumentacja.Size = new System.Drawing.Size(275, 72);
            this.btnDokumentacja.TabIndex = 10;
            this.btnDokumentacja.Text = "Dokumentacja";
            this.btnDokumentacja.UseVisualStyleBackColor = false;
            this.btnDokumentacja.Click += new System.EventHandler(this.btnDokumentacja_Click);
            // 
            // ProduktyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.btnDokumentacja);
            this.Controls.Add(this.btnProcesyTechnologiczne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.iBtnNew);
            this.Controls.Add(this.iBtnEdit);
            this.Controls.Add(this.dgvProdukty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduktyForm";
            this.Tag = "Pracownicy";
            this.Text = "AFPracownicyForm";
            this.Load += new System.EventHandler(this.AFProduktForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProdukty;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesyTechnologiczne;
        private System.Windows.Forms.Button btnDokumentacja;
    }
}