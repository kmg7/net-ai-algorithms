namespace ANNLib
{
    public class NodeLayerConfig(int nodeCount, ActivationFunc actifunc, bool nodesHasBias)
    {
        public int NodeCount { get; set; } = nodeCount;
        public ActivationFunc ActivationFunction { get; set; } = actifunc;
        public bool NodesHasBias { get; set; } = nodesHasBias;
    }
}
