using ANNLib;
using System.Text;

namespace DebugConsole
{
    internal static class LabLetterRecogData
    {
        public static List<TrainingData> DataSet = [];
        public static void ReadTrainingDataFromCSV(string path)
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
            DataSet = dataSet;
        }

        public static void PrintTrainingData()
        {
            string[] letters = ["A", "B", "C", "D", "E"];
            Console.WriteLine("\nLetter Recognition Data\n");
            for (int i = 0; i < letters.Length; i++)
            {
                //Console.WriteLine($"Inputs: {string.Join(", ", item.Inputs)}");
                Console.WriteLine($"Letter: [{letters[i]}] Outputs: {string.Join(", ", DataSet[i].Outputs)}");
            }
            Console.WriteLine();
        }

        public static void PrintModelPerformance(NetworkModel model)
        {
            Console.WriteLine("Index\tPredicted\tActual");
            for (int i = 0; i < DataSet.Count; i++)
            {
                double[] predicted = model.Run(DataSet[i].Inputs);
                StringBuilder pred_s = new();
                foreach (var p in predicted)
                {
                    pred_s.Append($"{p:F4} ");
                }
                StringBuilder outp_s = new();
                foreach (var o in DataSet[i].Outputs)
                {
                    outp_s.Append($"{o} ");
                }
                Console.WriteLine($"{i}\t{pred_s}\t{outp_s}");
            }
        }

    }
}
