namespace UIForm
{
    partial class Form1
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
            btnRun = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tBPopulationSize = new TextBox();
            tbCrossoverVal = new TextBox();
            tBMutationRate = new TextBox();
            tBElitismRate = new TextBox();
            tBGenerationSize = new TextBox();
            pictureBox1 = new PictureBox();
            chartPaneBig = new Panel();
            lblBest = new Label();
            groupBox1 = new GroupBox();
            comboBoxMutation = new ComboBox();
            label9 = new Label();
            comboBoxCrossover = new ComboBox();
            label8 = new Label();
            comboBoxSelection = new ComboBox();
            label1 = new Label();
            lblBestX = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            lblBestF = new Label();
            label10 = new Label();
            lblBestY = new Label();
            chartPaneSmall = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(224, 375);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(118, 45);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRunClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 4;
            label2.Text = "Populasyon Boyutu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 49);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 5;
            label3.Text = "Caprazlama Orani";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 6;
            label4.Text = "Mutasyon Orani";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 136);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 7;
            label5.Text = "Seckinlik Adedi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 78);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 8;
            label6.Text = "Jenerasyon Sayisi";
            // 
            // tBPopulationSize
            // 
            tBPopulationSize.Location = new Point(131, 16);
            tBPopulationSize.Name = "tBPopulationSize";
            tBPopulationSize.Size = new Size(61, 23);
            tBPopulationSize.TabIndex = 9;
            tBPopulationSize.Text = "1000";
            // 
            // tbCrossoverVal
            // 
            tbCrossoverVal.Location = new Point(131, 46);
            tbCrossoverVal.Name = "tbCrossoverVal";
            tbCrossoverVal.Size = new Size(61, 23);
            tbCrossoverVal.TabIndex = 10;
            tbCrossoverVal.Text = "0.08";
            // 
            // tBMutationRate
            // 
            tBMutationRate.Location = new Point(131, 104);
            tBMutationRate.Name = "tBMutationRate";
            tBMutationRate.Size = new Size(61, 23);
            tBMutationRate.TabIndex = 11;
            tBMutationRate.Text = "0.01";
            // 
            // tBElitismRate
            // 
            tBElitismRate.Location = new Point(131, 133);
            tBElitismRate.Name = "tBElitismRate";
            tBElitismRate.Size = new Size(61, 23);
            tBElitismRate.TabIndex = 12;
            tBElitismRate.Text = "30";
            // 
            // tBGenerationSize
            // 
            tBGenerationSize.Location = new Point(131, 75);
            tBGenerationSize.Name = "tBGenerationSize";
            tBGenerationSize.Size = new Size(61, 23);
            tBGenerationSize.TabIndex = 13;
            tBGenerationSize.Text = "1000";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.assgmnt;
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // chartPaneBig
            // 
            chartPaneBig.Location = new Point(374, 20);
            chartPaneBig.Name = "chartPaneBig";
            chartPaneBig.Size = new Size(600, 200);
            chartPaneBig.TabIndex = 15;
            // 
            // lblBest
            // 
            lblBest.AutoSize = true;
            lblBest.Location = new Point(6, 25);
            lblBest.Name = "lblBest";
            lblBest.Size = new Size(14, 15);
            lblBest.TabIndex = 16;
            lblBest.Text = "X";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(comboBoxMutation);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBoxCrossover);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBoxSelection);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tBGenerationSize);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tBElitismRate);
            groupBox1.Controls.Add(tBPopulationSize);
            groupBox1.Controls.Add(tBMutationRate);
            groupBox1.Controls.Add(tbCrossoverVal);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 315);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametreler";
            // 
            // comboBoxMutation
            // 
            comboBoxMutation.FormattingEnabled = true;
            comboBoxMutation.Location = new Point(6, 276);
            comboBoxMutation.Name = "comboBoxMutation";
            comboBoxMutation.Size = new Size(185, 23);
            comboBoxMutation.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 258);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 20;
            label9.Text = "Mutasyon Yontemi";
            // 
            // comboBoxCrossover
            // 
            comboBoxCrossover.FormattingEnabled = true;
            comboBoxCrossover.Location = new Point(7, 229);
            comboBoxCrossover.Name = "comboBoxCrossover";
            comboBoxCrossover.Size = new Size(185, 23);
            comboBoxCrossover.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 211);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 18;
            label8.Text = "Caprazlama Yontemi";
            // 
            // comboBoxSelection
            // 
            comboBoxSelection.FormattingEnabled = true;
            comboBoxSelection.Location = new Point(7, 183);
            comboBoxSelection.Name = "comboBoxSelection";
            comboBoxSelection.Size = new Size(185, 23);
            comboBoxSelection.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 165);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 16;
            label1.Text = "Seckinlik Yontemi";
            // 
            // lblBestX
            // 
            lblBestX.AutoSize = true;
            lblBestX.Location = new Point(6, 45);
            lblBestX.Name = "lblBestX";
            lblBestX.Size = new Size(39, 15);
            lblBestX.TabIndex = 18;
            lblBestX.Text = "X_VAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 75);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 19;
            label7.Text = "Y";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBestF);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lblBestY);
            groupBox2.Controls.Add(lblBest);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblBestX);
            groupBox2.Location = new Point(223, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(118, 164);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "En Iyi Cozum";
            // 
            // lblBestF
            // 
            lblBestF.AutoSize = true;
            lblBestF.Location = new Point(7, 145);
            lblBestF.Name = "lblBestF";
            lblBestF.Size = new Size(38, 15);
            lblBestF.TabIndex = 22;
            lblBestF.Text = "F_VAL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 125);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 21;
            label10.Text = "F";
            // 
            // lblBestY
            // 
            lblBestY.AutoSize = true;
            lblBestY.Location = new Point(6, 95);
            lblBestY.Name = "lblBestY";
            lblBestY.Size = new Size(39, 15);
            lblBestY.TabIndex = 20;
            lblBestY.Text = "Y_VAL";
            // 
            // chartPaneSmall
            // 
            chartPaneSmall.Location = new Point(374, 230);
            chartPaneSmall.Name = "chartPaneSmall";
            chartPaneSmall.Size = new Size(600, 200);
            chartPaneSmall.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(998, 450);
            Controls.Add(chartPaneSmall);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chartPaneBig);
            Controls.Add(pictureBox1);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRun;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tBPopulationSize;
        private TextBox tbCrossoverVal;
        private TextBox tBMutationRate;
        private TextBox tBElitismRate;
        private TextBox tBGenerationSize;
        private PictureBox pictureBox1;
        private Panel chartPaneBig;
        private Label lblBest;
        private GroupBox groupBox1;
        private Label lblBestX;
        private Label label7;
        private GroupBox groupBox2;
        private Label lblBestY;
        private Label lblBestF;
        private Label label10;
        private Label label1;
        private ComboBox comboBoxSelection;
        private ComboBox comboBoxMutation;
        private Label label9;
        private ComboBox comboBoxCrossover;
        private Label label8;
        private Panel chartPaneSmall;
    }
}
