namespace ANNLib
{

    public enum CostFunc
    {
        Subtract,
        MeanSquaredError,
        MeanAbsoluteError,
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
                CostFunc.MeanAbsoluteError => MeanAbsoulteError(predicted, actual),
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
            double sum = 0;
            for (int i = 0; i < predicted.Length; i++)
            {
                sum += Math.Pow(predicted[i] - actual[i], 2);
            }
            return sum / predicted.Length; // Divide by the length of the array to calculate the mean
        }

        public static double MeanAbsoulteError(double[] predicted, double[] actual)
        {
            double sum = 0;
            for (int i = 0; i < predicted.Length; i++)
            {
                sum += Math.Abs(predicted[i] - actual[i]);
            }
            return sum / predicted.Length;
        }
    }
}
