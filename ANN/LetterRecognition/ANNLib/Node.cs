﻿using System.Text.Json.Serialization;

namespace ANNLib
{
    public class Node
    {
        [JsonPropertyName("b")]
        public double Bias { get; set; }

        [JsonPropertyName("w")]
        public double[] Weights { get; set; }

        [JsonIgnore]
        public double ActivationResult { get; set; }

        [JsonIgnore]
        public double[] LastWeightChangeAmount { get; set; }

        [JsonIgnore]
        public double LastBiasChangeAmount { get; set; }

        [JsonIgnore]
        public double LastChangeRate { get; set; }

        public Node(double[] weights)
        {
            Weights = weights;
            Bias = 0;
            LastWeightChangeAmount = new double[weights.Length];
        }

        [JsonConstructor]
        public Node(double[] weights, double bias)
        {
            Weights = weights;
            Bias = bias;
            LastWeightChangeAmount = new double[weights.Length];
        }

        public Node(double[] weights, double bias, double lastBiasChange, double[] lastWeightChange)
        {
            Weights = weights;
            Bias = bias;
            LastBiasChangeAmount = lastBiasChange;
            LastWeightChangeAmount = lastWeightChange;
        }

        public static Node Random(Random random, int inputCount, bool hasBias = false)
        {
            double bias = 0;
            if (hasBias)
            {
                bias = (random.NextDouble() * 2) - 1;
            }

            double[] weights = Enumerable.Range(0, inputCount).Select(x => (random.NextDouble() * 2) - 1).ToArray();
            return new(weights, bias);
        }

        public double SumWeightedInputs(double[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * Weights[i];
            }
            return sum + Bias;
        }

        public double CalculateActivation(double[] inputs, ActivationFunc func)
        {
            double sum = SumWeightedInputs(inputs);
            ActivationResult = ActivationFunctions.Calculate(func, sum);
            return ActivationResult;
        }
    }
}
