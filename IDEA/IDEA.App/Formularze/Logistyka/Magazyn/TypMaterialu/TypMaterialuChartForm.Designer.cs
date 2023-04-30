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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartTypMaterialu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.CmbChartType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTypMaterialu)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTypMaterialu
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartTypMaterialu.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.ChartTypMaterialu.Legends.Add(legend4);
            this.ChartTypMaterialu.Location = new System.Drawing.Point(12, 51);
            this.ChartTypMaterialu.Name = "ChartTypMaterialu";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            this.ChartTypMaterialu.Series.Add(series4);
            this.ChartTypMaterialu.Size = new System.Drawing.Size(960, 628);
            this.ChartTypMaterialu.TabIndex = 1;
            this.ChartTypMaterialu.Text = "chart2";
            // 
            // BtnBack
            // 
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnBack.IconColor = System.Drawing.Color.Black;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(12, 11);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnBack.Size = new System.Drawing.Size(48, 35);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbChartType
            // 
            this.CmbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbChartType.Location = new System.Drawing.Point(793, 19);
            this.CmbChartType.Name = "CmbChartType";
            this.CmbChartType.Size = new System.Drawing.Size(179, 21);
            this.CmbChartType.TabIndex = 8;
            // 
            // TypMaterialuChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.CmbChartType);
            this.Controls.Add(this.BtnBack);
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
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.ComboBox CmbChartType;
    }
}