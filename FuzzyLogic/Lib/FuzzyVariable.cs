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
    }
}
