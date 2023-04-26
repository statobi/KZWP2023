namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    partial class EdytujSekcjeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNumer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbWysokosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddTypZasobu = new FontAwesome.Sharp.IconButton();
            this.CmbTypZasobu = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnApply = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbPowierzchniaRobocza = new System.Windows.Forms.TextBox();
            this.LblPowierzchniaRobocza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Typ zasobu";
            // 
            // TxbNumer
            // 
            this.TxbNumer.Enabled = false;
            this.TxbNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbNumer.Location = new System.Drawing.Point(24, 129);
            this.TxbNumer.Margin = new System.Windows.Forms.Padding(4);
            this.TxbNumer.Name = "TxbNumer";
            this.TxbNumer.ReadOnly = true;
            this.TxbNumer.Size = new System.Drawing.Size(408, 30);
            this.TxbNumer.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Numer";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 58);
            this.label4.TabIndex = 37;
            this.label4.Text = "Edytuj sekcję";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxbWysokosc
            // 
            this.TxbWysokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbWysokosc.Location = new System.Drawing.Point(25, 383);
            this.TxbWysokosc.Margin = new System.Windows.Forms.Padding(4);
            this.TxbWysokosc.Name = "TxbWysokosc";
            this.TxbWysokosc.Size = new System.Drawing.Size(408, 30);
            this.TxbWysokosc.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Wysokość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Powierzchnia robocza";
            // 
            // BtnAddTypZasobu
            // 
            this.BtnAddTypZasobu.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.BtnAddTypZasobu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAddTypZasobu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAddTypZasobu.IconColor = System.Drawing.Color.Black;
            this.BtnAddTypZasobu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddTypZasobu.IconSize = 32;
            this.BtnAddTypZasobu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddTypZasobu.Location = new System.Drawing.Point(337, 299);
            this.BtnAddTypZasobu.Name = "BtnAddTypZasobu";
            this.BtnAddTypZasobu.Size = new System.Drawing.Size(98, 36);
            this.BtnAddTypZasobu.TabIndex = 45;
            this.BtnAddTypZasobu.Text = "Dodaj";
            this.BtnAddTypZasobu.UseVisualStyleBackColor = true;
            // 
            // CmbTypZasobu
            // 
            this.CmbTypZasobu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbTypZasobu.FormattingEnabled = true;
            this.CmbTypZasobu.Location = new System.Drawing.Point(25, 302);
            this.CmbTypZasobu.Name = "CmbTypZasobu";
            this.CmbTypZasobu.Size = new System.Drawing.Size(306, 30);
            this.CmbTypZasobu.TabIndex = 44;
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
            this.BtnCancel.Location = new System.Drawing.Point(235, 489);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(199, 59);
            this.BtnCancel.TabIndex = 47;
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
            this.BtnApply.Location = new System.Drawing.Point(13, 489);
            this.BtnApply.Margin = new System.Windows.Forms.Padding(4);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(214, 59);
            this.BtnApply.TabIndex = 46;
            this.BtnApply.Text = "Zatwierdź";
            this.BtnApply.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(199, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 28);
            this.label6.TabIndex = 49;
            this.label6.Text = "Pozostało:    ";
            // 
            // TxbPowierzchniaRobocza
            // 
            this.TxbPowierzchniaRobocza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbPowierzchniaRobocza.Location = new System.Drawing.Point(21, 216);
            this.TxbPowierzchniaRobocza.Margin = new System.Windows.Forms.Padding(4);
            this.TxbPowierzchniaRobocza.Name = "TxbPowierzchniaRobocza";
            this.TxbPowierzchniaRobocza.Size = new System.Drawing.Size(171, 30);
            this.TxbPowierzchniaRobocza.TabIndex = 48;
            // 
            // LblPowierzchniaRobocza
            // 
            this.LblPowierzchniaRobocza.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPowierzchniaRobocza.Location = new System.Drawing.Point(299, 218);
            this.LblPowierzchniaRobocza.Name = "LblPowierzchniaRobocza";
            this.LblPowierzchniaRobocza.Size = new System.Drawing.Size(232, 28);
            this.LblPowierzchniaRobocza.TabIndex = 50;
            this.LblPowierzchniaRobocza.Text = "0 m2";
            // 
            // EdytujSekcjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 561);
            this.Controls.Add(this.LblPowierzchniaRobocza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxbPowierzchniaRobocza);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.BtnAddTypZasobu);
            this.Controls.Add(this.CmbTypZasobu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbNumer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbWysokosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EdytujSekcjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdytujSekcjeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbWysokosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnAddTypZasobu;
        private System.Windows.Forms.ComboBox CmbTypZasobu;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnApply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbPowierzchniaRobocza;
        private System.Windows.Forms.Label LblPowierzchniaRobocza;
    }
}