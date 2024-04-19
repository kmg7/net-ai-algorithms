namespace Lib
{
    using System;
    using System.Collections.Generic;
    public enum CrossoverType
    {
        Arithmetic,
        SinglePoint,
        TwoPoint,
        Uniform,
    }
    public static class CrossoverMethod
    {
        public readonly static Random random = new Random();
        public static List<Individual> SinglePointCrossover(List<Individual> parents)
        {
            int crossoverPoint = random.Next(0, parents[0].Genes.Count);
            List<Individual> offspring = new List<Individual>();

            for (int i = 0; i < parents.Count - 1; i += 2)
            {
                Individual parent1 = parents[i];
                Individual parent2 = parents[i + 1];

                List<double> childGenes1 = new List<double>(parent1.Genes.GetRange(0, crossoverPoint));
                childGenes1.AddRange(parent2.Genes.GetRange(crossoverPoint, parent2.Genes.Count - crossoverPoint));

                List<double> childGenes2 = new List<double>(parent2.Genes.GetRange(0, crossoverPoint));
                childGenes2.AddRange(parent1.Genes.GetRange(crossoverPoint, parent1.Genes.Count - crossoverPoint));

                offspring.Add(new Individual(childGenes1));
                offspring.Add(new Individual(childGenes2));
            }

            return offspring;
        }

        public static List<Individual> TwoPointCrossover(List<Individual> parents)
        {
            int crossoverPoint1 = random.Next(0, parents[0].Genes.Count);
            int crossoverPoint2 = random.Next(crossoverPoint1 + 1, parents[0].Genes.Count);
            List<Individual> offspring = new List<Individual>();

            for (int i = 0; i < parents.Count - 1; i += 2)
            {
                Individual parent1 = parents[i];
                Individual parent2 = parents[i + 1];

                List<double> childGenes1 = new List<double>(parent1.Genes.GetRange(0, crossoverPoint1));
                childGenes1.AddRange(parent2.Genes.GetRange(crossoverPoint1, crossoverPoint2 - crossoverPoint1));
                childGenes1.AddRange(parent1.Genes.GetRange(crossoverPoint2, parent1.Genes.Count - crossoverPoint2));

                List<double> childGenes2 = new List<double>(parent2.Genes.GetRange(0, crossoverPoint1));
                childGenes2.AddRange(parent1.Genes.GetRange(crossoverPoint1, crossoverPoint2 - crossoverPoint1));
                childGenes2.AddRange(parent2.Genes.GetRange(crossoverPoint2, parent2.Genes.Count - crossoverPoint2));

                offspring.Add(new Individual(childGenes1));
                offspring.Add(new Individual(childGenes2));
            }

            return offspring;
        }

        public static List<Individual> UniformCrossover(List<Individual> parents)
        {
            List<Individual> offspring = new List<Individual>();

            for (int i = 0; i < parents.Count - 1; i += 2)
            {
                Individual parent1 = parents[i];
                Individual parent2 = parents[i + 1];

                List<double> childGenes1 = new List<double>();
                List<double> childGenes2 = new List<double>();

                for (int j = 0; j < parent1.Genes.Count; j++)
                {
                    if (random.NextDouble() < 0.5)
                    {
                        childGenes1.Add(parent1.Genes[j]);
                        childGenes2.Add(parent2.Genes[j]);
                    }
                    else
                    {
                        childGenes1.Add(parent2.Genes[j]);
                        childGenes2.Add(parent1.Genes[j]);
                    }
                }

                offspring.Add(new Individual(childGenes1));
                offspring.Add(new Individual(childGenes2));
            }

            return offspring;
        }

        public static List<Individual> ArithmeticCrossover(List<Individual> parents, double alpha)
        {
            List<Individual> offspring = new List<Individual>();

            for (int i = 0; i < parents.Count - 1; i += 2)
            {
                Individual parent1 = parents[i];
                Individual parent2 = parents[i + 1];

                List<double> childGenes1 = new List<double>();
                List<double> childGenes2 = new List<double>();

                for (int j = 0; j < parent1.Genes.Count; j++)
                {
                    double gene1 = parent1.Genes[j];
                    double gene2 = parent2.Genes[j];

                    double minGene = Math.Min(gene1, gene2);
                    double maxGene = Math.Max(gene1, gene2);

                    double range = maxGene - minGene;

                    double rand = random.NextDouble();

                    double childGene1 = gene1 - alpha * rand * range;
                    double childGene2 = gene2 + alpha * rand * range;

                    childGenes1.Add(childGene1);
                    childGenes2.Add(childGene2);
                }

                offspring.Add(new Individual(childGenes1));
                offspring.Add(new Individual(childGenes2));
            }

            return offspring;
        }
    }

}
