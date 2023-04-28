namespace IDEA.App.Formularze.Produkcja
{
    partial class MaszynyCU
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbolMaszyny = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkaMaszyny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDataPrzychodu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDataRozchodu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrzebiegPoczatkowy = new System.Windows.Forms.TextBox();
            this.txtKosztRoboczogodziny = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDodajRodzMaszyny = new System.Windows.Forms.Button();
            this.cbRodzajMaszyny = new System.Windows.Forms.ComboBox();
            this.cbModelMaszyny = new System.Windows.Forms.ComboBox();
            this.btnDodajModelMaszyny = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxDataRozchodu = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(10, 73);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(146, 24);
            this.lblImie.TabIndex = 4;
            this.lblImie.Text = "Rodzaj maszyny";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Symbol maszyny";
            // 
            // txtSymbolMaszyny
            // 
            this.txtSymbolMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSymbolMaszyny.Location = new System.Drawing.Point(310, 142);
            this.txtSymbolMaszyny.Name = "txtSymbolMaszyny";
            this.txtSymbolMaszyny.Size = new System.Drawing.Size(373, 29);
            this.txtSymbolMaszyny.TabIndex = 7;
            this.txtSymbolMaszyny.TextChanged += new System.EventHandler(this.txtSymbolMaszyny_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marka maszyny";
            // 
            // txtMarkaMaszyny
            // 
            this.txtMarkaMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMarkaMaszyny.Location = new System.Drawing.Point(310, 177);
            this.txtMarkaMaszyny.Name = "txtMarkaMaszyny";
            this.txtMarkaMaszyny.ReadOnly = true;
            this.txtMarkaMaszyny.Size = new System.Drawing.Size(373, 29);
            this.txtMarkaMaszyny.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model maszyny";
            // 
            // dateDataPrzychodu
            // 
            this.dateDataPrzychodu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataPrzychodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataPrzychodu.Location = new System.Drawing.Point(310, 290);
            this.dateDataPrzychodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDataPrzychodu.Name = "dateDataPrzychodu";
            this.dateDataPrzychodu.Size = new System.Drawing.Size(340, 26);
            this.dateDataPrzychodu.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Data przychodu";
            // 
            // dateDataRozchodu
            // 
            this.dateDataRozchodu.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataRozchodu.Enabled = false;
            this.dateDataRozchodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataRozchodu.Location = new System.Drawing.Point(310, 329);
            this.dateDataRozchodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDataRozchodu.Name = "dateDataRozchodu";
            this.dateDataRozchodu.Size = new System.Drawing.Size(340, 26);
            this.dateDataRozchodu.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Data rozchodu";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(141, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(58, 4);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 35;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(10, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Przebieg poczatkowy";
            // 
            // txtPrzebiegPoczatkowy
            // 
            this.txtPrzebiegPoczatkowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzebiegPoczatkowy.Location = new System.Drawing.Point(310, 208);
            this.txtPrzebiegPoczatkowy.Name = "txtPrzebiegPoczatkowy";
            this.txtPrzebiegPoczatkowy.Size = new System.Drawing.Size(187, 29);
            this.txtPrzebiegPoczatkowy.TabIndex = 47;
            // 
            // txtKosztRoboczogodziny
            // 
            this.txtKosztRoboczogodziny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKosztRoboczogodziny.Location = new System.Drawing.Point(310, 248);
            this.txtKosztRoboczogodziny.Name = "txtKosztRoboczogodziny";
            this.txtKosztRoboczogodziny.ReadOnly = true;
            this.txtKosztRoboczogodziny.Size = new System.Drawing.Size(187, 29);
            this.txtKosztRoboczogodziny.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(10, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 24);
            this.label12.TabIndex = 48;
            this.label12.Text = "Koszt roboczogodziny";
            // 
            // btnDodajRodzMaszyny
            // 
            this.btnDodajRodzMaszyny.Location = new System.Drawing.Point(698, 76);
            this.btnDodajRodzMaszyny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajRodzMaszyny.Name = "btnDodajRodzMaszyny";
            this.btnDodajRodzMaszyny.Size = new System.Drawing.Size(131, 24);
            this.btnDodajRodzMaszyny.TabIndex = 52;
            this.btnDodajRodzMaszyny.Text = "Dodaj rodzaj maszyny";
            this.btnDodajRodzMaszyny.UseVisualStyleBackColor = true;
            this.btnDodajRodzMaszyny.Click += new System.EventHandler(this.btnDodajRodzMaszyny_Click_1);
            // 
            // cbRodzajMaszyny
            // 
            this.cbRodzajMaszyny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRodzajMaszyny.FormattingEnabled = true;
            this.cbRodzajMaszyny.Location = new System.Drawing.Point(310, 76);
            this.cbRodzajMaszyny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRodzajMaszyny.Name = "cbRodzajMaszyny";
            this.cbRodzajMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbRodzajMaszyny.TabIndex = 36;
            this.cbRodzajMaszyny.SelectedIndexChanged += new System.EventHandler(this.cbRodzajMaszyny_SelectedIndexChanged);
            this.cbRodzajMaszyny.Click += new System.EventHandler(this.cbRodzajMaszyny_Click);
            // 
            // cbModelMaszyny
            // 
            this.cbModelMaszyny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelMaszyny.FormattingEnabled = true;
            this.cbModelMaszyny.Location = new System.Drawing.Point(310, 110);
            this.cbModelMaszyny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbModelMaszyny.Name = "cbModelMaszyny";
            this.cbModelMaszyny.Size = new System.Drawing.Size(373, 21);
            this.cbModelMaszyny.TabIndex = 53;
            // 
            // btnDodajModelMaszyny
            // 
            this.btnDodajModelMaszyny.Location = new System.Drawing.Point(698, 108);
            this.btnDodajModelMaszyny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajModelMaszyny.Name = "btnDodajModelMaszyny";
            this.btnDodajModelMaszyny.Size = new System.Drawing.Size(131, 24);
            this.btnDodajModelMaszyny.TabIndex = 54;
            this.btnDodajModelMaszyny.Text = "Dodaj model maszyny";
            this.btnDodajModelMaszyny.UseVisualStyleBackColor = true;
            this.btnDodajModelMaszyny.Click += new System.EventHandler(this.btnDodajModelMaszyny_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(290, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Dodawanie nowej maszyny";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxDataRozchodu
            // 
            this.checkBoxDataRozchodu.AutoSize = true;
            this.checkBoxDataRozchodu.Location = new System.Drawing.Point(278, 339);
            this.checkBoxDataRozchodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxDataRozchodu.Name = "checkBoxDataRozchodu";
            this.checkBoxDataRozchodu.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDataRozchodu.TabIndex = 57;
            this.checkBoxDataRozchodu.UseVisualStyleBackColor = true;
            this.checkBoxDataRozchodu.CheckedChanged += new System.EventHandler(this.checkBoxDataRozchodu_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 53);
            this.panel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 60);
            this.panel2.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnAccept);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(629, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 60);
            this.panel3.TabIndex = 0;
            // 
            // MaszynyCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxDataRozchodu);
            this.Controls.Add(this.btnDodajModelMaszyny);
            this.Controls.Add(this.cbModelMaszyny);
            this.Controls.Add(this.btnDodajRodzMaszyny);
            this.Controls.Add(this.txtKosztRoboczogodziny);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrzebiegPoczatkowy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbRodzajMaszyny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateDataRozchodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateDataPrzychodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarkaMaszyny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSymbolMaszyny);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaszynyCU";
            this.Text = "MaszynyCU";
            this.Load += new System.EventHandler(this.MaszynyCU_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymbolMaszyny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarkaMaszyny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDataPrzychodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDataRozchodu;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrzebiegPoczatkowy;
        private System.Windows.Forms.TextBox txtKosztRoboczogodziny;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDodajRodzMaszyny;
        private System.Windows.Forms.ComboBox cbRodzajMaszyny;
        private System.Windows.Forms.ComboBox cbModelMaszyny;
        private System.Windows.Forms.Button btnDodajModelMaszyny;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxDataRozchodu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}