﻿using System.Windows.Forms;

namespace IDEA.App
{
    partial class AFZamowieniaCU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.cbFaktura = new System.Windows.Forms.ComboBox();
            this.dateDataZamowienia = new System.Windows.Forms.DateTimePicker();
            this.dateDataRealizacji = new System.Windows.Forms.DateTimePicker();
            this.panelMove = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(16, 94);
            this.lblImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(120, 36);
            this.lblImie.TabIndex = 1;
            this.lblImie.Text = "Klient: *";
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(179, 12);
            this.lblKindWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(410, 31);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Dodawanie Nowego Zamówienia";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKindWindow.Click += new System.EventHandler(this.lblKindWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pracownik: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data zamówienia: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data realizacji: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numer: *";
            // 
            // txtNumer
            // 
            this.txtNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumer.Location = new System.Drawing.Point(277, 262);
            this.txtNumer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumer.MaxLength = 30;
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(401, 34);
            this.txtNumer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Faktura:";
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
            // cbKlient
            // 
            this.cbKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(277, 89);
            this.cbKlient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(401, 37);
            this.cbKlient.TabIndex = 24;
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(277, 132);
            this.cbPracownik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(401, 37);
            this.cbPracownik.TabIndex = 25;
            // 
            // cbFaktura
            // 
            this.cbFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFaktura.FormattingEnabled = true;
            this.cbFaktura.Location = new System.Drawing.Point(277, 303);
            this.cbFaktura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFaktura.Name = "cbFaktura";
            this.cbFaktura.Size = new System.Drawing.Size(401, 37);
            this.cbFaktura.TabIndex = 26;
            // 
            // dateDataZamowienia
            // 
            this.dateDataZamowienia.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataZamowienia.Location = new System.Drawing.Point(277, 180);
            this.dateDataZamowienia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDataZamowienia.Name = "dateDataZamowienia";
            this.dateDataZamowienia.Size = new System.Drawing.Size(401, 30);
            this.dateDataZamowienia.TabIndex = 27;
            // 
            // dateDataRealizacji
            // 
            this.dateDataRealizacji.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataRealizacji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataRealizacji.Location = new System.Drawing.Point(277, 222);
            this.dateDataRealizacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDataRealizacji.Name = "dateDataRealizacji";
            this.dateDataRealizacji.Size = new System.Drawing.Size(401, 30);
            this.dateDataRealizacji.TabIndex = 28;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(747, 60);
            this.panelMove.TabIndex = 29;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(693, 298);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 49);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(26, 373);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 29);
            this.label17.TabIndex = 45;
            this.label17.Text = "* wymagane";
            // 
            // AFZamowieniaCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 642);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateDataRealizacji);
            this.Controls.Add(this.dateDataZamowienia);
            this.Controls.Add(this.cbFaktura);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKindWindow);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFZamowieniaCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.ComboBox cbFaktura;
        private System.Windows.Forms.DateTimePicker dateDataZamowienia;
        private System.Windows.Forms.DateTimePicker dateDataRealizacji;
        private System.Windows.Forms.Panel panelMove;
        private CheckBox checkBox1;
        private Label label17;
    }
}