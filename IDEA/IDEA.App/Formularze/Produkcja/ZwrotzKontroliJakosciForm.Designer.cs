namespace IDEA.App.Formularze.Produkcja
{
    partial class ZwrotzKontroliJakosciForm
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
            this.dgvZwrot = new System.Windows.Forms.DataGridView();
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwrot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZwrot
            // 
            this.dgvZwrot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZwrot.Location = new System.Drawing.Point(27, 12);
            this.dgvZwrot.Name = "dgvZwrot";
            this.dgvZwrot.Size = new System.Drawing.Size(809, 331);
            this.dgvZwrot.TabIndex = 0;
            // 
            // iBtnBack
            // 
            this.iBtnBack.ForeColor = System.Drawing.Color.Coral;
            this.iBtnBack.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iBtnBack.IconColor = System.Drawing.Color.Red;
            this.iBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBack.Location = new System.Drawing.Point(720, 372);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(75, 52);
            this.iBtnBack.TabIndex = 35;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // ZwrotzKontroliJakosciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.iBtnBack);
            this.Controls.Add(this.dgvZwrot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZwrotzKontroliJakosciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZwrotzKontroliJakosciForm";
            this.Load += new System.EventHandler(this.ZwrotzKontroliJakosciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwrot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZwrot;
        private FontAwesome.Sharp.IconButton iBtnBack;
    }
}