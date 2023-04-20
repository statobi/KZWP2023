namespace IDEA.App
{
    partial class InitForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAF = new System.Windows.Forms.Button();
            this.btnProdukcja = new System.Windows.Forms.Button();
            this.btnLogistyka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAF
            // 
            this.btnAF.Location = new System.Drawing.Point(288, 229);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(173, 120);
            this.btnAF.TabIndex = 0;
            this.btnAF.Text = "A-F";
            this.btnAF.UseVisualStyleBackColor = true;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnProdukcja
            // 
            this.btnProdukcja.Location = new System.Drawing.Point(508, 229);
            this.btnProdukcja.Name = "btnProdukcja";
            this.btnProdukcja.Size = new System.Drawing.Size(173, 120);
            this.btnProdukcja.TabIndex = 1;
            this.btnProdukcja.Text = "Produkcja";
            this.btnProdukcja.UseVisualStyleBackColor = true;
            this.btnProdukcja.Click += new System.EventHandler(this.btnProdukcja_Click);
            // 
            // btnLogistyka
            // 
            this.btnLogistyka.Location = new System.Drawing.Point(761, 229);
            this.btnLogistyka.Name = "btnLogistyka";
            this.btnLogistyka.Size = new System.Drawing.Size(173, 120);
            this.btnLogistyka.TabIndex = 2;
            this.btnLogistyka.Text = "Logistyka";
            this.btnLogistyka.UseVisualStyleBackColor = true;
            this.btnLogistyka.Click += new System.EventHandler(this.btnLogistyka_Click);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnLogistyka);
            this.Controls.Add(this.btnProdukcja);
            this.Controls.Add(this.btnAF);
            this.Name = "InitForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InitForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAF;
        private System.Windows.Forms.Button btnProdukcja;
        private System.Windows.Forms.Button btnLogistyka;
    }
}

