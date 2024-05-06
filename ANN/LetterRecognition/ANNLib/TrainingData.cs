namespace ANNLib
{
    public class TrainingData(double[] inputs, double[] outputs)
    {
        public double[] Inputs { get; set; } = inputs;
        public double[] Outputs { get; set; } = outputs;
    }
}
