public class Individual
{
    public List<double> Genes { get; set; }
    public double Fitness { get; set; }

    public Individual(List<double> genes)
    {
        Genes = genes;
        Fitness = ObjectiveFunction.Evaluate(genes);
    }
}
