using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TheCentralLimitTheorem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<double> Values { get; set; }
        public bool FileIsLoaded { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCsv();
        }
        private void ReadCsv()
        {
            try
            {
                string[] ArrayStrings = File.ReadAllLines("data.csv");
                Values = new List<double>();
                for (int i = 0; i < ArrayStrings.Length; i++)
                {
                    string[] valuesInString = ArrayStrings[i].Split(';');
                    for (int j = 0; j < valuesInString.Length; j++)
                        Values.Add(Convert.ToDouble(valuesInString[j]));
                }
                FileIsLoaded = true;
            }
            catch (Exception ex)
            {
                FileIsLoaded = false;
                MessageBox.Show("Возникли проблемы при доступе к файлу: " + ex.Message);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!FileIsLoaded) ReadCsv();
            if (FileIsLoaded)
            {
                DataGridValues.Rows.Clear();
                List<List<double>> listSelections = new List<List<double>>();
                for (int i = 0; i < NudSeries.Value; i++)
                    listSelections.Add(Values.OrderBy(x => new Random().Next()).Take((int)NudSelections.Value).ToList());
                FillTheTable(listSelections);
            }
        }
        private void FillTheTable(List<List<double>> listSelections)
        {
            ChartResult.Series.Clear();
            ChartDistribution.Series.Clear();
            for (int i = 0; i < listSelections.Count; i++)
            {
                double avg = listSelections[i].Average();
                double dispersion = ComputeDispersion(listSelections[i], avg);
                DataGridValues.Rows.Add(i + 1, avg, dispersion, Math.Sqrt(dispersion));
                BuildChart(listSelections[i], Math.Sqrt(dispersion), avg);
            }
        }
        private double ComputeDispersion(List<double> selections, double avg)
        {
            double dispersion = 0;
            double argument = 1.0 / (selections.Count - 1.0);
            var result = selections.GroupBy(n => n).Select(m => new { m.Key, Count = m.Count() });
            foreach (var item in result)
                dispersion += Math.Pow(item.Key - avg, 2) * item.Count;
            dispersion *= argument;
            return dispersion;
        }
        private void BuildChart(List<double> listDispersion, double S, double avg)
        {
            ChartResult.Series.Add("Гистограмма " + (ChartResult.Series.Count + 1));
            ChartResult.Series.Last().BorderWidth = 3;
            ChartDistribution.Series.Add("Нормальное распределение " + (ChartDistribution.Series.Count + 1));
            ChartDistribution.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            ChartDistribution.Series.Last().BorderWidth = 3;
            listDispersion.Sort();
            var result = listDispersion.GroupBy(n => n).Select(m => new { m.Key, Count = m.Count() });
            foreach (var item in result)
            {
                ChartResult.Series.Last().Points.AddXY(item.Key, item.Count);
                ChartDistribution.Series.Last().Points.AddXY(item.Key, ComputeNormalDistribution(item.Key, S, avg));
            }
            TrackBarChartMapping.Minimum = (int)ChartResult.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            TrackBarChartMapping.Maximum = (int)ChartResult.ChartAreas[0].AxisX.ScaleView.ViewMaximum + 10;
            TrackBarChartMapping.Value = (int)ChartResult.ChartAreas[0].AxisX.ScaleView.Size;
            TrackBarDistributionChart.Minimum = (int)ChartDistribution.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            TrackBarDistributionChart.Maximum = (int)ChartDistribution.ChartAreas[0].AxisX.ScaleView.ViewMaximum + 10;
            TrackBarDistributionChart.Value = (int)ChartDistribution.ChartAreas[0].AxisX.ScaleView.Size;
        }
        private double ComputeNormalDistribution(double X, double S, double avg)
        {
            return 1 / (S * Math.Sqrt(2 * Math.PI)) * Math.Exp(-1 * (Math.Pow(X - avg, 2) / (2 * Math.Pow(S, 2))));
        }
        private void TrackBarChartMapping_Scroll(object sender, EventArgs e) => ChartResult.ChartAreas[0].AxisX.ScaleView.Size = TrackBarChartMapping.Value;

        private void TrackBarDistributionChart_Scroll(object sender, EventArgs e) => ChartDistribution.ChartAreas[0].AxisX.ScaleView.Size = TrackBarDistributionChart.Value;
    }
}
