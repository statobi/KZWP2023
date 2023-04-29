using System.Windows.Forms;

namespace IDEA.App
{
    partial class AFPracownicyZatrudnienieCU
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
            this.lblImie = new System.Windows.Forms.Label();
            this.lblKindWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataod = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dateDataod = new System.Windows.Forms.DateTimePicker();
            this.panelMove = new System.Windows.Forms.Panel();
            this.DgwPracownicyZatrudnienie = new System.Windows.Forms.DataGridView();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.btnCancel2 = new FontAwesome.Sharp.IconButton();
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            this.lblDatado = new System.Windows.Forms.Label();
            this.dateDatado = new System.Windows.Forms.DateTimePicker();
            this.lblPensjaNetto = new System.Windows.Forms.Label();
            this.lblPensjaBrutto = new System.Windows.Forms.Label();
            this.txtPensjaNetto = new System.Windows.Forms.TextBox();
            this.txtPensjaBrutto = new System.Windows.Forms.TextBox();
            this.lblDotychczasowystaz = new System.Windows.Forms.Label();
            this.numDotychczasowystaz = new System.Windows.Forms.NumericUpDown();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwPracownicyZatrudnienie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDotychczasowystaz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(16, 94);
            this.lblImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(0, 29);
            this.lblImie.TabIndex = 1;
            // 
            // lblKindWindow
            // 
            this.lblKindWindow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKindWindow.AutoSize = true;
            this.lblKindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKindWindow.Location = new System.Drawing.Point(15, 18);
            this.lblKindWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(321, 31);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Zatrudnienie Pracownika:";
            this.lblKindWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 4;
            // 
            // lblDataod
            // 
            this.lblDataod.AutoSize = true;
            this.lblDataod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataod.Location = new System.Drawing.Point(16, 370);
            this.lblDataod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataod.Name = "lblDataod";
            this.lblDataod.Size = new System.Drawing.Size(102, 29);
            this.lblDataod.TabIndex = 8;
            this.lblDataod.Text = "Data od:";
            this.lblDataod.Click += new System.EventHandler(this.dateDataod_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Coral;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(634, 284);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 64);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(21, 284);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 64);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateDataod
            // 
            this.dateDataod.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataod.Location = new System.Drawing.Point(260, 370);
            this.dateDataod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDataod.Name = "dateDataod";
            this.dateDataod.Size = new System.Drawing.Size(474, 30);
            this.dateDataod.TabIndex = 28;
            this.dateDataod.ValueChanged += new System.EventHandler(this.dateDataod_ValueChanged);
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Controls.Add(this.lblKindWindow);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(747, 60);
            this.panelMove.TabIndex = 29;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // DgwPracownicyZatrudnienie
            // 
            this.DgwPracownicyZatrudnienie.AllowUserToResizeRows = false;
            this.DgwPracownicyZatrudnienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwPracownicyZatrudnienie.Location = new System.Drawing.Point(21, 78);
            this.DgwPracownicyZatrudnienie.MultiSelect = false;
            this.DgwPracownicyZatrudnienie.Name = "DgwPracownicyZatrudnienie";
            this.DgwPracownicyZatrudnienie.ReadOnly = true;
            this.DgwPracownicyZatrudnienie.RowHeadersVisible = false;
            this.DgwPracownicyZatrudnienie.RowHeadersWidth = 51;
            this.DgwPracownicyZatrudnienie.RowTemplate.Height = 24;
            this.DgwPracownicyZatrudnienie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwPracownicyZatrudnienie.Size = new System.Drawing.Size(710, 188);
            this.DgwPracownicyZatrudnienie.TabIndex = 31;
            this.DgwPracownicyZatrudnienie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwPracownicyZatrudnienie_CellClick);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(468, 604);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 64);
            this.btnAccept.TabIndex = 32;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel2
            // 
            this.btnCancel2.ForeColor = System.Drawing.Color.Coral;
            this.btnCancel2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel2.IconColor = System.Drawing.Color.Red;
            this.btnCancel2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel2.Location = new System.Drawing.Point(576, 604);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 64);
            this.btnCancel2.TabIndex = 33;
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // iBtnBack
            // 
            this.iBtnBack.ForeColor = System.Drawing.Color.Coral;
            this.iBtnBack.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iBtnBack.IconColor = System.Drawing.Color.Red;
            this.iBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBack.Location = new System.Drawing.Point(21, 604);
            this.iBtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(100, 64);
            this.iBtnBack.TabIndex = 34;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // lblDatado
            // 
            this.lblDatado.AutoSize = true;
            this.lblDatado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatado.Location = new System.Drawing.Point(16, 412);
            this.lblDatado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatado.Name = "lblDatado";
            this.lblDatado.Size = new System.Drawing.Size(102, 29);
            this.lblDatado.TabIndex = 35;
            this.lblDatado.Text = "Data do:";
            // 
            // dateDatado
            // 
            this.dateDatado.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDatado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDatado.Location = new System.Drawing.Point(260, 412);
            this.dateDatado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDatado.Name = "dateDatado";
            this.dateDatado.Size = new System.Drawing.Size(474, 30);
            this.dateDatado.TabIndex = 36;
            // 
            // lblPensjaNetto
            // 
            this.lblPensjaNetto.AutoSize = true;
            this.lblPensjaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPensjaNetto.Location = new System.Drawing.Point(16, 462);
            this.lblPensjaNetto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPensjaNetto.Name = "lblPensjaNetto";
            this.lblPensjaNetto.Size = new System.Drawing.Size(157, 29);
            this.lblPensjaNetto.TabIndex = 38;
            this.lblPensjaNetto.Text = "Pensja Netto:";
            // 
            // lblPensjaBrutto
            // 
            this.lblPensjaBrutto.AutoSize = true;
            this.lblPensjaBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPensjaBrutto.Location = new System.Drawing.Point(16, 506);
            this.lblPensjaBrutto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPensjaBrutto.Name = "lblPensjaBrutto";
            this.lblPensjaBrutto.Size = new System.Drawing.Size(162, 29);
            this.lblPensjaBrutto.TabIndex = 39;
            this.lblPensjaBrutto.Text = "Pensja Brutto:";
            // 
            // txtPensjaNetto
            // 
            this.txtPensjaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPensjaNetto.Location = new System.Drawing.Point(260, 457);
            this.txtPensjaNetto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPensjaNetto.Name = "txtPensjaNetto";
            this.txtPensjaNetto.Size = new System.Drawing.Size(474, 34);
            this.txtPensjaNetto.TabIndex = 40;
            this.txtPensjaNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPensjaNetto.TextChanged += new System.EventHandler(this.txtPensjaNetto_TextChanged);
            // 
            // txtPensjaBrutto
            // 
            this.txtPensjaBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPensjaBrutto.Location = new System.Drawing.Point(260, 503);
            this.txtPensjaBrutto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPensjaBrutto.Name = "txtPensjaBrutto";
            this.txtPensjaBrutto.Size = new System.Drawing.Size(474, 34);
            this.txtPensjaBrutto.TabIndex = 41;
            this.txtPensjaBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDotychczasowystaz
            // 
            this.lblDotychczasowystaz.AutoSize = true;
            this.lblDotychczasowystaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDotychczasowystaz.Location = new System.Drawing.Point(16, 547);
            this.lblDotychczasowystaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDotychczasowystaz.Name = "lblDotychczasowystaz";
            this.lblDotychczasowystaz.Size = new System.Drawing.Size(231, 29);
            this.lblDotychczasowystaz.TabIndex = 42;
            this.lblDotychczasowystaz.Text = "Dotychczasowy staż:";
            // 
            // numDotychczasowystaz
            // 
            this.numDotychczasowystaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numDotychczasowystaz.Location = new System.Drawing.Point(260, 547);
            this.numDotychczasowystaz.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDotychczasowystaz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDotychczasowystaz.Name = "numDotychczasowystaz";
            this.numDotychczasowystaz.Size = new System.Drawing.Size(474, 34);
            this.numDotychczasowystaz.TabIndex = 43;
            this.numDotychczasowystaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDotychczasowystaz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AFPracownicyZatrudnienieCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 690);
            this.Controls.Add(this.numDotychczasowystaz);
            this.Controls.Add(this.lblDotychczasowystaz);
            this.Controls.Add(this.txtPensjaBrutto);
            this.Controls.Add(this.txtPensjaNetto);
            this.Controls.Add(this.lblPensjaBrutto);
            this.Controls.Add(this.lblPensjaNetto);
            this.Controls.Add(this.dateDatado);
            this.Controls.Add(this.lblDatado);
            this.Controls.Add(this.iBtnBack);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.DgwPracownicyZatrudnienie);
            this.Controls.Add(this.dateDataod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDataod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFPracownicyZatrudnienieCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.Load += new System.EventHandler(this.AFPracownicyZatrudnienieCU_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwPracownicyZatrudnienie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDotychczasowystaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataod;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DateTimePicker dateDataod;
        private System.Windows.Forms.Panel panelMove;
        private DataGridView DgwPracownicyZatrudnienie;
        private FontAwesome.Sharp.IconButton btnAccept;
        private FontAwesome.Sharp.IconButton btnCancel2;
        private FontAwesome.Sharp.IconButton iBtnBack;
        private Label lblDatado;
        private DateTimePicker dateDatado;
        private Label lblPensjaNetto;
        private Label lblPensjaBrutto;
        private TextBox txtPensjaNetto;
        private TextBox txtPensjaBrutto;
        private Label lblDotychczasowystaz;
        private NumericUpDown numDotychczasowystaz;
    }
}