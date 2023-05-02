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
            this.dateWysylki.Location = new System.Drawing.Point(259, 343);
            this.dateWysylki.Margin = new System.Windows.Forms.Padding(2);
            this.dateWysylki.Name = "dateWysylki";
            this.dateWysylki.Size = new System.Drawing.Size(381, 26);
            this.dateWysylki.TabIndex = 41;
            // 
            // lblDataZmiany
            // 
            this.lblDataZmiany.AutoSize = true;
            this.lblDataZmiany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZmiany.Location = new System.Drawing.Point(84, 343);
            this.lblDataZmiany.Name = "lblDataZmiany";
            this.lblDataZmiany.Size = new System.Drawing.Size(158, 24);
            this.lblDataZmiany.TabIndex = 40;
            this.lblDataZmiany.Text = "Data Przekazania:";
            // 
            // ProdukcjaKonczenieProdukcjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateWysylki);
            this.Controls.Add(this.lblDataZmiany);
            this.Controls.Add(this.btnPakowanie);
            this.Controls.Add(this.dgvZakonczenie);
            this.Controls.Add(this.iBtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdukcjaKonczenieProdukcjiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdukcjaKonczenieProdukcjiForm";
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
    }
}