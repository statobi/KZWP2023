namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    partial class PrzegladyForm
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
            this.btn_usun_przeglad = new System.Windows.Forms.Button();
            this.btn_dodaj_przeglad = new System.Windows.Forms.Button();
            this.dgv_przeglad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_przeglad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_usun_przeglad
            // 
            this.btn_usun_przeglad.Location = new System.Drawing.Point(199, 289);
            this.btn_usun_przeglad.Name = "btn_usun_przeglad";
            this.btn_usun_przeglad.Size = new System.Drawing.Size(162, 59);
            this.btn_usun_przeglad.TabIndex = 5;
            this.btn_usun_przeglad.Text = "Usuń przegląd";
            this.btn_usun_przeglad.UseVisualStyleBackColor = true;
            this.btn_usun_przeglad.Click += new System.EventHandler(this.btn_usun_przeglad_Click);
            // 
            // btn_dodaj_przeglad
            // 
            this.btn_dodaj_przeglad.Location = new System.Drawing.Point(442, 289);
            this.btn_dodaj_przeglad.Name = "btn_dodaj_przeglad";
            this.btn_dodaj_przeglad.Size = new System.Drawing.Size(162, 59);
            this.btn_dodaj_przeglad.TabIndex = 4;
            this.btn_dodaj_przeglad.Text = "Dodaj przegląd";
            this.btn_dodaj_przeglad.UseVisualStyleBackColor = true;
            this.btn_dodaj_przeglad.Click += new System.EventHandler(this.btn_dodaj_przeglad_Click);
            // 
            // dgv_przeglad
            // 
            this.dgv_przeglad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_przeglad.Location = new System.Drawing.Point(12, 12);
            this.dgv_przeglad.Name = "dgv_przeglad";
            this.dgv_przeglad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_przeglad.Size = new System.Drawing.Size(776, 241);
            this.dgv_przeglad.TabIndex = 3;
            this.dgv_przeglad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_przeglad_CellClick);
            // 
            // PrzegladyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_usun_przeglad);
            this.Controls.Add(this.btn_dodaj_przeglad);
            this.Controls.Add(this.dgv_przeglad);
            this.Name = "PrzegladyForm";
            this.Text = "PrzegladyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_przeglad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_usun_przeglad;
        private System.Windows.Forms.Button btn_dodaj_przeglad;
        private System.Windows.Forms.DataGridView dgv_przeglad;
    }
}