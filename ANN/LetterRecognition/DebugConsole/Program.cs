using ANNLib;

Console.WriteLine("ANN Debug Console!");

// The model from Rishal Hurbans - Grokking Artificial Intelligence Algortihms
Node n1 = new([3.35, -5.82, 0.85, -4.35], 0);
Node n2 = new([-3.94, 4.88, -1.83, 4.21], 0);
Node n3 = new([2.43, -4.35, 0.36, -2.97], 0);
Node n4 = new([-0.58, 1.3, 0.31, 1.4], 0);
Node n5 = new([-3.34, 4.4, -0.75, 3.89], 0);

NodeLayer hidden1 = new([n1, n2, n3, n4, n5], ActivationFunc.Sigmoid);
List<NodeLayer> hiddenNodeLayers = [hidden1];

Node o1 = new([8.45, -6.96, 6.28, -1.36, -6.1], 0);// for collision
NodeLayer output = new([o1], 0);

NetworkModel goodModel = new(hiddenNodeLayers, output);

//Speed, TerrainQuality, DegreeOfVision, TotalExpreience
double[] input1 = [0.542, 0.5, 0.5, 0.2];
double[] input2 = [1, 0.1, 0.2, 0.275];

List<double[]> history = [];
history.Add(goodModel.Run(input1));
history.Add(goodModel.Run(input2));

for (int i = 0; i < history.Count; i++)
{
    Console.WriteLine($"Input[{i}] Result %{history[i][0] * 100}");
}


Console.WriteLine("----------------------------------------------------------------------------------");

TrainingData[] tdata = [
    new([0.542, 0.5, 0.5, 0.2], [0]),
    new([1, 0.1, 0.2, 0.275], [1]),
    new([0.067, 0.6 ,0.8, 0.125 ], [0]),
    new([0.417, 0.2, 0.9, 0.004  ],[1]),
    new([0.208 ,0.9 ,0.1 ,0.400 ],[0]),
    new([0.667 ,0.3, 0.3 ,0.015 ],[1]),
    new([0.333 ,0.3 ,1.0 ,1.000 ],[0]),
];
Node m1 = new([0.86, 0.22, 0.75, 0.7], 0);
Node m2 = new([0.17, 0.81, 0.19, 0.29], 0);
Node m3 = new([0.34, 0.02, 0.01, 0.76], 0);
Node m4 = new([0.27, 0.56, 0.77, 0.69], 0);
Node m5 = new([0.69, 0.81, 0.95, 0.38]);

Node o2 = new([0.62, 0.43, 0.58, 0.7, 0.11]);

NodeLayer hidden2 = new([m1, m2, m3, m4, m5], ActivationFunc.Sigmoid);
NodeLayer output2 = new([o2], ActivationFunc.Sigmoid);
NetworkModel poorModel = new([hidden2], output2);

Console.WriteLine("Index\tSpeed\tTerrain\tVision\tExprerience\tCollision");
for (int i = 0; i < tdata.Length; i++)
{
    double[] inputs = tdata[i].Inputs;
    Console.WriteLine($"{i}\t{inputs[0]}\t{inputs[1]}\t{inputs[2]}\t{inputs[3]}\t\t{tdata[i].Outputs[0]}");
}

Console.WriteLine("----------------------------------------------------------------------------------");

Console.WriteLine("\nPoor model not trained yet\n");

Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine("Index\tPredicted\tActual");
for (int i = 0; i < tdata.Length; i++)
{
    double[] inputs = tdata[i].Inputs;
    double[] predicted = poorModel.Run(inputs);
    Console.WriteLine($"{i}\t{predicted[0]:F4}\t\t{tdata[i].Outputs[0]}");
}
Console.WriteLine("----------------------------------------------------------------------------------");

ModelTrainer.TrainModel(tdata, poorModel, CostFunc.Subtract, 1, 2);

Console.WriteLine("\nPoor model trained \n");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine("Index\tPredicted\tActual");
for (int i = 0; i < tdata.Length; i++)
{
    double[] inputs = tdata[i].Inputs;
    double[] predicted = poorModel.Run(inputs);
    Console.WriteLine($"{i}\t{predicted[0]:F4}\t\t{tdata[i].Outputs[0]}");
}
Console.WriteLine("----------------------------------------------------------------------------------");

