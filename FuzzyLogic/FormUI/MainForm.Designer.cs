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
            chart_sensitivity = new SpecialChart();
            chart_quantity = new SpecialChart();
            chart_dirtiness = new SpecialChart();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            chart_spinrate = new SpecialChart();
            chart_time = new SpecialChart();
            chart_detergent = new SpecialChart();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // chart_sensitivity
            // 
            chart_sensitivity.Location = new Point(3, 25);
            chart_sensitivity.Name = "chart_sensitivity";
            chart_sensitivity.Size = new Size(417, 188);
            chart_sensitivity.TabIndex = 0;
            // 
            // chart_quantity
            // 
            chart_quantity.Location = new Point(3, 236);
            chart_quantity.Name = "chart_quantity";
            chart_quantity.Size = new Size(417, 188);
            chart_quantity.TabIndex = 1;
            // 
            // chart_dirtiness
            // 
            chart_dirtiness.Location = new Point(3, 447);
            chart_dirtiness.Name = "chart_dirtiness";
            chart_dirtiness.Size = new Size(417, 188);
            chart_dirtiness.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numericUpDown1.Location = new Point(676, 25);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numericUpDown2.Location = new Point(676, 54);
            numericUpDown2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(55, 23);
            numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numericUpDown3.Location = new Point(676, 83);
            numericUpDown3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(55, 23);
            numericUpDown3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(586, 27);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 6;
            label1.Text = "SENSITIVITY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(586, 56);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 7;
            label2.Text = "QUANTITY";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(586, 85);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 8;
            label3.Text = "DIRTINESS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(616, 129);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "RUN";
            button1.UseVisualStyleBackColor = true;
            // 
            // chart_spinrate
            // 
            chart_spinrate.Location = new Point(897, 27);
            chart_spinrate.Name = "chart_spinrate";
            chart_spinrate.Size = new Size(417, 188);
            chart_spinrate.TabIndex = 10;
            // 
            // chart_time
            // 
            chart_time.Location = new Point(897, 236);
            chart_time.Name = "chart_time";
            chart_time.Size = new Size(417, 188);
            chart_time.TabIndex = 11;
            // 
            // chart_detergent
            // 
            chart_detergent.Location = new Point(897, 447);
            chart_detergent.Name = "chart_detergent";
            chart_detergent.Size = new Size(417, 188);
            chart_detergent.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(162, 9);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 13;
            label4.Text = "SENSITIVITY";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(162, 216);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 14;
            label5.Text = "QUANTITY";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(171, 427);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 15;
            label6.Text = "DIRTINESS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(1087, 9);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 16;
            label7.Text = "SPIN RATE";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(1098, 216);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 17;
            label8.Text = "TIME";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(1079, 427);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 18;
            label9.Text = "DETERGENT";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 671);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chart_detergent);
            Controls.Add(chart_time);
            Controls.Add(chart_spinrate);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(chart_dirtiness);
            Controls.Add(chart_quantity);
            Controls.Add(chart_sensitivity);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SpecialChart chart_sensitivity;
        private SpecialChart chart_quantity;
        private SpecialChart chart_dirtiness;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private SpecialChart chart_spinrate;
        private SpecialChart chart_time;
        private SpecialChart chart_detergent;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
