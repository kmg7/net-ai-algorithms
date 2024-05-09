using ANNLib;

namespace FormUI
{
    public partial class NodeLayer : UserControl
    {
        public NodeLayer()
        {
            InitializeComponent();
        }

        private void HiddenLayerControl_Load(object sender, EventArgs e)
        {
            InitBias.SelectedIndex = 0;
            ActiFunc.DataSource = Enum.GetValues(typeof(ActivationFunc));
            Refresh();
        }

        public (int nodes, ActivationFunc func, bool initBias) GetLayerConfig()
        {
            return ((int)NodeCount.Value, (ActivationFunc)ActiFunc.SelectedItem, InitBias.SelectedIndex == 0);
        }
    }
}
