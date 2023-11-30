namespace _13_ReachTextBox
{
    public partial class Form1 : Form
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = checkBox1.Checked;
        }

        private void ChangeSelectedFontBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamily.GenericMonospace, 25, FontStyle.Bold);
        }

        private void ChangeSelectedColorBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void ChangeSelectedBackgroundColorBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Yellow;
        }

        private void IndentLeftBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent--;
        }

        private void IndentRightBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent++;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DesktopPath + @"/document.rtf", RichTextBoxStreamType.RichText);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(DesktopPath + @"/document.rtf", RichTextBoxStreamType.RichText);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void makeBulletToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void makeBulletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = makeBulletToolStripMenuItem.Checked;
        }
    }
}