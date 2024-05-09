namespace FormUI
{
    partial class NodeLayer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            InitBias = new ComboBox();
            NodeCount = new NumericUpDown();
            ActiFunc = new ComboBox();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NodeCount).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label10);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(InitBias);
            groupBox.Controls.Add(NodeCount);
            groupBox.Controls.Add(ActiFunc);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(146, 110);
            groupBox.TabIndex = 10;
            groupBox.TabStop = false;
            groupBox.Text = "Node Layer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 46);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 10;
            label10.Text = "Func";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 70);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 9;
            label7.Text = "Initial Bias";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 8;
            label6.Text = "Node";
            // 
            // InitBias
            // 
            InitBias.FormattingEnabled = true;
            InitBias.Items.AddRange(new object[] { "Yes", "No" });
            InitBias.Location = new Point(72, 67);
            InitBias.Name = "InitBias";
            InitBias.Size = new Size(59, 23);
            InitBias.TabIndex = 7;
            // 
            // NodeCount
            // 
            NodeCount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            NodeCount.Location = new Point(48, 17);
            NodeCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NodeCount.Name = "NodeCount";
            NodeCount.Size = new Size(83, 23);
            NodeCount.TabIndex = 6;
            // 
            // ActiFunc
            // 
            ActiFunc.FormattingEnabled = true;
            ActiFunc.Location = new Point(48, 43);
            ActiFunc.Name = "ActiFunc";
            ActiFunc.Size = new Size(83, 23);
            ActiFunc.TabIndex = 4;
            // 
            // NodeLayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "NodeLayer";
            Size = new Size(146, 110);
            Load += HiddenLayerControl_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NodeCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label label10;
        private Label label7;
        private Label label6;
        private ComboBox InitBias;
        private NumericUpDown NodeCount;
        private ComboBox ActiFunc;
    }
}
