namespace IDEA.App
{
    partial class ZarzadzanieProdukcjaForm
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
            this.dgvTrwajaceProcesy = new System.Windows.Forms.DataGridView();
            this.dgvSkladZamowienia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrwajaceProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrwajaceProcesy
            // 
            this.dgvTrwajaceProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrwajaceProcesy.Location = new System.Drawing.Point(531, 68);
            this.dgvTrwajaceProcesy.Name = "dgvTrwajaceProcesy";
            this.dgvTrwajaceProcesy.Size = new System.Drawing.Size(354, 467);
            this.dgvTrwajaceProcesy.TabIndex = 0;
            // 
            // dgvSkladZamowienia
            // 
            this.dgvSkladZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladZamowienia.Location = new System.Drawing.Point(125, 68);
            this.dgvSkladZamowienia.Name = "dgvSkladZamowienia";
            this.dgvSkladZamowienia.Size = new System.Drawing.Size(359, 467);
            this.dgvSkladZamowienia.TabIndex = 1;
            // 
            // ZarzadzanieProdukcjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.dgvSkladZamowienia);
            this.Controls.Add(this.dgvTrwajaceProcesy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ZarzadzanieProdukcjaForm";
            this.Text = "ZarzadzanieProdukcjaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrwajaceProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrwajaceProcesy;
        private System.Windows.Forms.DataGridView dgvSkladZamowienia;
    }
}