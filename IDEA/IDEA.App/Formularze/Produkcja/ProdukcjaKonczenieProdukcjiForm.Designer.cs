namespace IDEA.App.Formularze.Produkcja
{
    partial class ProdukcjaKonczenieProdukcjiForm
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
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            this.dgvZakonczenie = new System.Windows.Forms.DataGridView();
            this.btnPakowanie = new System.Windows.Forms.Button();
            this.dateWysylki = new System.Windows.Forms.DateTimePicker();
            this.lblDataZmiany = new System.Windows.Forms.Label();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakonczenie)).BeginInit();
            this.SuspendLayout();
            // 
            // iBtnBack
            // 
            this.iBtnBack.ForeColor = System.Drawing.Color.Coral;
            this.iBtnBack.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iBtnBack.IconColor = System.Drawing.Color.Red;
            this.iBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBack.Location = new System.Drawing.Point(676, 386);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(75, 52);
            this.iBtnBack.TabIndex = 36;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // dgvZakonczenie
            // 
            this.dgvZakonczenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakonczenie.Location = new System.Drawing.Point(17, 19);
            this.dgvZakonczenie.Name = "dgvZakonczenie";
            this.dgvZakonczenie.Size = new System.Drawing.Size(764, 285);
            this.dgvZakonczenie.TabIndex = 37;
            this.dgvZakonczenie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZakonczenie_CellClick);
            // 
            // btnPakowanie
            // 
            this.btnPakowanie.Location = new System.Drawing.Point(520, 386);
            this.btnPakowanie.Name = "btnPakowanie";
            this.btnPakowanie.Size = new System.Drawing.Size(120, 52);
            this.btnPakowanie.TabIndex = 39;
            this.btnPakowanie.Text = "Wyślij do pakowania";
            this.btnPakowanie.UseVisualStyleBackColor = true;
            this.btnPakowanie.Click += new System.EventHandler(this.btnPakowanie_Click);
            // 
            // dateWysylki
            // 
            this.dateWysylki.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateWysylki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateWysylki.Location = new System.Drawing.Point(259, 346);
            this.dateWysylki.Margin = new System.Windows.Forms.Padding(2);
            this.dateWysylki.Name = "dateWysylki";
            this.dateWysylki.Size = new System.Drawing.Size(312, 26);
            this.dateWysylki.TabIndex = 41;
            // 
            // lblDataZmiany
            // 
            this.lblDataZmiany.AutoSize = true;
            this.lblDataZmiany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZmiany.Location = new System.Drawing.Point(80, 348);
            this.lblDataZmiany.Name = "lblDataZmiany";
            this.lblDataZmiany.Size = new System.Drawing.Size(165, 24);
            this.lblDataZmiany.TabIndex = 40;
            this.lblDataZmiany.Text = "Data Przekazania:*";
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(259, 320);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(192, 21);
            this.cbPracownik.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(136, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Pracownik:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(90, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "* Wymagane";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProdukcjaKonczenieProdukcjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.dateWysylki);
            this.Controls.Add(this.lblDataZmiany);
            this.Controls.Add(this.btnPakowanie);
            this.Controls.Add(this.dgvZakonczenie);
            this.Controls.Add(this.iBtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdukcjaKonczenieProdukcjiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdukcjaKonczenieProdukcjiForm";
            this.Load += new System.EventHandler(this.ProdukcjaKonczenieProdukcjiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakonczenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnBack;
        private System.Windows.Forms.DataGridView dgvZakonczenie;
        private System.Windows.Forms.Button btnPakowanie;
        private System.Windows.Forms.DateTimePicker dateWysylki;
        private System.Windows.Forms.Label lblDataZmiany;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}