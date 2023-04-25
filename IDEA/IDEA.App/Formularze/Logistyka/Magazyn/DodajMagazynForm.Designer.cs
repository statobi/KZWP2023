namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    partial class DodajMagazynForm
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
            this.BtnDodajMagazyn = new FontAwesome.Sharp.IconButton();
            this.TxbNazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbPowierzchniaRobocza = new System.Windows.Forms.TextBox();
            this.TxbTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDodajMagazyn
            // 
            this.BtnDodajMagazyn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDodajMagazyn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodajMagazyn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnDodajMagazyn.IconColor = System.Drawing.Color.Black;
            this.BtnDodajMagazyn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDodajMagazyn.IconSize = 36;
            this.BtnDodajMagazyn.Location = new System.Drawing.Point(11, 487);
            this.BtnDodajMagazyn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDodajMagazyn.Name = "BtnDodajMagazyn";
            this.BtnDodajMagazyn.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.BtnDodajMagazyn.Size = new System.Drawing.Size(415, 59);
            this.BtnDodajMagazyn.TabIndex = 5;
            this.BtnDodajMagazyn.Text = "Dodaj";
            this.BtnDodajMagazyn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDodajMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDodajMagazyn.UseVisualStyleBackColor = true;
            this.BtnDodajMagazyn.Click += new System.EventHandler(this.BtnDodajMagazyn_Click);
            // 
            // TxbNazwa
            // 
            this.TxbNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbNazwa.Location = new System.Drawing.Point(16, 129);
            this.TxbNazwa.Margin = new System.Windows.Forms.Padding(4);
            this.TxbNazwa.Name = "TxbNazwa";
            this.TxbNazwa.Size = new System.Drawing.Size(408, 30);
            this.TxbNazwa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nr telefonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Powierzchnia robocza";
            // 
            // TxbPowierzchniaRobocza
            // 
            this.TxbPowierzchniaRobocza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbPowierzchniaRobocza.Location = new System.Drawing.Point(16, 299);
            this.TxbPowierzchniaRobocza.Margin = new System.Windows.Forms.Padding(4);
            this.TxbPowierzchniaRobocza.Name = "TxbPowierzchniaRobocza";
            this.TxbPowierzchniaRobocza.Size = new System.Drawing.Size(408, 30);
            this.TxbPowierzchniaRobocza.TabIndex = 14;
            // 
            // TxbTelefon
            // 
            this.TxbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbTelefon.Location = new System.Drawing.Point(16, 213);
            this.TxbTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.TxbTelefon.Name = "TxbTelefon";
            this.TxbTelefon.Size = new System.Drawing.Size(408, 30);
            this.TxbTelefon.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(84, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dodaj magazyn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nazwa";
            // 
            // DodajMagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbTelefon);
            this.Controls.Add(this.TxbPowierzchniaRobocza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbNazwa);
            this.Controls.Add(this.BtnDodajMagazyn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DodajMagazynForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajMagazynForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnDodajMagazyn;
        private System.Windows.Forms.TextBox TxbNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbPowierzchniaRobocza;
        private System.Windows.Forms.TextBox TxbTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}