using System.Windows.Forms;

namespace _14_ProductEditorHomeWork
{
    public partial class MainForm : Form
    {
        List<Products> products = new List<Products>();
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 153, 153);
            listBox1.BackColor = Color.FromArgb(255, 204, 204);
            listBox1.BorderStyle = BorderStyle.None;
            EditBtn.BackColor = Color.FromArgb(255, 204, 204);
            EditBtn.ForeColor = Color.White;
            InfoBtn.BackColor = Color.FromArgb(255, 204, 204);
            InfoBtn.ForeColor = Color.White;
            MinusBtn.BackColor = Color.FromArgb(255, 102, 102);
            MinusBtn.ForeColor = Color.White;
            PlusBtn.BackColor = Color.FromArgb(0, 153, 76);
            PlusBtn.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            listBox1.ForeColor = Color.White;
            listBox1.DataSource = products;
        }
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            EditInfoForm editInfoForm = new EditInfoForm();
            editInfoForm.ShowDialog();
        }
        private void UpdateOrderComboBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = products;

        }
        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            products.RemoveAt(listBox1.SelectedIndex);
            MessageBox.Show("Product was removed!");
            UpdateOrderComboBox();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                EditInfoForm editInfoForm1 = new EditInfoForm(products[listBox1.SelectedIndex], 1);
                if (editInfoForm1.ShowDialog() == DialogResult.OK)
                {
                    products[listBox1.SelectedIndex] = editInfoForm1.Products;
                    UpdateOrderComboBox();
                }
            }
            else
            {
                MessageBox.Show("Виберіть продукт для редагування.");
            }
        }
        private void InfoBtn_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                EditInfoForm editInfoForm1 = new EditInfoForm(products[listBox1.SelectedIndex], true);
                editInfoForm1.ShowDialog();
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            EditInfoForm editInfoForm = new EditInfoForm(product);
            if (editInfoForm.ShowDialog() == DialogResult.OK)
            {
                products.Add(product);
                UpdateOrderComboBox();
            }
        }
    }
}