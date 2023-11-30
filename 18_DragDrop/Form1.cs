namespace _18_DragDrop
{
    public partial class Form1 : Form
    {
        bool isSelected = false;
        string selectedText = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) ||
                e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                listBox1.BackColor = Color.Cyan;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragLeave(object sender, EventArgs e)
        {
            listBox1.ResetBackColor();
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string item = e.Data.GetData(DataFormats.Text).ToString();
                listBox1.Items.Add(item);

            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    listBox1.Items.Add(item);
                }
            }
            listBox1.ResetBackColor();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isSelected && textBox1.SelectionLength == 0)
            {
                isSelected = true;
            }
            else
            {

                textBox1.DoDragDrop(selectedText, DragDropEffects.Copy);
                isSelected = false;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelected)
            {
                selectedText = textBox1.SelectedText;
            }
        }
    }
}