namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    partial class TransportWewnetrznyPodsumowanieForm
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
            this.DGVTransporty = new System.Windows.Forms.DataGridView();
            this.DGVSklad = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransporty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSklad)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTransporty
            // 
            this.DGVTransporty.AllowUserToAddRows = false;
            this.DGVTransporty.AllowUserToDeleteRows = false;
            this.DGVTransporty.AllowUserToResizeColumns = false;
            this.DGVTransporty.AllowUserToResizeRows = false;
            this.DGVTransporty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTransporty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTransporty.Location = new System.Drawing.Point(12, 49);
            this.DGVTransporty.MultiSelect = false;
            this.DGVTransporty.Name = "DGVTransporty";
            this.DGVTransporty.ReadOnly = true;
            this.DGVTransporty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTransporty.Size = new System.Drawing.Size(776, 205);
            this.DGVTransporty.TabIndex = 0;
            this.DGVTransporty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTransporty_CellClick);
            // 
            // DGVSklad
            // 
            this.DGVSklad.AllowUserToAddRows = false;
            this.DGVSklad.AllowUserToDeleteRows = false;
            this.DGVSklad.AllowUserToResizeColumns = false;
            this.DGVSklad.AllowUserToResizeRows = false;
            this.DGVSklad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSklad.Location = new System.Drawing.Point(12, 297);
            this.DGVSklad.MultiSelect = false;
            this.DGVSklad.Name = "DGVSklad";
            this.DGVSklad.ReadOnly = true;
            this.DGVSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSklad.Size = new System.Drawing.Size(776, 227);
            this.DGVSklad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(273, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dodane transporty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(286, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Skład transportu";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Red;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancel.IconColor = System.Drawing.Color.Red;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancel.IconSize = 46;
            this.BtnCancel.Location = new System.Drawing.Point(393, 536);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(236, 48);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.Text = "Anuluj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAdd.IconSize = 36;
            this.BtnAdd.Location = new System.Drawing.Point(142, 536);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(245, 48);
            this.BtnAdd.TabIndex = 32;
            this.BtnAdd.Text = "Zrealizuj transport";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TransportWewnetrznyPodsumowanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVSklad);
            this.Controls.Add(this.DGVTransporty);
            this.Name = "TransportWewnetrznyPodsumowanieForm";
            this.Text = "TransportWewnetrznyPodsumowanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransportWewnetrznyPodsumowanie_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransporty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSklad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTransporty;
        private System.Windows.Forms.DataGridView DGVSklad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnAdd;
    }
}