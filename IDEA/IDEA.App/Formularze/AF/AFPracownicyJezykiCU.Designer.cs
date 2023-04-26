using System.Windows.Forms;

namespace IDEA.App
{
    partial class AFPracownicyJezykiCU
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
            this.lblDataZmiany = new System.Windows.Forms.Label();
            this.lblJezyk = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.cbJezyk = new System.Windows.Forms.ComboBox();
            this.dateDataZmiany = new System.Windows.Forms.DateTimePicker();
            this.panelMove = new System.Windows.Forms.Panel();
            this.DgwPracownicyJezyki = new System.Windows.Forms.DataGridView();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.btnCancel2 = new FontAwesome.Sharp.IconButton();
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            this.txtPoziom = new System.Windows.Forms.Label();
            this.cbPoziom = new System.Windows.Forms.ComboBox();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwPracownicyJezyki)).BeginInit();
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
            this.lblKindWindow.Size = new System.Drawing.Size(442, 31);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Języki Pracownika: - do modyfikacji";
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
            // lblDataZmiany
            // 
            this.lblDataZmiany.AutoSize = true;
            this.lblDataZmiany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZmiany.Location = new System.Drawing.Point(13, 407);
            this.lblDataZmiany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataZmiany.Name = "lblDataZmiany";
            this.lblDataZmiany.Size = new System.Drawing.Size(148, 29);
            this.lblDataZmiany.TabIndex = 8;
            this.lblDataZmiany.Text = "Data zmiany:";
            // 
            // lblJezyk
            // 
            this.lblJezyk.AutoSize = true;
            this.lblJezyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJezyk.Location = new System.Drawing.Point(16, 464);
            this.lblJezyk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJezyk.Name = "lblJezyk";
            this.lblJezyk.Size = new System.Drawing.Size(171, 29);
            this.lblJezyk.TabIndex = 12;
            this.lblJezyk.Text = "Wybierz Język:";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Coral;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(631, 320);
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
            this.btnAdd.Location = new System.Drawing.Point(18, 320);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 64);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbJezyk
            // 
            this.cbJezyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbJezyk.FormattingEnabled = true;
            this.cbJezyk.Location = new System.Drawing.Point(224, 456);
            this.cbJezyk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbJezyk.Name = "cbJezyk";
            this.cbJezyk.Size = new System.Drawing.Size(507, 37);
            this.cbJezyk.TabIndex = 26;
            // 
            // dateDataZmiany
            // 
            this.dateDataZmiany.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataZmiany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataZmiany.Location = new System.Drawing.Point(224, 407);
            this.dateDataZmiany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDataZmiany.Name = "dateDataZmiany";
            this.dateDataZmiany.Size = new System.Drawing.Size(507, 30);
            this.dateDataZmiany.TabIndex = 28;
            this.dateDataZmiany.ValueChanged += new System.EventHandler(this.dateDataRealizacji_ValueChanged);
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
            // DgwPracownicyJezyki
            // 
            this.DgwPracownicyJezyki.AllowUserToResizeRows = false;
            this.DgwPracownicyJezyki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwPracownicyJezyki.Location = new System.Drawing.Point(21, 78);
            this.DgwPracownicyJezyki.MultiSelect = false;
            this.DgwPracownicyJezyki.Name = "DgwPracownicyJezyki";
            this.DgwPracownicyJezyki.ReadOnly = true;
            this.DgwPracownicyJezyki.RowHeadersVisible = false;
            this.DgwPracownicyJezyki.RowHeadersWidth = 51;
            this.DgwPracownicyJezyki.RowTemplate.Height = 24;
            this.DgwPracownicyJezyki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwPracownicyJezyki.Size = new System.Drawing.Size(710, 220);
            this.DgwPracownicyJezyki.TabIndex = 31;
            this.DgwPracownicyJezyki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwPracownicyJezyki_CellClick);
            // 
            // btnAccept
            // 
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(44)))));
            this.btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccept.Location = new System.Drawing.Point(468, 565);
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
            this.btnCancel2.Location = new System.Drawing.Point(576, 565);
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
            this.iBtnBack.Location = new System.Drawing.Point(21, 565);
            this.iBtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(100, 64);
            this.iBtnBack.TabIndex = 34;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // txtPoziom
            // 
            this.txtPoziom.AutoSize = true;
            this.txtPoziom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPoziom.Location = new System.Drawing.Point(16, 516);
            this.txtPoziom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPoziom.Name = "txtPoziom";
            this.txtPoziom.Size = new System.Drawing.Size(192, 29);
            this.txtPoziom.TabIndex = 35;
            this.txtPoziom.Text = "Wybierz Poziom:";
            // 
            // cbPoziom
            // 
            this.cbPoziom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPoziom.FormattingEnabled = true;
            this.cbPoziom.Location = new System.Drawing.Point(224, 513);
            this.cbPoziom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPoziom.Name = "cbPoziom";
            this.cbPoziom.Size = new System.Drawing.Size(507, 37);
            this.cbPoziom.TabIndex = 36;
            this.cbPoziom.SelectedIndexChanged += new System.EventHandler(this.cbPoziom_SelectedIndexChanged);
            // 
            // AFPracownicyJezykiCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 642);
            this.Controls.Add(this.cbPoziom);
            this.Controls.Add(this.txtPoziom);
            this.Controls.Add(this.iBtnBack);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.DgwPracownicyJezyki);
            this.Controls.Add(this.dateDataZmiany);
            this.Controls.Add(this.cbJezyk);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblJezyk);
            this.Controls.Add(this.lblDataZmiany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFPracownicyJezykiCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.Load += new System.EventHandler(this.AFPracownicyDzialyCU_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwPracownicyJezyki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataZmiany;
        private System.Windows.Forms.Label lblJezyk;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.ComboBox cbJezyk;
        private System.Windows.Forms.DateTimePicker dateDataZmiany;
        private System.Windows.Forms.Panel panelMove;
        private DataGridView DgwPracownicyJezyki;
        private FontAwesome.Sharp.IconButton btnAccept;
        private FontAwesome.Sharp.IconButton btnCancel2;
        private FontAwesome.Sharp.IconButton iBtnBack;
        private Label txtPoziom;
        private ComboBox cbPoziom;
    }
}