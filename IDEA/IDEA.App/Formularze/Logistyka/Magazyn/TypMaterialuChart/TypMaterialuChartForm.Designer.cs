namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    partial class TypMaterialuChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartTypMaterialu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbChartType = new System.Windows.Forms.ComboBox();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTypMaterialu)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTypMaterialu
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartTypMaterialu.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.ChartTypMaterialu.Legends.Add(legend1);
            this.ChartTypMaterialu.Location = new System.Drawing.Point(12, 51);
            this.ChartTypMaterialu.Name = "ChartTypMaterialu";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            series1.BorderColor = System.Drawing.Color.Lime;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.CustomProperties = "PointWidth=0.9";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            series1.YValuesPerPoint = 4;
            this.ChartTypMaterialu.Series.Add(series1);
            this.ChartTypMaterialu.Size = new System.Drawing.Size(960, 628);
            this.ChartTypMaterialu.TabIndex = 1;
            this.ChartTypMaterialu.Text = "chart2";
            this.ChartTypMaterialu.Customize += new System.EventHandler(this.ChartTypMaterialu_Customize);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(960, 47);
            this.label4.TabIndex = 25;
            this.label4.Text = "Udział zasobów w magazynach z podziałem na typy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CmbChartType
            // 
            this.CmbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbChartType.Location = new System.Drawing.Point(793, 19);
            this.CmbChartType.Name = "CmbChartType";
            this.CmbChartType.Size = new System.Drawing.Size(179, 21);
            this.CmbChartType.TabIndex = 26;
            this.CmbChartType.SelectedIndexChanged += new System.EventHandler(this.CmbChartType_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnBack.IconColor = System.Drawing.Color.Black;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(11, 11);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnBack.Size = new System.Drawing.Size(48, 35);
            this.BtnBack.TabIndex = 27;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TypMaterialuChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.CmbChartType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChartTypMaterialu);
            this.Name = "TypMaterialuChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypMaterialuChartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypMaterialuChartForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTypMaterialu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTypMaterialu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbChartType;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}