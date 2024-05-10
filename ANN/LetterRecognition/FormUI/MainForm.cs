using ANNLib;
using System.Text;
using System.Text.Json;

namespace FormUI
{
    public partial class MainForm : Form
    {
        private string? SelectedFilePath { get; set; }
        private NetworkModel? Model { get; set; }
        private TrainingData[]? TrainingData { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDataSetStatus();
            UpdateModelStatus();
            TrainCostFunc.DataSource = Enum.GetValues(typeof(CostFunc));
            ConsoleWriteLine("Letter recoginiton for A-B-C-D-E letters");
        }

        private void ButtonDatasetImport_Click(object sender, EventArgs e)
        {
            // open the file select dialog and get the path of the file select only csv files
            OpenFileDialog fileDialog = new()
            {
                Filter = "CSV Files|*.csv"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFilePath = fileDialog.FileName;
                UpdateDataSetStatus();
                ConsoleWriteLine("Dataset file selected");
            }
        }

        private void UpdateDataSetStatus()
        {
            if (SelectedFilePath == null)
            {
                LabelDataSetStatus.Text = "Not Imported";
                ButtonDatasetParse.Enabled = false;
                return;
            }
            ButtonDatasetParse.Enabled = true;
            LabelDataSetStatus.Text = "Imported";
        }
        private void UpdateModelStatus()
        {
            if (Model == null)
            {
                LabelModelStatus.Text = "Not Ready";
                ButtonModelExport.Enabled = false;
                return;
            }
            ButtonModelExport.Enabled = true;
            LabelModelStatus.Text = "Ready";
        }

        private void ButtonDatasetParse_Click(object sender, EventArgs e)
        {
            if (SelectedFilePath == null)
            {
                UpdateDataSetStatus();
                return;
            }
            try
            {
                TrainingData = [.. RecognitionEngine.ReadDataSetFromFile(SelectedFilePath)];
                ButtonDatasetParse.Enabled = false;
                LabelDataSetStatus.Text = "Ready";
                PrintTrainingData();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }

        private void ButtonTrain_Click(object sender, EventArgs e)
        {
            if (TrainingData == null)
            {
                _ = MessageBox.Show("Dataset not ready");
                return;
            }
            if (Model == null)
            {
                _ = MessageBox.Show("Model not ready");
                return;
            }
            if (!TrainingConfigAreValid()) return;
            try
            {
                TrainingConfig cfg = new((CostFunc)TrainCostFunc.SelectedItem, (int)TrainingEpoch.Value,
                    (double)TrainingLearnRate.Value, (double)TrainingMomentum.Value);
                RecognitionEngine.TrainModel(Model, TrainingData, cfg);
                ConsoleWriteLine("Training Completed");
                PrintModelPerformance();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }
        private bool TrainingConfigAreValid()
        {
            // validate the training config values
            if (TrainCostFunc.SelectedItem == null)
            {
                _ = MessageBox.Show("Cost Function not selected");
                return false;
            }
            if (TrainingEpoch.Value == 0)
            {
                _ = MessageBox.Show("Epochs must be greater than 0");
                return false;
            }
            if (TrainingLearnRate.Value == 0)
            {
                _ = MessageBox.Show("Learning Rate must be greater than 0");
                return false;
            }
            if (TrainingMomentum.Value == 0)
            {
                _ = MessageBox.Show("Momentum must be greater than 0");
                return false;
            }
            return true;
        }

        private void ButtonModelCreate_Click(object sender, EventArgs e)
        {
            if (Model != null)
            {
                DialogResult answer = MessageBox.Show("Model already exists, do you want to overwrite it?", "Warning", MessageBoxButtons.YesNo);
                if (answer != DialogResult.Yes)
                {
                    return;
                }
            }
            try
            {
                var (nodes, actiFunc, initBias) = Hidden1.GetLayerConfig();
                if (nodes == 0)
                {
                    _ = MessageBox.Show("First hidden layer cannot be empty");
                }
                List<NodeLayerConfig> hiddenLayers = [new(nodes, actiFunc, initBias)];

                (nodes, actiFunc, initBias) = Hidden2.GetLayerConfig();
                if (nodes != 0)
                {
                    hiddenLayers.Add(new(nodes, actiFunc, initBias));
                }

                (_, actiFunc, initBias) = Output.GetLayerConfig();

                NetworkModelConfig cfg = new(35, hiddenLayers, new(5, actiFunc, initBias));
                Model = RecognitionEngine.RandomModel(cfg);
                UpdateModelStatus();
                PrintModelPerformance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClassify_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                _ = MessageBox.Show("Model not ready");
                return;
            }
            try
            {
                var values = letterMatrix1.GetPixels();
                double[] predictions = RecognitionEngine.ClassifyModel(Model, Array.ConvertAll(values, (x => (double)x)));
                StringBuilder pred_s = new();
                foreach (var p in predictions)
                {
                    pred_s.Append($"{p:F4}\t");
                }
                ConsoleWriteLine($"Predictions");
                ConsoleWriteLine("A\tB\tC\tD\tE");
                ConsoleWriteLine(pred_s.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConsoleWriteLine(string msg)
        {
            ResultConsole.Text += msg + "\n";
            ResultConsole.Refresh();
        }
        private void ConsoleClear()
        {
            ResultConsole.Text = "";
            ResultConsole.Refresh();
        }

        public void PrintTrainingData()
        {
            if (TrainingData == null)
            {
                return;
            }
            string[] letters = ["A", "B", "C", "D", "E"];
            ConsoleWriteLine("Letter Recognition Data");
            for (int i = 0; i < letters.Length; i++)
            {
                //Console.WriteLine($"Inputs: {string.Join(", ", item.Inputs)}");
                ConsoleWriteLine($"Letter: [{letters[i]}] Outputs: {string.Join(", ", TrainingData[i].Outputs)}");
            }
            ConsoleWriteLine("");
        }

        private void PrintModelPerformance()
        {
            if (TrainingData == null || Model == null)
            {
                return;
            }
            ConsoleWriteLine("Index\tPredicted\t\t\tActual");
            for (int i = 0; i < TrainingData.Length; i++)
            {
                double[] predicted = Model.Run(TrainingData[i].Inputs);
                StringBuilder pred_s = new();
                foreach (var p in predicted)
                {
                    pred_s.Append($"{p:F4} ");
                }
                StringBuilder outp_s = new();
                foreach (var o in TrainingData[i].Outputs)
                {
                    outp_s.Append($"{o} ");
                }
                ConsoleWriteLine($"{i}\t{pred_s}\t{outp_s}");
            }
        }

        private void ButtonConsoleClear_Click(object sender, EventArgs e)
        {
            ConsoleClear();
        }

        private void ButtonModelExport_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(Model);
            // save json to file open a new file dialog
            SaveFileDialog fileDialog = new()
            {
                Filter = "JSON Files|*.json"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fileDialog.FileName, json);
                ConsoleWriteLine("Model exported to file");
            }
        }

        private void ButtonModelImport_Click(object sender, EventArgs e)
        {
            //open a file dialog and parse json model to model if all goes ok change the model and model status

            if (Model != null)
            {
                DialogResult answer = MessageBox.Show("Model already exists, do you want to overwrite it?", "Warning", MessageBoxButtons.YesNo);
                if (answer != DialogResult.Yes)
                {
                    return;
                }
            }
            OpenFileDialog fileDialog = new()
            {
                Filter = "JSON Files|*.json"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(fileDialog.FileName);
                    Model = JsonSerializer.Deserialize<NetworkModel>(json);
                    UpdateModelStatus();
                    ConsoleWriteLine("Model imported from file");
                    PrintModelPerformance();
                }
                catch (Exception ex)
                {
                    //_ = MessageBox.Show(ex.Message);
                    throw ex;
                }
            }
        }
    }
}
