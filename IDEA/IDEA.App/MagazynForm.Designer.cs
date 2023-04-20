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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDodajMagazyn = new FontAwesome.Sharp.IconButton();
            this.BtnModyfikujMagazyn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 607);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(655, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dostępne magazyny";
            // 
            // BtnDodajMagazyn
            // 
            this.BtnDodajMagazyn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDodajMagazyn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodajMagazyn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnDodajMagazyn.IconColor = System.Drawing.Color.Black;
            this.BtnDodajMagazyn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDodajMagazyn.IconSize = 36;
            this.BtnDodajMagazyn.Location = new System.Drawing.Point(12, 104);
            this.BtnDodajMagazyn.Name = "BtnDodajMagazyn";
            this.BtnDodajMagazyn.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.BtnDodajMagazyn.Size = new System.Drawing.Size(311, 49);
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
            this.BtnModyfikujMagazyn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnModyfikujMagazyn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BtnModyfikujMagazyn.IconColor = System.Drawing.Color.Black;
            this.BtnModyfikujMagazyn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnModyfikujMagazyn.IconSize = 32;
            this.BtnModyfikujMagazyn.Location = new System.Drawing.Point(12, 177);
            this.BtnModyfikujMagazyn.Name = "BtnModyfikujMagazyn";
            this.BtnModyfikujMagazyn.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.BtnModyfikujMagazyn.Size = new System.Drawing.Size(311, 49);
            this.BtnModyfikujMagazyn.TabIndex = 5;
            this.BtnModyfikujMagazyn.Text = "Modyfikuj";
            this.BtnModyfikujMagazyn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModyfikujMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModyfikujMagazyn.UseVisualStyleBackColor = true;
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.BtnModyfikujMagazyn);
            this.Controls.Add(this.BtnDodajMagazyn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MagazynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagazynForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnDodajMagazyn;
        private FontAwesome.Sharp.IconButton BtnModyfikujMagazyn;
    }
}