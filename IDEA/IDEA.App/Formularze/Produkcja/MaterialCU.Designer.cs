namespace IDEA.App.Formularze.Produkcja
{
    partial class MaterialCU
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
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnDodajRodzajProduktu = new FontAwesome.Sharp.IconButton();
            this.cbRodzajMaterialu = new System.Windows.Forms.ComboBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.cbJednostka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSzerokosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGlebokosc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWysokosc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(162, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(147, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(298, 25);
            this.lblKindWindow.TabIndex = 30;
            this.lblKindWindow.Text = "Dodawanie Nowego Materiału";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Controls.Add(this.lblKindWindow);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Margin = new System.Windows.Forms.Padding(2);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(560, 49);
            this.panelMove.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(12, 458);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 24);
            this.label17.TabIndex = 48;
            this.label17.Text = "* wymagane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(93, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nazwa: *";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(208, 70);
            this.txtNazwa.MaxLength = 30;
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(302, 29);
            this.txtNazwa.TabIndex = 46;
            // 
            // btnDodajRodzajProduktu
            // 
            this.btnDodajRodzajProduktu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnDodajRodzajProduktu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnDodajRodzajProduktu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDodajRodzajProduktu.IconSize = 25;
            this.btnDodajRodzajProduktu.Location = new System.Drawing.Point(515, 108);
            this.btnDodajRodzajProduktu.Name = "btnDodajRodzajProduktu";
            this.btnDodajRodzajProduktu.Size = new System.Drawing.Size(30, 30);
            this.btnDodajRodzajProduktu.TabIndex = 59;
            this.btnDodajRodzajProduktu.UseVisualStyleBackColor = true;
            // 
            // cbRodzajMaterialu
            // 
            this.cbRodzajMaterialu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRodzajMaterialu.FormattingEnabled = true;
            this.cbRodzajMaterialu.Location = new System.Drawing.Point(208, 107);
            this.cbRodzajMaterialu.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajMaterialu.Name = "cbRodzajMaterialu";
            this.cbRodzajMaterialu.Size = new System.Drawing.Size(302, 30);
            this.cbRodzajMaterialu.TabIndex = 58;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(12, 111);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(170, 24);
            this.lblImie.TabIndex = 57;
            this.lblImie.Text = "Rodzaj Materiału: *";
            // 
            // cbJednostka
            // 
            this.cbJednostka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbJednostka.FormattingEnabled = true;
            this.cbJednostka.Location = new System.Drawing.Point(208, 155);
            this.cbJednostka.Margin = new System.Windows.Forms.Padding(2);
            this.cbJednostka.Name = "cbJednostka";
            this.cbJednostka.Size = new System.Drawing.Size(302, 30);
            this.cbJednostka.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(65, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "Jednostka: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(67, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Szerokość: *";
            // 
            // txtSzerokosc
            // 
            this.txtSzerokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSzerokosc.Location = new System.Drawing.Point(208, 200);
            this.txtSzerokosc.MaxLength = 30;
            this.txtSzerokosc.Name = "txtSzerokosc";
            this.txtSzerokosc.Size = new System.Drawing.Size(302, 29);
            this.txtSzerokosc.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(76, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Głębość: *";
            // 
            // txtGlebokosc
            // 
            this.txtGlebokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtGlebokosc.Location = new System.Drawing.Point(208, 246);
            this.txtGlebokosc.MaxLength = 30;
            this.txtGlebokosc.Name = "txtGlebokosc";
            this.txtGlebokosc.Size = new System.Drawing.Size(302, 29);
            this.txtGlebokosc.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(64, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 67;
            this.label5.Text = "Wysokość: *";
            // 
            // txtWysokosc
            // 
            this.txtWysokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWysokosc.Location = new System.Drawing.Point(208, 299);
            this.txtWysokosc.MaxLength = 30;
            this.txtWysokosc.Name = "txtWysokosc";
            this.txtWysokosc.Size = new System.Drawing.Size(302, 29);
            this.txtWysokosc.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(105, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Masa: *";
            // 
            // txtMasa
            // 
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMasa.Location = new System.Drawing.Point(208, 344);
            this.txtMasa.MaxLength = 30;
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(302, 29);
            this.txtMasa.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(111, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 71;
            this.label7.Text = "Opis: ";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(208, 389);
            this.txtOpis.MaxLength = 30;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(302, 29);
            this.txtOpis.TabIndex = 70;
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(470, 458);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 72;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // MaterialCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 522);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWysokosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGlebokosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSzerokosc);
            this.Controls.Add(this.cbJednostka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajRodzajProduktu);
            this.Controls.Add(this.cbRodzajMaterialu);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialCU";
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazwa;
        private FontAwesome.Sharp.IconButton btnDodajRodzajProduktu;
        private System.Windows.Forms.ComboBox cbRodzajMaterialu;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.ComboBox cbJednostka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSzerokosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGlebokosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWysokosc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOpis;
        private FontAwesome.Sharp.IconButton btnAccept;
    }
}