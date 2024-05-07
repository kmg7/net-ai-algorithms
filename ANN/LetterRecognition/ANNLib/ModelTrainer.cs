namespace ANNLib
{
    public static class ModelTrainer
    {
        public static void TrainModel(TrainingData[] data, NetworkModel model, CostFunc costFunc, int epochs, double momentum, double learningRate)
        {
            for (int i = 0; i < epochs; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    //get the untouched weights for output nodes
                    List<double[]> outputWeigthsUpdate = [];
                    foreach (var output in model.OutputLayer.Nodes)
                    {
                        outputWeigthsUpdate.Add(output.Weights);
                    }

                    List<List<double[]>> hiddenOutputWeightsUpdate = [];
                    foreach (var layer in model.HiddenLayers)
                    {
                        List<double[]> layerWeights = [];
                        foreach (var node in layer.Nodes)
                        {
                            layerWeights.Add(node.Weights);
                        }
                        hiddenOutputWeightsUpdate.Add(layerWeights);
                    }

                    double[] netOutputs = model.Run(data[j].Inputs);// forward propagation
                    double errorCost = -CostFunctions.Calculate(costFunc, netOutputs, data[j].Outputs);

                    // between hidden layers and output layer weights
                    // updating the output layer
                    for (int k = 0; k < model.OutputLayer.Nodes.Count; k++)
                    {
                        Node outputNode = model.OutputLayer.Nodes[k];
                        NodeLayer lastHiddenLayer = model.HiddenLayers.Last();

                        double derivative = outputNode.ActivationResult * (1 - outputNode.ActivationResult);
                        double changeRate = errorCost * derivative;// derivative * errorCost
                        outputNode.LastChangeRate = changeRate;
                        for (int l = 0; l < outputNode.Weights.Length; l++)
                        {
                            // (learn rate * change rate * activation result) + momentum * actual class 
                            double updateValue = learningRate * changeRate * lastHiddenLayer.Nodes[l].ActivationResult + (momentum * outputNode.LastWeightChangeAmount[l]);
                            outputNode.LastWeightChangeAmount[l] = updateValue;
                            outputWeigthsUpdate[k][l] += updateValue;
                        }
                        //update bias
                        double biasUpdateRate = learningRate * changeRate + (momentum * outputNode.LastBiasChangeAmount);
                        outputNode.LastBiasChangeAmount = biasUpdateRate;
                        outputNode.Bias += biasUpdateRate;
                    }

                    // between hidden layer and input layer or between hidden layers
                    // updating hiddenLayers
                    for (int k = model.HiddenLayers.Count - 1; k >= 0; k--)
                    {
                        NodeLayer hiddenLayer = model.HiddenLayers[k];
                        double[] layerInputs = k == 0 ? data[j].Inputs : model.HiddenLayers[k - 1].Nodes.Select(n => n.ActivationResult).ToArray();

                        for (int l = 0; l < hiddenLayer.Nodes.Count; l++)
                        {
                            Node hiddenNode = hiddenLayer.Nodes[l];
                            NodeLayer nextLayer = k == model.HiddenLayers.Count - 1 ? model.OutputLayer : model.HiddenLayers[k + 1];

                            double derivative = hiddenNode.ActivationResult * (1 - hiddenNode.ActivationResult);
                            double nextLayerSum = 0;

                            for (int m = 0; m < nextLayer.Nodes.Count; m++)
                            {
                                nextLayerSum += nextLayer.Nodes[m].Weights[l] * nextLayer.Nodes[m].LastChangeRate;// nextLayer.Nodes[m].Weights[l] is the weight between the hidden node and the next layer node
                            }
                            double changeRate = derivative * nextLayerSum;

                            for (int m = 0; m < hiddenNode.Weights.Length; m++)
                            {
                                double updateValue = learningRate * changeRate * layerInputs[m] + (momentum * hiddenNode.LastWeightChangeAmount[m]);
                                hiddenNode.LastWeightChangeAmount[m] = updateValue;
                                hiddenOutputWeightsUpdate[k][l][m] += updateValue;
                            }
                            //update bias
                            double biasUpdateRate = learningRate * changeRate + (momentum * hiddenNode.LastBiasChangeAmount);
                            hiddenNode.LastBiasChangeAmount = biasUpdateRate;
                            hiddenNode.Bias += biasUpdateRate;
                        }
                    }
                    // update the existing output weights
                    for (int k = 0; k < model.OutputLayer.Nodes.Count; k++)
                    {
                        model.OutputLayer.Nodes[k].Weights = outputWeigthsUpdate[k];
                    }

                    for (int k = 0; k < model.HiddenLayers.Count; k++)
                    {
                        for (int l = 0; l < model.HiddenLayers[k].Nodes.Count; l++)
                        {
                            model.HiddenLayers[k].Nodes[l].Weights = hiddenOutputWeightsUpdate[k][l];
                        }
                    }
                }
            }
        }
    }
}
