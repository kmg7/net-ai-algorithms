using ANNLib;

namespace FormUI
{
    public static class RecognitionEngine
    {
        public static NetworkModel RandomModel(NetworkModelConfig config)
        {
            return NetworkModel.Random(config);
        }
        public static void TrainModel(NetworkModel model, TrainingData[] data, TrainingConfig config)
        {
            ModelTrainer.TrainModel(data, model, config.CostFunction, config.Epochs, config.Momentum, config.LearnRate);
        }

        public static double[] ClassifyModel(NetworkModel model, double[] input)
        {
            return model.Run(input);
        }

        public static List<TrainingData> ReadDataSetFromFile(string path)
        {
            List<TrainingData> dataSet = [];
            string[] rows = File.ReadAllLines(path);
            for (int i = 1; i < rows.Length; i++)
            {
                string[] columns = rows[i].Split(',');
                List<double> inputs = [];
                for (int j = 0; j < columns.Length - 1; j++)
                {
                    string[] str = columns[j].Split(" ");
                    inputs.AddRange(columns[j].Split(' ').Select(x => double.Parse(x)));
                }
                double[] outputs = columns.Last().Split(' ').Select(x => double.Parse(x)).ToArray();
                dataSet.Add(new TrainingData([.. inputs], outputs));
            }
            return dataSet;
        }
    }
}
