namespace FormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DrawInputCharts();
            DrawOutputCharts();
            try
            {
                ReadRulesFromCSV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading rules from CSV file: " + ex.Message);
            }
            CraftTheEngine();
        }

    }
}

