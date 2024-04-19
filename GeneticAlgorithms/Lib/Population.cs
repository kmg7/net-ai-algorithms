public class Population
{
    public List<Individual> Individuals { get; private set; }

    public Population(int size)
    {
        Individuals = new List<Individual>();
        InitializePopulation(size);
    }

    private void InitializePopulation(int size)
    {
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            double x = random.NextDouble() * 20 - 10; // Generate random value within [-10, 10]
            double y = random.NextDouble() * 20 - 10; // Generate random value within [-10, 10]
            Individuals.Add(new Individual(new List<double> { x, y }));
        }
    }

    public void EvaluatePopulation()
    {
        foreach (Individual individual in Individuals)
        {
            individual.Fitness = ObjectiveFunction.Evaluate(individual.Genes);
        }
    }

    public void Replace(List<Individual> offspring)
    {
        Individuals = offspring;
    }
}

