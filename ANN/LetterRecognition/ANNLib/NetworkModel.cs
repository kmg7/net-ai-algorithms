using System.Text.Json.Serialization;

namespace ANNLib
{
    public class NetworkModel(List<NodeLayer> hiddenLayers, NodeLayer outputLayer)
    {
        [JsonPropertyName("hidden")]
        public List<NodeLayer> HiddenLayers { get; set; } = hiddenLayers;

        [JsonPropertyName("output")]
        public NodeLayer OutputLayer { get; set; } = outputLayer;

        public double[] Run(double[] inputs)
        {
            double[] inputResults = HiddenLayers[0].CalculateLayer(inputs);
            List<double[]> history = [inputResults];

            for (int i = 1; i < HiddenLayers.Count; i++)
            {
                // calculate the layer output and add to the history. it will be be used in the next layer
                history.Add(HiddenLayers[i].CalculateLayer(history[i - 1]));
            }
            return OutputLayer.CalculateLayer(history.Last());
        }

        public static NetworkModel Random(
            int inputCount,
            List<(int nodeCount, ActivationFunc actifunc, bool nodesHasBias)> hiddenLayerOptions,
            (int nodeCount, ActivationFunc actiFunc, bool nodesHasBias) outputLayerOption
            )
        {
            List<NodeLayer> hiddenLayers = [];
            Random random = new();
            for (int i = 0; i < hiddenLayerOptions.Count; i++)
            {
                var (nodeCount, actifunc, nodesHasBias) = hiddenLayerOptions[i];
                int nodeInputCount = i == 0 ? inputCount : hiddenLayerOptions[i - 1].nodeCount;
                hiddenLayers.Add(NodeLayer.Random(random, actifunc, nodeInputCount, nodeCount, nodesHasBias));
            }

            var (outputNodeCount, outputActiFunc, outputNodesHasBias) = outputLayerOption;
            int outputNodeInputCount = hiddenLayerOptions.Last().nodeCount;
            NodeLayer outputLayer = NodeLayer.Random(random, outputActiFunc, outputNodeInputCount, outputNodeCount, outputNodesHasBias);

            return new(hiddenLayers, outputLayer);
        }
        public static NetworkModel Random(NetworkModelConfig config)
        {
            List<NodeLayer> hiddenLayers = [];
            Random random = new();
            for (int i = 0; i < config.Hidden.Count; i++)
            {
                NodeLayerConfig nlc = config.Hidden[i];
                int nodeInputCount = i == 0 ? config.InputCount : config.Hidden[i - 1].NodeCount;
                hiddenLayers.Add(NodeLayer.Random(random, nlc.ActivationFunction, nodeInputCount, nlc.NodeCount, nlc.NodesHasBias));
            }

            NodeLayerConfig oc = config.Output;
            int outputNodeInputCount = config.Hidden.Last().NodeCount;
            NodeLayer outputLayer = NodeLayer.Random(random, oc.ActivationFunction, outputNodeInputCount, oc.NodeCount, oc.NodesHasBias);

            return new(hiddenLayers, outputLayer);
        }
    }
}
