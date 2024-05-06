namespace ANNLib
{
    public class Node(double[] weights, double bias)
    {
        public double[] Weights { get; set; } = weights;
        public double Bias { get; set; } = bias;
        public double ActivationResult { get; set; }

        public double SumWeightedInputs(double[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * Weights[i];
            }
            return sum + Bias;
        }

        public double CalculateActivation(double[] inputs, ActivationFunc func)
        {
            double sum = SumWeightedInputs(inputs);
            ActivationResult = ActivationFunctions.Calculate(func, sum);
            return ActivationResult;
        }
    }
}
