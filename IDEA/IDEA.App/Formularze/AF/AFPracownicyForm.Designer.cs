namespace IDEA.App
{
    partial class AFPracownicyForm
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
            this.dgvPracownicy = new System.Windows.Forms.DataGridView();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDzial = new System.Windows.Forms.Button();
            this.btnStanowisko = new System.Windows.Forms.Button();
            this.btnRodzajUmowy = new System.Windows.Forms.Button();
            this.btnZatrudnienie = new System.Windows.Forms.Button();
            this.btnJezyki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPracownicy
            // 
            this.dgvPracownicy.AllowUserToResizeRows = false;
            this.dgvPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracownicy.Location = new System.Drawing.Point(16, 58);
            this.dgvPracownicy.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPracownicy.MultiSelect = false;
            this.dgvPracownicy.Name = "dgvPracownicy";
            this.dgvPracownicy.ReadOnly = true;
            this.dgvPracownicy.RowHeadersVisible = false;
            this.dgvPracownicy.RowHeadersWidth = 51;
            this.dgvPracownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPracownicy.Size = new System.Drawing.Size(1280, 489);
            this.dgvPracownicy.TabIndex = 2;
            this.dgvPracownicy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPracownicy_CellClick);
            this.dgvPracownicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPracownicy_CellContentClick);
            // 
            // iBtnEdit
            // 
            this.iBtnEdit.BackColor = System.Drawing.Color.White;
            this.iBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEdit.Location = new System.Drawing.Point(140, 601);
            this.iBtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnEdit.Name = "iBtnEdit";
            this.iBtnEdit.Size = new System.Drawing.Size(100, 87);
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
            this.iBtnNew.Location = new System.Drawing.Point(16, 601);
            this.iBtnNew.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(100, 87);
            this.iBtnNew.TabIndex = 4;
            this.iBtnNew.UseVisualStyleBackColor = true;
            this.iBtnNew.Click += new System.EventHandler(this.iBtnNew_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(1196, 601);
            this.iBtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(100, 87);
            this.iBtnDelete.TabIndex = 5;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(525, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pracownicy";
            // 
            // btnDzial
            // 
            this.btnDzial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDzial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDzial.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDzial.Location = new System.Drawing.Point(115, 726);
            this.btnDzial.Name = "btnDzial";
            this.btnDzial.Size = new System.Drawing.Size(196, 60);
            this.btnDzial.TabIndex = 9;
            this.btnDzial.Text = "Dział";
            this.btnDzial.UseVisualStyleBackColor = false;
            this.btnDzial.Click += new System.EventHandler(this.btnDzial_Click);
            // 
            // btnStanowisko
            // 
            this.btnStanowisko.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStanowisko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStanowisko.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanowisko.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStanowisko.Location = new System.Drawing.Point(317, 726);
            this.btnStanowisko.Name = "btnStanowisko";
            this.btnStanowisko.Size = new System.Drawing.Size(199, 60);
            this.btnStanowisko.TabIndex = 10;
            this.btnStanowisko.Text = "Stanowisko";
            this.btnStanowisko.UseVisualStyleBackColor = false;
            this.btnStanowisko.Click += new System.EventHandler(this.btnStanowisko_Click);
            // 
            // btnRodzajUmowy
            // 
            this.btnRodzajUmowy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRodzajUmowy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRodzajUmowy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRodzajUmowy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRodzajUmowy.Location = new System.Drawing.Point(522, 726);
            this.btnRodzajUmowy.Name = "btnRodzajUmowy";
            this.btnRodzajUmowy.Size = new System.Drawing.Size(225, 60);
            this.btnRodzajUmowy.TabIndex = 11;
            this.btnRodzajUmowy.Text = "Rodzaj Umowy";
            this.btnRodzajUmowy.UseVisualStyleBackColor = false;
            this.btnRodzajUmowy.Click += new System.EventHandler(this.btnRodzajUmowy_Click);
            // 
            // btnZatrudnienie
            // 
            this.btnZatrudnienie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnZatrudnienie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZatrudnienie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatrudnienie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZatrudnienie.Location = new System.Drawing.Point(753, 726);
            this.btnZatrudnienie.Name = "btnZatrudnienie";
            this.btnZatrudnienie.Size = new System.Drawing.Size(218, 60);
            this.btnZatrudnienie.TabIndex = 12;
            this.btnZatrudnienie.Text = "Zatrudnienie";
            this.btnZatrudnienie.UseVisualStyleBackColor = false;
            this.btnZatrudnienie.Click += new System.EventHandler(this.btnZatrudnienie_Click);
            // 
            // btnJezyki
            // 
            this.btnJezyki.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnJezyki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJezyki.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJezyki.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJezyki.Location = new System.Drawing.Point(977, 726);
            this.btnJezyki.Name = "btnJezyki";
            this.btnJezyki.Size = new System.Drawing.Size(212, 60);
            this.btnJezyki.TabIndex = 13;
            this.btnJezyki.Text = "Języki";
            this.btnJezyki.UseVisualStyleBackColor = false;
            this.btnJezyki.Click += new System.EventHandler(this.btnJezyki_Click);
            // 
            // AFPracownicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 838);
            this.Controls.Add(this.btnJezyki);
            this.Controls.Add(this.btnZatrudnienie);
            this.Controls.Add(this.btnRodzajUmowy);
            this.Controls.Add(this.btnStanowisko);
            this.Controls.Add(this.btnDzial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.iBtnNew);
            this.Controls.Add(this.iBtnEdit);
            this.Controls.Add(this.dgvPracownicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFPracownicyForm";
            this.Tag = "Pracownicy";
            this.Text = "AFPracownicyForm";
            this.Load += new System.EventHandler(this.AFPracownicyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPracownicy;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDzial;
        private System.Windows.Forms.Button btnStanowisko;
        private System.Windows.Forms.Button btnRodzajUmowy;
        private System.Windows.Forms.Button btnZatrudnienie;
        private System.Windows.Forms.Button btnJezyki;
    }
}