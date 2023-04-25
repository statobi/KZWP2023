namespace IDEA.App.Formularze.Produkcja
{
    partial class RodzajMaszynyForm
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
            this.dgvRodzajMaszyny = new System.Windows.Forms.DataGridView();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.txtRodzajMaszyny = new System.Windows.Forms.TextBox();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRodzajMaszyny
            // 
            this.dgvRodzajMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzajMaszyny.Location = new System.Drawing.Point(395, 12);
            this.dgvRodzajMaszyny.Name = "dgvRodzajMaszyny";
            this.dgvRodzajMaszyny.Size = new System.Drawing.Size(286, 260);
            this.dgvRodzajMaszyny.TabIndex = 1;
            this.dgvRodzajMaszyny.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRodzajMaszyny_CellClick);
            this.dgvRodzajMaszyny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRodzajMaszyny_CellContentClick);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(58, 176);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 52);
            this.btnAccept.TabIndex = 36;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(184, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(8, 74);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(146, 24);
            this.lblImie.TabIndex = 38;
            this.lblImie.Text = "Rodzaj maszyny";
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(7, 12);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(368, 25);
            this.lblKindWindow.TabIndex = 39;
            this.lblKindWindow.Text = "Dodawanie nowego rodzaju maszyny";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKindWindow.Click += new System.EventHandler(this.lblKindWindow_Click);
            // 
            // txtRodzajMaszyny
            // 
            this.txtRodzajMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRodzajMaszyny.Location = new System.Drawing.Point(12, 101);
            this.txtRodzajMaszyny.Name = "txtRodzajMaszyny";
            this.txtRodzajMaszyny.Size = new System.Drawing.Size(298, 29);
            this.txtRodzajMaszyny.TabIndex = 40;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Red;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(336, 217);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(53, 55);
            this.iBtnDelete.TabIndex = 41;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // RodzajMaszynyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 292);
            this.Controls.Add(this.iBtnDelete);
            this.Controls.Add(this.txtRodzajMaszyny);
            this.Controls.Add(this.lblKindWindow);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvRodzajMaszyny);
            this.Name = "RodzajMaszynyForm";
            this.Text = "RodzajMaszynyForm";
            this.Load += new System.EventHandler(this.RodzajMaszynyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajMaszyny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRodzajMaszyny;
        private FontAwesome.Sharp.IconButton btnAccept;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.TextBox txtRodzajMaszyny;
        private FontAwesome.Sharp.IconButton iBtnDelete;
    }
}