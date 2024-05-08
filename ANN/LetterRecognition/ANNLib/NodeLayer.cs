namespace ANNLib
{
    public class NodeLayer(List<Node> nodes, ActivationFunc actiFunc)
    {
        public List<Node> Nodes { get; set; } = nodes;
        public ActivationFunc ActiFunc { get; set; } = actiFunc;

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
