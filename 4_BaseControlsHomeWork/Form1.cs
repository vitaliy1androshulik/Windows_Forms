using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4_BaseControlsHomeWork
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            HotelName.BackColor = Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ymovi_CheckBox_Click(object sender, EventArgs e)
        {
            if (Ymovi_CheckBox.Checked = true)
            {
                Order.Enabled = true;
            }
            else if (Ymovi_CheckBox.Checked = false)
            {
                Order.Enabled = false;
            }
        }
        private void ClearCheckBox()
        {
            foreach (var item in this.Controls.OfType<System.Windows.Forms.CheckBox>())
            {
                item.Checked = false;
            }
        }
        private void ClearTextBox()
        {
            foreach (var item in this.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                item.Text = "";
            }
        }
        private bool isHaveInformation()
        {
            return (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked);
        }
        private void Vidminity_Click(object sender, EventArgs e)
        {
            ClearCheckBox();
            ClearTextBox();
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;
            CountOfPeople.Value = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            Ymovi_CheckBox.Checked = false;
            Order.Enabled = false;
            
        }
        private void Order_Click(object sender, EventArgs e)
        {
            if (!isHaveInformation())
            {
                MessageBox.Show("Select type of hotel!");
                return;
            }
            StringBuilder res = new StringBuilder("==================Hotel==================\n");
            res.Append("Type of hotel :: ");
            if (radioButton1.Checked)
            {
                res.Append("Econom ");
            }
            if (radioButton2.Checked)
            {
                res.Append("Standart ");
            }
            if (radioButton3.Checked)
            {
                res.Append("Luxury ");
            }
            res.AppendLine();

            res.AppendLine("Name :: " + NameTextBox.Text);
            res.AppendLine("Surname :: " + SurnameTextBox.Text);
            res.AppendLine("Phone :: " + PhoneNumber.Text);

            res.AppendLine("Count of peoples :: " + CountOfPeople.Value);

            res.AppendLine("Start :: " + monthCalendar1.SelectionStart);
            res.AppendLine("End :: " + monthCalendar1.SelectionEnd);
            res.AppendLine();
            res.AppendLine("Comment :: " + BigTextBox.Text);
            res.AppendLine();
            res.AppendLine();
            res.AppendLine();
            SaveToFile(res);
            res.Append("Information saved to file!");


            MessageBox.Show(res.ToString());
            ClearTextBox();
            ClearCheckBox();
        }

        private void SaveToFile(StringBuilder res)
        {
            if (res.Length > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream fs = File.Create("Hotel.bin"))
                {
                    formatter.Serialize(fs, res);
                }
            }
            else
            {
                MessageBox.Show("Error!", "Error save to file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private StringBuilder LoadFromFile()
        {
            if (File.Exists("Hotel.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                StringBuilder loadinformation = null;
                using (Stream fs = File.OpenRead("Hotel.bin"))
                {
                    loadinformation = (StringBuilder)formatter.Deserialize(fs);
                }
                return loadinformation;
            }
            else
            {
                StringBuilder res = new StringBuilder();
                res.Append("Error load from file!");
                return res;
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            StringBuilder res = LoadFromFile();

            MessageBox.Show(res.ToString(), "Information!", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}