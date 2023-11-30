namespace _17_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage($"New tab {tabControl1.TabPages.Count + 1}");



            // 
            // NameTextBox
            // 
            TextBox nameTb = new TextBox();
            nameTb.Location = new Point(95, 61);
            nameTb.Name = "NameTextBox";
            nameTb.Size = new Size(113, 23);
            nameTb.TabIndex = 2;
            // 
            // button1
            // 
            Button clearButton = new Button();
            clearButton.Location = new Point(110, 90);
            clearButton.Name = "button1";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            //clearButton.Click += ClearBtn_Clickk;
            clearButton.Click += (sender, e) => { nameTb.Clear(); };
            // 
            // label2
            // 
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Location = new Point(44, 61);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label1
            // 
            Label mainlabel = new Label();
            mainlabel.AutoSize = true;
            mainlabel.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            mainlabel.Location = new Point(75, 16);
            mainlabel.Name = "label1";
            mainlabel.Size = new Size(156, 42);
            mainlabel.TabIndex = 0;
            mainlabel.Text = "Hello user";




            page.Controls.Add(mainlabel);
            page.Controls.Add(label2);
            page.Controls.Add(nameTb);
            page.Controls.Add(clearButton);
            tabControl1.TabPages.Add(page);
        }

        //private void ClearBtn_Clickk(object? sender, EventArgs e)
        //{
        //    nameTb.Clear();
        //}

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }
        TextBox GetSelectionTab()
        {
            foreach (var item in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                if (item.Name == "NameTextBox")
                {
                    return item;
                }

            }
            return null;
        }
        public TextBox SelectedNameTb
        {
            get
            {
                foreach (var item in tabControl1.SelectedTab.Controls.OfType<TextBox>())
                {
                    if (item.Name == "NameTextBox")
                    {
                        return item;
                    }
                }
                return null;
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name {GetSelectionTab().Text}");
        }
    }
}