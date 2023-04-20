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
            this.btnAF.Location = new System.Drawing.Point(384, 282);
            this.btnAF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(231, 148);
            this.btnAF.TabIndex = 0;
            this.btnAF.Text = "A-F";
            this.btnAF.UseVisualStyleBackColor = true;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnProdukcja
            // 
            this.btnProdukcja.Location = new System.Drawing.Point(677, 282);
            this.btnProdukcja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProdukcja.Name = "btnProdukcja";
            this.btnProdukcja.Size = new System.Drawing.Size(231, 148);
            this.btnProdukcja.TabIndex = 1;
            this.btnProdukcja.Text = "Produkcja";
            this.btnProdukcja.UseVisualStyleBackColor = true;
            this.btnProdukcja.Click += new System.EventHandler(this.btnProdukcja_Click);
            // 
            // btnLogistyka
            // 
            this.btnLogistyka.Location = new System.Drawing.Point(1015, 282);
            this.btnLogistyka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogistyka.Name = "btnLogistyka";
            this.btnLogistyka.Size = new System.Drawing.Size(231, 148);
            this.btnLogistyka.TabIndex = 2;
            this.btnLogistyka.Text = "Logistyka";
            this.btnLogistyka.UseVisualStyleBackColor = true;
            this.btnLogistyka.Click += new System.EventHandler(this.btnLogistyka_Click);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1579, 838);
            this.Controls.Add(this.btnLogistyka);
            this.Controls.Add(this.btnProdukcja);
            this.Controls.Add(this.btnAF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
=======
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Controls.Add(this.btnLogistyka);
            this.Controls.Add(this.btnProdukcja);
            this.Controls.Add(this.btnAF);
>>>>>>> 587fff4ce5acf4a9ae384943c608e5820e6b44b9
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

