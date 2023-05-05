using System.Windows.Forms;

namespace IDEA.App
{
    partial class AFUrlopy2CU
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
            this.lblRu = new System.Windows.Forms.Label();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.cbRodzajUrlopu = new System.Windows.Forms.ComboBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.dateDataPocz = new System.Windows.Forms.DateTimePicker();
            this.dateDataKonc = new System.Windows.Forms.DateTimePicker();
            this.panelMove = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.numDniRobocze = new System.Windows.Forms.NumericUpDown();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDniRobocze)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRu
            // 
            this.lblRu.AutoSize = true;
            this.lblRu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRu.Location = new System.Drawing.Point(12, 76);
            this.lblRu.Name = "lblRu";
            this.lblRu.Size = new System.Drawing.Size(144, 24);
            this.lblRu.TabIndex = 1;
            this.lblRu.Text = "Rodzaj urlopu: *";
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(203, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(188, 25);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Dodawanie Urlopu";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pracownik: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Początek urlopu: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Koniec urlopu: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ilosć dni roboczych: *";
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
            // cbRodzajUrlopu
            // 
            this.cbRodzajUrlopu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRodzajUrlopu.FormattingEnabled = true;
            this.cbRodzajUrlopu.Location = new System.Drawing.Point(208, 72);
            this.cbRodzajUrlopu.Margin = new System.Windows.Forms.Padding(2);
            this.cbRodzajUrlopu.Name = "cbRodzajUrlopu";
            this.cbRodzajUrlopu.Size = new System.Drawing.Size(302, 30);
            this.cbRodzajUrlopu.TabIndex = 24;
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(208, 107);
            this.cbPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(302, 30);
            this.cbPracownik.TabIndex = 25;
            // 
            // dateDataPocz
            // 
            this.dateDataPocz.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataPocz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataPocz.Location = new System.Drawing.Point(208, 146);
            this.dateDataPocz.Margin = new System.Windows.Forms.Padding(2);
            this.dateDataPocz.Name = "dateDataPocz";
            this.dateDataPocz.Size = new System.Drawing.Size(302, 26);
            this.dateDataPocz.TabIndex = 27;
            // 
            // dateDataKonc
            // 
            this.dateDataKonc.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataKonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataKonc.Location = new System.Drawing.Point(208, 180);
            this.dateDataKonc.Margin = new System.Windows.Forms.Padding(2);
            this.dateDataKonc.Name = "dateDataKonc";
            this.dateDataKonc.Size = new System.Drawing.Size(302, 26);
            this.dateDataKonc.TabIndex = 28;
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
            this.panelMove.TabIndex = 29;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(12, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 24);
            this.label17.TabIndex = 45;
            this.label17.Text = "* wymagane";
            // 
            // numDniRobocze
            // 
            this.numDniRobocze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numDniRobocze.Location = new System.Drawing.Point(208, 211);
            this.numDniRobocze.Name = "numDniRobocze";
            this.numDniRobocze.Size = new System.Drawing.Size(302, 29);
            this.numDniRobocze.TabIndex = 46;
            // 
            // AFUrlopyCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 522);
            this.Controls.Add(this.numDniRobocze);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateDataKonc);
            this.Controls.Add(this.dateDataPocz);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.cbRodzajUrlopu);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRu);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AFUrlopyCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDniRobocze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRu;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.ComboBox cbRodzajUrlopu;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.DateTimePicker dateDataPocz;
        private System.Windows.Forms.DateTimePicker dateDataKonc;
        private System.Windows.Forms.Panel panelMove;
        private Label label17;
        private NumericUpDown numDniRobocze;
    }
}