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
            this.dgv_transporty_wewnetrzne = new System.Windows.Forms.DataGridView();
            this.dgv_zlecenie_magazynowe = new System.Windows.Forms.DataGridView();
            this.btn_Dodaj_Transport_wewnetrzny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_usun_transport_wewnetrzny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_produkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transporty_wewnetrzne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zlecenie_magazynowe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sklad_zamowienia_material
            // 
            this.dgv_sklad_zamowienia_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sklad_zamowienia_material.Location = new System.Drawing.Point(17, 225);
            this.dgv_sklad_zamowienia_material.Name = "dgv_sklad_zamowienia_material";
            this.dgv_sklad_zamowienia_material.Size = new System.Drawing.Size(797, 76);
            this.dgv_sklad_zamowienia_material.TabIndex = 0;
            this.dgv_sklad_zamowienia_material.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sklad_zamowienia_material_CellContentClick);
            // 
            // dgv_sklad_zamowienia_produkt
            // 
            this.dgv_sklad_zamowienia_produkt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sklad_zamowienia_produkt.Location = new System.Drawing.Point(17, 340);
            this.dgv_sklad_zamowienia_produkt.Name = "dgv_sklad_zamowienia_produkt";
            this.dgv_sklad_zamowienia_produkt.Size = new System.Drawing.Size(797, 70);
            this.dgv_sklad_zamowienia_produkt.TabIndex = 1;
            this.dgv_sklad_zamowienia_produkt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sklad_zamowienia_produkt_CellContentClick);
            // 
            // dgv_transporty_wewnetrzne
            // 
            this.dgv_transporty_wewnetrzne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transporty_wewnetrzne.Location = new System.Drawing.Point(17, 440);
            this.dgv_transporty_wewnetrzne.Name = "dgv_transporty_wewnetrzne";
            this.dgv_transporty_wewnetrzne.Size = new System.Drawing.Size(797, 239);
            this.dgv_transporty_wewnetrzne.TabIndex = 2;
            this.dgv_transporty_wewnetrzne.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dostepne_pojazd_CellClick);
            // 
            // dgv_zlecenie_magazynowe
            // 
            this.dgv_zlecenie_magazynowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zlecenie_magazynowe.Location = new System.Drawing.Point(17, 35);
            this.dgv_zlecenie_magazynowe.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_zlecenie_magazynowe.Name = "dgv_zlecenie_magazynowe";
            this.dgv_zlecenie_magazynowe.ReadOnly = true;
            this.dgv_zlecenie_magazynowe.RowTemplate.Height = 24;
            this.dgv_zlecenie_magazynowe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_zlecenie_magazynowe.Size = new System.Drawing.Size(956, 157);
            this.dgv_zlecenie_magazynowe.TabIndex = 3;
            this.dgv_zlecenie_magazynowe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zlecenie_magazynowe_CellClick);
            this.dgv_zlecenie_magazynowe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zlecenie_magazynowe_CellContentClick);
            // 
            // btn_Dodaj_Transport_wewnetrzny
            // 
            this.btn_Dodaj_Transport_wewnetrzny.Location = new System.Drawing.Point(819, 524);
            this.btn_Dodaj_Transport_wewnetrzny.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dodaj_Transport_wewnetrzny.Name = "btn_Dodaj_Transport_wewnetrzny";
            this.btn_Dodaj_Transport_wewnetrzny.Size = new System.Drawing.Size(160, 76);
            this.btn_Dodaj_Transport_wewnetrzny.TabIndex = 4;
            this.btn_Dodaj_Transport_wewnetrzny.Text = "Dodaj transport wewnętrzny";
            this.btn_Dodaj_Transport_wewnetrzny.UseVisualStyleBackColor = true;
            this.btn_Dodaj_Transport_wewnetrzny.Click += new System.EventHandler(this.btn_Dodaj_Transport_wewnetrzny_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wszystkie transporty wewnętrzne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wszystkie zlecenia magazynowe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Skład zlecenia produkt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Skład zlecenia materiał";
            // 
            // btn_usun_transport_wewnetrzny
            // 
            this.btn_usun_transport_wewnetrzny.Location = new System.Drawing.Point(819, 604);
            this.btn_usun_transport_wewnetrzny.Margin = new System.Windows.Forms.Padding(2);
            this.btn_usun_transport_wewnetrzny.Name = "btn_usun_transport_wewnetrzny";
            this.btn_usun_transport_wewnetrzny.Size = new System.Drawing.Size(160, 76);
            this.btn_usun_transport_wewnetrzny.TabIndex = 9;
            this.btn_usun_transport_wewnetrzny.Text = "Usuń transport wewnętrzny";
            this.btn_usun_transport_wewnetrzny.UseVisualStyleBackColor = true;
            this.btn_usun_transport_wewnetrzny.Click += new System.EventHandler(this.btn_usun_TW_Click);
            // 
            // TransportWewnetrznyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.btn_usun_transport_wewnetrzny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Dodaj_Transport_wewnetrzny);
            this.Controls.Add(this.dgv_zlecenie_magazynowe);
            this.Controls.Add(this.dgv_transporty_wewnetrzne);
            this.Controls.Add(this.dgv_sklad_zamowienia_produkt);
            this.Controls.Add(this.dgv_sklad_zamowienia_material);
            this.Name = "TransportWewnetrznyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportWewnetrznyForm";
            this.Load += new System.EventHandler(this.TransportWewnetrznyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sklad_zamowienia_produkt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transporty_wewnetrzne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zlecenie_magazynowe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sklad_zamowienia_material;
        private System.Windows.Forms.DataGridView dgv_sklad_zamowienia_produkt;
        private System.Windows.Forms.DataGridView dgv_transporty_wewnetrzne;
        private System.Windows.Forms.DataGridView dgv_zlecenie_magazynowe;
        private System.Windows.Forms.Button btn_Dodaj_Transport_wewnetrzny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_usun_transport_wewnetrzny;
    }
}