namespace Lib
{
    public class ExecutionReport
    {
        public int[] TriggeredRuleIndexes { get; set; } = [];
        public List<Dictionary<int, double>> AntecedentResults { get; set; } = [];
        public Dictionary<int, Dictionary<int, double>> MamdaniResults { get; set; } = [];
        public List<double> MamdaniValues { get; set; } = [];
        public List<double> OutputResults { get; set; } = [];

        public ExecutionReport()
        {
        }
        public ExecutionReport(
            int[] triggeredRuleIndexes, List<Dictionary<int, double>> antecedentResults,
            Dictionary<int, Dictionary<int, double>> mamdaniResults,
            List<double> mamdaniValues,
            List<double> outputResults
            )
        {
            TriggeredRuleIndexes = triggeredRuleIndexes;
            AntecedentResults = antecedentResults;
            MamdaniResults = mamdaniResults;
            MamdaniValues = mamdaniValues;
            OutputResults = outputResults;
        }
    }
}
