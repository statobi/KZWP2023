namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    partial class DodajSekcjeForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxbPowierzchniaRobocza = new System.Windows.Forms.TextBox();
            this.TxbWysokosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.TxbNumer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTypZasobu = new System.Windows.Forms.ComboBox();
            this.BtnAddTypZasobu = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAvaliablePowierzchniaRobocza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Numer";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 47);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dodaj sekcję";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxbPowierzchniaRobocza
            // 
            this.TxbPowierzchniaRobocza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbPowierzchniaRobocza.Location = new System.Drawing.Point(18, 175);
            this.TxbPowierzchniaRobocza.Name = "TxbPowierzchniaRobocza";
            this.TxbPowierzchniaRobocza.Size = new System.Drawing.Size(129, 26);
            this.TxbPowierzchniaRobocza.TabIndex = 23;
            // 
            // TxbWysokosc
            // 
            this.TxbWysokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbWysokosc.Location = new System.Drawing.Point(19, 311);
            this.TxbWysokosc.Name = "TxbWysokosc";
            this.TxbWysokosc.Size = new System.Drawing.Size(307, 26);
            this.TxbWysokosc.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Wysokość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Powierzchnia robocza";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAdd.IconSize = 36;
            this.BtnAdd.Location = new System.Drawing.Point(10, 397);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(159, 48);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxbNumer
            // 
            this.TxbNumer.Enabled = false;
            this.TxbNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbNumer.Location = new System.Drawing.Point(18, 105);
            this.TxbNumer.Name = "TxbNumer";
            this.TxbNumer.ReadOnly = true;
            this.TxbNumer.Size = new System.Drawing.Size(307, 26);
            this.TxbNumer.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Typ zasobu";
            // 
            // CmbTypZasobu
            // 
            this.CmbTypZasobu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CmbTypZasobu.FormattingEnabled = true;
            this.CmbTypZasobu.Location = new System.Drawing.Point(19, 247);
            this.CmbTypZasobu.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTypZasobu.Name = "CmbTypZasobu";
            this.CmbTypZasobu.Size = new System.Drawing.Size(227, 25);
            this.CmbTypZasobu.TabIndex = 29;
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
            this.BtnAddTypZasobu.Location = new System.Drawing.Point(249, 244);
            this.BtnAddTypZasobu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddTypZasobu.Name = "BtnAddTypZasobu";
            this.BtnAddTypZasobu.Size = new System.Drawing.Size(77, 29);
            this.BtnAddTypZasobu.TabIndex = 30;
            this.BtnAddTypZasobu.Text = "Dodaj";
            this.BtnAddTypZasobu.UseVisualStyleBackColor = true;
            this.BtnAddTypZasobu.Click += new System.EventHandler(this.BtnAddTypZasobu_Click);
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
            this.BtnCancel.Location = new System.Drawing.Point(175, 397);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 48);
            this.BtnCancel.TabIndex = 31;
            this.BtnCancel.Text = "Anuluj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(152, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Pozostało: asdads";
            // 
            // LblAvaliablePowierzchniaRobocza
            // 
            this.LblAvaliablePowierzchniaRobocza.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAvaliablePowierzchniaRobocza.Location = new System.Drawing.Point(230, 176);
            this.LblAvaliablePowierzchniaRobocza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAvaliablePowierzchniaRobocza.Name = "LblAvaliablePowierzchniaRobocza";
            this.LblAvaliablePowierzchniaRobocza.Size = new System.Drawing.Size(174, 23);
            this.LblAvaliablePowierzchniaRobocza.TabIndex = 33;
            this.LblAvaliablePowierzchniaRobocza.Text = "0 m2";
            // 
            // DodajSekcjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 456);
            this.Controls.Add(this.LblAvaliablePowierzchniaRobocza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddTypZasobu);
            this.Controls.Add(this.CmbTypZasobu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbNumer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbPowierzchniaRobocza);
            this.Controls.Add(this.TxbWysokosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DodajSekcjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajSekcjeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbPowierzchniaRobocza;
        private System.Windows.Forms.TextBox TxbWysokosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.TextBox TxbNumer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTypZasobu;
        private FontAwesome.Sharp.IconButton BtnAddTypZasobu;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAvaliablePowierzchniaRobocza;
    }
}