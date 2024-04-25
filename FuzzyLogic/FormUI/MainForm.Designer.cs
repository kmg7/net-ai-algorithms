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
            numericUpDown_sens = new NumericUpDown();
            numericUpDown_quant = new NumericUpDown();
            numericUpDown_dirt = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_run = new Button();
            chart_spinrate = new SpecialChart();
            chart_time = new SpecialChart();
            chart_detergent = new SpecialChart();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            index = new DataGridViewTextBoxColumn();
            sens = new DataGridViewTextBoxColumn();
            quant = new DataGridViewTextBoxColumn();
            dirt = new DataGridViewTextBoxColumn();
            spin = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            detergent = new DataGridViewTextBoxColumn();
            label_sens_res = new Label();
            label_quant_res = new Label();
            label_dirt_res = new Label();
            listBox_mam_results = new ListBox();
            label_spin_out = new Label();
            label_time_out = new Label();
            label_deterg_out = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label_spin_det = new Label();
            label_time_det = new Label();
            label_deter_det = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_sens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_dirt).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // numericUpDown_sens
            // 
            numericUpDown_sens.DecimalPlaces = 2;
            numericUpDown_sens.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numericUpDown_sens.Location = new Point(526, 35);
            numericUpDown_sens.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_sens.Name = "numericUpDown_sens";
            numericUpDown_sens.Size = new Size(55, 23);
            numericUpDown_sens.TabIndex = 3;
            // 
            // numericUpDown_quant
            // 
            numericUpDown_quant.DecimalPlaces = 2;
            numericUpDown_quant.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numericUpDown_quant.Location = new Point(526, 64);
            numericUpDown_quant.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_quant.Name = "numericUpDown_quant";
            numericUpDown_quant.Size = new Size(55, 23);
            numericUpDown_quant.TabIndex = 4;
            // 
            // numericUpDown_dirt
            // 
            numericUpDown_dirt.DecimalPlaces = 2;
            numericUpDown_dirt.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numericUpDown_dirt.Location = new Point(526, 93);
            numericUpDown_dirt.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_dirt.Name = "numericUpDown_dirt";
            numericUpDown_dirt.Size = new Size(55, 23);
            numericUpDown_dirt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(436, 37);
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
            label2.Location = new Point(436, 70);
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
            label3.Location = new Point(436, 99);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 8;
            label3.Text = "DIRTINESS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_run
            // 
            button_run.Location = new Point(615, 5);
            button_run.Name = "button_run";
            button_run.Size = new Size(75, 23);
            button_run.TabIndex = 9;
            button_run.Text = "RUN";
            button_run.UseVisualStyleBackColor = true;
            button_run.Click += button_run_Click;
            // 
            // chart_spinrate
            // 
            chart_spinrate.Location = new Point(878, 27);
            chart_spinrate.Name = "chart_spinrate";
            chart_spinrate.Size = new Size(417, 188);
            chart_spinrate.TabIndex = 10;
            // 
            // chart_time
            // 
            chart_time.Location = new Point(878, 236);
            chart_time.Name = "chart_time";
            chart_time.Size = new Size(417, 188);
            chart_time.TabIndex = 11;
            // 
            // chart_detergent
            // 
            chart_detergent.Location = new Point(878, 447);
            chart_detergent.Name = "chart_detergent";
            chart_detergent.Size = new Size(417, 188);
            chart_detergent.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(3, 5);
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
            label5.Location = new Point(3, 216);
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
            label6.Location = new Point(3, 427);
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
            label7.Location = new Point(1239, 5);
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
            label8.Location = new Point(1260, 216);
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
            label9.Location = new Point(1231, 427);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 18;
            label9.Text = "DETERGENT";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(436, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 251);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { index, sens, quant, dirt, spin, time, detergent });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(426, 229);
            dataGridView1.TabIndex = 0;
            // 
            // index
            // 
            index.HeaderText = "#";
            index.Name = "index";
            index.ReadOnly = true;
            index.Width = 20;
            // 
            // sens
            // 
            sens.HeaderText = "Sensitiviy";
            sens.Name = "sens";
            sens.ReadOnly = true;
            sens.Width = 60;
            // 
            // quant
            // 
            quant.HeaderText = "Quantity";
            quant.Name = "quant";
            quant.ReadOnly = true;
            quant.Width = 60;
            // 
            // dirt
            // 
            dirt.HeaderText = "Dirtiness";
            dirt.Name = "dirt";
            dirt.ReadOnly = true;
            dirt.Width = 60;
            // 
            // spin
            // 
            spin.HeaderText = "Spin";
            spin.Name = "spin";
            spin.ReadOnly = true;
            spin.Width = 60;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.Name = "time";
            time.ReadOnly = true;
            time.Width = 60;
            // 
            // detergent
            // 
            detergent.HeaderText = "Detergent";
            detergent.Name = "detergent";
            detergent.ReadOnly = true;
            detergent.Width = 60;
            // 
            // label_sens_res
            // 
            label_sens_res.AutoSize = true;
            label_sens_res.BorderStyle = BorderStyle.Fixed3D;
            label_sens_res.Location = new Point(595, 37);
            label_sens_res.Name = "label_sens_res";
            label_sens_res.Size = new Size(95, 17);
            label_sens_res.TabIndex = 20;
            label_sens_res.Text = "SENSITIVITY_RES";
            label_sens_res.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_quant_res
            // 
            label_quant_res.AutoSize = true;
            label_quant_res.BorderStyle = BorderStyle.Fixed3D;
            label_quant_res.Location = new Point(595, 70);
            label_quant_res.Name = "label_quant_res";
            label_quant_res.Size = new Size(89, 17);
            label_quant_res.TabIndex = 21;
            label_quant_res.Text = "QUANTITY_RES";
            label_quant_res.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_dirt_res
            // 
            label_dirt_res.AutoSize = true;
            label_dirt_res.BorderStyle = BorderStyle.Fixed3D;
            label_dirt_res.Location = new Point(595, 99);
            label_dirt_res.Name = "label_dirt_res";
            label_dirt_res.Size = new Size(86, 17);
            label_dirt_res.TabIndex = 22;
            label_dirt_res.Text = "DIRTINESS_RES";
            label_dirt_res.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox_mam_results
            // 
            listBox_mam_results.FormattingEnabled = true;
            listBox_mam_results.ItemHeight = 15;
            listBox_mam_results.Location = new Point(820, 7);
            listBox_mam_results.Name = "listBox_mam_results";
            listBox_mam_results.Size = new Size(48, 124);
            listBox_mam_results.TabIndex = 23;
            // 
            // label_spin_out
            // 
            label_spin_out.AutoSize = true;
            label_spin_out.BorderStyle = BorderStyle.Fixed3D;
            label_spin_out.Location = new Point(1190, 5);
            label_spin_out.Name = "label_spin_out";
            label_spin_out.Size = new Size(2, 17);
            label_spin_out.TabIndex = 27;
            label_spin_out.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_time_out
            // 
            label_time_out.AutoSize = true;
            label_time_out.BorderStyle = BorderStyle.Fixed3D;
            label_time_out.Location = new Point(1190, 216);
            label_time_out.Name = "label_time_out";
            label_time_out.Size = new Size(2, 17);
            label_time_out.TabIndex = 28;
            label_time_out.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_deterg_out
            // 
            label_deterg_out.AutoSize = true;
            label_deterg_out.BorderStyle = BorderStyle.Fixed3D;
            label_deterg_out.Location = new Point(1190, 427);
            label_deterg_out.Name = "label_deterg_out";
            label_deterg_out.Size = new Size(2, 17);
            label_deterg_out.TabIndex = 29;
            label_deterg_out.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(1100, 5);
            label10.Name = "label10";
            label10.Size = new Size(65, 17);
            label10.TabIndex = 30;
            label10.Text = "CENTROID";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(1100, 218);
            label11.Name = "label11";
            label11.Size = new Size(65, 17);
            label11.TabIndex = 31;
            label11.Text = "CENTROID";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(1100, 427);
            label12.Name = "label12";
            label12.Size = new Size(65, 17);
            label12.TabIndex = 32;
            label12.Text = "CENTROID";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Location = new Point(444, 407);
            label13.Name = "label13";
            label13.Size = new Size(63, 17);
            label13.TabIndex = 33;
            label13.Text = "SPIN RATE";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(615, 407);
            label14.Name = "label14";
            label14.Size = new Size(35, 17);
            label14.TabIndex = 34;
            label14.Text = "TIME";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(756, 407);
            label15.Name = "label15";
            label15.Size = new Size(71, 17);
            label15.TabIndex = 35;
            label15.Text = "DETERGENT";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_spin_det
            // 
            label_spin_det.AutoSize = true;
            label_spin_det.BorderStyle = BorderStyle.Fixed3D;
            label_spin_det.Location = new Point(444, 437);
            label_spin_det.Name = "label_spin_det";
            label_spin_det.Size = new Size(2, 17);
            label_spin_det.TabIndex = 36;
            label_spin_det.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_time_det
            // 
            label_time_det.AutoSize = true;
            label_time_det.BorderStyle = BorderStyle.Fixed3D;
            label_time_det.Location = new Point(615, 437);
            label_time_det.Name = "label_time_det";
            label_time_det.Size = new Size(2, 17);
            label_time_det.TabIndex = 37;
            label_time_det.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_deter_det
            // 
            label_deter_det.AutoSize = true;
            label_deter_det.BorderStyle = BorderStyle.Fixed3D;
            label_deter_det.Location = new Point(756, 437);
            label_deter_det.Name = "label_deter_det";
            label_deter_det.Size = new Size(2, 17);
            label_deter_det.TabIndex = 38;
            label_deter_det.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 671);
            Controls.Add(label_deter_det);
            Controls.Add(label_time_det);
            Controls.Add(label_spin_det);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label_deterg_out);
            Controls.Add(label_time_out);
            Controls.Add(label_spin_out);
            Controls.Add(listBox_mam_results);
            Controls.Add(label_dirt_res);
            Controls.Add(label_quant_res);
            Controls.Add(label_sens_res);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chart_detergent);
            Controls.Add(chart_time);
            Controls.Add(chart_spinrate);
            Controls.Add(button_run);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown_dirt);
            Controls.Add(numericUpDown_quant);
            Controls.Add(numericUpDown_sens);
            Controls.Add(chart_dirtiness);
            Controls.Add(chart_quantity);
            Controls.Add(chart_sensitivity);
            Name = "MainForm";
            Text = "Washing Machine Program Inference Engine";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_sens).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quant).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_dirt).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SpecialChart chart_sensitivity;
        private SpecialChart chart_quantity;
        private SpecialChart chart_dirtiness;
        private NumericUpDown numericUpDown_sens;
        private NumericUpDown numericUpDown_quant;
        private NumericUpDown numericUpDown_dirt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_run;
        private SpecialChart chart_spinrate;
        private SpecialChart chart_time;
        private SpecialChart chart_detergent;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn sens;
        private DataGridViewTextBoxColumn quant;
        private DataGridViewTextBoxColumn dirt;
        private DataGridViewTextBoxColumn spin;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn detergent;
        private Label label_sens_res;
        private Label label_quant_res;
        private Label label_dirt_res;
        private ListBox listBox_mam_results;
        private Label label_spin_out;
        private Label label_time_out;
        private Label label_deterg_out;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label_spin_det;
        private Label label_time_det;
        private Label label_deter_det;
    }
}
