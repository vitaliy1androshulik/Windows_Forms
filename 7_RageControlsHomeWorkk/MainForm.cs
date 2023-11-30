using System.Text.RegularExpressions;

namespace _7_RageControlsHomeWorkk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MaxLengthValue.Text = numericUpDown1.Value.ToString();
            toolStripProgressBar1.Maximum = (int)numericUpDown1.Value;
            textBox1.MaxLength = (int)numericUpDown1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            CurrentLengthValue.Text = textBox1.Text.Length.ToString();
            if (textBox1.Text.Length > toolStripProgressBar1.Value)
            {
                toolStripProgressBar1.Value++;
            }
            else if (textBox1.Text.Length < toolStripProgressBar1.Value)
            {
                toolStripProgressBar1.Value--;
            }

            string digitPattern = @"(\d)";
            string letterPattern = @"([a-zA-Z])";

            string text = textBox1.Text;

            int digitcount = Regex.Matches(text, digitPattern).Count;
            DigitValue.Text = digitcount.ToString();

            int letterCount = Regex.Matches(text, letterPattern).Count;
            LetterValue.Text = letterCount.ToString();

            string wordPattern = @"(\w+)";
            int wordCount = Regex.Matches(text, wordPattern).Count;
            wordValue.Text = wordCount.ToString();
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxLengthValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxLengthValue_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void MaxLengthValue_OwnerChanged(object sender, EventArgs e)
        {
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Cyan;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int height = (int)textBox1.Font.Size;
            height++;
            textBox1.Font = new Font(textBox1.Font.FontFamily, height);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 8.5f);
        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Calibri", 8.5f);
        }

        private void comicSansMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Comic Sans MS", 8.5f);
        }

        private void georgiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Georgia", 8.5f);
        }

        private void microsoftHimalayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Microsoft Himalaya", 8.5f);
        }

        private void verdanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Verdana", 8.5f);
        }

        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int height = (int)textBox1.Font.Size;
            height--;
            textBox1.Font = new Font(textBox1.Font.FontFamily, height);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = true;
        }

        private void toolStripStatusLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}