namespace IDEA.App
{
    partial class AFBilansForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvVZamowienia = new System.Windows.Forms.DataGridView();
            this.dgvVSklad = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChartColumn = new FontAwesome.Sharp.IconButton();
            this.btnChartPie = new FontAwesome.Sharp.IconButton();
            this.cbRok = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVZamowienia
            // 
            this.dgvVZamowienia.AllowUserToResizeRows = false;
            this.dgvVZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVZamowienia.Location = new System.Drawing.Point(879, 581);
            this.dgvVZamowienia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVZamowienia.MultiSelect = false;
            this.dgvVZamowienia.Name = "dgvVZamowienia";
            this.dgvVZamowienia.ReadOnly = true;
            this.dgvVZamowienia.RowHeadersVisible = false;
            this.dgvVZamowienia.RowHeadersWidth = 51;
            this.dgvVZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVZamowienia.Size = new System.Drawing.Size(363, 114);
            this.dgvVZamowienia.TabIndex = 2;
            // 
            // dgvVSklad
            // 
            this.dgvVSklad.AllowUserToResizeRows = false;
            this.dgvVSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVSklad.Location = new System.Drawing.Point(899, 717);
            this.dgvVSklad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVSklad.MultiSelect = false;
            this.dgvVSklad.Name = "dgvVSklad";
            this.dgvVSklad.ReadOnly = true;
            this.dgvVSklad.RowHeadersVisible = false;
            this.dgvVSklad.RowHeadersWidth = 51;
            this.dgvVSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVSklad.Size = new System.Drawing.Size(363, 93);
            this.dgvVSklad.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 81);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1259, 729);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(23, 81);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1259, 729);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // btnChartColumn
            // 
            this.btnChartColumn.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnChartColumn.IconColor = System.Drawing.Color.Black;
            this.btnChartColumn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChartColumn.Location = new System.Drawing.Point(60, 13);
            this.btnChartColumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartColumn.Name = "btnChartColumn";
            this.btnChartColumn.Size = new System.Drawing.Size(73, 61);
            this.btnChartColumn.TabIndex = 12;
            this.btnChartColumn.UseVisualStyleBackColor = true;
            this.btnChartColumn.Click += new System.EventHandler(this.btnChartColumn_Click);
            // 
            // btnChartPie
            // 
            this.btnChartPie.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnChartPie.IconColor = System.Drawing.Color.Black;
            this.btnChartPie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChartPie.Location = new System.Drawing.Point(194, 13);
            this.btnChartPie.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartPie.Name = "btnChartPie";
            this.btnChartPie.Size = new System.Drawing.Size(73, 61);
            this.btnChartPie.TabIndex = 13;
            this.btnChartPie.UseVisualStyleBackColor = true;
            this.btnChartPie.Click += new System.EventHandler(this.btnChartPie_Click);
            // 
            // cbRok
            // 
            this.cbRok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRok.FormattingEnabled = true;
            this.cbRok.Location = new System.Drawing.Point(1022, 22);
            this.cbRok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRok.Name = "cbRok";
            this.cbRok.Size = new System.Drawing.Size(220, 37);
            this.cbRok.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(944, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Rok:";
            // 
            // AFBilansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 838);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRok);
            this.Controls.Add(this.btnChartPie);
            this.Controls.Add(this.btnChartColumn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dgvVZamowienia);
            this.Controls.Add(this.dgvVSklad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AFBilansForm";
            this.Tag = "Klienci";
            this.Text = "AFKlienciForm";
            this.Load += new System.EventHandler(this.AFKlienciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVZamowienia;
        private System.Windows.Forms.DataGridView dgvVSklad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private FontAwesome.Sharp.IconButton btnChartColumn;
        private FontAwesome.Sharp.IconButton btnChartPie;
        private System.Windows.Forms.ComboBox cbRok;
        private System.Windows.Forms.Label label1;
    }
}