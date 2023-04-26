namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    partial class MagazynForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVMagazyny = new System.Windows.Forms.DataGridView();
            this.BtnDodajMagazyn = new FontAwesome.Sharp.IconButton();
            this.BtnModyfikujMagazyn = new FontAwesome.Sharp.IconButton();
            this.DVGSekcja = new System.Windows.Forms.DataGridView();
            this.BtnAddSekcja = new FontAwesome.Sharp.IconButton();
            this.BtnModifySekcja = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMagazyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGSekcja)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMagazyny
            // 
            this.DGVMagazyny.AllowUserToAddRows = false;
            this.DGVMagazyny.AllowUserToDeleteRows = false;
            this.DGVMagazyny.AllowUserToOrderColumns = true;
            this.DGVMagazyny.AllowUserToResizeColumns = false;
            this.DGVMagazyny.AllowUserToResizeRows = false;
            this.DGVMagazyny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMagazyny.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVMagazyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMagazyny.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMagazyny.Location = new System.Drawing.Point(12, 67);
            this.DGVMagazyny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVMagazyny.MultiSelect = false;
            this.DGVMagazyny.Name = "DGVMagazyny";
            this.DGVMagazyny.ReadOnly = true;
            this.DGVMagazyny.RowHeadersWidth = 51;
            this.DGVMagazyny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMagazyny.Size = new System.Drawing.Size(1288, 340);
            this.DGVMagazyny.TabIndex = 0;
            this.DGVMagazyny.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMagazyny_CellClick);
            // 
            // BtnDodajMagazyn
            // 
            this.BtnDodajMagazyn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDodajMagazyn.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodajMagazyn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnDodajMagazyn.IconColor = System.Drawing.Color.Black;
            this.BtnDodajMagazyn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDodajMagazyn.IconSize = 40;
            this.BtnDodajMagazyn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDodajMagazyn.Location = new System.Drawing.Point(1144, 411);
            this.BtnDodajMagazyn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDodajMagazyn.Name = "BtnDodajMagazyn";
            this.BtnDodajMagazyn.Size = new System.Drawing.Size(75, 60);
            this.BtnDodajMagazyn.TabIndex = 4;
            this.BtnDodajMagazyn.UseVisualStyleBackColor = true;
            this.BtnDodajMagazyn.Click += new System.EventHandler(this.BtnDodajMagazyn_Click);
            // 
            // BtnModyfikujMagazyn
            // 
            this.BtnModyfikujMagazyn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnModyfikujMagazyn.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnModyfikujMagazyn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BtnModyfikujMagazyn.IconColor = System.Drawing.Color.Black;
            this.BtnModyfikujMagazyn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnModyfikujMagazyn.IconSize = 32;
            this.BtnModyfikujMagazyn.Location = new System.Drawing.Point(1225, 411);
            this.BtnModyfikujMagazyn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModyfikujMagazyn.Name = "BtnModyfikujMagazyn";
            this.BtnModyfikujMagazyn.Size = new System.Drawing.Size(75, 60);
            this.BtnModyfikujMagazyn.TabIndex = 5;
            this.BtnModyfikujMagazyn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModyfikujMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModyfikujMagazyn.UseVisualStyleBackColor = true;
            this.BtnModyfikujMagazyn.Click += new System.EventHandler(this.BtnModyfikujMagazyn_Click);
            // 
            // DVGSekcja
            // 
            this.DVGSekcja.AllowUserToAddRows = false;
            this.DVGSekcja.AllowUserToDeleteRows = false;
            this.DVGSekcja.AllowUserToResizeColumns = false;
            this.DVGSekcja.AllowUserToResizeRows = false;
            this.DVGSekcja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVGSekcja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DVGSekcja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGSekcja.Location = new System.Drawing.Point(12, 475);
            this.DVGSekcja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DVGSekcja.MultiSelect = false;
            this.DVGSekcja.Name = "DVGSekcja";
            this.DVGSekcja.ReadOnly = true;
            this.DVGSekcja.RowHeadersWidth = 51;
            this.DVGSekcja.RowTemplate.Height = 24;
            this.DVGSekcja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVGSekcja.Size = new System.Drawing.Size(1288, 305);
            this.DVGSekcja.TabIndex = 6;
            this.DVGSekcja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGSekcja_CellClick);
            this.DVGSekcja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGSekcja_CellDoubleClick);
            // 
            // BtnAddSekcja
            // 
            this.BtnAddSekcja.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAddSekcja.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAddSekcja.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnAddSekcja.IconColor = System.Drawing.Color.Black;
            this.BtnAddSekcja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAddSekcja.IconSize = 40;
            this.BtnAddSekcja.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddSekcja.Location = new System.Drawing.Point(1144, 784);
            this.BtnAddSekcja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddSekcja.Name = "BtnAddSekcja";
            this.BtnAddSekcja.Size = new System.Drawing.Size(75, 60);
            this.BtnAddSekcja.TabIndex = 7;
            this.BtnAddSekcja.UseVisualStyleBackColor = true;
            this.BtnAddSekcja.Click += new System.EventHandler(this.BtnAddSekcja_Click);
            // 
            // BtnModifySekcja
            // 
            this.BtnModifySekcja.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnModifySekcja.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnModifySekcja.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BtnModifySekcja.IconColor = System.Drawing.Color.Black;
            this.BtnModifySekcja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnModifySekcja.IconSize = 32;
            this.BtnModifySekcja.Location = new System.Drawing.Point(1225, 784);
            this.BtnModifySekcja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModifySekcja.Name = "BtnModifySekcja";
            this.BtnModifySekcja.Size = new System.Drawing.Size(75, 60);
            this.BtnModifySekcja.TabIndex = 8;
            this.BtnModifySekcja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModifySekcja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModifySekcja.UseVisualStyleBackColor = true;
            this.BtnModifySekcja.Click += new System.EventHandler(this.BtnModifySekcja_Click);
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 850);
            this.Controls.Add(this.BtnModifySekcja);
            this.Controls.Add(this.BtnAddSekcja);
            this.Controls.Add(this.DVGSekcja);
            this.Controls.Add(this.BtnModyfikujMagazyn);
            this.Controls.Add(this.BtnDodajMagazyn);
            this.Controls.Add(this.DGVMagazyny);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MagazynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagazynForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MagazynForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMagazyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGSekcja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMagazyny;
        private FontAwesome.Sharp.IconButton BtnDodajMagazyn;
        private FontAwesome.Sharp.IconButton BtnModyfikujMagazyn;
        private System.Windows.Forms.DataGridView DVGSekcja;
        private FontAwesome.Sharp.IconButton BtnAddSekcja;
        private FontAwesome.Sharp.IconButton BtnModifySekcja;
    }
}