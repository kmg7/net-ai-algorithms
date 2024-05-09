namespace ANNLib
{
    public enum ActivationFunc
    {
        Sigmoid,
        StepUnit,
        HyperbolicTangent,
        ReLU
    }

    public static class ActivationFunctions
    {
        public static double Calculate(ActivationFunc func, double x)
        {
            return func switch
            {
                ActivationFunc.Sigmoid => Sigmoid(x),
                ActivationFunc.StepUnit => StepUnit(x),
                ActivationFunc.HyperbolicTangent => HyperbolicTangent(x),
                ActivationFunc.ReLU => ReLU(x),
                _ => throw new NotImplementedException("ActivationFunc not implemented yet"),
            };
        }

        public static double Derivative(ActivationFunc func, double x)
        {
            return Calculate(func, x) * (1 - Calculate(func, x));
        }

        public static double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        public static double StepUnit(double x)
        {
            return x >= 0 ? 1 : 0;
        }

        public static double HyperbolicTangent(double x)
        {
            return Math.Tanh(x);
        }

        public static double ReLU(double x)
        {
            return x >= 0 ? x : 0;
        }
    }
}
