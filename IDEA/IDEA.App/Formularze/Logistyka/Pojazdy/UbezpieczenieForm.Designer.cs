namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    partial class UbezpieczenieForm
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
            this.dgv_ubezpieczenia = new System.Windows.Forms.DataGridView();
            this.btn_usunUbezpieczenie = new System.Windows.Forms.Button();
            this.btn_dodajUbezpieczenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubezpieczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ubezpieczenia
            // 
            this.dgv_ubezpieczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ubezpieczenia.Location = new System.Drawing.Point(12, 22);
            this.dgv_ubezpieczenia.Name = "dgv_ubezpieczenia";
            this.dgv_ubezpieczenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ubezpieczenia.Size = new System.Drawing.Size(822, 269);
            this.dgv_ubezpieczenia.TabIndex = 0;
            this.dgv_ubezpieczenia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ubezpieczenia_CellClick);
            // 
            // btn_usunUbezpieczenie
            // 
            this.btn_usunUbezpieczenie.Location = new System.Drawing.Point(456, 343);
            this.btn_usunUbezpieczenie.Name = "btn_usunUbezpieczenie";
            this.btn_usunUbezpieczenie.Size = new System.Drawing.Size(162, 59);
            this.btn_usunUbezpieczenie.TabIndex = 1;
            this.btn_usunUbezpieczenie.Text = "Usuń ubezpieczenie";
            this.btn_usunUbezpieczenie.UseVisualStyleBackColor = true;
            this.btn_usunUbezpieczenie.Click += new System.EventHandler(this.btn_usunUbezpieczenie_Click);
            // 
            // btn_dodajUbezpieczenie
            // 
            this.btn_dodajUbezpieczenie.Location = new System.Drawing.Point(193, 343);
            this.btn_dodajUbezpieczenie.Name = "btn_dodajUbezpieczenie";
            this.btn_dodajUbezpieczenie.Size = new System.Drawing.Size(162, 59);
            this.btn_dodajUbezpieczenie.TabIndex = 2;
            this.btn_dodajUbezpieczenie.Text = "Dodaj ubezpieczenie";
            this.btn_dodajUbezpieczenie.UseVisualStyleBackColor = true;
            this.btn_dodajUbezpieczenie.Click += new System.EventHandler(this.btn_dodajUbezpieczenie_Click);
            // 
            // UbezpieczenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 472);
            this.Controls.Add(this.btn_dodajUbezpieczenie);
            this.Controls.Add(this.btn_usunUbezpieczenie);
            this.Controls.Add(this.dgv_ubezpieczenia);
            this.Name = "UbezpieczenieForm";
            this.Text = "UbezpieczenieForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubezpieczenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ubezpieczenia;
        private System.Windows.Forms.Button btn_usunUbezpieczenie;
        private System.Windows.Forms.Button btn_dodajUbezpieczenie;
    }
}