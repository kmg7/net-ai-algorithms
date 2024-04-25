namespace Lib
{
    // Inference System will be the underlying MAMDANI engine for our system
    public class FuzzyInferenceEngine
    {
        public RuleTable RuleTable { get; }
        public List<FuzzyVariable> Antecedents { get; }
        public List<FuzzyVariable> Consequents { get; }
        public FuzzyInferenceEngine(List<FuzzyRule> rules, List<FuzzyVariable> antecedents, List<FuzzyVariable> consequents)
        {
            RuleTable = new RuleTable(rules);
            Antecedents = antecedents;
            Consequents = consequents;
        }

        public List<double> Execute(double[] values)
        {
            // Get the antecedent set results
            List<Dictionary<int, double>> antecedentSetResults = [];
            List<List<int>> antecedentSetIndexes = [];
            for (int i = 0; i < Antecedents.Count; i++)
            {
                antecedentSetResults.Add(Antecedents[i].GetSetResults(values[i]));
                antecedentSetIndexes.Add([.. antecedentSetResults[i].Keys]);
            }

            // Find the rule indexes that match the antecedent set results
            List<int> ruleIndexes = RuleTable.FindRuleIndexes(antecedentSetIndexes);

            // Calculate the firing strength of each rule
            List<FuzzyRuleTriggered> triggeredRules = [];
            foreach (int ruleIndex in ruleIndexes)
            {
                FuzzyRule rule = RuleTable.Rules[ruleIndex];
                double firingStrength = 1;
                for (int i = 0; i < rule.Antecedents.Length; i++)
                {
                    int setIndex = rule.Antecedents[i];
                    firingStrength = Math.Min(firingStrength, antecedentSetResults[i][setIndex]);
                }
                triggeredRules.Add(new FuzzyRuleTriggered(firingStrength, rule.Consequents));
            }

            // Calculate the membership values of the consequent sets
            List<List<double>> consequentSetResults = [];
            for (int i = 0; i < Consequents.Count; i++)
            {
                consequentSetResults.Add([]);
                for (int j = 0; j < Consequents[i].Sets.Count; j++)
                {
                    consequentSetResults[i].Add(0);
                }
            }
            Dictionary<int, Dictionary<int, double>> mamdaniResults = [];
            foreach (FuzzyRuleTriggered rule in triggeredRules)
            {
                for (int i = 0; i < rule.ConsequentIndexes.Length; i++)
                {
                    if (!mamdaniResults.ContainsKey(i))
                    {
                        mamdaniResults[i] = [];
                    }
                    int ruleConseqIndex = rule.ConsequentIndexes[i];//spin :2, time:3, detergent:1 // this is the index of the membership functions triggered fuzzy set
                    if (!mamdaniResults[i].ContainsKey(ruleConseqIndex))
                    {
                        mamdaniResults[i][ruleConseqIndex] = -1;
                    }
                    double existingValue = mamdaniResults[i][ruleConseqIndex]; // if we had a pointer mech. this block would look better
                    if (existingValue < rule.FiringStrength)
                    {
                        mamdaniResults[i][ruleConseqIndex] = rule.FiringStrength;
                    }
                }
            }
            List<FuzzyVariable> outputVariables = [];
            foreach (var item in mamdaniResults)
            {
                Console.WriteLine($"Consequent: {item.Key}");
                var conseq = Consequents[item.Key];
                List<FuzzySet> newSets = [];
                foreach (var subItem in item.Value)
                {
                    conseq.Sets[subItem.Key].SetCut(subItem.Value);
                    newSets.Add(conseq.Sets[subItem.Key]);
                    Console.WriteLine($"Set: {subItem.Key}, Membership: {subItem.Value}");
                }
                outputVariables.Add(new FuzzyVariable(conseq.Name, conseq.MinValue, conseq.MaxValue, newSets));
            }
            List<double> defuzifiedValues = [];
            for (int i = 0; i < outputVariables.Count; i++)
            {
                FuzzyVariable variable = outputVariables[i];
                List<double> memValues = consequentSetResults[i];
                double defuzifiedValue = Defuzifier.Defuzify(variable, memValues, DefuzificationMethod.Centroid);
                defuzifiedValues.Add(defuzifiedValue);
            }
            return defuzifiedValues;
        }
    }
}
