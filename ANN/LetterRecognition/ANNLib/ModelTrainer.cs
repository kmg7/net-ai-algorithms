namespace ANNLib
{
    public static class ModelTrainer
    {
        public static void TrainModel(TrainingData[] data, NetworkModel model, CostFunc costFunc, int epochs, double learningRate)
        {
            for (int i = 0; i < epochs; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    double[] predicted = model.Run(data[j].Inputs);// forward propagation
                    double cost = CostFunctions.Calculate(costFunc, predicted, data[j].Outputs);

                    foreach (var layer in model.HiddenLayers)
                    {
                        foreach (var node in layer.Nodes)
                        {
                            for (int k = 0; k < node.Weights.Length; k++)
                            {
                                double update = -learningRate * data[j].Inputs[k] * node.ActivationResult;
                                node.Weights[k] += update;
                            }
                        }
                    }
                }
            }
        }
    }
}
