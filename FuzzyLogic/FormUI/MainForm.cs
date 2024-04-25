using Lib;

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
            if (MamdaniInferenceEngine == null)
            {
                button_run.Enabled = false;
            }
        }
        private void button_run_Click(object sender, EventArgs e)
        {
            if (MamdaniInferenceEngine == null)
            {
                MessageBox.Show("Error: Inference engine is not ready");
                return;
            }
            double input_sens = ((double)numericUpDown_sens.Value);
            double input_quant = ((double)numericUpDown_quant.Value);
            double input_dirt = ((double)numericUpDown_dirt.Value);
            if (input_sens == 0 || input_dirt == 0 || input_quant == 0)
            {
                return;
            }
            chart_sensitivity.DrawLine(input_sens);
            chart_quantity.DrawLine(input_quant);
            chart_dirtiness.DrawLine(input_dirt);
            ExecutionReport executionReport = MamdaniInferenceEngine.Execute([input_sens, input_quant, input_dirt]);
            FillTheRulesTable(executionReport.TriggeredRuleIndexes);
            FillAntecedentResultLabels(executionReport.AntecedentResults);
            FillMamdaniOutputLabels(executionReport.MamdaniValues);
            FillOutputResultLabels(executionReport.OutputResults);
            FillOutputDetailResultLabels(executionReport.MamdaniResults);
        }
        private void FillAntecedentResultLabels(List<Dictionary<int, double>> antes)
        {
            string sens_text = "";
            string quant_text = "";
            string dirt_text = "";
            foreach (var item in antes[0])
            {
                string set_name = sens_input[item.Key];
                double set_value = item.Value;
                sens_text += $"{set_name.ToUpper()}: {set_value:F2} ";
            }
            foreach (var item in antes[1])
            {
                string set_name = quant_input[item.Key];
                double set_value = item.Value;
                quant_text += $"{set_name.ToUpper()}: {set_value:F2} ";
            }
            foreach (var item in antes[2])
            {
                string set_name = dirt_input[item.Key];
                double set_value = item.Value;
                dirt_text += $"{set_name.ToUpper()}: {set_value:F2} ";
            }
            label_sens_res.Text = sens_text;
            label_quant_res.Text = quant_text;
            label_dirt_res.Text = dirt_text;
        }
        private void FillMamdaniOutputLabels(List<double> mams)
        {
            // add the mamdani output doubles to list box
            listBox_mam_results.Items.Clear();
            foreach (var item in mams)
            {
                listBox_mam_results.Items.Add($"{item:F2}");
            }
        }
        private void FillOutputResultLabels(List<double> outputs)
        {
            double out_spin = outputs[0];
            double out_time = outputs[1];
            double out_deterg = outputs[2];
            chart_spinrate.DrawLine(out_spin);
            chart_time.DrawLine(out_time);
            chart_detergent.DrawLine(out_deterg);
            label_spin_out.Text = out_spin.ToString("F2");
            label_time_out.Text = out_time.ToString("F2");
            label_deterg_out.Text = out_deterg.ToString("F2");
        }
        private void FillOutputDetailResultLabels(Dictionary<int, Dictionary<int, double>> mams)
        {
            label_spin_det.Text = "";
            label_time_det.Text = "";
            label_deter_det.Text = "";

            foreach (var item in mams[0])
            {
                string set_name = spin_output[item.Key];
                double set_value = item.Value;
                label_spin_det.Text += $"{set_name.ToUpper()}: {set_value:F2} \n";
            }
            foreach (var item in mams[1])
            {
                string set_name = time_output[item.Key];
                double set_value = item.Value;
                label_time_det.Text += $"{set_name.ToUpper()}: {set_value:F2} \n";
            }
            foreach (var item in mams[2])
            {
                string set_name = detergent_output[item.Key];
                double set_value = item.Value;
                label_deter_det.Text += $"{set_name.ToUpper()}: {set_value:F2} \n";
            }
        }
    }
}

