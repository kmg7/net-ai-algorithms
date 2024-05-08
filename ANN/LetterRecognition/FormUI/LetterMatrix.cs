namespace FormUI
{
    public partial class LetterMatrix : UserControl
    {
        public bool[] Pixels { get; set; } = new bool[35];

        public LetterMatrix()
        {
            InitializeComponent();
        }

        public int[] GetPixels()
        {
            int[] pixels = new int[35];
            for (int i = 0; i < 35; i++)
            {
                pixels[i] = Pixels[i] ? 1 : 0;
            }
            return pixels;
        }

        private void InitializeMatrix()
        {
            for (int i = 0; i < 35; i++)
            {
                Label lbl = new()
                {
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.Fixed3D,
                    Location = new Point((i % 5) * 20, i / 5 * 20),
                    Name = $"{i}",
                    Size = new Size(20, 20),
                    TabIndex = i,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                lbl.Click += Label_Click; // Figure why we are getting a null reference warning here
                panel.Controls.Add(lbl);
            }
        }

        private void UpdateLabel(int index)
        {
            Pixels[index] = !Pixels[index];
            panel.Controls[index].BackColor = Pixels[index] ? Color.Black : Color.White;
            panel.Refresh();
        }

        private void LetterMatrix_Load(object sender, EventArgs e)
        {
            InitializeMatrix();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label caller = (Label)sender;
            int index = int.Parse(caller.Name);
            UpdateLabel(index);
            Refresh();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 35; i++)
            {
                Pixels[i] = false;
                panel.Controls[i].BackColor = Color.White;
            }
            panel.Refresh();
        }

        private void ButtonBlack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 35; i++)
            {
                Pixels[i] = true;
                panel.Controls[i].BackColor = Color.Black;
            }
            panel.Refresh();
        }
    }
}
