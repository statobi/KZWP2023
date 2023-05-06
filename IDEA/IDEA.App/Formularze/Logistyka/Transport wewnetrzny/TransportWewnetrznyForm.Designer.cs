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
            this.dgv_transporty_wewnetrzne = new System.Windows.Forms.DataGridView();
            this.dgv_zlecenie_magazynowe = new System.Windows.Forms.DataGridView();
            this.btn_Dodaj_Transport_wewnetrzny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_usun_transport_wewnetrzny = new System.Windows.Forms.Button();
            this.DGVSkladZlecenia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transporty_wewnetrzne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zlecenie_magazynowe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSkladZlecenia)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_zlecenie_magazynowe.AllowUserToAddRows = false;
            this.dgv_zlecenie_magazynowe.AllowUserToDeleteRows = false;
            this.dgv_zlecenie_magazynowe.AllowUserToResizeColumns = false;
            this.dgv_zlecenie_magazynowe.AllowUserToResizeRows = false;
            this.dgv_zlecenie_magazynowe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_zlecenie_magazynowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zlecenie_magazynowe.Location = new System.Drawing.Point(17, 35);
            this.dgv_zlecenie_magazynowe.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_zlecenie_magazynowe.Name = "dgv_zlecenie_magazynowe";
            this.dgv_zlecenie_magazynowe.ReadOnly = true;
            this.dgv_zlecenie_magazynowe.RowTemplate.Height = 24;
            this.dgv_zlecenie_magazynowe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_zlecenie_magazynowe.Size = new System.Drawing.Size(391, 375);
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
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wszystkie zlecenia magazynowe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(409, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Skład zlecenia";
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
            // DGVSkladZlecenia
            // 
            this.DGVSkladZlecenia.AllowUserToAddRows = false;
            this.DGVSkladZlecenia.AllowUserToDeleteRows = false;
            this.DGVSkladZlecenia.AllowUserToResizeColumns = false;
            this.DGVSkladZlecenia.AllowUserToResizeRows = false;
            this.DGVSkladZlecenia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSkladZlecenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSkladZlecenia.Location = new System.Drawing.Point(413, 35);
            this.DGVSkladZlecenia.Name = "DGVSkladZlecenia";
            this.DGVSkladZlecenia.ReadOnly = true;
            this.DGVSkladZlecenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSkladZlecenia.Size = new System.Drawing.Size(559, 375);
            this.DGVSkladZlecenia.TabIndex = 10;
            // 
            // TransportWewnetrznyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.DGVSkladZlecenia);
            this.Controls.Add(this.btn_usun_transport_wewnetrzny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Dodaj_Transport_wewnetrzny);
            this.Controls.Add(this.dgv_zlecenie_magazynowe);
            this.Controls.Add(this.dgv_transporty_wewnetrzne);
            this.Name = "TransportWewnetrznyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportWewnetrznyForm";
            this.Load += new System.EventHandler(this.TransportWewnetrznyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transporty_wewnetrzne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zlecenie_magazynowe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSkladZlecenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_transporty_wewnetrzne;
        private System.Windows.Forms.DataGridView dgv_zlecenie_magazynowe;
        private System.Windows.Forms.Button btn_Dodaj_Transport_wewnetrzny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_usun_transport_wewnetrzny;
        private System.Windows.Forms.DataGridView DGVSkladZlecenia;
    }
}