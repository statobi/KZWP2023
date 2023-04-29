namespace IDEA.App
{
    partial class AFBilansForm
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
            this.dgvVSklad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVZamowienia)).BeginInit();
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
            this.dgvVSklad.Size = new System.Drawing.Size(1280, 300);
            this.dgvVSklad.TabIndex = 9;
            this.dgvVSklad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVSklad_CellClick_1);
            // 
            // AFBilansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 838);
            this.Controls.Add(this.dgvVSklad);
            this.Controls.Add(this.dgvVZamowienia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFBilansForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFKlienciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSklad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVZamowienia;
        private System.Windows.Forms.DataGridView dgvVSklad;
    }
}