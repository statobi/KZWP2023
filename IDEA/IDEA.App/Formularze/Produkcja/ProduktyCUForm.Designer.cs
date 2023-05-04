using System.Windows.Forms;

namespace IDEA.App
{
    partial class ProduktyCUForm
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
            this.lblImie = new System.Windows.Forms.Label();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.cbRodzajProduktu = new System.Windows.Forms.ComboBox();
            this.panelMove = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSzerokosc = new System.Windows.Forms.NumericUpDown();
            this.numGlebokosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numWysokosc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numMasa = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajRodzajProduktu = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numSzerokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGlebokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWysokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMasa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(12, 116);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(165, 24);
            this.lblImie.TabIndex = 1;
            this.lblImie.Text = "Rodzaj Produktu: *";
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(134, 10);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(295, 25);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Dodawanie Nowego Produktu";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKindWindow.Click += new System.EventHandler(this.lblKindWindow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwa: *";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(208, 78);
            this.txtNazwa.MaxLength = 30;
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(302, 29);
            this.txtNazwa.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(175, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(473, 457);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbRodzajProduktu
            // 
            this.cbRodzajProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRodzajProduktu.FormattingEnabled = true;
            this.cbRodzajProduktu.Location = new System.Drawing.Point(208, 112);
            this.cbRodzajProduktu.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajProduktu.Name = "cbRodzajProduktu";
            this.cbRodzajProduktu.Size = new System.Drawing.Size(302, 30);
            this.cbRodzajProduktu.TabIndex = 24;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Margin = new System.Windows.Forms.Padding(2);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(560, 49);
            this.panelMove.TabIndex = 29;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(12, 432);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 24);
            this.label17.TabIndex = 45;
            this.label17.Text = "* wymagane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Szerokość: *";
            // 
            // numSzerokosc
            // 
            this.numSzerokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numSzerokosc.Location = new System.Drawing.Point(208, 210);
            this.numSzerokosc.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numSzerokosc.Name = "numSzerokosc";
            this.numSzerokosc.Size = new System.Drawing.Size(302, 29);
            this.numSzerokosc.TabIndex = 48;
            // 
            // numGlebokosc
            // 
            this.numGlebokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numGlebokosc.Location = new System.Drawing.Point(208, 245);
            this.numGlebokosc.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numGlebokosc.Name = "numGlebokosc";
            this.numGlebokosc.Size = new System.Drawing.Size(302, 29);
            this.numGlebokosc.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Głębokość: *";
            // 
            // numWysokosc
            // 
            this.numWysokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numWysokosc.Location = new System.Drawing.Point(208, 280);
            this.numWysokosc.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numWysokosc.Name = "numWysokosc";
            this.numWysokosc.Size = new System.Drawing.Size(302, 29);
            this.numWysokosc.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Wysokość: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Wymiary gabarytowe:";
            // 
            // numMasa
            // 
            this.numMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numMasa.Location = new System.Drawing.Point(208, 341);
            this.numMasa.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numMasa.Name = "numMasa";
            this.numMasa.Size = new System.Drawing.Size(302, 29);
            this.numMasa.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "Masa: *";
            // 
            // btnDodajRodzajProduktu
            // 
            this.btnDodajRodzajProduktu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnDodajRodzajProduktu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnDodajRodzajProduktu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDodajRodzajProduktu.IconSize = 25;
            this.btnDodajRodzajProduktu.Location = new System.Drawing.Point(515, 113);
            this.btnDodajRodzajProduktu.Name = "btnDodajRodzajProduktu";
            this.btnDodajRodzajProduktu.Size = new System.Drawing.Size(30, 30);
            this.btnDodajRodzajProduktu.TabIndex = 56;
            this.btnDodajRodzajProduktu.UseVisualStyleBackColor = true;
            this.btnDodajRodzajProduktu.Click += new System.EventHandler(this.btnDodajRodzajProduktu_Click);
            // 
            // ProduktyCUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 522);
            this.Controls.Add(this.btnDodajRodzajProduktu);
            this.Controls.Add(this.numMasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numWysokosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numGlebokosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSzerokosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbRodzajProduktu);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.lblKindWindow);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduktyCUForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.Load += new System.EventHandler(this.ProduktyCUForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSzerokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGlebokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWysokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazwa;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.ComboBox cbRodzajProduktu;
        private System.Windows.Forms.Panel panelMove;
        private Label label17;
        private Label label1;
        private NumericUpDown numSzerokosc;
        private NumericUpDown numGlebokosc;
        private Label label2;
        private NumericUpDown numWysokosc;
        private Label label3;
        private Label label5;
        private NumericUpDown numMasa;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnDodajRodzajProduktu;
    }
}