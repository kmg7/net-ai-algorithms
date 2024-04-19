namespace Lib
{
    public enum SelectionType
    {
        Tournament,
        RouletteWheel,
        StochasticUniversalSampling,
        RankBased,
    }
    public static class SelectionMethod
    {
        public static List<Individual> RouletteWheel(List<Individual> population, int numberOfParents)
        {
            Random random = new Random();
            double totalFitness = population.Sum(individual => individual.Fitness);
            return Enumerable.Range(0, numberOfParents)
                             .Select(_ =>
                             {
                                 double randomValue = random.NextDouble() * totalFitness;
                                 double cumulativeProbability = 0;

                                 foreach (Individual individual in population)
                                 {
                                     cumulativeProbability += individual.Fitness;
                                     if (cumulativeProbability >= randomValue)
                                     {
                                         return individual;
                                     }
                                 }
                                 return population.Last();
                             })
                             .ToList();
        }

        public static List<Individual> Tournament(List<Individual> individuals, int numParents)
        {
            List<Individual> selection = new List<Individual>();
            List<Individual> elites = individuals.OrderBy(individual => individual.Fitness).Take(numParents).ToList();
            return selection;
        }

        public static List<Individual> RankBasedSelection(List<Individual> population, int numberOfParents)
        {
            double totalProbability = (population.Count * (population.Count + 1)) / 2.0;
            return Enumerable.Range(0, numberOfParents)
                             .Select(_ =>
                             {
                                 double randomValue = new Random().NextDouble() * totalProbability;
                                 double cumulativeProbability = 0;

                                 foreach (Individual individual in population.OrderByDescending(x => x.Fitness))
                                 {
                                     cumulativeProbability += population.IndexOf(individual) + 1;
                                     if (cumulativeProbability >= randomValue)
                                     {
                                         return individual;
                                     }
                                 }
                                 return population.Last();
                             })
                             .ToList();
        }

        public static List<Individual> StochasticUniversalSampling(List<Individual> population, int numberOfParents)
        {
            double totalFitness = population.Sum(individual => individual.Fitness);
            double spacing = totalFitness / numberOfParents;
            double start = new Random().NextDouble() * spacing;

            double cumulativeProbability = 0;
            int index = 0;

            return Enumerable.Range(0, numberOfParents)
                             .Select(_ =>
                             {
                                 cumulativeProbability += spacing;

                                 while (cumulativeProbability > population[index].Fitness)
                                 {
                                     cumulativeProbability -= population[index].Fitness;
                                     index = (index + 1) % population.Count;
                                 }

                                 var selected = population[index];
                                 start += spacing;
                                 return selected;
                             })
                             .ToList();
        }
    }
}
