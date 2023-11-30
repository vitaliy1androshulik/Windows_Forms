namespace _9_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item !");
                return;
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string res = "----------- Selection item -----------";
            foreach (var item in listBox1.SelectedItems)
            {
                res += Environment.NewLine + item.ToString();
            }
            MessageBox.Show(res);

        }

        private void MoveLeftBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void MoveRightBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

                while(checkedListBox1.CheckedItems.Count>0)
                {
                    checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
                }
               
        }
    }
}