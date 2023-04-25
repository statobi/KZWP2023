﻿namespace IDEA.App
{
    partial class AFZamowieniaSkladCU
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
            this.btnImie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCenaNetto = new System.Windows.Forms.TextBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.numIlosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSugerowanaCenaNetto = new System.Windows.Forms.TextBox();
            this.txtSugerowanaCenaBrutto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCenaBrutto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTxtKomentarz = new System.Windows.Forms.RichTextBox();
            this.panelMove = new System.Windows.Forms.Panel();
            this.lblKindWindow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).BeginInit();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImie
            // 
            this.btnImie.AutoSize = true;
            this.btnImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImie.Location = new System.Drawing.Point(16, 94);
            this.btnImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnImie.Name = "btnImie";
            this.btnImie.Size = new System.Drawing.Size(102, 29);
            this.btnImie.TabIndex = 1;
            this.btnImie.Text = "Produkt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ilość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cena Netto:";
            // 
            // txtCenaNetto
            // 
            this.txtCenaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCenaNetto.Location = new System.Drawing.Point(293, 176);
            this.txtCenaNetto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCenaNetto.Name = "txtCenaNetto";
            this.txtCenaNetto.Size = new System.Drawing.Size(139, 34);
            this.txtCenaNetto.TabIndex = 9;
            this.txtCenaNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCenaNetto.TextChanged += new System.EventHandler(this.txtCenaNetto_TextChanged);
            this.txtCenaNetto.Leave += new System.EventHandler(this.txtCenaNetto_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(233, 562);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 64);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(631, 562);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 64);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbProdukt
            // 
            this.cbProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(293, 89);
            this.cbProdukt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(436, 37);
            this.cbProdukt.TabIndex = 24;
            this.cbProdukt.SelectedIndexChanged += new System.EventHandler(this.cbProdukt_SelectedIndexChanged);
            // 
            // numIlosc
            // 
            this.numIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIlosc.Location = new System.Drawing.Point(293, 135);
            this.numIlosc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIlosc.Name = "numIlosc";
            this.numIlosc.Size = new System.Drawing.Size(139, 34);
            this.numIlosc.TabIndex = 31;
            this.numIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sugerowana cena netto:";
            // 
            // txtSugerowanaCenaNetto
            // 
            this.txtSugerowanaCenaNetto.Enabled = false;
            this.txtSugerowanaCenaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSugerowanaCenaNetto.Location = new System.Drawing.Point(293, 218);
            this.txtSugerowanaCenaNetto.Margin = new System.Windows.Forms.Padding(4);
            this.txtSugerowanaCenaNetto.Name = "txtSugerowanaCenaNetto";
            this.txtSugerowanaCenaNetto.Size = new System.Drawing.Size(139, 34);
            this.txtSugerowanaCenaNetto.TabIndex = 32;
            this.txtSugerowanaCenaNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSugerowanaCenaBrutto
            // 
            this.txtSugerowanaCenaBrutto.Enabled = false;
            this.txtSugerowanaCenaBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSugerowanaCenaBrutto.Location = new System.Drawing.Point(293, 302);
            this.txtSugerowanaCenaBrutto.Margin = new System.Windows.Forms.Padding(4);
            this.txtSugerowanaCenaBrutto.Name = "txtSugerowanaCenaBrutto";
            this.txtSugerowanaCenaBrutto.Size = new System.Drawing.Size(139, 34);
            this.txtSugerowanaCenaBrutto.TabIndex = 36;
            this.txtSugerowanaCenaBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cena Brutto:";
            // 
            // txtCenaBrutto
            // 
            this.txtCenaBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCenaBrutto.Location = new System.Drawing.Point(293, 260);
            this.txtCenaBrutto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCenaBrutto.Name = "txtCenaBrutto";
            this.txtCenaBrutto.Size = new System.Drawing.Size(139, 34);
            this.txtCenaBrutto.TabIndex = 34;
            this.txtCenaBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCenaBrutto.Leave += new System.EventHandler(this.txtCenaBrutto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Sugerowana cena brutto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Komentarz:";
            // 
            // richTxtKomentarz
            // 
            this.richTxtKomentarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTxtKomentarz.Location = new System.Drawing.Point(293, 343);
            this.richTxtKomentarz.Name = "richTxtKomentarz";
            this.richTxtKomentarz.Size = new System.Drawing.Size(436, 131);
            this.richTxtKomentarz.TabIndex = 39;
            this.richTxtKomentarz.Text = "";
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Controls.Add(this.lblKindWindow);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(747, 60);
            this.panelMove.TabIndex = 40;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(98, 20);
            this.lblKindWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(563, 31);
            this.lblKindWindow.TabIndex = 3;
            this.lblKindWindow.Text = "Dodawanie Nowego Produktu do Zamówienia";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AFZamowieniaSkladCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 642);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.richTxtKomentarz);
            this.Controls.Add(this.txtSugerowanaCenaBrutto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCenaBrutto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSugerowanaCenaNetto);
            this.Controls.Add(this.numIlosc);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCenaNetto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImie);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFZamowieniaSkladCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).EndInit();
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCenaNetto;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.NumericUpDown numIlosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSugerowanaCenaNetto;
        private System.Windows.Forms.TextBox txtSugerowanaCenaBrutto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCenaBrutto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTxtKomentarz;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Label lblKindWindow;
    }
}