namespace Lib
{
    public class Debugger
    {
        public void Debug()
        {
            Console.WriteLine("Internal debugger pays its respects");
            double[] sens_strong_params = [-4, -1.5, 2, 4];
            double[] sens_mid_params = [3, 5, 7];
            double[] sens_low_params = [5.5, 8, 12.5, 14];
            FuzzySet sens_strong = new("strong", sens_strong_params, FunctionType.Trapezoid);
            FuzzySet sens_mid = new("mid", sens_mid_params, FunctionType.Triangle);
            FuzzySet sens_low = new("strong", sens_low_params, FunctionType.Trapezoid);
            FuzzyVariable sensitiviy = new("Hassaslik", 0, 10, [sens_strong, sens_mid, sens_low]);

            double[] quant_small_params = [-4, -1.5, 2, 4];
            double[] quant_med_params = [3, 5, 7];
            double[] quant_large_params = [5.5, 8, 12.5, 14];
            FuzzySet quant_small = new("small", quant_small_params, FunctionType.Trapezoid);
            FuzzySet quant_med = new("med", quant_med_params, FunctionType.Triangle);
            FuzzySet quant_large = new("large", quant_large_params, FunctionType.Trapezoid);
            FuzzyVariable quantity = new("Miktar", 0, 10, [quant_large, quant_med, quant_small]);

            double[] dirt_small_params = [-4.5, -2.5, 2, 4.5];
            double[] dirt_med_params = [3, 5, 7];
            double[] dirt_large_params = [5.5, 8, 12.5, 15];
            FuzzySet dirt_small = new("small", dirt_small_params, FunctionType.Trapezoid);
            FuzzySet dirt_med = new("med", dirt_med_params, FunctionType.Triangle);
            FuzzySet dirt_large = new("large", dirt_large_params, FunctionType.Trapezoid);
            FuzzyVariable dirt = new("Kirlilik", 0, 10, [dirt_large, dirt_med, dirt_small]);
            // inputs
            // sens: strong, mid, low
            // quant: small, med, large
            // dirt: small, med, large
            List<FuzzyRule> rules = new List<FuzzyRule>();

            // Read the rules from rules.csv file
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rules.csv");
            string[] lines = File.ReadAllLines(filePath);
            // inputs
            string[] sens_input = ["strong", "medium", "sensitive"];
            string[] quant_input = ["small", "medium", "large"];
            string[] dirt_input = ["small", "medium", "large"];

            // outputs
            string[] spin_output = ["sentitive", "average sensitive", "average", "average strong", "strong"];
            string[] time_output = ["short", "average short", "medium", "average long", "long"];
            string[] detergent_output = ["too few", "few", "medium", "much", "too much"];

            // Parse the rules
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
            RuleTable ruleTable = new(rules);
            Console.WriteLine("Sensitivity Results");
            var resSens = sensitiviy.GetSetResults(3.2);
            foreach (var item in resSens)
            {
                Console.WriteLine($"Set: {item.Key}, Membership: {item.Value}");
            }

            Console.WriteLine("Quantity Results");
            var resQuant = quantity.GetSetResults(3.2);
            foreach (var item in resQuant)
            {
                Console.WriteLine($"Set: {item.Key}, Membership: {item.Value}");
            }

            Console.WriteLine("Dirt Results");
            var resDirt = dirt.GetSetResults(3.2);
            foreach (var item in resDirt)
            {
                Console.WriteLine($"Set: {item.Key}, Membership: {item.Value}");
            }
            List<List<int>> antes = [[.. resSens.Keys], [.. resQuant.Keys], [.. resDirt.Keys]];
            //print antes
            foreach (var ante in antes)
            {
                foreach (var item in ante)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            var found = ruleTable.FindRuleIndexes(antes);
            Console.WriteLine($"Rule table found these {found.Count} rules");
            foreach (var item in found)
            {
                Console.WriteLine(item);
            }
            //get the relevant keys as arrays and search for the rules by looking up the table
        }
    }
}
