namespace _1_Welcome
{
    public partial class Form1 : Form
    {
        Point startLocation;
        public Form1()
        {
            InitializeComponent();
            startLocation = cs.Location;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Do yo want to close window?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello wordl", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Green;
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            cs.Location = new Point(cs.Location.X - 5, cs.Location.Y);
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            cs.Location = new Point(cs.Location.X + 5, cs.Location.Y);
        }

        private void cs_Click(object sender, EventArgs e)
        {
            cs.Location = startLocation;

            //cs.Left and cs.Right
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse position :: {e.X}, {e.Y}";
        }
    }
}