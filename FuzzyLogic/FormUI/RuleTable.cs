using Lib;

namespace FormUI
{
    public partial class MainForm : Form
    {
        // inputs
        readonly string[] sens_input = ["strong", "medium", "sensitive"];
        readonly string[] quant_input = ["small", "medium", "large"];
        readonly string[] dirt_input = ["small", "medium", "large"];

        // outputs
        readonly string[] spin_output = ["sensitive", "average sensitive", "medium", "average strong", "strong"];
        readonly string[] time_output = ["short", "average short", "medium", "average long", "long"];
        readonly string[] detergent_output = ["too few", "few", "medium", "much", "too much"];

        public List<FuzzyRule> Rules { get; set; } = [];
        public void ReadRulesFromCSV()
        {
            List<FuzzyRule> rules = [];
            // Read the rules from rules.csv file
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rules.csv");
            string[] lines = File.ReadAllLines(filePath);
            // Parse the rule
            for (int i = 1; i < lines.Length; i++)
            {
                //Console.WriteLine(lines[i]);
                string[] values = lines[i].Split(',');

                int[] antecedents = [
                    Array.IndexOf(sens_input, values[0]),
                    Array.IndexOf(quant_input, values[1]),
                    Array.IndexOf(dirt_input, values[2])
                ];

                int[] consequents = [
                    Array.IndexOf(spin_output, values[3]),
                    Array.IndexOf(time_output, values[4]),
                    Array.IndexOf(detergent_output, values[5])
                    ];

                rules.Add(new(antecedents, consequents));
            }
            _ = MessageBox.Show("Rule database read successfully");
            Rules = rules;
        }
        public void FillTheRulesTable(int[] indexes)
        {
            dataGridView1.Rows.Clear();
            foreach (int index in indexes)
            {
                FuzzyRule rule = Rules[index];
                string[] row = new string[] { $"{index}",sens_input[rule.Antecedents[0]],
                    quant_input[rule.Antecedents[1]],
                    dirt_input[rule.Antecedents[2]], spin_output[rule.Consequents[0]],
                    time_output[rule.Consequents[1]], detergent_output[rule.Consequents[2]] };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
