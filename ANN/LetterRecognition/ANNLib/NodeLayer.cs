using System.Text.Json.Serialization;

namespace ANNLib
{
    public class NodeLayer(List<Node> nodes, ActivationFunc actiFunc)
    {
        [JsonPropertyName("nodes")]
        public List<Node> Nodes { get; set; } = nodes;

        [JsonPropertyName("func"), JsonPropertyOrder(1)]
        public ActivationFunc ActiFunc { get; set; } = actiFunc;

        [JsonPropertyName("nodeCount"), JsonPropertyOrder(0)]
        public int NodeCount => Nodes.Count;

        public double[] CalculateLayer(double[] inputs)
        {
            double[] results = new double[Nodes.Count];
            for (int i = 0; i < Nodes.Count; i++)
            {
                results[i] = Nodes[i].CalculateActivation(inputs, ActiFunc);
            }
            return results;
        }

        public static NodeLayer Random(Random random, ActivationFunc actiFunc, int inputCount, int nodeCount, bool nodesHasBias = false)
        {
            var nodes = Enumerable.Range(0, nodeCount).Select(x => (Node.Random(random, inputCount, nodesHasBias)));
            return new NodeLayer([.. nodes], actiFunc);
        }
    }
}
