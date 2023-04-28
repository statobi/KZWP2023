using System.Windows.Forms;

namespace IDEA.App
{
    partial class AFZamowieniaStatusCU
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dateDataZmiany = new System.Windows.Forms.DateTimePicker();
            this.panelMove = new System.Windows.Forms.Panel();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.btnCancel2 = new FontAwesome.Sharp.IconButton();
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
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
            this.lblKindWindow.Location = new System.Drawing.Point(15, 21);
            this.lblKindWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKindWindow.Name = "lblKindWindow";
            this.lblKindWindow.Size = new System.Drawing.Size(281, 31);
            this.lblKindWindow.TabIndex = 2;
            this.lblKindWindow.Text = "Status zamówienia nr:";
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
            this.lblDataZmiany.Location = new System.Drawing.Point(16, 457);
            this.lblDataZmiany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataZmiany.Name = "lblDataZmiany";
            this.lblDataZmiany.Size = new System.Drawing.Size(148, 29);
            this.lblDataZmiany.TabIndex = 8;
            this.lblDataZmiany.Text = "Data zmiany:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(16, 505);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(177, 29);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Wybierz Status:";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Coral;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(631, 351);
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
            this.btnAdd.Location = new System.Drawing.Point(21, 351);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 64);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(224, 505);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(507, 37);
            this.cbStatus.TabIndex = 26;
            // 
            // dateDataZmiany
            // 
            this.dateDataZmiany.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateDataZmiany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDataZmiany.Location = new System.Drawing.Point(224, 457);
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
            this.panelMove.Size = new System.Drawing.Size(747, 79);
            this.panelMove.TabIndex = 29;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToResizeRows = false;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(21, 78);
            this.dgvStatus.MultiSelect = false;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.RowHeadersVisible = false;
            this.dgvStatus.RowHeadersWidth = 51;
            this.dgvStatus.RowTemplate.Height = 24;
            this.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatus.Size = new System.Drawing.Size(710, 248);
            this.dgvStatus.TabIndex = 31;
            this.dgvStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatus_CellClick);
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
            // AFZamowieniaStatusCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 642);
            this.Controls.Add(this.iBtnBack);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvStatus);
            this.Controls.Add(this.dateDataZmiany);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataZmiany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFZamowieniaStatusCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFKlienciCU";
            this.Load += new System.EventHandler(this.AFPracownicyDzialyCU_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblKindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataZmiany;
        private System.Windows.Forms.Label lblStatus;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dateDataZmiany;
        private System.Windows.Forms.Panel panelMove;
        private DataGridView dgvStatus;
        private FontAwesome.Sharp.IconButton btnAccept;
        private FontAwesome.Sharp.IconButton btnCancel2;
        private FontAwesome.Sharp.IconButton iBtnBack;
    }
}