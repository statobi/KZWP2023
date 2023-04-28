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
            this.DGVAsortyment.Location = new System.Drawing.Point(12, 451);
            this.DGVAsortyment.MultiSelect = false;
            this.DGVAsortyment.Name = "DGVAsortyment";
            this.DGVAsortyment.ReadOnly = true;
            this.DGVAsortyment.RowHeadersWidth = 51;
            this.DGVAsortyment.RowTemplate.Height = 24;
            this.DGVAsortyment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAsortyment.Size = new System.Drawing.Size(1288, 351);
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
            this.DGVPolka.Location = new System.Drawing.Point(12, 61);
            this.DGVPolka.MultiSelect = false;
            this.DGVPolka.Name = "DGVPolka";
            this.DGVPolka.ReadOnly = true;
            this.DGVPolka.RowHeadersWidth = 51;
            this.DGVPolka.RowTemplate.Height = 24;
            this.DGVPolka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPolka.Size = new System.Drawing.Size(1288, 330);
            this.DGVPolka.TabIndex = 2;
            this.DGVPolka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPolka_CellClick);
            // 
            // LblHeader
            // 
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.LblHeader.Location = new System.Drawing.Point(12, -4);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(1291, 46);
            this.LblHeader.TabIndex = 3;
            this.LblHeader.Text = "Header";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubheader
            // 
            this.LblSubheader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblSubheader.Location = new System.Drawing.Point(12, 35);
            this.LblSubheader.Name = "LblSubheader";
            this.LblSubheader.Size = new System.Drawing.Size(1288, 25);
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
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnBack.Size = new System.Drawing.Size(64, 43);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // SekcjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 841);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblSubheader);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.DGVPolka);
            this.Controls.Add(this.DGVAsortyment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SekcjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekcjaForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SekcjaForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsortyment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPolka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAsortyment;
        private System.Windows.Forms.DataGridView DGVPolka;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblSubheader;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}