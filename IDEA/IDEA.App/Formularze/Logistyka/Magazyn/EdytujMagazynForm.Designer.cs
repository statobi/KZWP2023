namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    partial class EdytujMagazynForm
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
            this.BtnEdytujMagazyn = new FontAwesome.Sharp.IconButton();
            this.TxbNazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbPowierzchniaRobocza = new System.Windows.Forms.TextBox();
            this.TxbTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEdytujMagazyn
            // 
            this.BtnEdytujMagazyn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnEdytujMagazyn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnEdytujMagazyn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.BtnEdytujMagazyn.IconColor = System.Drawing.Color.Black;
            this.BtnEdytujMagazyn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEdytujMagazyn.IconSize = 36;
            this.BtnEdytujMagazyn.Location = new System.Drawing.Point(8, 396);
            this.BtnEdytujMagazyn.Name = "BtnEdytujMagazyn";
            this.BtnEdytujMagazyn.Padding = new System.Windows.Forms.Padding(56, 0, 0, 0);
            this.BtnEdytujMagazyn.Size = new System.Drawing.Size(311, 48);
            this.BtnEdytujMagazyn.TabIndex = 5;
            this.BtnEdytujMagazyn.Text = "Zatwierdź";
            this.BtnEdytujMagazyn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdytujMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdytujMagazyn.UseVisualStyleBackColor = true;
            this.BtnEdytujMagazyn.Click += new System.EventHandler(this.BtnEdytujMagazyn_Click);
            // 
            // TxbNazwa
            // 
            this.TxbNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbNazwa.Location = new System.Drawing.Point(12, 105);
            this.TxbNazwa.Name = "TxbNazwa";
            this.TxbNazwa.Size = new System.Drawing.Size(307, 26);
            this.TxbNazwa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nr telefonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Powierzchnia robocza";
            // 
            // TxbPowierzchniaRobocza
            // 
            this.TxbPowierzchniaRobocza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbPowierzchniaRobocza.Location = new System.Drawing.Point(12, 243);
            this.TxbPowierzchniaRobocza.Name = "TxbPowierzchniaRobocza";
            this.TxbPowierzchniaRobocza.Size = new System.Drawing.Size(307, 26);
            this.TxbPowierzchniaRobocza.TabIndex = 14;
            // 
            // TxbTelefon
            // 
            this.TxbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbTelefon.Location = new System.Drawing.Point(12, 173);
            this.TxbTelefon.Name = "TxbTelefon";
            this.TxbTelefon.Size = new System.Drawing.Size(307, 26);
            this.TxbTelefon.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(63, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Edytuj magazyn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nazwa";
            // 
            // EdytujMagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 456);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbTelefon);
            this.Controls.Add(this.TxbPowierzchniaRobocza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbNazwa);
            this.Controls.Add(this.BtnEdytujMagazyn);
            this.MaximizeBox = false;
            this.Name = "EdytujMagazynForm";
            this.Text = "DodajMagazynForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EdytujMagazynForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnEdytujMagazyn;
        private System.Windows.Forms.TextBox TxbNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbPowierzchniaRobocza;
        private System.Windows.Forms.TextBox TxbTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}