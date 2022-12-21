
namespace TheCentralLimitTheorem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TrackBarChartMapping = new System.Windows.Forms.TrackBar();
            this.ChartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridValues = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NudSelections = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NudSeries = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TrackBarDistributionChart = new System.Windows.Forms.TrackBar();
            this.ChartDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarChartMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridValues)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSelections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDistributionChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DataGridValues);
            this.splitContainer1.Size = new System.Drawing.Size(736, 530);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.TrackBarChartMapping, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ChartResult, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(363, 309);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // TrackBarChartMapping
            // 
            this.TrackBarChartMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarChartMapping.Location = new System.Drawing.Point(3, 270);
            this.TrackBarChartMapping.Maximum = 500;
            this.TrackBarChartMapping.Name = "TrackBarChartMapping";
            this.TrackBarChartMapping.Size = new System.Drawing.Size(357, 36);
            this.TrackBarChartMapping.TabIndex = 2;
            this.TrackBarChartMapping.Scroll += new System.EventHandler(this.TrackBarChartMapping_Scroll);
            // 
            // ChartResult
            // 
            chartArea1.AxisX.ScaleView.Size = 50D;
            chartArea1.AxisX.Title = "Карман (значение)";
            chartArea1.AxisY.Title = "Частота";
            chartArea1.Name = "ChartArea1";
            this.ChartResult.ChartAreas.Add(chartArea1);
            this.ChartResult.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartResult.Legends.Add(legend1);
            this.ChartResult.Location = new System.Drawing.Point(3, 3);
            this.ChartResult.Name = "ChartResult";
            this.ChartResult.Size = new System.Drawing.Size(357, 261);
            this.ChartResult.TabIndex = 0;
            // 
            // DataGridValues
            // 
            this.DataGridValues.AllowUserToAddRows = false;
            this.DataGridValues.AllowUserToDeleteRows = false;
            this.DataGridValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.X,
            this.D,
            this.S});
            this.DataGridValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridValues.Location = new System.Drawing.Point(0, 0);
            this.DataGridValues.Name = "DataGridValues";
            this.DataGridValues.ReadOnly = true;
            this.DataGridValues.Size = new System.Drawing.Size(734, 213);
            this.DataGridValues.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.44954F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.55046F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.NudSelections, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NudSeries, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.StartButton, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(736, 26);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // NudSelections
            // 
            this.NudSelections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudSelections.Location = new System.Drawing.Point(444, 3);
            this.NudSelections.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NudSelections.Name = "NudSelections";
            this.NudSelections.Size = new System.Drawing.Size(141, 20);
            this.NudSelections.TabIndex = 3;
            this.NudSelections.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(297, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество выборки:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество раз:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NudSeries
            // 
            this.NudSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudSeries.Location = new System.Drawing.Point(146, 3);
            this.NudSeries.Name = "NudSeries";
            this.NudSeries.Size = new System.Drawing.Size(145, 20);
            this.NudSeries.TabIndex = 1;
            this.NudSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(591, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(142, 20);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Выполнить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // N
            // 
            this.N.HeaderText = "N - серий";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Width = 73;
            // 
            // X
            // 
            this.X.HeaderText = "X - среднее";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 83;
            // 
            // D
            // 
            this.D.HeaderText = "D - дисперсия";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Width = 95;
            // 
            // S
            // 
            this.S.HeaderText = "S - отклонение";
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Width = 98;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer2.Size = new System.Drawing.Size(736, 311);
            this.splitContainer2.SplitterDistance = 365;
            this.splitContainer2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.TrackBarDistributionChart, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ChartDistribution, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(365, 309);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // TrackBarDistributionChart
            // 
            this.TrackBarDistributionChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarDistributionChart.Location = new System.Drawing.Point(3, 270);
            this.TrackBarDistributionChart.Maximum = 500;
            this.TrackBarDistributionChart.Name = "TrackBarDistributionChart";
            this.TrackBarDistributionChart.Size = new System.Drawing.Size(359, 36);
            this.TrackBarDistributionChart.TabIndex = 2;
            this.TrackBarDistributionChart.Scroll += new System.EventHandler(this.TrackBarDistributionChart_Scroll);
            // 
            // ChartDistribution
            // 
            chartArea2.AxisX.ScaleView.Size = 50D;
            chartArea2.AxisX.Title = "Карман (значение)";
            chartArea2.AxisY.Title = "F(x) (норм. расп.)";
            chartArea2.Name = "ChartArea1";
            this.ChartDistribution.ChartAreas.Add(chartArea2);
            this.ChartDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ChartDistribution.Legends.Add(legend2);
            this.ChartDistribution.Location = new System.Drawing.Point(3, 3);
            this.ChartDistribution.Name = "ChartDistribution";
            this.ChartDistribution.Size = new System.Drawing.Size(359, 261);
            this.ChartDistribution.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Центральная предельная теорема";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarChartMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridValues)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSelections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSeries)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDistributionChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudSelections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudSeries;
        private System.Windows.Forms.DataGridView DataGridValues;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TrackBar TrackBarChartMapping;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TrackBar TrackBarDistributionChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDistribution;
    }
}

