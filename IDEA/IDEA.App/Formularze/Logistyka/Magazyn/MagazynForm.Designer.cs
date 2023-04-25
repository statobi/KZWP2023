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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMagazyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMagazyny
            // 
            this.DGVMagazyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMagazyny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMagazyny.Location = new System.Drawing.Point(12, 12);
            this.DGVMagazyny.Name = "DGVMagazyny";
            this.DGVMagazyny.RowHeadersWidth = 51;
            this.DGVMagazyny.Size = new System.Drawing.Size(1288, 364);
            this.DGVMagazyny.TabIndex = 0;
            // 
            // BtnDodajMagazyn
            // 
            this.BtnDodajMagazyn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDodajMagazyn.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodajMagazyn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnDodajMagazyn.IconColor = System.Drawing.Color.Black;
            this.BtnDodajMagazyn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDodajMagazyn.IconSize = 32;
            this.BtnDodajMagazyn.Location = new System.Drawing.Point(12, 777);
            this.BtnDodajMagazyn.Name = "BtnDodajMagazyn";
            this.BtnDodajMagazyn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnDodajMagazyn.Size = new System.Drawing.Size(167, 49);
            this.BtnDodajMagazyn.TabIndex = 4;
            this.BtnDodajMagazyn.Text = "Dodaj";
            this.BtnDodajMagazyn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDodajMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.BtnModyfikujMagazyn.Location = new System.Drawing.Point(203, 777);
            this.BtnModyfikujMagazyn.Name = "BtnModyfikujMagazyn";
            this.BtnModyfikujMagazyn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnModyfikujMagazyn.Size = new System.Drawing.Size(196, 49);
            this.BtnModyfikujMagazyn.TabIndex = 5;
            this.BtnModyfikujMagazyn.Text = "Modyfikuj";
            this.BtnModyfikujMagazyn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModyfikujMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModyfikujMagazyn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 389);
            this.dataGridView1.TabIndex = 6;
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 851);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnModyfikujMagazyn);
            this.Controls.Add(this.BtnDodajMagazyn);
            this.Controls.Add(this.DGVMagazyny);
            this.MaximizeBox = false;
            this.Name = "MagazynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagazynForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMagazyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMagazyny;
        private FontAwesome.Sharp.IconButton BtnDodajMagazyn;
        private FontAwesome.Sharp.IconButton BtnModyfikujMagazyn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}