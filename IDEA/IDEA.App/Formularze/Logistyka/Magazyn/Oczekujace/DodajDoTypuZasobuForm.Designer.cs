namespace IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace
{
    partial class DodajDoTypuZasobuForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTypZasobu = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnApply = new FontAwesome.Sharp.IconButton();
            this.CbAddTypZasobu = new System.Windows.Forms.CheckBox();
            this.TxbAddTypZasobu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dostępne typy zasobów";
            // 
            // CmbTypZasobu
            // 
            this.CmbTypZasobu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypZasobu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbTypZasobu.FormattingEnabled = true;
            this.CmbTypZasobu.Location = new System.Drawing.Point(33, 48);
            this.CmbTypZasobu.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTypZasobu.Name = "CmbTypZasobu";
            this.CmbTypZasobu.Size = new System.Drawing.Size(292, 25);
            this.CmbTypZasobu.TabIndex = 45;
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
            this.BtnCancel.Location = new System.Drawing.Point(178, 390);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 48);
            this.BtnCancel.TabIndex = 49;
            this.BtnCancel.Text = "Anuluj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnApply.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnApply.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnApply.IconColor = System.Drawing.Color.Black;
            this.BtnApply.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnApply.IconSize = 36;
            this.BtnApply.Location = new System.Drawing.Point(12, 390);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(160, 48);
            this.BtnApply.TabIndex = 48;
            this.BtnApply.Text = "Zatwierdź";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // CbAddTypZasobu
            // 
            this.CbAddTypZasobu.AutoSize = true;
            this.CbAddTypZasobu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CbAddTypZasobu.Location = new System.Drawing.Point(17, 104);
            this.CbAddTypZasobu.Name = "CbAddTypZasobu";
            this.CbAddTypZasobu.Size = new System.Drawing.Size(207, 25);
            this.CbAddTypZasobu.TabIndex = 50;
            this.CbAddTypZasobu.Text = "Utwórz nowy typ zasobu";
            this.CbAddTypZasobu.UseVisualStyleBackColor = true;
            this.CbAddTypZasobu.CheckedChanged += new System.EventHandler(this.CbAddTypZasobu_CheckedChanged);
            // 
            // TxbAddTypZasobu
            // 
            this.TxbAddTypZasobu.Enabled = false;
            this.TxbAddTypZasobu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbAddTypZasobu.Location = new System.Drawing.Point(32, 133);
            this.TxbAddTypZasobu.Name = "TxbAddTypZasobu";
            this.TxbAddTypZasobu.Size = new System.Drawing.Size(292, 26);
            this.TxbAddTypZasobu.TabIndex = 52;
            // 
            // DodajDoTypuZasobuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.TxbAddTypZasobu);
            this.Controls.Add(this.CbAddTypZasobu);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.CmbTypZasobu);
            this.Controls.Add(this.label3);
            this.Name = "DodajDoTypuZasobuForm";
            this.Text = "DodajDoTypuZasobuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTypZasobu;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnApply;
        private System.Windows.Forms.CheckBox CbAddTypZasobu;
        private System.Windows.Forms.TextBox TxbAddTypZasobu;
    }
}