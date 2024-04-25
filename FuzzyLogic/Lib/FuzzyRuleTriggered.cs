namespace Lib
{
    public class FuzzyRuleTriggered
    {
        public double FiringStrength { get; }
        public int[] ConsequentIndexes { get; }
        public FuzzyRuleTriggered(double firingStrength, int[] consequentIndexes)
        {
            FiringStrength = firingStrength;
            ConsequentIndexes = consequentIndexes;
        }
    }
}
