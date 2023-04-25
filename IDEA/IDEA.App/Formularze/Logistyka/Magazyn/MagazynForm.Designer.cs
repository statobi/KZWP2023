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
            this.DGVMagazyny = new System.Windows.Forms.DataGridView();
            this.BtnDodajMagazyn = new FontAwesome.Sharp.IconButton();
            this.BtnModyfikujMagazyn = new FontAwesome.Sharp.IconButton();
            this.DVGSekcja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMagazyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGSekcja)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMagazyny
            // 
            this.DGVMagazyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMagazyny.Location = new System.Drawing.Point(9, 10);
            this.DGVMagazyny.Margin = new System.Windows.Forms.Padding(2);
            this.DGVMagazyny.Name = "DGVMagazyny";
            this.DGVMagazyny.RowHeadersWidth = 51;
            this.DGVMagazyny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMagazyny.Size = new System.Drawing.Size(966, 296);
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
            this.BtnDodajMagazyn.Location = new System.Drawing.Point(9, 631);
            this.BtnDodajMagazyn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodajMagazyn.Name = "BtnDodajMagazyn";
            this.BtnDodajMagazyn.Size = new System.Drawing.Size(56, 49);
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
            this.BtnModyfikujMagazyn.Location = new System.Drawing.Point(78, 631);
            this.BtnModyfikujMagazyn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModyfikujMagazyn.Name = "BtnModyfikujMagazyn";
            this.BtnModyfikujMagazyn.Size = new System.Drawing.Size(56, 49);
            this.BtnModyfikujMagazyn.TabIndex = 5;
            this.BtnModyfikujMagazyn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModyfikujMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModyfikujMagazyn.UseVisualStyleBackColor = true;
            this.BtnModyfikujMagazyn.Click += new System.EventHandler(this.BtnModyfikujMagazyn_Click);
            // 
            // DVGSekcja
            // 
            this.DVGSekcja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGSekcja.Location = new System.Drawing.Point(9, 310);
            this.DVGSekcja.Margin = new System.Windows.Forms.Padding(2);
            this.DVGSekcja.Name = "DVGSekcja";
            this.DVGSekcja.RowHeadersWidth = 51;
            this.DVGSekcja.RowTemplate.Height = 24;
            this.DVGSekcja.Size = new System.Drawing.Size(966, 316);
            this.DVGSekcja.TabIndex = 6;
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.DVGSekcja);
            this.Controls.Add(this.BtnModyfikujMagazyn);
            this.Controls.Add(this.BtnDodajMagazyn);
            this.Controls.Add(this.DGVMagazyny);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MagazynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagazynForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMagazyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGSekcja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMagazyny;
        private FontAwesome.Sharp.IconButton BtnDodajMagazyn;
        private FontAwesome.Sharp.IconButton BtnModyfikujMagazyn;
        private System.Windows.Forms.DataGridView DVGSekcja;
    }
}