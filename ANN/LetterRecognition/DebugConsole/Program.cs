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

NetworkModel model = new(hiddenNodeLayers, output);

//Speed, TerrainQuality, DegreeOfVision, TotalExpreience
double[] input1 = [0.542, 0.5, 0.5, 0.2];
double[] input2 = [1, 0.1, 0.2, 0.275];

List<double[]> history = [];
history.Add(model.Run(input1));
history.Add(model.Run(input2));

for (int i = 0; i < history.Count; i++)
{
    Console.WriteLine($"Input[{i}] Result %{history[i][0] * 100}");
}

Console.ReadLine();

