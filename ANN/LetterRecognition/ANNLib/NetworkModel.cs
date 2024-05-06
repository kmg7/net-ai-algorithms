namespace ANNLib
{
    public class NetworkModel(List<NodeLayer> hidden, NodeLayer output)
    {
        public List<NodeLayer> HiddenLayers { get; set; } = hidden;
        public NodeLayer OutputLayer { get; set; } = output;

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
    }
}
