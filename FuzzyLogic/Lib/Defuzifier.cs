namespace Lib
{
    public static class Defuzifier
    {
        public static double Defuzify(FuzzyVariable variable, List<double> values, DefuzificationMethod method)
        {
            switch (method)
            {
                case DefuzificationMethod.WeightedAverage:
                    return WeightedAverage(variable, values);
                case DefuzificationMethod.Centroid:
                    return Centroid(variable);
                default:
                    throw new NotImplementedException();
            }
        }
        public static double WeightedAverage(FuzzyVariable variable, List<double> memValues)
        { // Calculate the defuzzified value using the midpoint of each set's support
            double numerator = 0;
            double denominator = 0;

            // Iterate over each fuzzy set in the variable
            for (int i = 0; i < variable.Sets.Count; i++)
            {
                int paramCount = variable.Sets[i].Parameters.Length;
                _ = paramCount - 2;
                _ = paramCount - 1;

                double firstParam = variable.Sets[i].Parameters[0];
                double lastParam = variable.Sets[i].Parameters.Last();
                double setMembership = memValues[i]; // Get the membership value for the current set
                double setMin = variable.MinValue + (variable.MaxValue - variable.MinValue) * firstParam; // Calculate the minimum value of the set's support
                double setMax = variable.MinValue + (variable.MaxValue - variable.MinValue) * lastParam; // Calculate the maximum value of the set's support
                double setCenter = (setMin + setMax) / 2; // Calculate the midpoint of the set's support

                // Update numerator and denominator
                numerator += setMembership * setCenter;
                denominator += setMembership;
            }

            // Avoid division by zero
            if (denominator == 0)
            {
                // Handle the case where all membership values are zero
                return 0;
            }

            // Return the defuzzified value
            return numerator / denominator;
        }

        public static double Centroid(FuzzyVariable variable)
        {
            double numerator = 0;
            double denominator = 0;
            foreach (FuzzySet set in variable.Sets)
            {
                int paramCount = set.Parameters.Length;
                int start = 0;
                int peak = paramCount - 2;
                int end = paramCount - 1;

                for (double i = set.Parameters[start]; i < set.Parameters[end]; i += 0.01)
                {
                    double memValue = set.CalculateCutMembership(i);
                    numerator += i * memValue;
                    denominator += memValue;
                }

            }
            return numerator / denominator;
        }
    }
}
