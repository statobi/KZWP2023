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
            this.BtnMagazyn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMagazyn
            // 
            this.BtnMagazyn.Location = new System.Drawing.Point(469, 125);
            this.BtnMagazyn.Name = "BtnMagazyn";
            this.BtnMagazyn.Size = new System.Drawing.Size(75, 23);
            this.BtnMagazyn.TabIndex = 0;
            this.BtnMagazyn.Text = "Magazyny";
            this.BtnMagazyn.UseVisualStyleBackColor = true;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 312);
            this.Controls.Add(this.BtnMagazyn);
            this.Name = "InitForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMagazyn;
    }
}

