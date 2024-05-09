namespace ANNLib
{
    public class TrainingConfig(CostFunc costFunc, int epochs, double learnRate, double momentum)
    {
        public int Epochs { get; set; } = epochs;
        public double LearnRate { get; set; } = learnRate;
        public double Momentum { get; set; } = momentum;
        public CostFunc CostFunction { get; set; } = costFunc;
    }
}
