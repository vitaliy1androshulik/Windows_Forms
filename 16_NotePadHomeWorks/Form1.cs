using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _16_NotePadHomeWorks
{
    public partial class Form1 : Form
    {
        
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
            this.richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
        }

        private void RichTextBox1_DragDrop(object? sender, DragEventArgs e)
        {
            string res = richTextBox1.Text;
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                var data = e.Data.GetData(DataFormats.Text);
                var filename = data.ToString();
                richTextBox1.LoadFile(data.ToString());

            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
              foreach (var item in (string[]) e.Data.GetData(DataFormats.FileDrop))
              {
                    if(Path.GetExtension(item) == ".rtf")
                    {
                        richTextBox1.LoadFile(item);
                        //res += richTextBox1.Text;
                        //richTextBox1.Text = res;
                    }
                    else if(Path.GetExtension(item) ==".txt")
                    {
                        string file = File.ReadAllText(item);
                        richTextBox1.Text = file;
                    }
              }
            }
            richTextBox1.ResetBackColor();
            


        }

        private void RichTextBox1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) ||
                e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) { richTextBox1.SelectAll(); }

        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }
        private void ChangeColor(int r, int g, int b)
        {
            statusStrip1.ForeColor = Color.FromArgb(r, g, b);
            menuStrip1.ForeColor = Color.FromArgb(r, g, b);
            richTextBox1.ForeColor = Color.FromArgb(r, g, b);
        }
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(255, 255, 255);
            this.BackColor = Color.FromArgb(16, 16, 16);
            richTextBox1.BackColor = Color.FromArgb(63, 63, 63);
            menuStrip1.BackColor = Color.FromArgb(16, 16, 16);
            statusStrip1.BackColor = Color.FromArgb(16, 16, 16);
            toolStrip1.BackColor = Color.FromArgb(16, 16, 16);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            CurrentLengthValue.Text = richTextBox1.Text.Length.ToString();
            string digitPattern = @"(\d)";
            string letterPattern = @"([a-zA-Z])";

            string text = richTextBox1.Text;

            int digitcount = Regex.Matches(text, digitPattern).Count;
            DigitValue.Text = digitcount.ToString();

            int letterCount = Regex.Matches(text, letterPattern).Count;
            LetterValue.Text = letterCount.ToString();

            string wordPattern = @"(\w+)";
            int wordCount = Regex.Matches(text, wordPattern).Count;
            wordValue.Text = wordCount.ToString();
        }

        private void maxSymbolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maxSymbolsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //MaxSymbols maxSymbols = new MaxSymbols(richTextBox1.Text.Length);
            //if (maxSymbols.ShowDialog() == DialogResult.OK)
            //{
            //    if (richTextBox1.Text.Length > maxSymbols.Number)
            //    {
            //        MessageBox.Show("The number of characters you entered is incorrect", "Symbols Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        richTextBox1.MaxLength = maxSymbols.Number;
            //    }
            //}
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = color.Color;
            }
        }

        private void textBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = color.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.Font = fontDialog.Font;
                statusStrip1.Font = fontDialog.Font;
                toolStrip1.Font = fontDialog.Font;
            }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(0, 0, 0);
            this.BackColor = Color.FromArgb(255, 255, 255);
            richTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            menuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            statusStrip1.BackColor = Color.FromArgb(255, 255, 255);
            toolStrip1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(255, 255, 255);
            this.BackColor = Color.FromArgb(255, 153, 153);
            richTextBox1.BackColor = Color.FromArgb(255, 204, 204);
            menuStrip1.BackColor = Color.FromArgb(255, 153, 153);
            statusStrip1.BackColor = Color.FromArgb(255, 153, 153);
            toolStrip1.BackColor = Color.FromArgb(255, 153, 153);
            tabPage1.BackColor = Color.FromArgb(255, 204, 204);
            tabPage1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(255, 255, 255);
            this.BackColor = Color.FromArgb(0, 128, 255);
            richTextBox1.BackColor = Color.FromArgb(102, 178, 255);
            menuStrip1.BackColor = Color.FromArgb(0, 128, 255);
            statusStrip1.BackColor = Color.FromArgb(0, 128, 255);
            toolStrip1.BackColor = Color.FromArgb(0, 128, 255);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                richTextBox1.Clear();
            }

            else
            {
                return;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                richTextBox1.Clear();
            }

            else
            {
                return;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            { richTextBox1.Undo(); }

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            DialogResult result = opentext.ShowDialog();
            opentext.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (result == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(opentext.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.SaveFile(DesktopPath + @"/document.rtf", RichTextBoxStreamType.RichText);
                MessageBox.Show("Saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        MemoryStream userInput = new MemoryStream();
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Text";
            save.DefaultExt = "txt";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = save.ShowDialog();
            Stream fileStream;
            if (result == DialogResult.OK)
            {
                fileStream = save.OpenFile();
                richTextBox1.SaveFile(userInput, RichTextBoxStreamType.PlainText);
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
            }
        }
    }
}