namespace _8_ComboBox
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            orders.Add(new Order(random.Next(0, 1000)));
            orders.Add(new Order(random.Next(0, 1000)));
            orders.Add(new Order(random.Next(0, 1000)));
            orders.Add(new Order(random.Next(0, 1000)));

            comboBox4.Items.AddRange(orders.ToArray());
            comboBox4.DataSource = orders; // dataSource - вказівничок
            UpdateOrderComboBox();
        }
        private void UpdateOrderComboBox()
        {
            comboBox4.DataSource = null;
            comboBox4.DataSource = orders;

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void ShowSelectBtn_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Selected order in list!!!");
                return;
            }

            Order selectedOrder = comboBox4.SelectedItem as Order;

            MessageBox.Show($"{selectedOrder.Number} {selectedOrder.TotalPrice.ToString()}$\n{selectedOrder.Date}", "Order details!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1)
            {
                return;
            }
            orders.RemoveAt(comboBox4.SelectedIndex);
            MessageBox.Show("Element was removed!");
            UpdateOrderComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            UpdateOrderComboBox();
            MessageBox.Show("Element was added!");
        }
    }
}