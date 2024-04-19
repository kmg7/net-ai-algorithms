namespace Lib
{
    public class GeneticAlgorithm
    {
        private List<List<Individual>> History = [];
        private readonly int PopulationSize;
        private readonly double MutationRate;
        private readonly int MaxGenerations;
        private readonly int SelectionSize;
        private readonly double IndividualCrossoverRate;
        private readonly SelectionType Selection;
        private readonly CrossoverType Crossover;
        private readonly MutationType Mutation;
        public GeneticAlgorithm(int populationSize, double mutationRate, int maxGenerations, int selectionSize, double crossoverRate, SelectionType selectionType, CrossoverType crossoverType, MutationType mutationType)
        {
            PopulationSize = populationSize;
            MutationRate = mutationRate;
            MaxGenerations = maxGenerations;
            SelectionSize = selectionSize;
            IndividualCrossoverRate = crossoverRate;
            Selection = selectionType;
            Crossover = crossoverType;
            Mutation = mutationType;
        }

        public void Run()
        {
            // Step 1: Create Initial Population
            Population population = new Population(PopulationSize);

            // Step 2: Evaluate Initial Population
            population.EvaluatePopulation();

            // Main GA Loop
            for (int i = 0; i < MaxGenerations; i++)
            {
                // Step 3: Selection
                List<Individual> parents;
                switch (Selection)
                {
                    case SelectionType.RouletteWheel:
                        parents = SelectionMethod.RouletteWheel(population.Individuals, SelectionSize);
                        break;

                    case SelectionType.Tournament:
                        parents = SelectionMethod.Tournament(population.Individuals, SelectionSize);
                        break;

                    case SelectionType.RankBased:
                        parents = SelectionMethod.RankBasedSelection(population.Individuals, SelectionSize);
                        break;

                    case SelectionType.StochasticUniversalSampling:
                        parents = SelectionMethod.StochasticUniversalSampling(population.Individuals, SelectionSize);
                        break;

                    default:
                        parents = SelectionMethod.Tournament(population.Individuals, SelectionSize);
                        break;
                }

                // Step 4: Crossover
                List<Individual> offspring = new List<Individual>();
                switch (Crossover)
                {
                    case CrossoverType.Uniform:
                        offspring = CrossoverMethod.UniformCrossover(parents);
                        break;

                    case CrossoverType.Arithmetic:
                        offspring = CrossoverMethod.ArithmeticCrossover(parents, IndividualCrossoverRate);
                        break;

                    case CrossoverType.SinglePoint:
                        offspring = CrossoverMethod.SinglePointCrossover(parents);
                        break;

                    case CrossoverType.TwoPoint:
                        offspring = CrossoverMethod.TwoPointCrossover(parents);
                        break;

                    default:
                        offspring = CrossoverMethod.ArithmeticCrossover(parents, IndividualCrossoverRate);
                        break;
                }

                // Step 5: Evaluate Offspring
                foreach (Individual child in offspring)
                {
                    child.Fitness = ObjectiveFunction.Evaluate(child.Genes);
                }

                // Step 6: Replacement
                List<Individual> newPopulation = population.Individuals.OrderBy(individual => individual.Fitness).ToList();
                for (int j = 0; j < offspring.Count; j++)
                {
                    newPopulation[newPopulation.Count - 1 - j] = offspring[j]; // Replace the worst individuals with the offspring
                }
                population.Replace(newPopulation);


                //Step 7: Mutation over the offspring
                switch (Mutation)
                {
                    case MutationType.Gaussian:
                        foreach (Individual individual in population.Individuals)
                        {
                            MutationMethod.GaussianMutation(individual, MutationRate, 1);
                        }
                        break;

                    case MutationType.Boundary:
                        foreach (Individual individual in population.Individuals)
                        {
                            MutationMethod.BoundaryMutation(individual, MutationRate, -10, 10);
                        }
                        break;

                    case MutationType.Uniform:
                        foreach (Individual individual in population.Individuals)
                        {
                            MutationMethod.UniformMutation(individual, MutationRate, -10, 10);
                        }
                        break;

                    default:
                        foreach (Individual individual in population.Individuals)
                        {
                            MutationMethod.GaussianMutation(individual, MutationRate, 1);
                        }
                        break;
                }

                // Save the population history with the best SelectionSize individuals
                History.Add(population.Individuals.OrderBy(individual => individual.Fitness).Take(SelectionSize).ToList());
            }
        }

        public List<List<Individual>> GetResults()
        {
            return History;
        }
    }
}
