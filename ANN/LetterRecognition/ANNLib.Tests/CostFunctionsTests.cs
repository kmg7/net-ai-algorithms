﻿namespace ANNLib.Tests
{
    [TestClass]
    public class CostFunctionsTests
    {
        [TestMethod]
        public void MeanSquareError_ReturnsCorrectValue()
        {
            double[] predicted = { 0.5, 0.3 };
            double[] actual = { 0.3, 0.5 };
            double expected = 0.04;

            double result = CostFunctions.MeanSquareError(predicted, actual);

            Assert.AreEqual(expected, result, 0.000001);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectValue()
        {
            double[] predicted = { 0.5 };
            double[] actual = { 0.3 };
            double expected = 0.2;

            double result = CostFunctions.Subtract(predicted, actual);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_ReturnsCorrectValue()
        {
            double[] predicted = { 0.5, 0.3 };
            double[] actual = { 0.3, 0.5 };
            CostFunc func = CostFunc.MeanSquaredError;
            double expected = 0.04;

            double result = CostFunctions.Calculate(func, predicted, actual);

            Assert.AreEqual(expected, result, 0.000001);
        }
    }
}
