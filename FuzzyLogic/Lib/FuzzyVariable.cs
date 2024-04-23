namespace Lib
{
    internal class FuzzyVariable
    {
        public string Name { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public List<FuzzySet> Sets { get; set; }
        public FuzzyVariable(string name, double min, double max, List<FuzzySet> members)
        {
            Name = name;
            MinValue = min;
            MaxValue = max;
            Sets = members;
        }
        // Get the index of set and its membership value
        public Dictionary<int, double> GetSetResults(double value)
        {
            Dictionary<int, double> sets = [];
            for (int i = 0; i < Sets.Count; i++)
            {
                double memValue = Sets[i].CalculateMembership(value);
                if (memValue > 0)
                {
                    sets.Add(i, memValue);
                }
            }
            return sets;
        }
    }
}
