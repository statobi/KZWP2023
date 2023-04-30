namespace IDEA.App.Formularze.Logistyka.Wysylki
{
    partial class WysylkiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSkladWysylki = new System.Windows.Forms.DataGridView();
            this.BtnDodaj = new FontAwesome.Sharp.IconButton();
            this.dgvWysylka = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladWysylki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWysylka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Skład wysyłki:";
            // 
            // dgvSkladWysylki
            // 
            this.dgvSkladWysylki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladWysylki.Location = new System.Drawing.Point(12, 361);
            this.dgvSkladWysylki.Name = "dgvSkladWysylki";
            this.dgvSkladWysylki.RowHeadersWidth = 47;
            this.dgvSkladWysylki.Size = new System.Drawing.Size(966, 263);
            this.dgvSkladWysylki.TabIndex = 10;
            this.dgvSkladWysylki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladWysylki_CellContentClick);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnDodaj.IconColor = System.Drawing.Color.Black;
            this.BtnDodaj.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDodaj.IconSize = 40;
            this.BtnDodaj.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDodaj.Location = new System.Drawing.Point(458, 629);
            this.BtnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(56, 47);
            this.BtnDodaj.TabIndex = 9;
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // dgvWysylka
            // 
            this.dgvWysylka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWysylka.Location = new System.Drawing.Point(12, 36);
            this.dgvWysylka.Name = "dgvWysylka";
            this.dgvWysylka.RowHeadersWidth = 47;
            this.dgvWysylka.Size = new System.Drawing.Size(966, 286);
            this.dgvWysylka.TabIndex = 8;
            this.dgvWysylka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWysylka_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wszystkie wysyłki";
            // 
            // WysylkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 853);
            this.Controls.Add(this.dgvWysylka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSkladWysylki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDodaj);
            this.Name = "WysylkiForm";
            this.Text = "Wysyłki";
            this.Load += new System.EventHandler(this.WysylkiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladWysylki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWysylka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSkladWysylki;
        private FontAwesome.Sharp.IconButton BtnDodaj;
        private System.Windows.Forms.DataGridView dgvWysylka;
        private System.Windows.Forms.Label label2;
    }
}