namespace IDEA.App.Formularze.Logistyka.Magazyn.Nieprzypisane
{
    partial class OczekujaceForm
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
            this.DGVOczekujace = new System.Windows.Forms.DataGridView();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnArrange = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOczekujace)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVOczekujace
            // 
            this.DGVOczekujace.AllowUserToAddRows = false;
            this.DGVOczekujace.AllowUserToDeleteRows = false;
            this.DGVOczekujace.AllowUserToResizeColumns = false;
            this.DGVOczekujace.AllowUserToResizeRows = false;
            this.DGVOczekujace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOczekujace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOczekujace.Location = new System.Drawing.Point(12, 58);
            this.DGVOczekujace.Name = "DGVOczekujace";
            this.DGVOczekujace.ReadOnly = true;
            this.DGVOczekujace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVOczekujace.Size = new System.Drawing.Size(583, 621);
            this.DGVOczekujace.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnBack.IconColor = System.Drawing.Color.Black;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(12, 11);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnBack.Size = new System.Drawing.Size(48, 35);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnArrange
            // 
            this.BtnArrange.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnArrange.IconColor = System.Drawing.Color.Black;
            this.BtnArrange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnArrange.Location = new System.Drawing.Point(792, 656);
            this.BtnArrange.Name = "BtnArrange";
            this.BtnArrange.Size = new System.Drawing.Size(180, 23);
            this.BtnArrange.TabIndex = 9;
            this.BtnArrange.Text = "Rozmieść asortyment w magazynie";
            this.BtnArrange.UseVisualStyleBackColor = true;
            this.BtnArrange.Click += new System.EventHandler(this.BtnArrange_Click);
            // 
            // OczekujaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.BtnArrange);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DGVOczekujace);
            this.Name = "OczekujaceForm";
            this.Text = "NieprzypisaneForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NieprzypisaneForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOczekujace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVOczekujace;
        private FontAwesome.Sharp.IconButton BtnBack;
        private FontAwesome.Sharp.IconButton BtnArrange;
    }
}