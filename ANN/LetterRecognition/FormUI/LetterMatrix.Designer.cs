namespace FormUI
{
    partial class LetterMatrix
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
            panel = new Panel();
            ButtonWhite = new Button();
            ButtonBlack = new Button();
            LabelSizeInfo = new Label();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ControlDark;
            panel.Location = new Point(3, 3);
            panel.Name = "panel";
            panel.Size = new Size(100, 140);
            panel.TabIndex = 0;
            // 
            // ButtonWhite
            // 
            ButtonWhite.BackColor = Color.White;
            ButtonWhite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonWhite.Location = new Point(3, 146);
            ButtonWhite.Name = "ButtonWhite";
            ButtonWhite.Size = new Size(25, 25);
            ButtonWhite.TabIndex = 2;
            ButtonWhite.Text = "W";
            ButtonWhite.UseVisualStyleBackColor = false;
            ButtonWhite.Click += ButtonClear_Click;
            // 
            // ButtonBlack
            // 
            ButtonBlack.BackColor = SystemColors.Desktop;
            ButtonBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonBlack.ForeColor = Color.White;
            ButtonBlack.Location = new Point(78, 146);
            ButtonBlack.Name = "ButtonBlack";
            ButtonBlack.Size = new Size(25, 25);
            ButtonBlack.TabIndex = 3;
            ButtonBlack.Text = "B";
            ButtonBlack.UseVisualStyleBackColor = false;
            ButtonBlack.Click += ButtonBlack_Click;
            // 
            // LabelSizeInfo
            // 
            LabelSizeInfo.AutoSize = true;
            LabelSizeInfo.Location = new Point(40, 151);
            LabelSizeInfo.Name = "LabelSizeInfo";
            LabelSizeInfo.Size = new Size(25, 15);
            LabelSizeInfo.TabIndex = 4;
            LabelSizeInfo.Text = "7x5";
            LabelSizeInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LetterMatrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(LabelSizeInfo);
            Controls.Add(ButtonBlack);
            Controls.Add(ButtonWhite);
            Controls.Add(panel);
            Name = "LetterMatrix";
            Size = new Size(106, 174);
            Load += LetterMatrix_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button ButtonWhite;
        private Button ButtonBlack;
        private Label LabelSizeInfo;
    }
}
