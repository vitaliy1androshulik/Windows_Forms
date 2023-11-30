using System.Diagnostics;

namespace _5_RangeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //groupBox1.Controls.OfType<RadioButton>();
            foreach (var item in groupBox1.Controls.OfType<RadioButton>())
            {
                item.CheckedChanged += Item_CheckedChanged;
            }
            foreach (var item in groupBox2.Controls.OfType<RadioButton>())
            {
                item.CheckedChanged += Item_CheckedChanged; // зразу обробник на дві групи
            }
        }

        private void Item_CheckedChanged(object? sender, EventArgs e)
        {
            bool isFirstGroupIsChecked = false;
            bool isSecondGroupIsChecked = false;
            foreach (var item in groupBox1.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    isFirstGroupIsChecked = true;
                    break;
                }
            }
            foreach (var item in groupBox2.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    isSecondGroupIsChecked = true;
                    break;
                }
            }

            OrderButton.Enabled = isFirstGroupIsChecked && isSecondGroupIsChecked;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach (var item in groupBox1.Controls.OfType<RadioButton>().Union(groupBox2.Controls.OfType<RadioButton>()))
            {
                if (item.Checked)
                {
                    total += float.Parse(item.Tag.ToString());
                }
            }
            MessageBox.Show($"Ordered!!\nTotal price :: {total}$");
            textBox1.Text += $"123 {DateTime.Now.ToShortDateString()}   {total} $ {Environment.NewLine}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (var item in groupBox1.Controls.OfType<RadioButton>().Union(groupBox2.Controls.OfType<RadioButton>()))
            {
                item.Checked = false;
            }
        }
    }
}