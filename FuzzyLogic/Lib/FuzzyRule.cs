namespace Lib
{
    internal class FuzzyRule
    {
        public FuzzySet[] Antecedents { get; set; }
        public FuzzySet[] Consequents { get; set; }

        public FuzzyRule(FuzzySet[] antecedents, FuzzySet[] consequents)
        {
            Antecedents = antecedents;
            Consequents = consequents;
        }
    }
}
