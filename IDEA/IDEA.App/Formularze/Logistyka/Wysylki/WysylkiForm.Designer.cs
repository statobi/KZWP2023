namespace IDEA.App.Formularze.Logistyka.Wysylki
{
    partial class WysylkiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWysylka = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.dgvSkladWysylki = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlanowane = new System.Windows.Forms.Button();
            this.btnZrealizowane = new System.Windows.Forms.Button();
            this.btnWszystkie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWysylka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladWysylki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWysylka
            // 
            this.dgvWysylka.AllowUserToAddRows = false;
            this.dgvWysylka.AllowUserToDeleteRows = false;
            this.dgvWysylka.AllowUserToOrderColumns = true;
            this.dgvWysylka.AllowUserToResizeColumns = false;
            this.dgvWysylka.AllowUserToResizeRows = false;
            this.dgvWysylka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWysylka.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvWysylka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWysylka.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvWysylka.Location = new System.Drawing.Point(12, 36);
            this.dgvWysylka.MultiSelect = false;
            this.dgvWysylka.Name = "dgvWysylka";
            this.dgvWysylka.ReadOnly = true;
            this.dgvWysylka.RowHeadersWidth = 47;
            this.dgvWysylka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWysylka.Size = new System.Drawing.Size(966, 286);
            this.dgvWysylka.TabIndex = 0;
            this.dgvWysylka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWysylka_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wysyłki:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEdit.Location = new System.Drawing.Point(386, 629);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(217, 39);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.Location = new System.Drawing.Point(165, 629);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Bookman Old Style", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDelete.Location = new System.Drawing.Point(607, 629);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 39);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvSkladWysylki
            // 
            this.dgvSkladWysylki.AllowUserToAddRows = false;
            this.dgvSkladWysylki.AllowUserToDeleteRows = false;
            this.dgvSkladWysylki.AllowUserToOrderColumns = true;
            this.dgvSkladWysylki.AllowUserToResizeColumns = false;
            this.dgvSkladWysylki.AllowUserToResizeRows = false;
            this.dgvSkladWysylki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkladWysylki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSkladWysylki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSkladWysylki.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSkladWysylki.Location = new System.Drawing.Point(12, 361);
            this.dgvSkladWysylki.MultiSelect = false;
            this.dgvSkladWysylki.Name = "dgvSkladWysylki";
            this.dgvSkladWysylki.RowHeadersWidth = 47;
            this.dgvSkladWysylki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSkladWysylki.Size = new System.Drawing.Size(966, 263);
            this.dgvSkladWysylki.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Skład wysyłki:";
            // 
            // btnPlanowane
            // 
            this.btnPlanowane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanowane.Font = new System.Drawing.Font("Bookman Old Style", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlanowane.Location = new System.Drawing.Point(854, 3);
            this.btnPlanowane.Name = "btnPlanowane";
            this.btnPlanowane.Size = new System.Drawing.Size(124, 31);
            this.btnPlanowane.TabIndex = 48;
            this.btnPlanowane.TabStop = false;
            this.btnPlanowane.Text = "Planowane";
            this.btnPlanowane.UseVisualStyleBackColor = true;
            this.btnPlanowane.Click += new System.EventHandler(this.btnPlanowane_Click);
            // 
            // btnZrealizowane
            // 
            this.btnZrealizowane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZrealizowane.Font = new System.Drawing.Font("Bookman Old Style", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZrealizowane.Location = new System.Drawing.Point(731, 3);
            this.btnZrealizowane.Name = "btnZrealizowane";
            this.btnZrealizowane.Size = new System.Drawing.Size(124, 31);
            this.btnZrealizowane.TabIndex = 49;
            this.btnZrealizowane.TabStop = false;
            this.btnZrealizowane.Text = "Zrealizowane";
            this.btnZrealizowane.UseVisualStyleBackColor = true;
            this.btnZrealizowane.Click += new System.EventHandler(this.btnZrealizowane_Click);
            // 
            // btnWszystkie
            // 
            this.btnWszystkie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWszystkie.Font = new System.Drawing.Font("Bookman Old Style", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkie.Location = new System.Drawing.Point(608, 3);
            this.btnWszystkie.Name = "btnWszystkie";
            this.btnWszystkie.Size = new System.Drawing.Size(124, 31);
            this.btnWszystkie.TabIndex = 50;
            this.btnWszystkie.TabStop = false;
            this.btnWszystkie.Text = "Wszystkie";
            this.btnWszystkie.UseVisualStyleBackColor = true;
            this.btnWszystkie.Click += new System.EventHandler(this.btnWszystkie_Click);
            // 
            // WysylkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 853);
            this.Controls.Add(this.btnWszystkie);
            this.Controls.Add(this.btnZrealizowane);
            this.Controls.Add(this.btnPlanowane);
            this.Controls.Add(this.dgvSkladWysylki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvWysylka);
            this.Controls.Add(this.label2);
            this.Name = "WysylkiForm";
            this.Text = "Wysyłki";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WysylkiForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWysylka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladWysylki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvWysylka;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.DataGridView dgvSkladWysylki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlanowane;
        private System.Windows.Forms.Button btnZrealizowane;
        private System.Windows.Forms.Button btnWszystkie;
    }
}