public static class ObjectiveFunction
{
    public static double Evaluate(List<double> genes)
    {
        double x = genes[0];
        double y = genes[1];
        double term1 = Math.Pow(Math.Sin(3 * Math.PI * x), 2);
        double term2 = Math.Pow(x - 1, 2) * (1 + Math.Pow(Math.Sin(3 * Math.PI * y), 2));
        double term3 = Math.Pow(y - 1, 2) * (1 + Math.Pow(Math.Sin(2 * Math.PI * y), 2));
        return term1 + term2 + term3;
    }
}
