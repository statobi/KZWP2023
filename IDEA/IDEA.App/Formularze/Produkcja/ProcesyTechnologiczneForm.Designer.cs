namespace IDEA.App.Formularze.Produkcja
{
    partial class ProcesyTechnologiczneForm
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
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProcesyTechnologiczne = new System.Windows.Forms.DataGridView();
            this.iBtnNew = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyTechnologiczne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(783, 487);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 71);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Procesy Technologiczne";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvProcesyTechnologiczne
            // 
            this.dgvProcesyTechnologiczne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesyTechnologiczne.Location = new System.Drawing.Point(20, 66);
            this.dgvProcesyTechnologiczne.Name = "dgvProcesyTechnologiczne";
            this.dgvProcesyTechnologiczne.Size = new System.Drawing.Size(824, 404);
            this.dgvProcesyTechnologiczne.TabIndex = 57;
            // 
            // iBtnNew
            // 
            this.iBtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iBtnNew.IconColor = System.Drawing.Color.Black;
            this.iBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNew.Location = new System.Drawing.Point(20, 487);
            this.iBtnNew.Name = "iBtnNew";
            this.iBtnNew.Size = new System.Drawing.Size(75, 71);
            this.iBtnNew.TabIndex = 60;
            this.iBtnNew.UseVisualStyleBackColor = true;
            // 
            // ProcesyTechnologiczneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 570);
            this.Controls.Add(this.iBtnNew);
            this.Controls.Add(this.dgvProcesyTechnologiczne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcesyTechnologiczneForm";
            this.Text = "ProcesyTechnologiczneForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyTechnologiczne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProcesyTechnologiczne;
        private FontAwesome.Sharp.IconButton iBtnNew;
    }
}