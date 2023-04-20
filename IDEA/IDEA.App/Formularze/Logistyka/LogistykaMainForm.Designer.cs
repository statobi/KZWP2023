namespace IDEA.App
{
    partial class LogistykaMainForm
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
            this.BtnMagazyn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMagazyn
            // 
            this.BtnMagazyn.Location = new System.Drawing.Point(245, 91);
            this.BtnMagazyn.Name = "BtnMagazyn";
            this.BtnMagazyn.Size = new System.Drawing.Size(75, 23);
            this.BtnMagazyn.TabIndex = 0;
            this.BtnMagazyn.Text = "Magaz";
            this.BtnMagazyn.UseVisualStyleBackColor = true;
            // 
            // LogistykaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.BtnMagazyn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LogistykaMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogistykaMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMagazyn;
    }
}