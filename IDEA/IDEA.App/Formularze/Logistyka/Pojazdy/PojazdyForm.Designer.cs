namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    partial class PojazdyForm
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
            this.dgv_pojazdymain = new System.Windows.Forms.DataGridView();
            this.btn_dostepne_pojazdy = new System.Windows.Forms.Button();
            this.btn_odswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pojazdymain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pojazdymain
            // 
            this.dgv_pojazdymain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pojazdymain.Location = new System.Drawing.Point(34, 28);
            this.dgv_pojazdymain.Name = "dgv_pojazdymain";
            this.dgv_pojazdymain.RowHeadersWidth = 51;
            this.dgv_pojazdymain.RowTemplate.Height = 24;
            this.dgv_pojazdymain.Size = new System.Drawing.Size(1129, 320);
            this.dgv_pojazdymain.TabIndex = 0;
            this.dgv_pojazdymain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pojazdymain_CellContentClick);
            // 
            // btn_dostepne_pojazdy
            // 
            this.btn_dostepne_pojazdy.Location = new System.Drawing.Point(737, 414);
            this.btn_dostepne_pojazdy.Name = "btn_dostepne_pojazdy";
            this.btn_dostepne_pojazdy.Size = new System.Drawing.Size(273, 98);
            this.btn_dostepne_pojazdy.TabIndex = 3;
            this.btn_dostepne_pojazdy.Text = "Pokaż dostępne pojazdy";
            this.btn_dostepne_pojazdy.UseVisualStyleBackColor = true;
            this.btn_dostepne_pojazdy.Click += new System.EventHandler(this.btn_dostepne_pojazdy_Click);
            // 
            // btn_odswiez
            // 
            this.btn_odswiez.Location = new System.Drawing.Point(149, 414);
            this.btn_odswiez.Name = "btn_odswiez";
            this.btn_odswiez.Size = new System.Drawing.Size(273, 98);
            this.btn_odswiez.TabIndex = 7;
            this.btn_odswiez.Text = "Odśwież widok";
            this.btn_odswiez.UseVisualStyleBackColor = true;
            this.btn_odswiez.Click += new System.EventHandler(this.btn_odswiez_Click);
            // 
            // PojazdyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 581);
            this.Controls.Add(this.btn_odswiez);
            this.Controls.Add(this.btn_dostepne_pojazdy);
            this.Controls.Add(this.dgv_pojazdymain);
            this.Name = "PojazdyForm";
            this.Text = "PojazdyMain";
            this.Load += new System.EventHandler(this.PojazdyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pojazdymain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pojazdymain;
        private System.Windows.Forms.Button btn_dostepne_pojazdy;
        private System.Windows.Forms.Button btn_odswiez;
    }
}