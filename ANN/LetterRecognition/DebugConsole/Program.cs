using ANNLib;
using DebugConsole;

Console.WriteLine("ANN Debug Console!");

LabCollisionData.PrintTrainingData();
NetworkModel colsTrainedModel = LabCollisionData.TrainedModel();
Console.WriteLine("Collision Data Trained model\n");
LabCollisionData.PrintModelPerformance(colsTrainedModel);

NetworkModel colsPoorModel = LabCollisionData.PoorModel();
Console.WriteLine("Collision Data Not Trained Poor model\n");
LabCollisionData.PrintModelPerformance(colsPoorModel);

double momentum = 0.5;
double learningRate = 0.5;
int epoch = 50;

Console.WriteLine($"Momentum: {momentum}\tLearningRate: {learningRate}\tEpoch: {epoch}");
ModelTrainer.TrainModel(LabCollisionData.DataSet, colsPoorModel, CostFunc.MeanSquaredError, epoch, momentum, learningRate);
LabCollisionData.PrintModelPerformance(colsPoorModel);

Console.WriteLine("Collision Random Model");
NetworkModel collisionRandomModel = NetworkModel.Random(4, [(32, ActivationFunc.Sigmoid, true)], (1, ActivationFunc.Sigmoid, true));
LabCollisionData.PrintModelPerformance(collisionRandomModel);

ModelTrainer.TrainModel(LabCollisionData.DataSet, collisionRandomModel, CostFunc.MeanSquaredError, epoch, momentum, learningRate);
Console.WriteLine("Collision Random Model Trained");
Console.WriteLine($"Momentum: {momentum}\tLearningRate: {learningRate}\tEpoch: {epoch}");
LabCollisionData.PrintModelPerformance(collisionRandomModel);

LabXORData.PrintTrainingData();
NetworkModel xorModel = LabXORData.NotTrainedModel();
momentum = 0.8;
learningRate = 0.5;
epoch = 5000;

Console.WriteLine("XOR model not trained yet");
LabXORData.PrintModelPerformance(xorModel);
ModelTrainer.TrainModel(LabXORData.DataSet, xorModel, CostFunc.Subtract, epoch, momentum, learningRate);

Console.WriteLine("\nXOR model trained");
Console.WriteLine($"Momentum: {momentum}\tLearningRate: {learningRate}\tEpoch: {epoch}");
LabXORData.PrintModelPerformance(xorModel);

Console.WriteLine("XOR Random Model");
NetworkModel xorRandomModel = NetworkModel.Random(2, [(2, ActivationFunc.Sigmoid, true)], (1, ActivationFunc.Sigmoid, true));
LabXORData.PrintModelPerformance(xorRandomModel);

Console.WriteLine("XOR Random Model Trained");
Console.WriteLine($"Momentum: {momentum}\tLearningRate: {learningRate}\tEpoch: {epoch}");
ModelTrainer.TrainModel(LabXORData.DataSet, xorRandomModel, CostFunc.Subtract, epoch, momentum, learningRate);

LabXORData.PrintModelPerformance(xorRandomModel);

string filePath = Path.Combine(Environment.CurrentDirectory, "data_set_letters.csv");
LabLetterRecogData.ReadTrainingDataFromCSV(filePath);
LabLetterRecogData.PrintTrainingData();

int inputCount = 35;

int hiddenNodeCount = 100;
bool hiddenNodesHasBias = true;
ActivationFunc hiddenActiFunc = ActivationFunc.Sigmoid;

int outputCount = 5;
ActivationFunc outputActiFunc = ActivationFunc.Sigmoid;
bool outputNodesHasBias = true;

NetworkModel letterModel = NetworkModel.Random(inputCount,
    [(hiddenNodeCount, hiddenActiFunc, hiddenNodesHasBias)],
    (outputCount, outputActiFunc, outputNodesHasBias)
    );

LabLetterRecogData.PrintModelPerformance(letterModel);

Console.WriteLine("Letter Recog Model Trained");
Console.WriteLine($"Momentum: {momentum}\tLearningRate: {learningRate}\tEpoch: {epoch}");
ModelTrainer.TrainModel([.. LabLetterRecogData.DataSet], letterModel, CostFunc.MeanSquaredError, epoch, momentum, learningRate);

LabLetterRecogData.PrintModelPerformance(letterModel);


