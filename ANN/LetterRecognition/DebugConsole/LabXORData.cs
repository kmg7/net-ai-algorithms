using ANNLib;

namespace DebugConsole
{
    internal static class LabXORData
    {
        public static readonly TrainingData[] DataSet = [
            new([0, 0], [0]), new([0, 1], [1]),
            new([1, 0], [1]), new([1, 1], [0]),
        ];

        public static void PrintTrainingData()
        {
            Console.WriteLine("\nXOR DATASET\n");
            Console.WriteLine("Index\tX1\tX2\tXOR\t");
            for (int i = 0; i < DataSet.Length; i++)
            {
                Console.WriteLine($"{i}\t{DataSet[i].Inputs[0]}\t{DataSet[i].Inputs[1]}\t{DataSet[i].Outputs[0]}");
            }
            Console.WriteLine();
        }

        public static NetworkModel NotTrainedModel()
        {
            Node x1 = new([0.13, -0.92], 0.34);
            Node x2 = new([0.57, -0.33], -0.12);
            Node xo1 = new([0.16, 0.75], -0.99);
            NodeLayer xHid = new([x1, x2], ActivationFunc.Sigmoid);
            NodeLayer xOut = new([xo1], ActivationFunc.Sigmoid);
            return new([xHid], xOut);
        }

        public static void PrintModelPerformance(NetworkModel model)
        {
            Console.WriteLine("Index\tPredicted\tActual");
            for (int i = 0; i < DataSet.Length; i++)
            {
                double[] inputs = DataSet[i].Inputs;
                double[] predicted = model.Run(inputs);
                Console.WriteLine($"{i}\t{predicted[0]:F4}\t\t{DataSet[i].Outputs[0]}");
            }
            Console.WriteLine();
        }
    }
}
