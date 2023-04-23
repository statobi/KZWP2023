﻿namespace IDEA.App
{
    partial class InitForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.panelLogistykaSubmenu = new System.Windows.Forms.Panel();
            this.btnLogistyka3 = new FontAwesome.Sharp.IconButton();
            this.btnLogistyka2 = new FontAwesome.Sharp.IconButton();
            this.btnLogistyka1 = new FontAwesome.Sharp.IconButton();
            this.btnLogistyka = new FontAwesome.Sharp.IconButton();
            this.panelProdukcjaSubmenu = new System.Windows.Forms.Panel();
            this.btnProdukcja3 = new FontAwesome.Sharp.IconButton();
            this.btnPPlanowanieProcesy = new FontAwesome.Sharp.IconButton();
            this.btnPMaszyny = new FontAwesome.Sharp.IconButton();
            this.btnProdukcja = new FontAwesome.Sharp.IconButton();
            this.panelAFSubmenu = new System.Windows.Forms.Panel();
            this.btnAFKosztyRozne = new FontAwesome.Sharp.IconButton();
            this.btnAFSrodkiMajatkowe = new FontAwesome.Sharp.IconButton();
            this.btnAFFaktury = new FontAwesome.Sharp.IconButton();
            this.btnAFUrlopy = new FontAwesome.Sharp.IconButton();
            this.btnAFZamowienia = new FontAwesome.Sharp.IconButton();
            this.btnAFPracownicy = new FontAwesome.Sharp.IconButton();
            this.btnAFKlienci = new FontAwesome.Sharp.IconButton();
            this.btnAF = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogistykaSubmenu.SuspendLayout();
            this.panelProdukcjaSubmenu.SuspendLayout();
            this.panelAFSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(164)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelLogistykaSubmenu);
            this.panelSideMenu.Controls.Add(this.btnLogistyka);
            this.panelSideMenu.Controls.Add(this.panelProdukcjaSubmenu);
            this.panelSideMenu.Controls.Add(this.btnProdukcja);
            this.panelSideMenu.Controls.Add(this.panelAFSubmenu);
            this.panelSideMenu.Controls.Add(this.btnAF);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(333, 838);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(82)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHelp.IconColor = System.Drawing.Color.Black;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.Location = new System.Drawing.Point(0, 802);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(312, 55);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Pomoc";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelLogistykaSubmenu
            // 
            this.panelLogistykaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.panelLogistykaSubmenu.Controls.Add(this.btnLogistyka3);
            this.panelLogistykaSubmenu.Controls.Add(this.btnLogistyka2);
            this.panelLogistykaSubmenu.Controls.Add(this.btnLogistyka1);
            this.panelLogistykaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogistykaSubmenu.Location = new System.Drawing.Point(0, 679);
            this.panelLogistykaSubmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogistykaSubmenu.Name = "panelLogistykaSubmenu";
            this.panelLogistykaSubmenu.Size = new System.Drawing.Size(312, 123);
            this.panelLogistykaSubmenu.TabIndex = 6;
            // 
            // btnLogistyka3
            // 
            this.btnLogistyka3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnLogistyka3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogistyka3.FlatAppearance.BorderSize = 0;
            this.btnLogistyka3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistyka3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogistyka3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogistyka3.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.btnLogistyka3.IconColor = System.Drawing.Color.Black;
            this.btnLogistyka3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogistyka3.IconSize = 30;
            this.btnLogistyka3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistyka3.Location = new System.Drawing.Point(0, 74);
            this.btnLogistyka3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogistyka3.Name = "btnLogistyka3";
            this.btnLogistyka3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogistyka3.Size = new System.Drawing.Size(312, 37);
            this.btnLogistyka3.TabIndex = 2;
            this.btnLogistyka3.Text = "iconButton10";
            this.btnLogistyka3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistyka3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogistyka3.UseVisualStyleBackColor = false;
            this.btnLogistyka3.Click += new System.EventHandler(this.btnLogistyka3_Click);
            // 
            // btnLogistyka2
            // 
            this.btnLogistyka2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnLogistyka2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogistyka2.FlatAppearance.BorderSize = 0;
            this.btnLogistyka2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistyka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogistyka2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogistyka2.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.btnLogistyka2.IconColor = System.Drawing.Color.Black;
            this.btnLogistyka2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogistyka2.IconSize = 30;
            this.btnLogistyka2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistyka2.Location = new System.Drawing.Point(0, 37);
            this.btnLogistyka2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogistyka2.Name = "btnLogistyka2";
            this.btnLogistyka2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogistyka2.Size = new System.Drawing.Size(312, 37);
            this.btnLogistyka2.TabIndex = 1;
            this.btnLogistyka2.Text = "iconButton11";
            this.btnLogistyka2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistyka2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogistyka2.UseVisualStyleBackColor = false;
            this.btnLogistyka2.Click += new System.EventHandler(this.btnLogistyka2_Click);
            // 
            // btnLogistyka1
            // 
            this.btnLogistyka1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnLogistyka1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogistyka1.FlatAppearance.BorderSize = 0;
            this.btnLogistyka1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistyka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogistyka1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogistyka1.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.btnLogistyka1.IconColor = System.Drawing.Color.Black;
            this.btnLogistyka1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogistyka1.IconSize = 30;
            this.btnLogistyka1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistyka1.Location = new System.Drawing.Point(0, 0);
            this.btnLogistyka1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogistyka1.Name = "btnLogistyka1";
            this.btnLogistyka1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogistyka1.Size = new System.Drawing.Size(312, 37);
            this.btnLogistyka1.TabIndex = 0;
            this.btnLogistyka1.Text = "iconButton12";
            this.btnLogistyka1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistyka1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogistyka1.UseVisualStyleBackColor = false;
            this.btnLogistyka1.Click += new System.EventHandler(this.btnLogistyka1_Click);
            // 
            // btnLogistyka
            // 
            this.btnLogistyka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(82)))));
            this.btnLogistyka.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogistyka.FlatAppearance.BorderSize = 0;
            this.btnLogistyka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogistyka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogistyka.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogistyka.IconColor = System.Drawing.Color.Black;
            this.btnLogistyka.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogistyka.Location = new System.Drawing.Point(0, 624);
            this.btnLogistyka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogistyka.Name = "btnLogistyka";
            this.btnLogistyka.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLogistyka.Size = new System.Drawing.Size(312, 55);
            this.btnLogistyka.TabIndex = 5;
            this.btnLogistyka.Text = "Logistyka";
            this.btnLogistyka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistyka.UseVisualStyleBackColor = false;
            this.btnLogistyka.Click += new System.EventHandler(this.btnLogistyka_Click);
            // 
            // panelProdukcjaSubmenu
            // 
            this.panelProdukcjaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.panelProdukcjaSubmenu.Controls.Add(this.btnProdukcja3);
            this.panelProdukcjaSubmenu.Controls.Add(this.btnPPlanowanieProcesy);
            this.panelProdukcjaSubmenu.Controls.Add(this.btnPMaszyny);
            this.panelProdukcjaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdukcjaSubmenu.Location = new System.Drawing.Point(0, 501);
            this.panelProdukcjaSubmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelProdukcjaSubmenu.Name = "panelProdukcjaSubmenu";
            this.panelProdukcjaSubmenu.Size = new System.Drawing.Size(312, 123);
            this.panelProdukcjaSubmenu.TabIndex = 4;
            // 
            // btnProdukcja3
            // 
            this.btnProdukcja3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnProdukcja3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdukcja3.FlatAppearance.BorderSize = 0;
            this.btnProdukcja3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdukcja3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdukcja3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProdukcja3.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.btnProdukcja3.IconColor = System.Drawing.Color.Black;
            this.btnProdukcja3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdukcja3.IconSize = 30;
            this.btnProdukcja3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdukcja3.Location = new System.Drawing.Point(0, 74);
            this.btnProdukcja3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProdukcja3.Name = "btnProdukcja3";
            this.btnProdukcja3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProdukcja3.Size = new System.Drawing.Size(312, 37);
            this.btnProdukcja3.TabIndex = 2;
            this.btnProdukcja3.Text = "iconButton6";
            this.btnProdukcja3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdukcja3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdukcja3.UseVisualStyleBackColor = false;
            this.btnProdukcja3.Click += new System.EventHandler(this.btnProdukcja3_Click);
            // 
            // btnPPlanowanieProcesy
            // 
            this.btnPPlanowanieProcesy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnPPlanowanieProcesy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPPlanowanieProcesy.FlatAppearance.BorderSize = 0;
            this.btnPPlanowanieProcesy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPPlanowanieProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPPlanowanieProcesy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPPlanowanieProcesy.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.btnPPlanowanieProcesy.IconColor = System.Drawing.Color.Black;
            this.btnPPlanowanieProcesy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPPlanowanieProcesy.IconSize = 30;
            this.btnPPlanowanieProcesy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPPlanowanieProcesy.Location = new System.Drawing.Point(0, 37);
            this.btnPPlanowanieProcesy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPPlanowanieProcesy.Name = "btnPPlanowanieProcesy";
            this.btnPPlanowanieProcesy.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPPlanowanieProcesy.Size = new System.Drawing.Size(312, 37);
            this.btnPPlanowanieProcesy.TabIndex = 1;
            this.btnPPlanowanieProcesy.Text = "Procesy";
            this.btnPPlanowanieProcesy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPPlanowanieProcesy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPPlanowanieProcesy.UseVisualStyleBackColor = false;
            this.btnPPlanowanieProcesy.Click += new System.EventHandler(this.btnProdukcja2_Click);
            // 
            // btnPMaszyny
            // 
            this.btnPMaszyny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnPMaszyny.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPMaszyny.FlatAppearance.BorderSize = 0;
            this.btnPMaszyny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPMaszyny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPMaszyny.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.btnPMaszyny.IconColor = System.Drawing.Color.Black;
            this.btnPMaszyny.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPMaszyny.IconSize = 30;
            this.btnPMaszyny.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPMaszyny.Location = new System.Drawing.Point(0, 0);
            this.btnPMaszyny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPMaszyny.Name = "btnPMaszyny";
            this.btnPMaszyny.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPMaszyny.Size = new System.Drawing.Size(312, 37);
            this.btnPMaszyny.TabIndex = 0;
            this.btnPMaszyny.Text = "Maszyny";
            this.btnPMaszyny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPMaszyny.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPMaszyny.UseVisualStyleBackColor = false;
            this.btnPMaszyny.Click += new System.EventHandler(this.btnProdukcja1_Click);
            // 
            // btnProdukcja
            // 
            this.btnProdukcja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(82)))));
            this.btnProdukcja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdukcja.FlatAppearance.BorderSize = 0;
            this.btnProdukcja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdukcja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProdukcja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdukcja.IconColor = System.Drawing.Color.Black;
            this.btnProdukcja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdukcja.Location = new System.Drawing.Point(0, 446);
            this.btnProdukcja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProdukcja.Name = "btnProdukcja";
            this.btnProdukcja.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnProdukcja.Size = new System.Drawing.Size(312, 55);
            this.btnProdukcja.TabIndex = 3;
            this.btnProdukcja.Text = "Produkcja";
            this.btnProdukcja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdukcja.UseVisualStyleBackColor = false;
            this.btnProdukcja.Click += new System.EventHandler(this.btnProdukcja_Click);
            // 
            // panelAFSubmenu
            // 
            this.panelAFSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.panelAFSubmenu.Controls.Add(this.btnAFKosztyRozne);
            this.panelAFSubmenu.Controls.Add(this.btnAFSrodkiMajatkowe);
            this.panelAFSubmenu.Controls.Add(this.btnAFFaktury);
            this.panelAFSubmenu.Controls.Add(this.btnAFUrlopy);
            this.panelAFSubmenu.Controls.Add(this.btnAFZamowienia);
            this.panelAFSubmenu.Controls.Add(this.btnAFPracownicy);
            this.panelAFSubmenu.Controls.Add(this.btnAFKlienci);
            this.panelAFSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAFSubmenu.Location = new System.Drawing.Point(0, 178);
            this.panelAFSubmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAFSubmenu.Name = "panelAFSubmenu";
            this.panelAFSubmenu.Size = new System.Drawing.Size(312, 268);
            this.panelAFSubmenu.TabIndex = 2;
            // 
            // btnAFKosztyRozne
            // 
            this.btnAFKosztyRozne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnAFKosztyRozne.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAFKosztyRozne.FlatAppearance.BorderSize = 0;
            this.btnAFKosztyRozne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFKosztyRozne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAFKosztyRozne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAFKosztyRozne.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnAFKosztyRozne.IconColor = System.Drawing.Color.Black;
            this.btnAFKosztyRozne.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAFKosztyRozne.IconSize = 30;
            this.btnAFKosztyRozne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFKosztyRozne.Location = new System.Drawing.Point(0, 222);
            this.btnAFKosztyRozne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAFKosztyRozne.Name = "btnAFKosztyRozne";
            this.btnAFKosztyRozne.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAFKosztyRozne.Size = new System.Drawing.Size(312, 37);
            this.btnAFKosztyRozne.TabIndex = 6;
            this.btnAFKosztyRozne.Text = "Koszty Różne";
            this.btnAFKosztyRozne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFKosztyRozne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFKosztyRozne.UseVisualStyleBackColor = false;
            this.btnAFKosztyRozne.Click += new System.EventHandler(this.btnAFKosztyRozne_Click);
            // 
            // btnAFSrodkiMajatkowe
            // 
            this.btnAFSrodkiMajatkowe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnAFSrodkiMajatkowe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAFSrodkiMajatkowe.FlatAppearance.BorderSize = 0;
            this.btnAFSrodkiMajatkowe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFSrodkiMajatkowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAFSrodkiMajatkowe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAFSrodkiMajatkowe.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnAFSrodkiMajatkowe.IconColor = System.Drawing.Color.Black;
            this.btnAFSrodkiMajatkowe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAFSrodkiMajatkowe.IconSize = 30;
            this.btnAFSrodkiMajatkowe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFSrodkiMajatkowe.Location = new System.Drawing.Point(0, 185);
            this.btnAFSrodkiMajatkowe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAFSrodkiMajatkowe.Name = "btnAFSrodkiMajatkowe";
            this.btnAFSrodkiMajatkowe.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAFSrodkiMajatkowe.Size = new System.Drawing.Size(312, 37);
            this.btnAFSrodkiMajatkowe.TabIndex = 5;
            this.btnAFSrodkiMajatkowe.Text = "Środki Majątkowe";
            this.btnAFSrodkiMajatkowe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFSrodkiMajatkowe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFSrodkiMajatkowe.UseVisualStyleBackColor = false;
            this.btnAFSrodkiMajatkowe.Click += new System.EventHandler(this.btnAFSrodkiMajatkowe_Click);
            // 
            // btnAFFaktury
            // 
            this.btnAFFaktury.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnAFFaktury.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAFFaktury.FlatAppearance.BorderSize = 0;
            this.btnAFFaktury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFFaktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAFFaktury.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAFFaktury.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnAFFaktury.IconColor = System.Drawing.Color.Black;
            this.btnAFFaktury.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAFFaktury.IconSize = 30;
            this.btnAFFaktury.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFFaktury.Location = new System.Drawing.Point(0, 148);
            this.btnAFFaktury.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAFFaktury.Name = "btnAFFaktury";
            this.btnAFFaktury.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAFFaktury.Size = new System.Drawing.Size(312, 37);
            this.btnAFFaktury.TabIndex = 4;
            this.btnAFFaktury.Text = "Faktury";
            this.btnAFFaktury.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFFaktury.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFFaktury.UseVisualStyleBackColor = false;
            this.btnAFFaktury.Click += new System.EventHandler(this.btnAFFaktury_Click);
            // 
            // btnAFUrlopy
            // 
            this.btnAFUrlopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnAFUrlopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAFUrlopy.FlatAppearance.BorderSize = 0;
            this.btnAFUrlopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFUrlopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAFUrlopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAFUrlopy.IconChar = FontAwesome.Sharp.IconChar.UmbrellaBeach;
            this.btnAFUrlopy.IconColor = System.Drawing.Color.Black;
            this.btnAFUrlopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAFUrlopy.IconSize = 30;
            this.btnAFUrlopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFUrlopy.Location = new System.Drawing.Point(0, 111);
            this.btnAFUrlopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAFUrlopy.Name = "btnAFUrlopy";
            this.btnAFUrlopy.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAFUrlopy.Size = new System.Drawing.Size(312, 37);
            this.btnAFUrlopy.TabIndex = 3;
            this.btnAFUrlopy.Text = "Urlopy";
            this.btnAFUrlopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFUrlopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFUrlopy.UseVisualStyleBackColor = false;
            this.btnAFUrlopy.Click += new System.EventHandler(this.btnAFUrlopy_Click);
            // 
            // btnAFZamowienia
            // 
            this.btnAFZamowienia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnAFZamowienia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAFZamowienia.FlatAppearance.BorderSize = 0;
            this.btnAFZamowienia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAFZamowienia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAFZamowienia.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnAFZamowienia.IconColor = System.Drawing.Color.Black;
            this.btnAFZamowienia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAFZamowienia.IconSize = 30;
            this.btnAFZamowienia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFZamowienia.Location = new System.Drawing.Point(0, 74);
            this.btnAFZamowienia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAFZamowienia.Name = "btnAFZamowienia";
            this.btnAFZamowienia.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAFZamowienia.Size = new System.Drawing.Size(312, 37);
            this.btnAFZamowienia.TabIndex = 2;
            this.btnAFZamowienia.Text = "Zamówienia";
            this.btnAFZamowienia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFZamowienia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFZamowienia.UseVisualStyleBackColor = false;
            this.btnAFZamowienia.Click += new System.EventHandler(this.btnAFZamowienia_Click);
            // 
            // btnAFPracownicy
            // 
            this.btnAFPracownicy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnAFPracownicy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAFPracownicy.FlatAppearance.BorderSize = 0;
            this.btnAFPracownicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAFPracownicy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAFPracownicy.IconChar = FontAwesome.Sharp.IconChar.HelmetSafety;
            this.btnAFPracownicy.IconColor = System.Drawing.Color.Black;
            this.btnAFPracownicy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAFPracownicy.IconSize = 25;
            this.btnAFPracownicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFPracownicy.Location = new System.Drawing.Point(0, 37);
            this.btnAFPracownicy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAFPracownicy.Name = "btnAFPracownicy";
            this.btnAFPracownicy.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAFPracownicy.Size = new System.Drawing.Size(312, 37);
            this.btnAFPracownicy.TabIndex = 1;
            this.btnAFPracownicy.Text = "Pracownicy";
            this.btnAFPracownicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFPracownicy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFPracownicy.UseVisualStyleBackColor = false;
            this.btnAFPracownicy.Click += new System.EventHandler(this.btnAFPracownicy_Click);
            // 
            // btnAFKlienci
            // 
            this.btnAFKlienci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnAFKlienci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAFKlienci.FlatAppearance.BorderSize = 0;
            this.btnAFKlienci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFKlienci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAFKlienci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAFKlienci.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnAFKlienci.IconColor = System.Drawing.Color.Black;
            this.btnAFKlienci.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAFKlienci.IconSize = 25;
            this.btnAFKlienci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFKlienci.Location = new System.Drawing.Point(0, 0);
            this.btnAFKlienci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAFKlienci.Name = "btnAFKlienci";
            this.btnAFKlienci.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAFKlienci.Size = new System.Drawing.Size(312, 37);
            this.btnAFKlienci.TabIndex = 0;
            this.btnAFKlienci.Text = "Klienci";
            this.btnAFKlienci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFKlienci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFKlienci.UseVisualStyleBackColor = false;
            this.btnAFKlienci.Click += new System.EventHandler(this.btnAFKlienci_Click);
            // 
            // btnAF
            // 
            this.btnAF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(82)))));
            this.btnAF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAF.FlatAppearance.BorderSize = 0;
            this.btnAF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAF.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAF.IconColor = System.Drawing.Color.Black;
            this.btnAF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAF.Location = new System.Drawing.Point(0, 123);
            this.btnAF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(312, 55);
            this.btnAF.TabIndex = 1;
            this.btnAF.Text = "Administracja Finanse";
            this.btnAF.UseVisualStyleBackColor = false;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(312, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(164)))));
            this.pBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLogo.Image")));
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(312, 123);
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            this.pBoxLogo.Click += new System.EventHandler(this.pBoxLogo_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(539, 364);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(11, 10);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(333, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1312, 838);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1312, 838);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 838);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "IDEA";
            this.Text = "IDEA";
            this.Load += new System.EventHandler(this.InitForm_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogistykaSubmenu.ResumeLayout(false);
            this.panelProdukcjaSubmenu.ResumeLayout(false);
            this.panelAFSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogistykaSubmenu;
        private FontAwesome.Sharp.IconButton btnLogistyka3;
        private FontAwesome.Sharp.IconButton btnLogistyka2;
        private FontAwesome.Sharp.IconButton btnLogistyka1;
        private FontAwesome.Sharp.IconButton btnLogistyka;
        private System.Windows.Forms.Panel panelProdukcjaSubmenu;
        private FontAwesome.Sharp.IconButton btnProdukcja3;
        private FontAwesome.Sharp.IconButton btnPPlanowanieProcesy;
        private FontAwesome.Sharp.IconButton btnPMaszyny;
        private FontAwesome.Sharp.IconButton btnProdukcja;
        private System.Windows.Forms.Panel panelAFSubmenu;
        private FontAwesome.Sharp.IconButton btnAFZamowienia;
        private FontAwesome.Sharp.IconButton btnAFPracownicy;
        private FontAwesome.Sharp.IconButton btnAFKlienci;
        private FontAwesome.Sharp.IconButton btnAF;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnHelp;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAFSrodkiMajatkowe;
        private FontAwesome.Sharp.IconButton btnAFFaktury;
        private FontAwesome.Sharp.IconButton btnAFUrlopy;
        private FontAwesome.Sharp.IconButton btnAFKosztyRozne;
    }
}

