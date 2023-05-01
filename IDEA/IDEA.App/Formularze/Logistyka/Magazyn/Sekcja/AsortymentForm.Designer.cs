namespace IDEA.App.Formularze.Logistyka.Magazyn.Sekcja
{
    partial class AsortymentForm
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
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.LblSubheader = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.DGVMaterialy = new System.Windows.Forms.DataGridView();
            this.DGVProdukty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaterialy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnBack.IconColor = System.Drawing.Color.Black;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(11, 11);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnBack.Size = new System.Drawing.Size(48, 35);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblSubheader
            // 
            this.LblSubheader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LblSubheader.Location = new System.Drawing.Point(400, 25);
            this.LblSubheader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubheader.Name = "LblSubheader";
            this.LblSubheader.Size = new System.Drawing.Size(178, 20);
            this.LblSubheader.TabIndex = 9;
            this.LblSubheader.Text = "Subheader";
            this.LblSubheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHeader
            // 
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LblHeader.Location = new System.Drawing.Point(400, -6);
            this.LblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(180, 37);
            this.LblHeader.TabIndex = 8;
            this.LblHeader.Text = "Header";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVMaterialy
            // 
            this.DGVMaterialy.AllowUserToAddRows = false;
            this.DGVMaterialy.AllowUserToDeleteRows = false;
            this.DGVMaterialy.AllowUserToResizeColumns = false;
            this.DGVMaterialy.AllowUserToResizeRows = false;
            this.DGVMaterialy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGVMaterialy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMaterialy.Location = new System.Drawing.Point(11, 52);
            this.DGVMaterialy.MultiSelect = false;
            this.DGVMaterialy.Name = "DGVMaterialy";
            this.DGVMaterialy.ReadOnly = true;
            this.DGVMaterialy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMaterialy.Size = new System.Drawing.Size(473, 620);
            this.DGVMaterialy.TabIndex = 10;
            // 
            // DGVProdukty
            // 
            this.DGVProdukty.AllowUserToAddRows = false;
            this.DGVProdukty.AllowUserToDeleteRows = false;
            this.DGVProdukty.AllowUserToResizeColumns = false;
            this.DGVProdukty.AllowUserToResizeRows = false;
            this.DGVProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGVProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProdukty.Location = new System.Drawing.Point(490, 52);
            this.DGVProdukty.MultiSelect = false;
            this.DGVProdukty.Name = "DGVProdukty";
            this.DGVProdukty.ReadOnly = true;
            this.DGVProdukty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProdukty.Size = new System.Drawing.Size(479, 620);
            this.DGVProdukty.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Materiały";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(727, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produkty";
            // 
            // AsortymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 683);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVProdukty);
            this.Controls.Add(this.DGVMaterialy);
            this.Controls.Add(this.LblSubheader);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.BtnBack);
            this.Name = "AsortymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsortymentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AsortymentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaterialy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.Label LblSubheader;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.DataGridView DGVMaterialy;
        private System.Windows.Forms.DataGridView DGVProdukty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}