namespace UIForm
{
    using Lib;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int populationSize;
        int generationSize;
        double mutationRate;
        int selectionSize;
        double crossoverVal;

        private void btnRunClick(object sender, EventArgs e)
        {
            // Instanciate the algorithm and run it
            if (!validateAndSetInputs())
            {
                MessageBox.Show("Invalid input");
                return;
            }
            chartPaneBig.Controls.Clear();
            chartPaneSmall.Controls.Clear();
            // Create a chart control
            Chart chartBig = new Chart();
            chartBig.Size = new System.Drawing.Size(800, 600);
            chartBig.ChartAreas.Add(new ChartArea());

            chartBig.ChartAreas[0].AxisY.Minimum = 0;
            chartBig.ChartAreas[0].AxisY.Maximum = 10;

            chartBig.Series.Add("BestFitness");
            chartBig.Series["BestFitness"].ChartType = SeriesChartType.Line;

            Chart chartSmall = new Chart();
            chartSmall.Size = new System.Drawing.Size(800, 600);
            chartSmall.ChartAreas.Add(new ChartArea());

            chartSmall.ChartAreas[0].AxisY.Minimum = 0;
            chartSmall.ChartAreas[0].AxisY.Maximum = 1;


            chartSmall.Series.Add("BestFitness");
            chartSmall.Series["BestFitness"].ChartType = SeriesChartType.Line;


            btnRun.Enabled = false;
            btnRun.Text = "Running...";
            // Get the selected values from the comboboxes
            SelectionType selection = (SelectionType)comboBoxSelection.SelectedIndex;
            CrossoverType crossover = (CrossoverType)comboBoxCrossover.SelectedIndex;
            MutationType mutation = (MutationType)comboBoxMutation.SelectedIndex;

            // Create the algorithm
            GeneticAlgorithm ga = new GeneticAlgorithm(populationSize, mutationRate, generationSize, selectionSize, crossoverVal, selection, crossover, mutation);
            ga.Run();

            var hist = ga.GetResults();
            // Loop over history and display the results
            for (int i = 0; i < hist.Count; i++)
            {
                chartBig.Series["BestFitness"].Points.AddXY(i + 1, hist[i][0].Fitness);
                chartSmall.Series["BestFitness"].Points.AddXY(i + 1, hist[i][0].Fitness);
            }

            var last = hist.Last();
            var best = last[0];

            //lblBest.Text = $"X : {hist.Last()[0].X}, Y: {best.Y}, Fitness: {best.Fitness}";
            lblBestX.Text = $"{best.Genes[0]}";
            lblBestY.Text = $"{best.Genes[1]}";
            lblBestF.Text = $"{best.Fitness}";

            chartBig.Dock = DockStyle.Fill;
            chartSmall.Dock = DockStyle.Fill;
            chartPaneBig.Controls.Add(chartBig);
            chartPaneSmall.Controls.Add(chartSmall);
            btnRun.Enabled = true;
            btnRun.Text = "Run";

        }

        // Validate inputs and set the values
        private bool validateAndSetInputs()
        {
            return (int.TryParse(tBPopulationSize.Text, out populationSize) &&
                int.TryParse(tBGenerationSize.Text, out generationSize) &&
                double.TryParse(tBMutationRate.Text, out mutationRate) &&
                int.TryParse(tBElitismRate.Text, out selectionSize) &&
                double.TryParse(tbCrossoverVal.Text, out crossoverVal));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCrossover.DataSource = Enum.GetValues(typeof(CrossoverType));
            comboBoxSelection.DataSource = Enum.GetValues(typeof(SelectionType));
            comboBoxMutation.DataSource = Enum.GetValues(typeof(MutationType));
            comboBoxCrossover.SelectedIndex = 0;
            comboBoxSelection.SelectedIndex = 0;
            comboBoxMutation.SelectedIndex = 0;
        }
    }
}
