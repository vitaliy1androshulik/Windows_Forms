using System.Xml.Linq;

namespace _11_AdditionalsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            //1- with constructor
            //string name = textBox1.Text;
            //SecondForm secondform = new SecondForm(name);
            //secondform.Show();//in nomodel model
            //secondform.ShowDialog();//model model
            //MessageBox.Show(name);

            //2 - with properties
            //SecondForm secondform = new SecondForm();
            //secondform.UserName = textBox1.Text;
            //secondform.Show();

            //3 - Show
            //SecondForm secondform = new SecondForm();
            //secondform.Show(name);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //User user;//reference = null
            //
            //LoginForm loginForm = new LoginForm();
            //DialogResult result = loginForm.ShowDialog();
            //1 - using child form Properties

            //result==DialogResult.OK
            //if(result == DialogResult.OK) 
            //{
            //    user = loginForm.User;

            //    LoginLabel.Text = user.Login;
            //    PasswordLabel.Text = user.Password;
            //}
            //if(loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    user = loginForm.User;
            //
            //    LoginLabel.Text = user.Login;
            //    PasswordLabel.Text = user.Password;
            //}

            //2 - using reference to the object
            User user = new User();
            LoginForm loginForm = new LoginForm(user);
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                LoginLabel.Text = user.Login;
                PasswordLabel.Text = user.Password;
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}