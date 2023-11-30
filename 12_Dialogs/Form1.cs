using System.Diagnostics;

namespace _12_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var selected = dlg.Font;
                OpenBtn.Font = selected;
                SaveBtn.Font = selected;
                OpenFolderBtn.Font = selected;
                //OpenFolderBtn.Size = new Size(selected.Height, selected.Height);
                BackgroundBtn.Font = selected;
                FontBtn.Font = selected;
            }
        }

        private void BackgroundBtn_Click(object sender, EventArgs e)
        {
            ColorDialog newColorDialog = new ColorDialog();
            if (newColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = newColorDialog.Color;
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "All files(*.*)|*.*|Text Files(*.txt)|*.txt||)";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                textBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.OverwritePrompt = true;//перепитування перезапису
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter reader = new StreamWriter(saveFileDialog.FileName);
                reader.Write(textBox1.Text);
                reader.Close();
            }

        }

        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog()==DialogResult.OK) 
            {
                listBox1.Items.Clear();
               // Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach(var item in Directory.GetFiles(folderBrowserDialog.SelectedPath))
                {
                    listBox1.Items.Add(Path.GetFileName(item));
                }
            }
        }
    }
}