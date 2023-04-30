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
            this.dgv_zlecenie_magazynowe = new System.Windows.Forms.DataGridView();
            this.btn_Dodaj_Transport_wewnetrzny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_produkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dostepne_pojazd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zlecenie_magazynowe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sklad_zamowienia_material
            // 
            this.dgv_sklad_zamowienia_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sklad_zamowienia_material.Location = new System.Drawing.Point(64, 221);
            this.dgv_sklad_zamowienia_material.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sklad_zamowienia_material.Name = "dgv_sklad_zamowienia_material";
            this.dgv_sklad_zamowienia_material.Size = new System.Drawing.Size(729, 94);
            this.dgv_sklad_zamowienia_material.TabIndex = 0;
            this.dgv_sklad_zamowienia_material.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sklad_zamowienia_material_CellContentClick);
            // 
            // dgv_sklad_zamowienia_produkt
            // 
            this.dgv_sklad_zamowienia_produkt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sklad_zamowienia_produkt.Location = new System.Drawing.Point(64, 323);
            this.dgv_sklad_zamowienia_produkt.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sklad_zamowienia_produkt.Name = "dgv_sklad_zamowienia_produkt";
            this.dgv_sklad_zamowienia_produkt.Size = new System.Drawing.Size(729, 86);
            this.dgv_sklad_zamowienia_produkt.TabIndex = 1;
            this.dgv_sklad_zamowienia_produkt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sklad_zamowienia_produkt_CellContentClick);
            // 
            // dgv_dostepne_pojazd
            // 
            this.dgv_dostepne_pojazd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dostepne_pojazd.Location = new System.Drawing.Point(61, 417);
            this.dgv_dostepne_pojazd.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dostepne_pojazd.Name = "dgv_dostepne_pojazd";
            this.dgv_dostepne_pojazd.Size = new System.Drawing.Size(1014, 174);
            this.dgv_dostepne_pojazd.TabIndex = 2;
            this.dgv_dostepne_pojazd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dostepne_pojazd_CellContentClick);
            // 
            // dgv_zlecenie_magazynowe
            // 
            this.dgv_zlecenie_magazynowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zlecenie_magazynowe.Location = new System.Drawing.Point(64, 21);
            this.dgv_zlecenie_magazynowe.Name = "dgv_zlecenie_magazynowe";
            this.dgv_zlecenie_magazynowe.RowTemplate.Height = 24;
            this.dgv_zlecenie_magazynowe.Size = new System.Drawing.Size(486, 193);
            this.dgv_zlecenie_magazynowe.TabIndex = 3;
            this.dgv_zlecenie_magazynowe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zlecenie_magazynowe_CellClick);
            this.dgv_zlecenie_magazynowe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zlecenie_magazynowe_CellContentClick);
            // 
            // btn_Dodaj_Transport_wewnetrzny
            // 
            this.btn_Dodaj_Transport_wewnetrzny.Location = new System.Drawing.Point(1000, 184);
            this.btn_Dodaj_Transport_wewnetrzny.Name = "btn_Dodaj_Transport_wewnetrzny";
            this.btn_Dodaj_Transport_wewnetrzny.Size = new System.Drawing.Size(214, 93);
            this.btn_Dodaj_Transport_wewnetrzny.TabIndex = 4;
            this.btn_Dodaj_Transport_wewnetrzny.Text = "Dodaj transport wewnętrzny";
            this.btn_Dodaj_Transport_wewnetrzny.UseVisualStyleBackColor = true;
            this.btn_Dodaj_Transport_wewnetrzny.Click += new System.EventHandler(this.btn_Dodaj_Transport_wewnetrzny_Click);
            // 
            // TransportWewnetrznyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 758);
            this.Controls.Add(this.btn_Dodaj_Transport_wewnetrzny);
            this.Controls.Add(this.dgv_zlecenie_magazynowe);
            this.Controls.Add(this.dgv_dostepne_pojazd);
            this.Controls.Add(this.dgv_sklad_zamowienia_produkt);
            this.Controls.Add(this.dgv_sklad_zamowienia_material);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransportWewnetrznyForm";
            this.Text = "TransportWewnetrznyForm";
            this.Load += new System.EventHandler(this.TransportWewnetrznyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_produkt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dostepne_pojazd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zlecenie_magazynowe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sklad_zamowienia_material;
        private System.Windows.Forms.DataGridView dgv_sklad_zamowienia_produkt;
        private System.Windows.Forms.DataGridView dgv_dostepne_pojazd;
        private System.Windows.Forms.DataGridView dgv_zlecenie_magazynowe;
        private System.Windows.Forms.Button btn_Dodaj_Transport_wewnetrzny;
    }
}