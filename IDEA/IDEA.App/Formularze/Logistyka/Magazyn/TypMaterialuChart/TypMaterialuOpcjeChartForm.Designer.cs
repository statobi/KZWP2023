namespace IDEA.App.Formularze.Logistyka.Magazyn.TypMaterialuChart
{
    partial class TypMaterialuOpcjeChartForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.CmbMagazyn = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnOK = new FontAwesome.Sharp.IconButton();
            this.CmbTypWykresu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Magazyn";
            // 
            // CmbMagazyn
            // 
            this.CmbMagazyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbMagazyn.FormattingEnabled = true;
            this.CmbMagazyn.Location = new System.Drawing.Point(38, 36);
            this.CmbMagazyn.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMagazyn.Name = "CmbMagazyn";
            this.CmbMagazyn.Size = new System.Drawing.Size(222, 25);
            this.CmbMagazyn.TabIndex = 30;
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
            this.BtnCancel.Location = new System.Drawing.Point(148, 185);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 48);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.Text = "Anuluj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnOK.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnOK.IconColor = System.Drawing.Color.Black;
            this.BtnOK.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnOK.IconSize = 36;
            this.BtnOK.Location = new System.Drawing.Point(21, 185);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(121, 48);
            this.BtnOK.TabIndex = 32;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // CmbTypWykresu
            // 
            this.CmbTypWykresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbTypWykresu.FormattingEnabled = true;
            this.CmbTypWykresu.Location = new System.Drawing.Point(38, 113);
            this.CmbTypWykresu.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTypWykresu.Name = "CmbTypWykresu";
            this.CmbTypWykresu.Size = new System.Drawing.Size(222, 25);
            this.CmbTypWykresu.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Typ wykresu";
            // 
            // TypMaterialuOpcjeChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 245);
            this.Controls.Add(this.CmbTypWykresu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.CmbMagazyn);
            this.Controls.Add(this.label5);
            this.Name = "TypMaterialuOpcjeChartForm";
            this.Text = "TypMaterialuOpcjeChartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbMagazyn;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnOK;
        private System.Windows.Forms.ComboBox CmbTypWykresu;
        private System.Windows.Forms.Label label1;
    }
}