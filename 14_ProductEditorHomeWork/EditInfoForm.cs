using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_ProductEditorHomeWork
{
    public partial class EditInfoForm : Form
    {
        public Products Products;
        public EditInfoForm()
        {
            Products = new Products();
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 153, 153);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            CancelBtn.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.BackColor = Color.FromArgb(255, 204, 204);
            button1.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.ForeColor = Color.White;
            CancelBtn.ForeColor = Color.White;
            button1.ForeColor = Color.White;
        }
        public EditInfoForm(Products product)
        {
            InitializeComponent();
            Products = product;
            this.BackColor = Color.FromArgb(255, 153, 153);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            CancelBtn.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.BackColor = Color.FromArgb(255, 204, 204);
            button1.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.ForeColor = Color.White;
            CancelBtn.ForeColor = Color.White;
            button1.ForeColor = Color.White;

        }
        public EditInfoForm(Products product, int ds)
        {
            InitializeComponent();
            Products = product;
            this.BackColor = Color.FromArgb(255, 153, 153);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            CancelBtn.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.BackColor = Color.FromArgb(255, 204, 204);
            button1.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.ForeColor = Color.White;
            CancelBtn.ForeColor = Color.White;
            button1.ForeColor = Color.White;

            NameTextBox.Text = product.Name;
            PriceNumeric.Value = product.Price;
            CountNumeric.Value = product.Count;
            DiscountNumeric.Value = product.Discount;
            CountryCombo.Text = product.Country;

        }
        public EditInfoForm(Products product, bool read)
        {
            InitializeComponent();
            Products = product;
            this.BackColor = Color.FromArgb(255, 153, 153);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            CancelBtn.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.BackColor = Color.FromArgb(255, 204, 204);
            button1.BackColor = Color.FromArgb(255, 204, 204);
            OkBtn.ForeColor = Color.White;
            CancelBtn.ForeColor = Color.White;
            button1.ForeColor = Color.White;

            NameTextBox.ReadOnly = read;
            PriceNumeric.Enabled = !read;
            CountNumeric.Enabled = !read;
            DiscountNumeric.Enabled = !read;
            CountryCombo.Enabled = !read;

            NameTextBox.Text = product.Name;
            PriceNumeric.Value = product.Price;
            CountNumeric.Value = product.Count;
            DiscountNumeric.Value = product.Discount;
            CountryCombo.Text = product.Country;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Products.Name = NameTextBox.Text;
            Products.Price = (int)PriceNumeric.Value;
            Products.Count = (int)CountNumeric.Value;
            Products.Discount = (int)DiscountNumeric.Value;
            Products.Country = CountryCombo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dr == DialogResult.No)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            CountNumeric.Value = 0;
            DiscountNumeric.Value = 0;
            PriceNumeric.Value = 0;
            CountryCombo.SelectedItem = null;
        }
    }
}
