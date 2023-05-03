namespace IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace
{
    partial class PrzypiszTypZasobuForm
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
            this.DGVMaterialy = new System.Windows.Forms.DataGridView();
            this.DGVProdukty = new System.Windows.Forms.DataGridView();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnAssaignMaterial = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaterialy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMaterialy
            // 
            this.DGVMaterialy.AllowUserToAddRows = false;
            this.DGVMaterialy.AllowUserToDeleteRows = false;
            this.DGVMaterialy.AllowUserToResizeColumns = false;
            this.DGVMaterialy.AllowUserToResizeRows = false;
            this.DGVMaterialy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMaterialy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMaterialy.Location = new System.Drawing.Point(12, 52);
            this.DGVMaterialy.Name = "DGVMaterialy";
            this.DGVMaterialy.ReadOnly = true;
            this.DGVMaterialy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMaterialy.Size = new System.Drawing.Size(484, 543);
            this.DGVMaterialy.TabIndex = 0;
            // 
            // DGVProdukty
            // 
            this.DGVProdukty.AllowUserToAddRows = false;
            this.DGVProdukty.AllowUserToDeleteRows = false;
            this.DGVProdukty.AllowUserToResizeColumns = false;
            this.DGVProdukty.AllowUserToResizeRows = false;
            this.DGVProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProdukty.Location = new System.Drawing.Point(502, 52);
            this.DGVProdukty.Name = "DGVProdukty";
            this.DGVProdukty.ReadOnly = true;
            this.DGVProdukty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProdukty.Size = new System.Drawing.Size(470, 543);
            this.DGVProdukty.TabIndex = 1;
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
            this.BtnBack.TabIndex = 9;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAssaignMaterial
            // 
            this.BtnAssaignMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAssaignMaterial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAssaignMaterial.IconColor = System.Drawing.Color.Black;
            this.BtnAssaignMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAssaignMaterial.Location = new System.Drawing.Point(49, 601);
            this.BtnAssaignMaterial.Name = "BtnAssaignMaterial";
            this.BtnAssaignMaterial.Size = new System.Drawing.Size(413, 42);
            this.BtnAssaignMaterial.TabIndex = 10;
            this.BtnAssaignMaterial.Text = "Przypisz wybrane materialy do odpowiedniego zasobu";
            this.BtnAssaignMaterial.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(533, 601);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(413, 42);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "Przypisz wybrane produkty do odpowiedniego zasobu";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // PrzypiszTypZasobuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.BtnAssaignMaterial);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DGVProdukty);
            this.Controls.Add(this.DGVMaterialy);
            this.Name = "PrzypiszTypZasobuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrzypiszTypZasobuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrzypiszTypZasobuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaterialy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdukty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMaterialy;
        private System.Windows.Forms.DataGridView DGVProdukty;
        private FontAwesome.Sharp.IconButton BtnBack;
        private FontAwesome.Sharp.IconButton BtnAssaignMaterial;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}