namespace Lib
{
    internal class RuleTable
    {
        public List<FuzzyRule> Rules { get; set; }

        public RuleTable(List<FuzzyRule> rules)
        {
            Rules = rules;
        }
        // return the index of the rule that matches the antecedents
        public List<int> FindRuleIndexes(List<List<int>> antecedents)
        {
            List<int> found = [];
            for (int i = 0; i < Rules.Count; i++)
            {
                bool contains = antecedents[0].Contains(Rules[i].Antecedents[0]) &&
                    antecedents[1].Contains(Rules[i].Antecedents[1]) &&
                    antecedents[2].Contains(Rules[i].Antecedents[2]);

                if (contains)
                {
                    found.Add(i);
                }
            }
            return found;
        }
    }
}
