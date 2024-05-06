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
    }
}
