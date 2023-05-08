namespace IDEA.App
{
    partial class KontrolaJakosciFormCU
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
            this.txtZaakceptowane = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdrzucone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUwagi = new System.Windows.Forms.TextBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.panelMove = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtZaakceptowane
            // 
            this.txtZaakceptowane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZaakceptowane.Location = new System.Drawing.Point(175, 73);
            this.txtZaakceptowane.MaxLength = 30;
            this.txtZaakceptowane.Name = "txtZaakceptowane";
            this.txtZaakceptowane.Size = new System.Drawing.Size(373, 29);
            this.txtZaakceptowane.TabIndex = 0;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(12, 76);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(161, 24);
            this.lblImie.TabIndex = 1;
            this.lblImie.Text = "Zaakceptowane: *";
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(107, 9);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(330, 25);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Dodawanie nowej kontroli jakości";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odrzucone: *";
            // 
            // txtOdrzucone
            // 
            this.txtOdrzucone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOdrzucone.Location = new System.Drawing.Point(175, 108);
            this.txtOdrzucone.MaxLength = 30;
            this.txtOdrzucone.Name = "txtOdrzucone";
            this.txtOdrzucone.Size = new System.Drawing.Size(373, 29);
            this.txtOdrzucone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data kontroli :*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uwagi:*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUwagi
            // 
            this.txtUwagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUwagi.Location = new System.Drawing.Point(173, 178);
            this.txtUwagi.MaxLength = 10;
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(375, 29);
            this.txtUwagi.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(173, 246);
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
            this.btnAccept.Location = new System.Drawing.Point(473, 246);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
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
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(12, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 24);
            this.label17.TabIndex = 45;
            this.label17.Text = "* wymagane";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpData.Location = new System.Drawing.Point(173, 143);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(375, 29);
            this.dtpData.TabIndex = 46;
            // 
            // KontrolaJakosciFormCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 522);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUwagi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOdrzucone);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.txtZaakceptowane);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KontrolaJakosciFormCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.Load += new System.EventHandler(this.KontrolaJakosciFormCU_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZaakceptowane;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdrzucone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUwagi;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}