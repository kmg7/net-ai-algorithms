namespace ANNLib.Tests
{
    [TestClass]
    public class ActivationFunctionTests
    {
        [TestMethod]
        public void Sigmoid_ReturnsCorrectValue()
        {
            double x = 0.5;
            double expected = 0.6224593312018546;

            double result = ActivationFunctions.Sigmoid(x);

            Assert.AreEqual(expected, result, 1e-6);
        }

        [TestMethod]
        public void StepUnit_ReturnsCorrectValue()
        {
            double x = 1.5;
            double expected = 1;

            double result = ActivationFunctions.StepUnit(x);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HyperbolicTangent_ReturnsCorrectValue()
        {
            double x = 0.5;
            double expected = 0.46211715726000974;

            double result = ActivationFunctions.HyperbolicTangent(x);

            Assert.AreEqual(expected, result, 1e-6);
        }

        [TestMethod]
        public void ReLU_ReturnsCorrectValue()
        {
            double x = -1.5;
            double expected = 0;

            double result = ActivationFunctions.ReLU(x);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_ReturnsCorrectValue()
        {
            double x = 0.5;
            ActivationFunc func = ActivationFunc.Sigmoid;
            double expected = 0.6224593312018546;

            double result = ActivationFunctions.Calculate(func, x);

            Assert.AreEqual(expected, result, 1e-6);
        }

        [TestMethod]
        public void Derivative_ReturnsCorrectValue()
        {
            double x = 0.5;
            ActivationFunc func = ActivationFunc.Sigmoid;
            double expected = 0.2350037122015945;

            double result = ActivationFunctions.Derivative(func, x);

            Assert.AreEqual(expected, result, 1e-6);
        }
    }
}

