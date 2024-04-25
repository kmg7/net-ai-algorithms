using System.Windows.Forms.DataVisualization.Charting;

namespace FormUI
{
    public partial class SpecialChart : UserControl
    {
        public SpecialChart()
        {
            InitializeComponent();
        }
        public void DrawChart(Dictionary<String, List<double[]>> Series)
        {
            // Update the chart
            chart1.Series.Clear();
            chart1.Series.Add("INDEX");
            foreach (var serie in Series)
            {
                chart1.Series.Add(serie.Key);
                chart1.Series[serie.Key].ChartType = SeriesChartType.Line;
                foreach (var point in serie.Value)
                {
                    chart1.Series[serie.Key].Points.AddXY(point[0], point[1]);
                }
            }
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.Legends[0].Docking = Docking.Bottom;
        }
        public void DrawLine(double x)
        {
            //clear the LINE points first
            chart1.Series["INDEX"].Points.Clear();
            chart1.Series["INDEX"].ChartType = SeriesChartType.Line;
            chart1.Series["INDEX"].Points.AddXY(x, 0);
            chart1.Series["INDEX"].Points.AddXY(x, 1);
        }
        public void ClearLine()
        {
            chart1.Series["INDEX"].Points.Clear();
        }
    }
}
