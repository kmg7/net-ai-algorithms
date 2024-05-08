using ANNLib;

namespace DebugConsole
{
    internal static class LabCollisionData
    {
        // The data for ANN from Rishal Hurbans - Grokking Artificial Intelligence Algortihms
        public static readonly TrainingData[] DataSet = [
            new([0.542, 0.5, 0.5, 0.2], [0]),
            new([1, 0.1, 0.2, 0.275], [1]),
            new([0.067, 0.6 ,0.8, 0.125 ], [0]),
            new([0.417, 0.2, 0.9, 0.004  ],[1]),
            new([0.208 ,0.9 ,0.1 ,0.400 ],[0]),
            new([0.667 ,0.3, 0.3 ,0.015 ],[1]),
            new([0.333 ,0.3 ,1.0 ,1.000 ],[0]),
        ];

        public static void PrintTrainingData()
        {
            Console.WriteLine("\nCollision Data\n");
            Console.WriteLine("Index\tSpeed\tTerrain\tVision\tExprerience\tCollision");
            for (int i = 0; i < DataSet.Length; i++)
            {
                Console.WriteLine($"{i}\t{DataSet[i].Inputs[0]}\t{DataSet[i].Inputs[1]}\t{DataSet[i].Inputs[2]}\t{DataSet[i].Inputs[3]}\t\t{DataSet[i].Outputs[0]}");
            }
            Console.WriteLine();
        }

        public static NetworkModel TrainedModel()
        {
            // The model from Rishal Hurbans - Grokking Artificial Intelligence Algortihms
            Node n1 = new([3.35, -5.82, 0.85, -4.35], 0);
            Node n2 = new([-3.94, 4.88, -1.83, 4.21], 0);
            Node n3 = new([2.43, -4.35, 0.36, -2.97], 0);
            Node n4 = new([-0.58, 1.3, 0.31, 1.4], 0);
            Node n5 = new([-3.34, 4.4, -0.75, 3.89], 0);

            Node o1 = new([8.45, -6.96, 6.28, -1.36, -6.1], 0);// for collision

            NodeLayer hidden = new([n1, n2, n3, n4, n5], ActivationFunc.Sigmoid);
            NodeLayer output = new([o1], 0);

            return new([hidden], output);
        }

        public static NetworkModel PoorModel()
        {
            Node m1 = new([0.86, 0.22, 0.75, 0.7], 0);
            Node m2 = new([0.17, 0.81, 0.19, 0.29], 0);
            Node m3 = new([0.34, 0.02, 0.01, 0.76], 0);
            Node m4 = new([0.27, 0.56, 0.77, 0.69], 0);
            Node m5 = new([0.69, 0.81, 0.95, 0.38]);

            Node o2 = new([0.62, 0.43, 0.58, 0.7, 0.11]);

            NodeLayer hidden = new([m1, m2, m3, m4, m5], ActivationFunc.Sigmoid);
            NodeLayer output = new([o2], ActivationFunc.Sigmoid);

            return new([hidden], output);
        }

        public static void PrintModelPerformance(NetworkModel model)
        {
            Console.WriteLine("Index\tPredicted\tActual");
            for (int i = 0; i < DataSet.Length; i++)
            {
                double[] predicted = model.Run(DataSet[i].Inputs);
                Console.WriteLine($"{i}\t{predicted[0]:F4}\t\t{DataSet[i].Outputs[0]}");
            }
            Console.WriteLine();
        }
    }
}
