namespace Lib
{
    internal class FuzzySet
    {
        public string Name { get; set; }
        public FunctionType FunctionType { get; set; }
        public double[] Parameters { get; set; }

        public FuzzySet(string name, double[] parameters, FunctionType functionType)
        {
            // Error handling is still under consideration
            Name = name;
            Parameters = parameters;
            FunctionType = functionType;
        }
    }
}
