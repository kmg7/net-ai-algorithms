namespace Lib
{
    public enum MutationType
    {
        Gaussian,
        Uniform,
        Boundary
        //BitFlip,
        //Swap,
        //Inversion,
    }

    public static class MutationMethod
    {
        private static readonly Random random = new Random();

        public static void GaussianMutation(Individual individual, double mutationProbability, double mutationStrength)
        {

            for (int i = 0; i < individual.Genes.Count; i++)
            {
                if (random.NextDouble() < mutationProbability)
                {
                    double mutation = random.NextDouble() * mutationStrength;
                    if (random.NextDouble() < 0.5)
                    {
                        individual.Genes[i] += mutation;
                    }
                    else
                    {
                        individual.Genes[i] -= mutation;
                    }
                }
            }

            individual.Fitness = ObjectiveFunction.Evaluate(individual.Genes);
        }

        public static void BoundaryMutation(Individual individual, double mutationProbability, double minGeneValue, double maxGeneValue)
        {
            for (int i = 0; i < individual.Genes.Count; i++)
            {
                if (random.NextDouble() < mutationProbability)
                {
                    if (random.NextDouble() < 0.5)
                    {
                        individual.Genes[i] = minGeneValue;
                    }
                    else
                    {
                        individual.Genes[i] = maxGeneValue;
                    }
                }
            }

            individual.Fitness = ObjectiveFunction.Evaluate(individual.Genes);
        }

        public static void UniformMutation(Individual individual, double mutationProbability, double minGeneValue, double maxGeneValue)
        {

            for (int i = 0; i < individual.Genes.Count; i++)
            {
                if (random.NextDouble() < mutationProbability)
                {
                    individual.Genes[i] = random.NextDouble() * (maxGeneValue - minGeneValue) + minGeneValue;
                }
            }

            individual.Fitness = ObjectiveFunction.Evaluate(individual.Genes);
        }
    }

}
