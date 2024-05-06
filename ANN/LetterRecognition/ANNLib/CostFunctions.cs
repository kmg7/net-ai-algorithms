namespace ANNLib
{

    public enum CostFunc
    {
        Subtract,
        MeanSquaredError
    }

    public static class CostFunctions
    {
        /// <summary>
        /// Use subtract only when the output layer has a single node (CRITICAL).
        /// </summary>
        public static double Calculate(CostFunc func, double[] predicted, double[] actual)
        {
            return func switch
            {
                CostFunc.Subtract => Subtract(predicted, actual),
                CostFunc.MeanSquaredError => MeanSquareError(predicted, actual),
                _ => throw new NotImplementedException("CostFunc not implemented yet"),
            };
        }

        // Use this cost function only when the output layer has a single node
        public static double Subtract(double[] predicted, double[] actual)
        {
            return predicted[0] - actual[0];
        }

        public static double MeanSquareError(double[] predicted, double[] actual)
        {
            return predicted.Zip(actual, (p, a) => Math.Pow(p - a, 2)).Sum();
        }
    }
}
