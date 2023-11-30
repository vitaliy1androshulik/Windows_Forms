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
    public partial class LoginForm : Form
    {
        public User User;

        public LoginForm()
        {
            InitializeComponent();
            User = new User();  
        }
        public LoginForm(User user)
        {
            InitializeComponent();
            User = user;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Login.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Enter login and password!");
                return;
            }
            User.Login = Login.Text;
            User.Password = Password.Text;
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
