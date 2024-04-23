namespace Lib
{
    internal class FuzzyRule
    {
        public int[] Antecedents { get; set; }
        public int[] Consequents { get; set; }

        public FuzzyRule(int[] antecedents, int[] consequents)
        {
            Antecedents = antecedents;
            Consequents = consequents;
        }
    }
}
