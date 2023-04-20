namespace IDEA.App
{
    partial class AFMainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnPracownicy = new FontAwesome.Sharp.IconButton();
            this.btnKlienci = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.btnPracownicy);
            this.panelMenu.Controls.Add(this.btnKlienci);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 145);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(220, 30);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "iconButton4";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 115);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(220, 30);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "iconButton3";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPracownicy.IconChar = FontAwesome.Sharp.IconChar.HelmetSafety;
            this.btnPracownicy.IconColor = System.Drawing.Color.Black;
            this.btnPracownicy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPracownicy.IconSize = 30;
            this.btnPracownicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPracownicy.Location = new System.Drawing.Point(0, 85);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPracownicy.Size = new System.Drawing.Size(220, 30);
            this.btnPracownicy.TabIndex = 2;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // btnKlienci
            // 
            this.btnKlienci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKlienci.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnKlienci.IconColor = System.Drawing.Color.Black;
            this.btnKlienci.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKlienci.IconSize = 30;
            this.btnKlienci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlienci.Location = new System.Drawing.Point(0, 55);
            this.btnKlienci.Name = "btnKlienci";
            this.btnKlienci.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKlienci.Size = new System.Drawing.Size(220, 30);
            this.btnKlienci.TabIndex = 1;
            this.btnKlienci.Text = "Klienci";
            this.btnKlienci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKlienci.UseVisualStyleBackColor = true;
            this.btnKlienci.Click += new System.EventHandler(this.btnKlienci_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 55);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(13, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(195, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Dział A-F";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 681);
            this.panelDesktop.TabIndex = 1;
            // 
            // AFMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AFMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AFMainForm_FormClosed);
            this.Load += new System.EventHandler(this.AFMainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnPracownicy;
        private FontAwesome.Sharp.IconButton btnKlienci;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelDesktop;
    }
}