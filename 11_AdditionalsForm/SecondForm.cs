using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_AdditionalsForm
{
    public partial class SecondForm : Form
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set 
            { 
                userName = value;
                label2.Text = $"Hello, {userName}"; 
            }
        }

        public SecondForm(string name)
        {
            InitializeComponent();
            UserName = name;
            label2.Text = $"Hello, {name}";
        }
        public SecondForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User name :: {UserName}");
        }
        public void Show(string name)
        {
            UserName = name;
            this.Show();
        }
    }
}
