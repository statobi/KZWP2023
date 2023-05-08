namespace IDEA.App
{
    partial class KontrolaJakosciForm
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
            this.dgvKlienci = new System.Windows.Forms.DataGridView();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKonczenieProdukcji = new System.Windows.Forms.Button();
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKlienci
            // 
            this.dgvKlienci.AllowUserToResizeRows = false;
            this.dgvKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlienci.Location = new System.Drawing.Point(15, 292);
            this.dgvKlienci.MultiSelect = false;
            this.dgvKlienci.Name = "dgvKlienci";
            this.dgvKlienci.ReadOnly = true;
            this.dgvKlienci.RowHeadersVisible = false;
            this.dgvKlienci.RowHeadersWidth = 51;
            this.dgvKlienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlienci.Size = new System.Drawing.Size(948, 255);
            this.dgvKlienci.TabIndex = 2;
            this.dgvKlienci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellClick);
            this.dgvKlienci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienci_CellContentClick);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kontrola Jakości";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKonczenieProdukcji
            // 
            this.btnKonczenieProdukcji.Location = new System.Drawing.Point(656, 598);
            this.btnKonczenieProdukcji.Name = "btnKonczenieProdukcji";
            this.btnKonczenieProdukcji.Size = new System.Drawing.Size(141, 71);
            this.btnKonczenieProdukcji.TabIndex = 9;
            this.btnKonczenieProdukcji.Text = "Zakończenie Produkcji";
            this.btnKonczenieProdukcji.UseVisualStyleBackColor = true;
            this.btnKonczenieProdukcji.Click += new System.EventHandler(this.btnKonczenieProdukcji_Click);
            // 
            // dgvZamowienia
            // 
            this.dgvZamowienia.AllowUserToResizeRows = false;
            this.dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienia.Location = new System.Drawing.Point(366, 48);
            this.dgvZamowienia.MultiSelect = false;
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.ReadOnly = true;
            this.dgvZamowienia.RowHeadersVisible = false;
            this.dgvZamowienia.RowHeadersWidth = 51;
            this.dgvZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZamowienia.Size = new System.Drawing.Size(236, 207);
            this.dgvZamowienia.TabIndex = 15;
            this.dgvZamowienia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZamowienia_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(363, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Zamówienia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // KontrolaJakosciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvZamowienia);
            this.Controls.Add(this.btnKonczenieProdukcji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.iBtnNew);
            this.Controls.Add(this.iBtnEdit);
            this.Controls.Add(this.dgvKlienci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KontrolaJakosciForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFKlienciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKlienci;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKonczenieProdukcji;
        private System.Windows.Forms.DataGridView dgvZamowienia;
        private System.Windows.Forms.Label label2;
    }
}