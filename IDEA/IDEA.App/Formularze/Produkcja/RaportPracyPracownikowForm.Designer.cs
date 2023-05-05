namespace IDEA.App.Formularze.Produkcja
{
    partial class RaportPracyPracownikowForm
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
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // iBtnBack
            // 
            this.iBtnBack.ForeColor = System.Drawing.Color.Coral;
            this.iBtnBack.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iBtnBack.IconColor = System.Drawing.Color.Red;
            this.iBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBack.Location = new System.Drawing.Point(468, 355);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(60, 57);
            this.iBtnBack.TabIndex = 37;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(440, 341);
            this.chart.TabIndex = 38;
            this.chart.Text = "chart";
            // 
            // RaportPracyPracownikowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 424);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.iBtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaportPracyPracownikowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaportPracyPracownikowForm";
            this.Load += new System.EventHandler(this.RaportPracyPracownikowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnBack;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}