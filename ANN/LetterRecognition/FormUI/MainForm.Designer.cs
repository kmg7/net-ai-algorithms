namespace FormUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            letterMatrix1 = new LetterMatrix();
            groupBox1 = new GroupBox();
            ButtonTrain = new Button();
            TrainingEpoch = new NumericUpDown();
            TrainingMomentum = new NumericUpDown();
            TrainingLearnRate = new NumericUpDown();
            TrainCostFunc = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ButtonDataSetShow = new Button();
            ButtonDatasetParse = new Button();
            ButtonDatasetImport = new Button();
            LabelDataSetStatus = new Label();
            groupBox3 = new GroupBox();
            ButtonModelExport = new Button();
            ButtonModelImport = new Button();
            LabelModelStatus = new Label();
            groupBox4 = new GroupBox();
            Output = new NodeLayer();
            Hidden2 = new NodeLayer();
            Hidden1 = new NodeLayer();
            ButtonModelCreate = new Button();
            numericUpDown6 = new NumericUpDown();
            label9 = new Label();
            panel1 = new Panel();
            ResultConsole = new RichTextBox();
            ButtonClassify = new Button();
            ButtonConsoleClear = new Button();
            NumUDShowIndex = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrainingEpoch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrainingMomentum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrainingLearnRate).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumUDShowIndex).BeginInit();
            SuspendLayout();
            // 
            // letterMatrix1
            // 
            letterMatrix1.BackColor = SystemColors.ControlDarkDark;
            letterMatrix1.Location = new Point(153, 147);
            letterMatrix1.Name = "letterMatrix1";
            letterMatrix1.Pixels = new bool[]
    {
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false,
    false
    };
            letterMatrix1.Size = new Size(106, 175);
            letterMatrix1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(ButtonTrain);
            groupBox1.Controls.Add(TrainingEpoch);
            groupBox1.Controls.Add(TrainingMomentum);
            groupBox1.Controls.Add(TrainingLearnRate);
            groupBox1.Controls.Add(TrainCostFunc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 175);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Model Training";
            // 
            // ButtonTrain
            // 
            ButtonTrain.Location = new Point(10, 146);
            ButtonTrain.Name = "ButtonTrain";
            ButtonTrain.Size = new Size(116, 23);
            ButtonTrain.TabIndex = 8;
            ButtonTrain.Text = "Train";
            ButtonTrain.UseVisualStyleBackColor = true;
            ButtonTrain.Click += ButtonTrain_Click;
            // 
            // TrainingEpoch
            // 
            TrainingEpoch.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            TrainingEpoch.Location = new Point(78, 66);
            TrainingEpoch.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            TrainingEpoch.Name = "TrainingEpoch";
            TrainingEpoch.Size = new Size(48, 23);
            TrainingEpoch.TabIndex = 7;
            // 
            // TrainingMomentum
            // 
            TrainingMomentum.DecimalPlaces = 3;
            TrainingMomentum.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            TrainingMomentum.Location = new Point(78, 42);
            TrainingMomentum.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            TrainingMomentum.Name = "TrainingMomentum";
            TrainingMomentum.Size = new Size(48, 23);
            TrainingMomentum.TabIndex = 6;
            // 
            // TrainingLearnRate
            // 
            TrainingLearnRate.DecimalPlaces = 3;
            TrainingLearnRate.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            TrainingLearnRate.Location = new Point(78, 18);
            TrainingLearnRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            TrainingLearnRate.Name = "TrainingLearnRate";
            TrainingLearnRate.Size = new Size(48, 23);
            TrainingLearnRate.TabIndex = 5;
            // 
            // TrainCostFunc
            // 
            TrainCostFunc.FormattingEnabled = true;
            TrainCostFunc.Location = new Point(10, 111);
            TrainCostFunc.Name = "TrainCostFunc";
            TrainCostFunc.Size = new Size(116, 23);
            TrainCostFunc.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 93);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Cost Func";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Epoch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Momentum";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Learn Rate";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(NumUDShowIndex);
            groupBox2.Controls.Add(ButtonDataSetShow);
            groupBox2.Controls.Add(ButtonDatasetParse);
            groupBox2.Controls.Add(ButtonDatasetImport);
            groupBox2.Controls.Add(LabelDataSetStatus);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(94, 129);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dataset";
            // 
            // ButtonDataSetShow
            // 
            ButtonDataSetShow.Enabled = false;
            ButtonDataSetShow.Location = new Point(46, 96);
            ButtonDataSetShow.Name = "ButtonDataSetShow";
            ButtonDataSetShow.Size = new Size(37, 23);
            ButtonDataSetShow.TabIndex = 5;
            ButtonDataSetShow.Text = "Get";
            ButtonDataSetShow.UseVisualStyleBackColor = true;
            ButtonDataSetShow.Click += ButtonDataSetShow_Click;
            // 
            // ButtonDatasetParse
            // 
            ButtonDatasetParse.Enabled = false;
            ButtonDatasetParse.Location = new Point(10, 68);
            ButtonDatasetParse.Name = "ButtonDatasetParse";
            ButtonDatasetParse.Size = new Size(73, 23);
            ButtonDatasetParse.TabIndex = 4;
            ButtonDatasetParse.Text = "Parse";
            ButtonDatasetParse.UseVisualStyleBackColor = true;
            ButtonDatasetParse.Click += ButtonDatasetParse_Click;
            // 
            // ButtonDatasetImport
            // 
            ButtonDatasetImport.Location = new Point(10, 39);
            ButtonDatasetImport.Name = "ButtonDatasetImport";
            ButtonDatasetImport.Size = new Size(73, 23);
            ButtonDatasetImport.TabIndex = 3;
            ButtonDatasetImport.Text = "Import";
            ButtonDatasetImport.UseVisualStyleBackColor = true;
            ButtonDatasetImport.Click += ButtonDatasetImport_Click;
            // 
            // LabelDataSetStatus
            // 
            LabelDataSetStatus.AutoSize = true;
            LabelDataSetStatus.Location = new Point(10, 19);
            LabelDataSetStatus.Name = "LabelDataSetStatus";
            LabelDataSetStatus.Size = new Size(45, 15);
            LabelDataSetStatus.TabIndex = 1;
            LabelDataSetStatus.Text = "STATUS";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(ButtonModelExport);
            groupBox3.Controls.Add(ButtonModelImport);
            groupBox3.Controls.Add(LabelModelStatus);
            groupBox3.Location = new Point(660, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(94, 100);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Model";
            // 
            // ButtonModelExport
            // 
            ButtonModelExport.Enabled = false;
            ButtonModelExport.Location = new Point(10, 68);
            ButtonModelExport.Name = "ButtonModelExport";
            ButtonModelExport.Size = new Size(73, 23);
            ButtonModelExport.TabIndex = 6;
            ButtonModelExport.Text = "Export";
            ButtonModelExport.UseVisualStyleBackColor = true;
            ButtonModelExport.Click += ButtonModelExport_Click;
            // 
            // ButtonModelImport
            // 
            ButtonModelImport.Location = new Point(10, 39);
            ButtonModelImport.Name = "ButtonModelImport";
            ButtonModelImport.Size = new Size(73, 23);
            ButtonModelImport.TabIndex = 3;
            ButtonModelImport.Text = "Import";
            ButtonModelImport.UseVisualStyleBackColor = true;
            ButtonModelImport.Click += ButtonModelImport_Click;
            // 
            // LabelModelStatus
            // 
            LabelModelStatus.AutoSize = true;
            LabelModelStatus.Location = new Point(10, 19);
            LabelModelStatus.Name = "LabelModelStatus";
            LabelModelStatus.Size = new Size(45, 15);
            LabelModelStatus.TabIndex = 1;
            LabelModelStatus.Text = "STATUS";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Info;
            groupBox4.Controls.Add(Output);
            groupBox4.Controls.Add(Hidden2);
            groupBox4.Controls.Add(Hidden1);
            groupBox4.Controls.Add(ButtonModelCreate);
            groupBox4.Controls.Add(numericUpDown6);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(112, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(541, 129);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "New Model";
            // 
            // Output
            // 
            Output.Location = new Point(383, 24);
            Output.Name = "Output";
            Output.Size = new Size(146, 95);
            Output.TabIndex = 11;
            // 
            // Hidden2
            // 
            Hidden2.Location = new Point(231, 24);
            Hidden2.Name = "Hidden2";
            Hidden2.Size = new Size(146, 95);
            Hidden2.TabIndex = 10;
            // 
            // Hidden1
            // 
            Hidden1.Location = new Point(79, 20);
            Hidden1.Name = "Hidden1";
            Hidden1.Size = new Size(146, 99);
            Hidden1.TabIndex = 9;
            // 
            // ButtonModelCreate
            // 
            ButtonModelCreate.Location = new Point(6, 75);
            ButtonModelCreate.Name = "ButtonModelCreate";
            ButtonModelCreate.Size = new Size(67, 44);
            ButtonModelCreate.TabIndex = 8;
            ButtonModelCreate.Text = "Create";
            ButtonModelCreate.UseVisualStyleBackColor = true;
            ButtonModelCreate.Click += ButtonModelCreate_Click;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Enabled = false;
            numericUpDown6.Location = new Point(6, 38);
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(67, 23);
            numericUpDown6.TabIndex = 5;
            numericUpDown6.TextAlign = HorizontalAlignment.Right;
            numericUpDown6.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 20);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 0;
            label9.Text = "Input Node";
            // 
            // panel1
            // 
            panel1.Controls.Add(ResultConsole);
            panel1.Location = new Point(294, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 172);
            panel1.TabIndex = 8;
            // 
            // ResultConsole
            // 
            ResultConsole.Dock = DockStyle.Fill;
            ResultConsole.Location = new Point(0, 0);
            ResultConsole.Name = "ResultConsole";
            ResultConsole.Size = new Size(460, 172);
            ResultConsole.TabIndex = 0;
            ResultConsole.Text = "";
            // 
            // ButtonClassify
            // 
            ButtonClassify.Location = new Point(265, 147);
            ButtonClassify.Name = "ButtonClassify";
            ButtonClassify.Size = new Size(23, 175);
            ButtonClassify.TabIndex = 9;
            ButtonClassify.Text = "CLASSIFY";
            ButtonClassify.UseVisualStyleBackColor = true;
            ButtonClassify.Click += ButtonClassify_Click;
            // 
            // ButtonConsoleClear
            // 
            ButtonConsoleClear.Location = new Point(670, 118);
            ButtonConsoleClear.Name = "ButtonConsoleClear";
            ButtonConsoleClear.Size = new Size(73, 23);
            ButtonConsoleClear.TabIndex = 10;
            ButtonConsoleClear.Text = "Clear";
            ButtonConsoleClear.UseVisualStyleBackColor = true;
            ButtonConsoleClear.Click += ButtonConsoleClear_Click;
            // 
            // NumUDShowIndex
            // 
            NumUDShowIndex.Enabled = false;
            NumUDShowIndex.Location = new Point(10, 96);
            NumUDShowIndex.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            NumUDShowIndex.Name = "NumUDShowIndex";
            NumUDShowIndex.Size = new Size(36, 23);
            NumUDShowIndex.TabIndex = 6;
            NumUDShowIndex.TextAlign = HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 338);
            Controls.Add(ButtonConsoleClear);
            Controls.Add(ButtonClassify);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(letterMatrix1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrainingEpoch).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrainingMomentum).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrainingLearnRate).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumUDShowIndex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LetterMatrix letterMatrix1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox TrainCostFunc;
        private NumericUpDown TrainingLearnRate;
        private NumericUpDown TrainingMomentum;
        private NumericUpDown TrainingEpoch;
        private Button ButtonTrain;
        private GroupBox groupBox2;
        private Label LabelDataSetStatus;
        private Button ButtonDatasetImport;
        private Button ButtonDatasetParse;
        private GroupBox groupBox3;
        private Button ButtonModelImport;
        private Label LabelModelStatus;
        private Button ButtonModelExport;
        private GroupBox groupBox4;
        private Button ButtonModelCreate;
        private NumericUpDown numericUpDown6;
        private Label label9;
        private NodeLayer Hidden1;
        private NodeLayer Hidden2;
        private NodeLayer Output;
        private Panel panel1;
        private Button ButtonClassify;
        private Button ButtonConsoleClear;
        private RichTextBox ResultConsole;
        private Button ButtonDataSetShow;
        private NumericUpDown NumUDShowIndex;
    }
}
