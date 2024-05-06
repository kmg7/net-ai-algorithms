namespace ANNLib
{
    public class Node
    {
        public double[] Weights { get; set; }
        public double Bias { get; set; }
        public double ActivationResult { get; set; }

        public Node(double[] weights)
        {
            Weights = weights;
            Bias = 0;
        }

        public Node(double[] weights, double bias)
        {
            Weights = weights;
            Bias = bias;
        }

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
