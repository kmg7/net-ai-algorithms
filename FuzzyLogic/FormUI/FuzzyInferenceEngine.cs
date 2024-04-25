using Lib;

namespace FormUI
{
    public partial class MainForm : Form
    {
        FuzzyInferenceEngine? MamdaniInferenceEngine { get; set; }
        public void CraftTheEngine()
        {
            double[] sens_strong_params = [-4, -1.5, 2, 4];
            double[] sens_mid_params = [3, 5, 7];
            double[] sens_low_params = [5.5, 8, 12.5, 14];
            FuzzySet sens_strong = new("strong", sens_strong_params, FunctionType.Trapezoid);
            FuzzySet sens_mid = new("mid", sens_mid_params, FunctionType.Triangle);
            FuzzySet sens_low = new("strong", sens_low_params, FunctionType.Trapezoid);
            FuzzyVariable sensitiviy = new("Sensitivity", 0, 10, [sens_strong, sens_mid, sens_low]);

            double[] quant_small_params = [-4, -1.5, 2, 4];
            double[] quant_med_params = [3, 5, 7];
            double[] quant_large_params = [5.5, 8, 12.5, 14];
            FuzzySet quant_small = new("small", quant_small_params, FunctionType.Trapezoid);
            FuzzySet quant_med = new("med", quant_med_params, FunctionType.Triangle);
            FuzzySet quant_large = new("large", quant_large_params, FunctionType.Trapezoid);
            FuzzyVariable quantity = new("Quantity", 0, 10, [quant_large, quant_med, quant_small]);

            double[] dirt_small_params = [-4.5, -2.5, 2, 4.5];
            double[] dirt_med_params = [3, 5, 7];
            double[] dirt_large_params = [5.5, 8, 12.5, 15];
            FuzzySet dirt_small = new("small", dirt_small_params, FunctionType.Trapezoid);
            FuzzySet dirt_med = new("med", dirt_med_params, FunctionType.Triangle);
            FuzzySet dirt_large = new("large", dirt_large_params, FunctionType.Trapezoid);
            FuzzyVariable dirt = new("Dirtiness", 0, 10, [dirt_large, dirt_med, dirt_small]);

            double[] spin_sens_params = [-5.8, -2.8, 0.5, 1.5];
            double[] spin_avg_sens_params = [0.5, 2.75, 5];
            double[] spin_avg_params = [2.75, 5, 7.25];
            double[] spin_avg_strong_params = [5, 7.25, 9.5];
            double[] spin_strong_params = [8.5, 9.5, 12.8, 15.2];
            FuzzySet spin_sens = new("sensitive", spin_sens_params, FunctionType.Trapezoid);
            FuzzySet spin_avg_sens = new("average sensitive", spin_avg_sens_params, FunctionType.Triangle);
            FuzzySet spin_med = new("average", spin_avg_params, FunctionType.Triangle);
            FuzzySet spin_avg_strong = new("average strong", spin_avg_strong_params, FunctionType.Triangle);
            FuzzySet spin_strong = new("strong", spin_strong_params, FunctionType.Trapezoid);
            FuzzyVariable spin = new("Spin", 0, 10, [spin_sens, spin_avg_sens, spin_med, spin_avg_strong, spin_strong]);

            double[] time_short_params = [-46.5, -25.28, 22.3, 39.9];
            double[] time_avg_short_params = [22.3, 39.9, 57.5];
            double[] time_avg_params = [39.9, 57.5, 75.1];
            double[] time_avg_long_params = [57.5, 75.1, 92.7];
            double[] time_strong_params = [75, 92.7, 111.6, 130];
            FuzzySet time_short = new("short", time_short_params, FunctionType.Trapezoid);
            FuzzySet time_avg_short = new("average short", time_avg_short_params, FunctionType.Triangle);
            FuzzySet time_med = new("medium", time_avg_params, FunctionType.Triangle);
            FuzzySet time_avg_long = new("average long", time_avg_long_params, FunctionType.Triangle);
            FuzzySet time_long = new("long", time_strong_params, FunctionType.Trapezoid);
            FuzzyVariable time = new("Time", 0, 100, [time_short, time_avg_short, time_med, time_avg_long, time_long]);

            double[] detergent_too_few_params = [0, 0, 20, 85];
            double[] detergent_few_params = [20, 85, 150];
            double[] detergent_med_params = [85, 150, 215];
            double[] detergent_much_params = [150, 215, 280];
            double[] detergent_too_much_params = [215, 280, 300, 300];
            FuzzySet detergent_too_few = new("too few", detergent_too_few_params, FunctionType.Trapezoid);
            FuzzySet detergent_few = new("few", detergent_few_params, FunctionType.Triangle);
            FuzzySet detergent_med = new("medium", detergent_med_params, FunctionType.Triangle);
            FuzzySet detergent_much = new("much", detergent_much_params, FunctionType.Triangle);
            FuzzySet detergent_too_much = new("too much", detergent_too_much_params, FunctionType.Trapezoid);
            FuzzyVariable detergent = new("Detergent", 0, 300, [detergent_too_few, detergent_few, detergent_med, detergent_much, detergent_too_much]);

            FuzzyInferenceEngine engine = new(Rules, antecedents: [sensitiviy, quantity, dirt], consequents: [spin, time, detergent]);
            MamdaniInferenceEngine = engine;
        }
    }
}
