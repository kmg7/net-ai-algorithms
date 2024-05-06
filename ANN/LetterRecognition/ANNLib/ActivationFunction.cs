namespace ANNLib
{
    public enum ActivationFunc
    {
        Sigmoid
    }

    public static class ActivationFunctions
    {
        public static double Calculate(ActivationFunc func, double x)
        {
            return func switch
            {
                ActivationFunc.Sigmoid => Sigmoid(x),
                _ => throw new NotImplementedException("ActivationFunc not implemented yet"),
            };
        }

        public static double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
    }
}
