namespace IDEA.App.Formularze.Logistyka.Magazyn.Sekcja
{
    partial class SekcjaForm
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
            this.DGVAsortyment = new System.Windows.Forms.DataGridView();
            this.DGVPolka = new System.Windows.Forms.DataGridView();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblSubheader = new System.Windows.Forms.Label();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnAssortmentList = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsortyment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPolka)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAsortyment
            // 
            this.DGVAsortyment.AllowUserToAddRows = false;
            this.DGVAsortyment.AllowUserToDeleteRows = false;
            this.DGVAsortyment.AllowUserToResizeColumns = false;
            this.DGVAsortyment.AllowUserToResizeRows = false;
            this.DGVAsortyment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAsortyment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAsortyment.Location = new System.Drawing.Point(9, 374);
            this.DGVAsortyment.Margin = new System.Windows.Forms.Padding(2);
            this.DGVAsortyment.MultiSelect = false;
            this.DGVAsortyment.Name = "DGVAsortyment";
            this.DGVAsortyment.ReadOnly = true;
            this.DGVAsortyment.RowHeadersWidth = 51;
            this.DGVAsortyment.RowTemplate.Height = 24;
            this.DGVAsortyment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAsortyment.Size = new System.Drawing.Size(966, 298);
            this.DGVAsortyment.TabIndex = 1;
            // 
            // DGVPolka
            // 
            this.DGVPolka.AllowUserToAddRows = false;
            this.DGVPolka.AllowUserToDeleteRows = false;
            this.DGVPolka.AllowUserToResizeColumns = false;
            this.DGVPolka.AllowUserToResizeRows = false;
            this.DGVPolka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPolka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPolka.Location = new System.Drawing.Point(9, 50);
            this.DGVPolka.Margin = new System.Windows.Forms.Padding(2);
            this.DGVPolka.MultiSelect = false;
            this.DGVPolka.Name = "DGVPolka";
            this.DGVPolka.ReadOnly = true;
            this.DGVPolka.RowHeadersWidth = 51;
            this.DGVPolka.RowTemplate.Height = 24;
            this.DGVPolka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPolka.Size = new System.Drawing.Size(966, 268);
            this.DGVPolka.TabIndex = 2;
            this.DGVPolka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPolka_CellClick);
            // 
            // LblHeader
            // 
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LblHeader.Location = new System.Drawing.Point(804, -3);
            this.LblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(180, 37);
            this.LblHeader.TabIndex = 3;
            this.LblHeader.Text = "Header";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubheader
            // 
            this.LblSubheader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LblSubheader.Location = new System.Drawing.Point(804, 28);
            this.LblSubheader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubheader.Name = "LblSubheader";
            this.LblSubheader.Size = new System.Drawing.Size(178, 20);
            this.LblSubheader.TabIndex = 5;
            this.LblSubheader.Text = "Subheader";
            this.LblSubheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBack
            // 
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnBack.IconColor = System.Drawing.Color.Black;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(9, 10);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnBack.Size = new System.Drawing.Size(48, 35);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAssortmentList
            // 
            this.BtnAssortmentList.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.BtnAssortmentList.IconColor = System.Drawing.Color.Black;
            this.BtnAssortmentList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAssortmentList.IconSize = 40;
            this.BtnAssortmentList.Location = new System.Drawing.Point(9, 323);
            this.BtnAssortmentList.Name = "BtnAssortmentList";
            this.BtnAssortmentList.Size = new System.Drawing.Size(50, 46);
            this.BtnAssortmentList.TabIndex = 7;
            this.BtnAssortmentList.UseVisualStyleBackColor = true;
            this.BtnAssortmentList.Click += new System.EventHandler(this.BtnAssortmentList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(431, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Półki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(402, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Asortyment";
            // 
            // SekcjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 683);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAssortmentList);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblSubheader);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.DGVPolka);
            this.Controls.Add(this.DGVAsortyment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SekcjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekcjaForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SekcjaForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsortyment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPolka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAsortyment;
        private System.Windows.Forms.DataGridView DGVPolka;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblSubheader;
        private FontAwesome.Sharp.IconButton BtnBack;
        private FontAwesome.Sharp.IconButton BtnAssortmentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}