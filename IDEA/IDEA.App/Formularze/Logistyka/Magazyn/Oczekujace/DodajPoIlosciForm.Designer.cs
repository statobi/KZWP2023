namespace IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace
{
    partial class DodajPoIlosciForm
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
            this.TxbAsortyment = new System.Windows.Forms.TextBox();
            this.LblAsortyment = new System.Windows.Forms.Label();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.TxbIlosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblMaxIlosc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxbAsortyment
            // 
            this.TxbAsortyment.Enabled = false;
            this.TxbAsortyment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbAsortyment.Location = new System.Drawing.Point(21, 35);
            this.TxbAsortyment.Name = "TxbAsortyment";
            this.TxbAsortyment.ReadOnly = true;
            this.TxbAsortyment.Size = new System.Drawing.Size(307, 26);
            this.TxbAsortyment.TabIndex = 28;
            // 
            // LblAsortyment
            // 
            this.LblAsortyment.AutoSize = true;
            this.LblAsortyment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAsortyment.Location = new System.Drawing.Point(12, 9);
            this.LblAsortyment.Name = "LblAsortyment";
            this.LblAsortyment.Size = new System.Drawing.Size(114, 25);
            this.LblAsortyment.TabIndex = 27;
            this.LblAsortyment.Text = "Asortyment";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Red;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancel.IconColor = System.Drawing.Color.Red;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancel.IconSize = 46;
            this.BtnCancel.Location = new System.Drawing.Point(177, 390);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 48);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.Text = "Anuluj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAdd.IconSize = 36;
            this.BtnAdd.Location = new System.Drawing.Point(12, 390);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(159, 48);
            this.BtnAdd.TabIndex = 32;
            this.BtnAdd.Text = "Zatwierdź";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxbIlosc
            // 
            this.TxbIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbIlosc.Location = new System.Drawing.Point(21, 110);
            this.TxbIlosc.Name = "TxbIlosc";
            this.TxbIlosc.Size = new System.Drawing.Size(129, 26);
            this.TxbIlosc.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ilość";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(155, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Max: asdads";
            // 
            // LblMaxIlosc
            // 
            this.LblMaxIlosc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblMaxIlosc.Location = new System.Drawing.Point(196, 113);
            this.LblMaxIlosc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMaxIlosc.Name = "LblMaxIlosc";
            this.LblMaxIlosc.Size = new System.Drawing.Size(174, 23);
            this.LblMaxIlosc.TabIndex = 37;
            this.LblMaxIlosc.Text = "0";
            // 
            // DodajPoIlosciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.LblMaxIlosc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxbIlosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxbAsortyment);
            this.Controls.Add(this.LblAsortyment);
            this.Name = "DodajPoIlosciForm";
            this.Text = "DodajPoIlosciForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajPoIlosciForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbAsortyment;
        private System.Windows.Forms.Label LblAsortyment;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.TextBox TxbIlosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblMaxIlosc;
    }
}