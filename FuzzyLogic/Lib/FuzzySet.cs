namespace Lib
{
    internal class FuzzySet
    {
        public string Name { get; set; }
        public FunctionType FunctionType { get; set; }
        public double[] Parameters { get; set; }
        public FuzzySet(string name, double[] parameters, FunctionType functionType)
        {
            Name = name;
            Parameters = parameters;
            FunctionType = functionType;
        }

        public double CalculateMembership(double value)
        {
            switch (FunctionType)
            {
                case FunctionType.Triangle:
                    return Triangle(value);
                case FunctionType.Trapezoid:
                    return Trapezoidal(value);
                default:
                    return -1;
            }
        }
        private double Triangle(double value)
        {
            // Kaufmann and Gupte 1988
            double a = Parameters[0];
            double b = Parameters[1];
            double c = Parameters[2];
            double x = value;
            if (x <= a || x >= c) return 0; // Outside the triangle
            if (x > a && x <= b) return (x - a) / (b - a); // Rising edge of the triangle
            if (x > b && x < c) return (c - x) / (c - b); // Falling edge of the triangle
            return 0; // Should never reach here
        }

        private double Trapezoidal(double value)
        {
            double a = Parameters[0];
            double b = Parameters[1];
            double c = Parameters[2];
            double d = Parameters[3];
            double x = value;
            if (x <= a || x >= d) return 0; // Outside the trapezoid
            if (x >= b && x <= c) return 1; // Inside the trapezoid
            if (x > a && x < b) return (x - a) / (b - a); // Rising edge of the trapezoid
            if (x > c && x < d) return (d - x) / (d - c); // Falling edge of the trapezoid
            return 0; // Should never reach here
        }
    }
}
