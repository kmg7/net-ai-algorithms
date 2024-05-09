namespace ANNLib
{
    public class NetworkModelConfig(int inputCount, List<NodeLayerConfig> hidden, NodeLayerConfig output)
    {
        public int InputCount { get; set; } = inputCount;
        public List<NodeLayerConfig> Hidden { get; set; } = hidden;
        public NodeLayerConfig Output { get; set; } = output;
    }
}
