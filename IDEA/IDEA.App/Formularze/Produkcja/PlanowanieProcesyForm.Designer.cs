namespace IDEA.App.Formularze.Produkcja
{
    partial class PlanowanieProcesyForm
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
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.dgvProcesy = new System.Windows.Forms.DataGridView();
            this.dgvZaplanowaneProcesy = new System.Windows.Forms.DataGridView();
            this.dgvSkladZamowienia = new System.Windows.Forms.DataGridView();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.cbNazwaProcesu = new System.Windows.Forms.ComboBox();
            this.tbIloscProduktow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaplanowaneProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(364, 559);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(75, 71);
            this.iBtnNew.TabIndex = 5;
            this.iBtnNew.UseVisualStyleBackColor = true;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(445, 559);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(75, 71);
            this.iBtnDelete.TabIndex = 7;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            // 
            // iBtnEdit
            // 
            this.iBtnEdit.BackColor = System.Drawing.Color.White;
            this.iBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEdit.Location = new System.Drawing.Point(526, 559);
            this.iBtnEdit.Name = "iBtnEdit";
            this.iBtnEdit.Size = new System.Drawing.Size(75, 71);
            this.iBtnEdit.TabIndex = 6;
            this.iBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEdit.UseVisualStyleBackColor = false;
            // 
            // dgvProcesy
            // 
            this.dgvProcesy.AllowUserToResizeRows = false;
            this.dgvProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesy.Location = new System.Drawing.Point(24, 313);
            this.dgvProcesy.MultiSelect = false;
            this.dgvProcesy.Name = "dgvProcesy";
            this.dgvProcesy.ReadOnly = true;
            this.dgvProcesy.RowHeadersVisible = false;
            this.dgvProcesy.RowHeadersWidth = 51;
            this.dgvProcesy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcesy.Size = new System.Drawing.Size(316, 317);
            this.dgvProcesy.TabIndex = 8;
            this.dgvProcesy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesy_CellContentClick);
            // 
            // dgvZaplanowaneProcesy
            // 
            this.dgvZaplanowaneProcesy.AllowUserToResizeRows = false;
            this.dgvZaplanowaneProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaplanowaneProcesy.Location = new System.Drawing.Point(607, 313);
            this.dgvZaplanowaneProcesy.MultiSelect = false;
            this.dgvZaplanowaneProcesy.Name = "dgvZaplanowaneProcesy";
            this.dgvZaplanowaneProcesy.ReadOnly = true;
            this.dgvZaplanowaneProcesy.RowHeadersVisible = false;
            this.dgvZaplanowaneProcesy.RowHeadersWidth = 51;
            this.dgvZaplanowaneProcesy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaplanowaneProcesy.Size = new System.Drawing.Size(338, 317);
            this.dgvZaplanowaneProcesy.TabIndex = 9;
            // 
            // dgvSkladZamowienia
            // 
            this.dgvSkladZamowienia.AllowUserToResizeRows = false;
            this.dgvSkladZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladZamowienia.Location = new System.Drawing.Point(24, 98);
            this.dgvSkladZamowienia.MultiSelect = false;
            this.dgvSkladZamowienia.Name = "dgvSkladZamowienia";
            this.dgvSkladZamowienia.ReadOnly = true;
            this.dgvSkladZamowienia.RowHeadersVisible = false;
            this.dgvSkladZamowienia.RowHeadersWidth = 51;
            this.dgvSkladZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladZamowienia.Size = new System.Drawing.Size(921, 166);
            this.dgvSkladZamowienia.TabIndex = 10;
            this.dgvSkladZamowienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladZamowienia_CellClick);
            this.dgvSkladZamowienia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladZamowienia_CellContentClick);
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(32, 267);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(229, 25);
            this.lblKindWindow.TabIndex = 11;
            this.lblKindWindow.Text = "Proces technologiczny";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(618, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Zaplanowane procesy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 13;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvZamowienia
            // 
            this.dgvZamowienia.AllowUserToResizeRows = false;
            this.dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienia.Location = new System.Drawing.Point(24, 19);
            this.dgvZamowienia.MultiSelect = false;
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.ReadOnly = true;
            this.dgvZamowienia.RowHeadersVisible = false;
            this.dgvZamowienia.RowHeadersWidth = 51;
            this.dgvZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZamowienia.Size = new System.Drawing.Size(266, 61);
            this.dgvZamowienia.TabIndex = 14;
            this.dgvZamowienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZamowienia_CellClick);
            // 
            // cbNazwaProcesu
            // 
            this.cbNazwaProcesu.FormattingEnabled = true;
            this.cbNazwaProcesu.Location = new System.Drawing.Point(379, 326);
            this.cbNazwaProcesu.Name = "cbNazwaProcesu";
            this.cbNazwaProcesu.Size = new System.Drawing.Size(192, 21);
            this.cbNazwaProcesu.TabIndex = 15;
            // 
            // tbIloscProduktow
            // 
            this.tbIloscProduktow.Location = new System.Drawing.Point(379, 378);
            this.tbIloscProduktow.Name = "tbIloscProduktow";
            this.tbIloscProduktow.Size = new System.Drawing.Size(192, 20);
            this.tbIloscProduktow.TabIndex = 16;
            // 
            // PlanowanieProcesyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 642);
            this.Controls.Add(this.tbIloscProduktow);
            this.Controls.Add(this.cbNazwaProcesu);
            this.Controls.Add(this.dgvZamowienia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKindWindow);
            this.Controls.Add(this.dgvSkladZamowienia);
            this.Controls.Add(this.dgvZaplanowaneProcesy);
            this.Controls.Add(this.dgvProcesy);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.iBtnEdit);
            this.Controls.Add(this.iBtnNew);
            this.Name = "PlanowanieProcesyForm";
            this.Text = "PlanowanieProcesyForm";
            this.Load += new System.EventHandler(this.PlanowanieProcesyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaplanowaneProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnNew;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private System.Windows.Forms.DataGridView dgvProcesy;
        private System.Windows.Forms.DataGridView dgvZaplanowaneProcesy;
        private System.Windows.Forms.DataGridView dgvSkladZamowienia;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvZamowienia;
        private System.Windows.Forms.ComboBox cbNazwaProcesu;
        private System.Windows.Forms.TextBox tbIloscProduktow;
    }
}