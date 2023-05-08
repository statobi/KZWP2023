namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    partial class SkladZamowieniaForm
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
            this.DGVSkladZamowienia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSkladZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSkladZamowienia
            // 
            this.DGVSkladZamowienia.AllowUserToAddRows = false;
            this.DGVSkladZamowienia.AllowUserToDeleteRows = false;
            this.DGVSkladZamowienia.AllowUserToResizeColumns = false;
            this.DGVSkladZamowienia.AllowUserToResizeRows = false;
            this.DGVSkladZamowienia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSkladZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSkladZamowienia.Location = new System.Drawing.Point(12, 12);
            this.DGVSkladZamowienia.Name = "DGVSkladZamowienia";
            this.DGVSkladZamowienia.ReadOnly = true;
            this.DGVSkladZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSkladZamowienia.Size = new System.Drawing.Size(689, 426);
            this.DGVSkladZamowienia.TabIndex = 0;
            // 
            // SkladZamowieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.DGVSkladZamowienia);
            this.MaximizeBox = false;
            this.Name = "SkladZamowieniaForm";
            this.Text = "SkladZamowieniaForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SkladZamowieniaForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSkladZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSkladZamowienia;
    }
}