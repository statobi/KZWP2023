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
            this.btn_przeglady = new System.Windows.Forms.Button();
            this.btn_ubezpieczenia = new System.Windows.Forms.Button();
            this.btn_dodaj_pojazd = new System.Windows.Forms.Button();
            this.btn_usun_pojazd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pojazdymain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pojazdymain
            // 
            this.dgv_pojazdymain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pojazdymain.Location = new System.Drawing.Point(26, 23);
            this.dgv_pojazdymain.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_pojazdymain.Name = "dgv_pojazdymain";
            this.dgv_pojazdymain.RowHeadersWidth = 51;
            this.dgv_pojazdymain.RowTemplate.Height = 24;
            this.dgv_pojazdymain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pojazdymain.Size = new System.Drawing.Size(847, 260);
            this.dgv_pojazdymain.TabIndex = 0;
            this.dgv_pojazdymain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pojazdymain_CellClick);
            // 
            // btn_dostepne_pojazdy
            // 
            this.btn_dostepne_pojazdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dostepne_pojazdy.Location = new System.Drawing.Point(460, 299);
            this.btn_dostepne_pojazdy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dostepne_pojazdy.Name = "btn_dostepne_pojazdy";
            this.btn_dostepne_pojazdy.Size = new System.Drawing.Size(205, 80);
            this.btn_dostepne_pojazdy.TabIndex = 3;
            this.btn_dostepne_pojazdy.Text = "Pokaż dostępne pojazdy";
            this.btn_dostepne_pojazdy.UseVisualStyleBackColor = true;
            this.btn_dostepne_pojazdy.Click += new System.EventHandler(this.btn_dostepne_pojazdy_Click);
            // 
            // btn_odswiez
            // 
            this.btn_odswiez.Location = new System.Drawing.Point(746, 299);
            this.btn_odswiez.Margin = new System.Windows.Forms.Padding(2);
            this.btn_odswiez.Name = "btn_odswiez";
            this.btn_odswiez.Size = new System.Drawing.Size(127, 52);
            this.btn_odswiez.TabIndex = 7;
            this.btn_odswiez.Text = "Odśwież widok";
            this.btn_odswiez.UseVisualStyleBackColor = true;
            this.btn_odswiez.Click += new System.EventHandler(this.btn_odswiez_Click);
            // 
            // btn_przeglady
            // 
            this.btn_przeglady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_przeglady.Location = new System.Drawing.Point(113, 383);
            this.btn_przeglady.Margin = new System.Windows.Forms.Padding(2);
            this.btn_przeglady.Name = "btn_przeglady";
            this.btn_przeglady.Size = new System.Drawing.Size(205, 80);
            this.btn_przeglady.TabIndex = 8;
            this.btn_przeglady.Text = "Przeglądy";
            this.btn_przeglady.UseVisualStyleBackColor = true;
            this.btn_przeglady.Click += new System.EventHandler(this.btn_przeglady_Click);
            // 
            // btn_ubezpieczenia
            // 
            this.btn_ubezpieczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ubezpieczenia.Location = new System.Drawing.Point(113, 299);
            this.btn_ubezpieczenia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ubezpieczenia.Name = "btn_ubezpieczenia";
            this.btn_ubezpieczenia.Size = new System.Drawing.Size(205, 80);
            this.btn_ubezpieczenia.TabIndex = 9;
            this.btn_ubezpieczenia.Text = "Ubezpieczenia";
            this.btn_ubezpieczenia.UseVisualStyleBackColor = true;
            this.btn_ubezpieczenia.Click += new System.EventHandler(this.btn_ubezpieczenia_Click);
            // 
            // btn_dodaj_pojazd
            // 
            this.btn_dodaj_pojazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dodaj_pojazd.Location = new System.Drawing.Point(460, 386);
            this.btn_dodaj_pojazd.Name = "btn_dodaj_pojazd";
            this.btn_dodaj_pojazd.Size = new System.Drawing.Size(205, 75);
            this.btn_dodaj_pojazd.TabIndex = 10;
            this.btn_dodaj_pojazd.Text = "Dodaj pojazd";
            this.btn_dodaj_pojazd.UseVisualStyleBackColor = true;
            this.btn_dodaj_pojazd.Click += new System.EventHandler(this.btn_dodaj_pojazd_Click);
            // 
            // btn_usun_pojazd
            // 
            this.btn_usun_pojazd.Location = new System.Drawing.Point(714, 392);
            this.btn_usun_pojazd.Name = "btn_usun_pojazd";
            this.btn_usun_pojazd.Size = new System.Drawing.Size(140, 69);
            this.btn_usun_pojazd.TabIndex = 11;
            this.btn_usun_pojazd.Text = "Usuń pojazd";
            this.btn_usun_pojazd.UseVisualStyleBackColor = true;
            this.btn_usun_pojazd.Click += new System.EventHandler(this.btn_usun_pojazd_Click);
            // 
            // PojazdyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 530);
            this.Controls.Add(this.btn_usun_pojazd);
            this.Controls.Add(this.btn_dodaj_pojazd);
            this.Controls.Add(this.btn_ubezpieczenia);
            this.Controls.Add(this.btn_przeglady);
            this.Controls.Add(this.btn_odswiez);
            this.Controls.Add(this.btn_dostepne_pojazdy);
            this.Controls.Add(this.dgv_pojazdymain);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btn_przeglady;
        private System.Windows.Forms.Button btn_ubezpieczenia;
        private System.Windows.Forms.Button btn_dodaj_pojazd;
        private System.Windows.Forms.Button btn_usun_pojazd;
    }
}