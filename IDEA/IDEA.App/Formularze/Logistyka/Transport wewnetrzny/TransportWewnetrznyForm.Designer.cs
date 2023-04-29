namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    partial class TransportWewnetrznyForm
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
            this.dgv_sklad_zamowienia_material = new System.Windows.Forms.DataGridView();
            this.dgv_sklad_zamowienia_produkt = new System.Windows.Forms.DataGridView();
            this.dgv_dostepne_pojazd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_produkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dostepne_pojazd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sklad_zamowienia_material
            // 
            this.dgv_sklad_zamowienia_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sklad_zamowienia_material.Location = new System.Drawing.Point(46, 32);
            this.dgv_sklad_zamowienia_material.Name = "dgv_sklad_zamowienia_material";
            this.dgv_sklad_zamowienia_material.Size = new System.Drawing.Size(748, 141);
            this.dgv_sklad_zamowienia_material.TabIndex = 0;
            this.dgv_sklad_zamowienia_material.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sklad_zamowienia_material_CellContentClick);
            // 
            // dgv_sklad_zamowienia_produkt
            // 
            this.dgv_sklad_zamowienia_produkt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sklad_zamowienia_produkt.Location = new System.Drawing.Point(46, 179);
            this.dgv_sklad_zamowienia_produkt.Name = "dgv_sklad_zamowienia_produkt";
            this.dgv_sklad_zamowienia_produkt.Size = new System.Drawing.Size(748, 141);
            this.dgv_sklad_zamowienia_produkt.TabIndex = 1;
            this.dgv_sklad_zamowienia_produkt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sklad_zamowienia_produkt_CellContentClick);
            // 
            // dgv_dostepne_pojazd
            // 
            this.dgv_dostepne_pojazd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dostepne_pojazd.Location = new System.Drawing.Point(46, 326);
            this.dgv_dostepne_pojazd.Name = "dgv_dostepne_pojazd";
            this.dgv_dostepne_pojazd.Size = new System.Drawing.Size(748, 157);
            this.dgv_dostepne_pojazd.TabIndex = 2;
            this.dgv_dostepne_pojazd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dostepne_pojazd_CellContentClick);
            // 
            // TransportWewnetrznyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 616);
            this.Controls.Add(this.dgv_dostepne_pojazd);
            this.Controls.Add(this.dgv_sklad_zamowienia_produkt);
            this.Controls.Add(this.dgv_sklad_zamowienia_material);
            this.Name = "TransportWewnetrznyForm";
            this.Text = "TransportWewnetrznyForm";
            this.Load += new System.EventHandler(this.TransportWewnetrznyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_produkt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dostepne_pojazd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sklad_zamowienia_material;
        private System.Windows.Forms.DataGridView dgv_sklad_zamowienia_produkt;
        private System.Windows.Forms.DataGridView dgv_dostepne_pojazd;
    }
}