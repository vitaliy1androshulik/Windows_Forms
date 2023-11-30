using System.Text;

namespace _3_BaseControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private bool isHaveInformation()
        {
            return (radioButton1.Checked|| radioButton1.Checked|| radioButton1.Checked);
        }
        private void ClearTextBox()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }
        private void ClearCheckBox()
        {
            foreach (var item in this.Controls.OfType<CheckBox>())
            {
                item.Checked=false;
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {
            if(!isHaveInformation())
            {
                MessageBox.Show("Select type of hotel!");
                return;
            }
            StringBuilder res = new StringBuilder("==================Order==================\n");
            res.Append("Meals :: ");
            if (checkBox1.Checked)
            {
                res.Append("Breakfast ");
            }
            if (checkBox1.Checked)
            {
                res.Append("Lunch ");
            }
            if (checkBox1.Checked)
            {
                res.Append("Dinner ");
            }
            res.AppendLine();
            res.Append("Delivery :: ");
            if (radioButton1.Checked)
            {
                res.Append("Economy ");
            }
            if (radioButton2.Checked)
            {
                res.Append("Standart ");
            }
            if (radioButton3.Checked)
            {
                res.Append("Fast ");
            }
            res.AppendLine();

            res.AppendLine("Login :: " + textBox1.Text);
            res.AppendLine("Password :: " + textBox2.Text);
            res.AppendLine("Phone :: " + textBox4.Text);

            res.AppendLine("Date :: " + dateTimePicker1.Value);
            res.AppendLine("Start :: " + monthCalendar1.SelectionStart);
            res.AppendLine("End :: " + monthCalendar1.SelectionEnd);

            res.AppendLine("Count :: "+numericUpDown1.Value);


            MessageBox.Show(res.ToString());
            ClearTextBox();
            ClearCheckBox();
        }
    }
}