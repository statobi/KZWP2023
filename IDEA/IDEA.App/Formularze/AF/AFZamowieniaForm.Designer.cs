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
            this.btnStanZamowienia = new FontAwesome.Sharp.IconButton();
            this.txtWartoscNetto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWartoscBrutto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSklad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVZamowienia
            // 
            this.dgvVZamowienia.AllowUserToResizeRows = false;
            this.dgvVZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVZamowienia.Location = new System.Drawing.Point(16, 58);
            this.dgvVZamowienia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVZamowienia.MultiSelect = false;
            this.dgvVZamowienia.Name = "dgvVZamowienia";
            this.dgvVZamowienia.ReadOnly = true;
            this.dgvVZamowienia.RowHeadersVisible = false;
            this.dgvVZamowienia.RowHeadersWidth = 51;
            this.dgvVZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVZamowienia.Size = new System.Drawing.Size(1280, 302);
            this.dgvVZamowienia.TabIndex = 2;
            this.dgvVZamowienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVZamowienia_CellClick);
            // 
            // iBtnEditZamowienie
            // 
            this.iBtnEditZamowienie.BackColor = System.Drawing.SystemColors.Control;
            this.iBtnEditZamowienie.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEditZamowienie.IconColor = System.Drawing.Color.Black;
            this.iBtnEditZamowienie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditZamowienie.IconSize = 40;
            this.iBtnEditZamowienie.Location = new System.Drawing.Point(141, 367);
            this.iBtnEditZamowienie.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnEditZamowienie.Name = "iBtnEditZamowienie";
            this.iBtnEditZamowienie.Size = new System.Drawing.Size(63, 63);
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
            this.iBtnNewZamowienie.Location = new System.Drawing.Point(20, 367);
            this.iBtnNewZamowienie.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnNewZamowienie.Name = "iBtnNewZamowienie";
            this.iBtnNewZamowienie.Size = new System.Drawing.Size(63, 63);
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
            this.iBtnDeleteZamowienie.Location = new System.Drawing.Point(1212, 367);
            this.iBtnDeleteZamowienie.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnDeleteZamowienie.Name = "iBtnDeleteZamowienie";
            this.iBtnDeleteZamowienie.Size = new System.Drawing.Size(63, 63);
            this.iBtnDeleteZamowienie.TabIndex = 5;
            this.iBtnDeleteZamowienie.UseVisualStyleBackColor = true;
            this.iBtnDeleteZamowienie.Click += new System.EventHandler(this.iBtnDelete_Click);
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
            // dgvVSklad
            // 
            this.dgvVSklad.AllowUserToResizeRows = false;
            this.dgvVSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVSklad.Location = new System.Drawing.Point(16, 438);
            this.dgvVSklad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVSklad.MultiSelect = false;
            this.dgvVSklad.Name = "dgvVSklad";
            this.dgvVSklad.ReadOnly = true;
            this.dgvVSklad.RowHeadersVisible = false;
            this.dgvVSklad.RowHeadersWidth = 51;
            this.dgvVSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVSklad.Size = new System.Drawing.Size(1018, 300);
            this.dgvVSklad.TabIndex = 9;
            this.dgvVSklad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVSklad_CellClick_1);
            // 
            // iBtnSprawdz
            // 
            this.iBtnSprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iBtnSprawdz.Location = new System.Drawing.Point(742, 368);
            this.iBtnSprawdz.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnSprawdz.Name = "iBtnSprawdz";
            this.iBtnSprawdz.Size = new System.Drawing.Size(152, 63);
            this.iBtnSprawdz.TabIndex = 10;
            this.iBtnSprawdz.Text = "Sprawdź\r\nDatę Realizacji";
            this.iBtnSprawdz.UseVisualStyleBackColor = true;
            this.iBtnSprawdz.Click += new System.EventHandler(this.iBtnSprawdz_Click);
            // 
            // iBtnNewSklad
            // 
            this.iBtnNewSklad.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNewSklad.IconColor = System.Drawing.Color.Black;
            this.iBtnNewSklad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNewSklad.IconSize = 40;
            this.iBtnNewSklad.Location = new System.Drawing.Point(20, 761);
            this.iBtnNewSklad.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnNewSklad.Name = "iBtnNewSklad";
            this.iBtnNewSklad.Size = new System.Drawing.Size(63, 63);
            this.iBtnNewSklad.TabIndex = 11;
            this.iBtnNewSklad.UseVisualStyleBackColor = true;
            this.iBtnNewSklad.Click += new System.EventHandler(this.iBtnNewSklad_Click);
            // 
            // iBtnEditSklad
            // 
            this.iBtnEditSklad.BackColor = System.Drawing.SystemColors.Control;
            this.iBtnEditSklad.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEditSklad.IconColor = System.Drawing.Color.Black;
            this.iBtnEditSklad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditSklad.IconSize = 40;
            this.iBtnEditSklad.Location = new System.Drawing.Point(141, 761);
            this.iBtnEditSklad.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnEditSklad.Name = "iBtnEditSklad";
            this.iBtnEditSklad.Size = new System.Drawing.Size(63, 63);
            this.iBtnEditSklad.TabIndex = 12;
            this.iBtnEditSklad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEditSklad.UseVisualStyleBackColor = false;
            this.iBtnEditSklad.Click += new System.EventHandler(this.iBtnEditSklad_Click);
            // 
            // iBtnDeleteSklad
            // 
            this.iBtnDeleteSklad.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDeleteSklad.IconColor = System.Drawing.Color.Red;
            this.iBtnDeleteSklad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteSklad.IconSize = 40;
            this.iBtnDeleteSklad.Location = new System.Drawing.Point(1212, 761);
            this.iBtnDeleteSklad.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnDeleteSklad.Name = "iBtnDeleteSklad";
            this.iBtnDeleteSklad.Size = new System.Drawing.Size(63, 63);
            this.iBtnDeleteSklad.TabIndex = 13;
            this.iBtnDeleteSklad.UseVisualStyleBackColor = true;
            this.iBtnDeleteSklad.Click += new System.EventHandler(this.iBtnDeleteSklad_Click);
            // 
            // btnStanZamowienia
            // 
            this.btnStanZamowienia.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btnStanZamowienia.IconColor = System.Drawing.Color.Black;
            this.btnStanZamowienia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStanZamowienia.IconSize = 40;
            this.btnStanZamowienia.Location = new System.Drawing.Point(608, 367);
            this.btnStanZamowienia.Margin = new System.Windows.Forms.Padding(4);
            this.btnStanZamowienia.Name = "btnStanZamowienia";
            this.btnStanZamowienia.Size = new System.Drawing.Size(63, 63);
            this.btnStanZamowienia.TabIndex = 14;
            this.btnStanZamowienia.UseVisualStyleBackColor = true;
            this.btnStanZamowienia.Click += new System.EventHandler(this.btnStanZamowienia_Click);
            // 
            // txtWartoscNetto
            // 
            this.txtWartoscNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscNetto.Location = new System.Drawing.Point(1053, 538);
            this.txtWartoscNetto.Margin = new System.Windows.Forms.Padding(4);
            this.txtWartoscNetto.Name = "txtWartoscNetto";
            this.txtWartoscNetto.ReadOnly = true;
            this.txtWartoscNetto.Size = new System.Drawing.Size(202, 34);
            this.txtWartoscNetto.TabIndex = 15;
            this.txtWartoscNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWartoscNetto.TextChanged += new System.EventHandler(this.txtCenaNetto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1048, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Łączna Wartość Netto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1048, 599);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Łączna Wartość Brutto:";
            // 
            // txtWartoscBrutto
            // 
            this.txtWartoscBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartoscBrutto.Location = new System.Drawing.Point(1053, 632);
            this.txtWartoscBrutto.Margin = new System.Windows.Forms.Padding(4);
            this.txtWartoscBrutto.Name = "txtWartoscBrutto";
            this.txtWartoscBrutto.ReadOnly = true;
            this.txtWartoscBrutto.Size = new System.Drawing.Size(202, 34);
            this.txtWartoscBrutto.TabIndex = 17;
            this.txtWartoscBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1263, 541);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "zł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1263, 635);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "zł";
            // 
            // AFZamowieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 838);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWartoscBrutto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWartoscNetto);
            this.Controls.Add(this.btnStanZamowienia);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private FontAwesome.Sharp.IconButton btnStanZamowienia;
        private System.Windows.Forms.TextBox txtWartoscNetto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWartoscBrutto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}